using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;

using VideoLibrary; //유튜브 동영상 다운로드 라이브러리

using OpenCvSharp; //Open CV 라이브러리

//using SocketIOClient;
using Quobject.SocketIoClientDotNet.Client;

using Newtonsoft.Json.Linq;

namespace OpenPose_Video_Splliter {
    public partial class OpenPose : Form {

        #region Variables
        int saveCount = 0;
        int divideNumber = 0;

        //임시 비트맵, 매트릭스
        Bitmap tempImage;
        Mat tempMat;

        VideoCapture capture;
        //불러온 비디오 경로
        string videoPath = null;
        //이전에 불러온 비디오 경로 : 자동 삭제에 쓰임
        string PreVideoPath = null;
        //샘플링된 비디오 경로
        string sampleVideoPath = null;
        List<string> sampleVideoPaths_Front = new List<string>();
        List<string> sampleVideoPaths_Side = new List<string>();
        //아웃풋 JSON 경로
        List<string> outputJSONPaths = new List<string>();


        //연산시간 계산 변수
        double start, end;

        //샘플링할 목록 리스트
        BindingList<FrameVector> frameList = new BindingList<FrameVector>();

        //오픈포즈데모 프로세스 실행 인덱스
        int openPoseProcessIndex = 0;
        int samplePathIndex_Front = 0;
        int samplePathIndex_Side = 0;
        #endregion

        #region Open Pose Settings
        //OpenPoseDemo.exe 경로
        private string OpenPoseDemoExePath = null;
        //오픈포즈 아웃풋 경로
        private string OpenPoseOutputPath = null;

        //오픈포즈 세부설정 자작 클래스
        private OpenPoseSetting openSetting;



        #endregion

        #region Web Socket

        Socket socket;

        string host_MJ = "localhost";
        string port_MJ = "8001";

        SocketJSON socketJSON = new SocketJSON();

        #endregion

        public OpenPose() {
            InitializeComponent();
        }

        //이 윈도우 폼이 불러졌을 때 //최초실행
        private void Form1_Load(object sender , EventArgs e) {

            //소켓 설정

            socket = IO.Socket("http://mjstudio.cafe24app.com/");
            //연결되었을 때
            socket.On(Socket.EVENT_CONNECT , () => {
                LABEL_SOCKETSTATE.Invoke(new MethodInvoker(delegate () {
                    LABEL_SOCKETSTATE.Text = "Socket State : 연결 완료!";
                }));

                //연결 끊겼을 때
                socket.On(Socket.EVENT_DISCONNECT , () => {
                    LABEL_SOCKETSTATE.Invoke(new MethodInvoker(delegate () {
                        LABEL_SOCKETSTATE.Text = "Socket State : 연결 끊김...";
                    }));
                });

                //submit 성공 했을 때
                socket.On("submit" , () => {
                    LABEL_SUBMITSTATE.Invoke(new MethodInvoker(delegate () {
                        LABEL_SUBMITSTATE.Text = "Submit : 제출 성공!";
                    }));
                });
                socket.On("submit fail" , () => {
                    LABEL_SUBMITSTATE.Invoke(new MethodInvoker(delegate () {
                        LABEL_SUBMITSTATE.Text = "Submit : 제출 실패...";
                    }));
                });
            });
            //연결 오류일 때
            socket.On(Socket.EVENT_CONNECT_ERROR , () => {
                LABEL_SOCKETSTATE.Invoke(new MethodInvoker(delegate () {
                    LABEL_SOCKETSTATE.Text = "Socket State : 연결 에러";
                }));
            });
        
        
            //아웃풋 콤보박스를 첫번째 요소로 선택
            COMBO_OUTPUTFORMAT.SelectedIndex = 0;

            //이름 콤보박스
            COMBO_WHO.SelectedIndex = 0;

            //오픈포즈 세팅
            openSetting = new OpenPoseSetting();
            //프로퍼티 바인딩
            CHECK_NOBLENDING.DataBindings.Add("Checked" , openSetting , "NoBlending");
            CHECK_NODISPLAY.DataBindings.Add("Checked" , openSetting , "NoWindow");

            FRAMESAMPLE_LISTBOX.DataSource = frameList;

            COMBO_WHO.DataBindings.Add("SelectedIndex" , socketJSON , "UserIndex");
        }

