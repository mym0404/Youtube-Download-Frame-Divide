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

using Newtonsoft.Json.Linq;

namespace Youtube_Download_Frame_Divide {
    public partial class MJStudio : Form {

        #region Variables
        int saveCount = 0;
        int divideNumber = 0;

        //임시 비트맵, 매트릭스
        Bitmap tempImage;
        Mat tempMat;

        VideoCapture capture;
        //불러온 비디오 경로
        string videoPath = null;
 


        //연산시간 계산 변수
        double start, end;


        #endregion

 

        public MJStudio() {
            InitializeComponent();
        }

        //이 윈도우 폼이 불러졌을 때 //최초실행
        private void Form1_Load(object sender , EventArgs e) {

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

                File.WriteAllBytes((videoPath = @"./output/" + video.FullName) , await video.GetBytesAsync());
                
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

            //트랙바활성화
            FRAME_TRACKBAR.Enabled = true;

            if (capture != null) {
                capture.Dispose();
            }
            GC.Collect();


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

                    DOWNSTATE_TEXT.Text = "Video Loaded!";
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

        }

        //샘플링 백그라운드 워커
        private void SAVEDOWORK(object sender , System.ComponentModel.DoWorkEventArgs e) {

            //시작시간 저장
            start = Cv2.GetTickCount();
            BackgroundWorker worker = (BackgroundWorker)sender;
            saveCount = 0;

            GC.Collect();

            //저장해야할 프레임 정보를 계산한다.
            int AllFrame = capture.FrameCount;
            int startFrame = int.Parse( STARTTEXT_TEXT.Text);
            int endFrame = int.Parse(ENDTEXT_TEXT.Text);
            divideNumber = int.Parse(WHATFRAME_TEXT.Text);
            //1-500 프레임을 받고싶은데 100장으로 나누려면 5프레임이 델타 프레임이된다.
            float deltaFrame = (endFrame - startFrame + 1) / (float)divideNumber;
            float currFrame = 0;

            //저장경로

            if (!File.Exists(@"./output"))
                Directory.CreateDirectory(@"./output");
            if (!File.Exists(@"./output/sample"))
                Directory.CreateDirectory(@"./output/sample");


            string savePath = Path.GetFullPath(@"./output/sample");

            OpenCvSharp.Size dSize;
            using (Mat tempMat = new Mat()) {
                capture.Read(tempMat);
                dSize = new OpenCvSharp.Size(tempMat.Width , tempMat.Height);
            }

            //처음 Read할 프레임을 지정
            capture.PosFrames = startFrame;
            currFrame = startFrame;



            try {
                using (Mat frame = new Mat()) {
                    for (int i = 0 ; i < divideNumber ; i++) {

                        capture.Read(frame);

                        
                        //읽어들일 프레임이 없으면 종료
                        if (frame.Empty())
                            break;
                          
                        //프레임 작업
                        currFrame += deltaFrame;
                        capture.PosFrames = (int)currFrame;


                        frame.ImWrite(@"./output/sample/" + (i+1).ToString()+".jpg");
                        

                        //메모리정리
                        GC.Collect();
                        worker.ReportProgress(i + 1);
                    }

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            //진행상황 작업
            saveCount++;
            


        
               
            
        }
       
        //샘플링진행상황 핸들러
        private void SAVEPROGRESS(object sender , System.ComponentModel.ProgressChangedEventArgs e) {
            SAVEVIDEO_LABEL.Text = e.ProgressPercentage.ToString() +"...";
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

            #endregion

            //끝시간
            var end = Cv2.GetTickCount() - start;
            end/= Cv2.GetTickFrequency();
            SAVEVIDEO_LABEL.Text = "Completed[" + Math.Round(end).ToString() + "s]";


        }



        //아웃풋폴더 클릭
        private void button1_Click(object sender , EventArgs e) {
            string outputDirectory = @".\output";
            if (!File.Exists(outputDirectory)) {
                Directory.CreateDirectory(outputDirectory);
            }
            Process.Start(outputDirectory);
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