        //다운로드 버튼 클릭
        private async void DOWN_BTN_Click(object sender , EventArgs e) {


            //다운로드버튼 비활성화
            LOCALOPEN_BTN.Enabled = false;
            DOWN_BTN.Enabled = false;
            //트랙버튼비활성화
            //FRAME_TRACKBAR.Enabled = false;




            //메모리 초기화
            GC.Collect();

            start = Cv2.GetTickCount();

            //다운로드
            try {
                var youtube = YouTube.Default;
                DOWNSTATE_TEXT.Text = "Downloading...";
                var video = await youtube.GetVideoAsync(URL_TEXT.Text);

                File.WriteAllBytes((videoPath = "./output/" + video.FullName) , await video.GetBytesAsync());
                
                videoPath = Path.GetFullPath(videoPath);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                DOWNSTATE_TEXT.Text = "Error..";
                DOWN_BTN.Enabled = true;
                return;
            }
            //다운로드 끝

            end = Cv2.GetTickCount() - start;
            end /= Cv2.GetTickFrequency();
            DOWNSTATE_TEXT.Text = "Completed[" + Math.Round(end).ToString() + "s]";


            EndLoadVideo();

        }
        
        //비디오 불러오기 완료 함수
        private void EndLoadVideo() {

            //frameList초기화
            frameList.Clear();

            //비디오이름 라벨 교체
            VIDEONAME_TEXT.Text = Path.GetFileName(videoPath);

            //버튼활성화
            LOCALOPEN_BTN.Enabled = true;
            SETSTART_BTN.Enabled = true;
            SETEND_BTN.Enabled = true;
            SAVEIMAGE_BTN.Enabled = true;
            DOWN_BTN.Enabled = true;
            FRAMELEFT_BTN.Enabled = true;
            FRAMERIGHT_BTN.Enabled = true;
            FRAMEBOX_TEXT.Enabled = true;
            ADD_BTN.Enabled = true;

            //트랙바활성화
            FRAME_TRACKBAR.Enabled = true;

            if (capture != null) {
                capture.Dispose();
            }
            GC.Collect();


            //만약 첫 비디오 추가일 시에
            if (PreVideoPath == null) {
                PreVideoPath = videoPath;
                
            }

            //만약 비디오 자동 삭제 체크가 되있다면
            if (AUTODELETE_CHECK.Checked) {



                if (File.Exists(PreVideoPath) &&!Path.Equals(PreVideoPath,videoPath)) 
                { //삭제하려는 파일이 존재하고 똑같은 파일을 열지 않았을 경우에만
                    
                    File.Delete(PreVideoPath);
                    

                }
            }
            PreVideoPath = videoPath;

            //비디오캡쳐 OPENCV
            capture = new VideoCapture(videoPath);

            

            FRAME_TRACKBAR.Minimum = 0;
            FRAME_TRACKBAR.Maximum = capture.FrameCount - 1;

            //프레임 라벨 표시
            FRAMEBAR_LABEL.Text = "0/" + FRAME_TRACKBAR.Maximum.ToString();




            //미리보기 이미지 표시
            tempMat = new Mat();
            
            capture.Read(tempMat);
            tempImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(tempMat);
            FRAME_PICTUREBOX.Image = tempImage;
        }

       

        //프레임 왼쪽 버튼 클릭
        private void FRAMELEFT_BTN_Click(object sender , EventArgs e) {
            if (FRAME_TRACKBAR.Value > 0) {
                FRAME_TRACKBAR.Value--;
                FRAME_TRACKBAR_MOUSEUP(sender , null);
            }
        }
        //프레임 오른쪽 버튼 클릭
        private void FRAMERIGHT_BTN_Click(object sender , EventArgs e) {
            if (FRAME_TRACKBAR.Value < FRAME_TRACKBAR.Maximum) {
                FRAME_TRACKBAR.Value++;
                FRAME_TRACKBAR_MOUSEUP(sender , null);
            }
        }

        //시작프레임 설정 버튼 클릭
        private void SETSTARTCLICK(object sender , EventArgs e) {
            STARTTEXT_TEXT.Text = FRAME_TRACKBAR.Value.ToString();
        }
        
        //끝 프레임 설정 버튼 클릭
        private void SETENDCLICK(object sender , EventArgs e) {
            ENDTEXT_TEXT.Text = FRAME_TRACKBAR.Value.ToString();
        }

        //직접 비디오파일 불러오기 버튼 클릭
        private void LOCALOPEN_BTN_Click(object sender , EventArgs e) {
            string formats = "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                  " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm";


            using (OpenFileDialog fd = new OpenFileDialog() {
                Filter = formats ,
                Title = "Select your video" })
                {
                if (fd.ShowDialog() == DialogResult.OK) {

                    videoPath = fd.FileName;
                    EndLoadVideo();


                }

            }
        }

        //프레임 직접 입력 텍스트
        private void SETFRAMEKEYDOWN(object sender , KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) { //만약 엔터키가 입력되면
                int result;
                if (int.TryParse(FRAMEBOX_TEXT.Text , out result) &&
                    (result >= 0 && result <= FRAME_TRACKBAR.Maximum)) {
                    FRAME_TRACKBAR.Value = result;
                    FRAME_TRACKBAR_MOUSEUP(sender , null);
                } else {
                    MessageBox.Show("Input a integer in range!");
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        //샘플링 버튼 클릭
        private void SAVEIMAGE_BTN_Click(object sender , EventArgs e) {
            SAVEVIDEO_LABEL.Text = "0/" + frameList.Count.ToString()+"...";
            
            
            SAVEPROGRESS_BACKGROUNDWORKER.RunWorkerAsync();

            //각종 것들을 비활성화한다.
            SETSTART_BTN.Enabled = false;
            SETEND_BTN.Enabled = false;

            SAVEIMAGE_BTN.Enabled = false;
            DOWN_BTN.Enabled = false;
            LOCALOPEN_BTN.Enabled = false;
            FRAMELEFT_BTN.Enabled = false;
            FRAMERIGHT_BTN.Enabled = false;
            FRAME_TRACKBAR.Enabled = false;
            FRAMEBOX_TEXT.Enabled = false;
            ADD_BTN.Enabled = false;
            DELETE_BTN.Enabled = false;

            

        }

        //샘플링 백그라운드 워커
        private void SAVEDOWORK(object sender , System.ComponentModel.DoWorkEventArgs e) {

            //샘플링된 비디오 경로들 초기화
            sampleVideoPaths_Front.Clear();
            sampleVideoPaths_Side.Clear();

            //시작시간 저장
            start = Cv2.GetTickCount();
            BackgroundWorker worker = (BackgroundWorker)sender;

            saveCount = 0;

            for (int n = 0 ; n < FRAMESAMPLE_LISTBOX.Items.Count ; n++) {
        
                GC.Collect();           

                //저장해야할 프레임 정보를 계산한다.
                int AllFrame = capture.FrameCount;
                int startFrame = frameList[n].start;
                int endFrame = frameList[n].end;
                divideNumber = int.Parse(WHATFRAME_TEXT.Text);
                //1-500 프레임을 받고싶은데 100장으로 나누려면 5프레임이 델타 프레임이된다.
                float deltaFrame = (endFrame - startFrame + 1) / (float)divideNumber;
                float currFrame = 0;

                capture.PosFrames = startFrame;
                //저장경로
                string savePath_front = Path.GetFullPath("./output/sample/sample_front/");
                string savePath_side = Path.GetFullPath("./output/sample/sample_side/");

                OpenCvSharp.Size dSize;
                using (Mat tempMat = new Mat()) {
                    capture.Read(tempMat);
                    dSize = new OpenCvSharp.Size(tempMat.Width , tempMat.Height);
                }

                //처음 Read할 프레임을 지정
                capture.PosFrames = startFrame;
                currFrame = startFrame;

                //샘플 비디오의 경로를 설정
                //sampleVideoPath = savePath + "sample" + (n + 1).ToString() + ".avi";
                DateTime dt1970 = new DateTime(1970 , 1 , 1);
                DateTime current = DateTime.Now;
                TimeSpan span = current - dt1970;

                if (frameList[n].isFront) {
                    sampleVideoPath = savePath_front + (span.TotalMilliseconds-new Random().NextDouble()*1241.2).ToString()+".avi";
                } else {
                    sampleVideoPath = savePath_side + (span.TotalMilliseconds-new Random().NextDouble()*1241.2).ToString()+".avi";
                }
                

                sampleVideoPath = Path.GetFullPath(sampleVideoPath);

                if (frameList[n].isFront) {
                    sampleVideoPaths_Front.Add(sampleVideoPath);
                } else {
                    sampleVideoPaths_Side.Add(sampleVideoPath);
                }
                
                
                //주요 함수
                bool isFront = frameList[n].isFront;
                bool isFlip = frameList[n].isLeft; //만약에 왼쪽라디오 버튼이면 플립이 true


                using (VideoWriter writer = new VideoWriter(sampleVideoPath , "MJPG"
                    , 10 , dSize))
                using (Mat frame = new Mat()) {

                    for (int i = 0 ; i < divideNumber ; i++) {

                        capture.Read(frame);

                        //읽어들일 프레임이 없으면 종료
                        if (frame.Empty())
                            break;

                        //프레임 작업
                        currFrame += deltaFrame;
                        capture.PosFrames = (int)currFrame;

                        //정면이 아니고 Left 설정일때 만 flip
                        if (isFront == false) {
                            if (isFlip)
                                Cv2.Flip(frame , frame , FlipMode.Y);
                        }

                        //sample.avi에 쓴다
                        writer.Write(frame);




                        //메모리정리
                        GC.Collect();
                    }

                }
                
                //진행상황 작업
                saveCount++;
                worker.ReportProgress(saveCount);
            
            
            }
               
            
        }
       
        //샘플링진행상황 핸들러
        private void SAVEPROGRESS(object sender , System.ComponentModel.ProgressChangedEventArgs e) {
            SAVEVIDEO_LABEL.Text = e.ProgressPercentage.ToString() + "/"+FRAMESAMPLE_LISTBOX.Items.Count.ToString()+"...";
        }
        
        //샘플링 완료
        private void SAVECOMPLETE(object sender , System.ComponentModel.RunWorkerCompletedEventArgs e) {
            
            #region Component Set
            //각종 버튼을 활성화한다
            SETSTART_BTN.Enabled = true;
            SETEND_BTN.Enabled = true;
            SAVEIMAGE_BTN.Enabled = true;
            DOWN_BTN.Enabled = true;
            LOCALOPEN_BTN.Enabled = true;
            FRAMELEFT_BTN.Enabled = true;
            FRAMERIGHT_BTN.Enabled = true;
            FRAME_TRACKBAR.Enabled = true;
            FRAMEBOX_TEXT.Enabled = true;
            ADD_BTN.Enabled = true;
            DELETE_BTN.Enabled = true;
            #endregion

            //끝시간
            var end = Cv2.GetTickCount() - start;
            end/= Cv2.GetTickFrequency();
            SAVEVIDEO_LABEL.Text = "Completed[" + Math.Round(end).ToString() + "s]";

            //샘플링된 비디오 수 업데이트
            SAMPLEDVIDEOCOUNTFRONT_LABEL.Text = sampleVideoPaths_Front.Count.ToString();
            SAMPLEDVIDEOCOUNTSIDE_LABEL.Text = sampleVideoPaths_Side.Count.ToString();
        }

        //오픈포즈데모.exe 경로 설정 버튼
        private void OPENPOSEDEMO_BTN_Click(object sender , EventArgs e) {
            string filter = "Exe Files (.exe)|*.exe";

            using (OpenFileDialog fd = new OpenFileDialog() {
                Title = "Select OpenPoseDemo.exe" ,
                Filter = filter
            }) {
                if (fd.ShowDialog()==DialogResult.OK) {
                    OpenPoseDemoExePath = fd.FileName;
                    textBox1.Text = OpenPoseDemoExePath;
                }
            }
        }
        
        //오픈포즈 아웃풋 경로 설정 버튼
        private void OPENPOSEOUTPUT_BTN_Click(object sender , EventArgs e) {  
            using (FolderBrowserDialog fd = new FolderBrowserDialog() {
                Description = "Select OpenPose output path"}) {
                if (fd.ShowDialog()==DialogResult.OK) {
                    OpenPoseOutputPath = fd.SelectedPath;
                    textBox2.Text = OpenPoseOutputPath;
                }
            }
        }

        //아웃풋폴더 클릭
        private void button1_Click(object sender , EventArgs e) {
            Process.Start(@".\output");
        }

        //프레임 트랙바에서 마우스를 들었을 때
        private void FRAME_TRACKBAR_MOUSEUP(object sender , MouseEventArgs e) {
             if (tempImage != null) {
                tempImage.Dispose();
                tempMat.Dispose();
            }
            tempMat = new Mat();
            capture.PosFrames = FRAME_TRACKBAR.Value;

            capture.Read(tempMat);

            tempImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(tempMat);

            FRAME_PICTUREBOX.Image = tempImage;

            FRAMEBAR_LABEL.Text = FRAME_TRACKBAR.Value.ToString() + "/" + FRAME_TRACKBAR.Maximum.ToString();

            FRAMEBOX_TEXT.Text = FRAME_TRACKBAR.Value.ToString();
        }

        private void button2_Click(object sender , EventArgs e) {
            if(OpenPoseOutputPath!=null)
            Process.Start(OpenPoseOutputPath);
        }

        private void CHECK_ISFRONT_CheckedChanged(object sender , EventArgs e) {
            if (CHECK_ISFRONT.Checked == true) {
                CHECK_ISLEFTSIDE.Enabled = false;
            } else {
                CHECK_ISLEFTSIDE.Enabled = true;
            }
        }

        

        
        //리스트 추가 버튼
        private void ADD_BTN_Click(object sender , EventArgs e) {
            int startFrame = int.Parse(STARTTEXT_TEXT.Text);
            int endFrame = int.Parse(ENDTEXT_TEXT.Text);

            if (startFrame >= endFrame) {
                MessageBox.Show("Start frame can't have higher value than end!" , "error");
                return;
            }


            
            frameList.Add(new FrameVector(
                int.Parse(STARTTEXT_TEXT.Text),int.Parse(ENDTEXT_TEXT.Text),
                CHECK_ISFRONT.Checked,CHECK_ISLEFTSIDE.Checked
            ));
            
            if (FRAMESAMPLE_LISTBOX.Items.Count > 0)
                DELETE_BTN.Enabled = true;
            else
                DELETE_BTN.Enabled = false;

        }
        //리스트 삭제 버튼
        private void DELETE_BTN_Click(object sender , EventArgs e) {
            if (FRAMESAMPLE_LISTBOX.Items.Count == 0) {
                MessageBox.Show("There is no element in listbox!" , "error");
                return;
            }
            
            int focusIndex = FRAMESAMPLE_LISTBOX.SelectedIndex;

            frameList.RemoveAt(focusIndex);

            if (FRAMESAMPLE_LISTBOX.Items.Count > 0)
                DELETE_BTN.Enabled = true;
            else
                DELETE_BTN.Enabled = false;
        }

        bool OutputDirectorySetted = false;

        //오픈포즈 버튼 클릭
        private void OPENPOSE_Click(object sender , EventArgs e) {

            

            //처음 버튼을 눌렀을 때만 실행
            if (OutputDirectorySetted == false) {
                OutputDirectorySetted = true;
                outputJSONPaths.Clear();
                LABEL_OPENPOSESTATE.Text = "Posing....";

                

                //아웃풋 디렉토리 경로 설정 outputJSONPaths 엔 정면 샘플된 동영상들의 경로들부터 추가된다.
                for (int i = 0 ; i < sampleVideoPaths_Front.Count ; i++) {
                    string dir = GetNextDirectoryPath(OpenPoseOutputPath+Path.DirectorySeparatorChar+"Front");
                    Directory.CreateDirectory(dir);
                    //MessageBox.Show("만든 위치 : " + dir);
                    outputJSONPaths.Add(dir);
                }
                //아웃풋 디렉토리 경로 설정
                for (int i = 0 ; i < sampleVideoPaths_Side.Count ; i++) {
                    string dir = GetNextDirectoryPath(OpenPoseOutputPath+Path.DirectorySeparatorChar+"Side");
                    Directory.CreateDirectory(dir);
                    //MessageBox.Show("만든 위치 : " + dir);
                    outputJSONPaths.Add(dir);
                }
                start = Cv2.GetTickCount();
            }
            
            
            #region Error Process
            bool isError = false;
            string ErrorString = "";

            if (!File.Exists(OpenPoseDemoExePath)) {
                isError = true;
                ErrorString += "OpenPoseDemo.exe not exist\n";
            }
            if (OpenPoseOutputPath == null) {
                isError = true;
                ErrorString+="Select Output Directory!\n";
            }
            if (isError) {
                MessageBox.Show(ErrorString,"Error");
                return;
            }
            #endregion

            Process process = new Process();
            process.StartInfo.FileName = OpenPoseDemoExePath;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.StartInfo.Arguments = null;
            process.StartInfo.WorkingDirectory = Directory.GetParent(Path.GetDirectoryName(OpenPoseDemoExePath)).FullName;


            //인자 설정
            

            //모든 샘플링 비디오를 모두 실행시켰다면 종료
            if (openPoseProcessIndex >= (sampleVideoPaths_Front.Count+sampleVideoPaths_Side.Count)) {
                openPoseProcessIndex = 0;
                samplePathIndex_Front = 0;
                samplePathIndex_Side = 0;

                OutputDirectorySetted = false;




                //빈 폴더 지우기
                string[ ] dirs = Directory.GetDirectories(OpenPoseOutputPath+Path.DirectorySeparatorChar+"Front");
                
                
                for (int i = 0 ; i < dirs.Length ; i ++) {
                    if (Directory.GetFiles(dirs[i]).Length == 0) {
                        Directory.Delete(dirs[i]);
                    }
                }
                dirs = Directory.GetDirectories(OpenPoseOutputPath+Path.DirectorySeparatorChar+"Side");
                
                
                for (int i = 0 ; i < dirs.Length ; i ++) {
                    if (Directory.GetFiles(dirs[i]).Length == 0) {
                        Directory.Delete(dirs[i]);
                    }
                }
                //빈폴더 지우기 끝


                end = (Cv2.GetTickCount()-start)/Cv2.GetTickFrequency();
                
  
                LABEL_OPENPOSESTATE.Text = "Completed[" + Math.Round(end).ToString() + "s]";


                return;
            }

            //샘플 동영상 경로, 아웃풋 폴더 경로
            if (openPoseProcessIndex < sampleVideoPaths_Front.Count) {//0, 2이라고 할 때 
                sampleVideoPath = sampleVideoPaths_Front[samplePathIndex_Front++];
            } else {
                sampleVideoPath = sampleVideoPaths_Side[samplePathIndex_Side++];
            }
            
            string outputPath = outputJSONPaths[openPoseProcessIndex++];
            


            switch (COMBO_OUTPUTFORMAT.SelectedIndex) {
                case 0: // JSON

                    process.StartInfo.Arguments = @"--video " + "\"" + sampleVideoPath
                        + "\"" + " --write_json " + "\"" + outputPath + "/\"";
                        
                    break;
                
                case 1: //JSON + VIDEO
                    process.StartInfo.Arguments = @"--video " + "\"" + sampleVideoPath + "\""
                        + " --write_video " + "\"" + outputPath + "/result.avi\""
                        + " --write_json " + "\"" + outputPath + "/\"";
                    break;
                    
            }

            
            string options = @"";

            if (openSetting.NoBlending)
                options += @" --disable_blending";
            if (openSetting.NoWindow)
                options += @" --display 0";
            
            options += @" --keypoint_scale " + openSetting.KeyPointScaleMode;
            options += @" --number_people_max " + openSetting.NumberPeopleMax;

            process.StartInfo.Arguments += options;


            //프로세스가 종료될때의 이벤트를 이 함수로 다시 설정함으로써 반복적으로 실행될 수 있게 한다.
            //process.Exited += OPENPOSE_Click;
            

            //프로세스 실행
            process.Start();
            process.WaitForExit(); //종료까지 대기

            //소켓처리
            socket.Emit("submit" ,  JObject.FromObject(socketJSON));

            OPENPOSE_Click(this , null); //다시 함수 실행
            

        }

        private void COMBO_WHO_SelectedIndexChanged(object sender , EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender , LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://mjstudio.cafe24app.com/");
        }

        private void button3_Click(object sender , EventArgs e) {
            
        }

        private void textBox2_TextChanged(object sender , EventArgs e) {

        }

        private void FRAMESAMPLE_LISTBOX_SelectedIndexChanged(object sender , EventArgs e) {

        }

        //다음 위치할 디렉터리 위치 반환
        private string GetNextDirectoryPath(string path) {

            int i = 1;

            
            while (Directory.Exists(path +Path.DirectorySeparatorChar + i.ToString())) {

                i++;
            }
            string output = path + "/" + i.ToString();
            output = Path.GetFullPath(output);
            return output;
        }
    }
}
