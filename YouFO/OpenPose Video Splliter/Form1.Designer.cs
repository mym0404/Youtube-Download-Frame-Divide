namespace OpenPose_Video_Splliter {
    partial class OpenPose {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.DOWN_BTN = new System.Windows.Forms.Button();
            this.URL_TEXT = new System.Windows.Forms.TextBox();
            this.URL_LABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AUTODELETE_CHECK = new System.Windows.Forms.CheckBox();
            this.FRAME_PICTUREBOX = new System.Windows.Forms.PictureBox();
            this.FRAME_TRACKBAR = new System.Windows.Forms.TrackBar();
            this.SETSTART_BTN = new System.Windows.Forms.Button();
            this.SETEND_BTN = new System.Windows.Forms.Button();
            this.FRAMEBAR_LABEL = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.FRAMELEFT_BTN = new System.Windows.Forms.Button();
            this.FRAMERIGHT_BTN = new System.Windows.Forms.Button();
            this.SAVEIMAGE_BTN = new System.Windows.Forms.Button();
            this.WHATFRAME_TEXT = new System.Windows.Forms.TextBox();
            this.DOWNSTATE_TEXT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOCALOPEN_BTN = new System.Windows.Forms.Button();
            this.VIDEONAME_TEXT = new System.Windows.Forms.TextBox();
            this.FRAMEBOX_TEXT = new System.Windows.Forms.TextBox();
            this.SAVEVIDEO_LABEL = new System.Windows.Forms.Label();
            this.SAVEPROGRESS_BACKGROUNDWORKER = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DELETE_BTN = new System.Windows.Forms.Button();
            this.CHECK_ISFRONT = new System.Windows.Forms.CheckBox();
            this.CHECK_ISLEFTSIDE = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SAMPLEDVIDEOCOUNTSIDE_LABEL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SAMPLEDVIDEOCOUNTFRONT_LABEL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CHECK_NOBLENDING = new System.Windows.Forms.CheckBox();
            this.CHECK_NODISPLAY = new System.Windows.Forms.CheckBox();
            this.OPENPOSE_BTN = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OPENPOSEOUTPUT_BTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OPENPOSEDEMO_BTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.COMBO_OUTPUTFORMAT = new System.Windows.Forms.ComboBox();
            this.FRAMESAMPLE_LISTBOX = new System.Windows.Forms.ListBox();
            this.STARTTEXT_TEXT = new System.Windows.Forms.TextBox();
            this.ENDTEXT_TEXT = new System.Windows.Forms.TextBox();
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.COMBO_WHO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LABEL_SOCKETSTATE = new System.Windows.Forms.Label();
            this.LABEL_SUBMITSTATE = new System.Windows.Forms.Label();
            this.LABEL_OPENPOSESTATE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME_PICTUREBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME_TRACKBAR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DOWN_BTN
            // 
            this.DOWN_BTN.Location = new System.Drawing.Point(315, 28);
            this.DOWN_BTN.Name = "DOWN_BTN";
            this.DOWN_BTN.Size = new System.Drawing.Size(93, 23);
            this.DOWN_BTN.TabIndex = 0;
            this.DOWN_BTN.Text = "DOWNLOAD";
            this.DOWN_BTN.UseVisualStyleBackColor = true;
            this.DOWN_BTN.Click += new System.EventHandler(this.DOWN_BTN_Click);
            // 
            // URL_TEXT
            // 
            this.URL_TEXT.Location = new System.Drawing.Point(119, 29);
            this.URL_TEXT.Name = "URL_TEXT";
            this.URL_TEXT.Size = new System.Drawing.Size(183, 21);
            this.URL_TEXT.TabIndex = 1;
            // 
            // URL_LABEL
            // 
            this.URL_LABEL.AutoSize = true;
            this.URL_LABEL.Location = new System.Drawing.Point(19, 33);
            this.URL_LABEL.Name = "URL_LABEL";
            this.URL_LABEL.Size = new System.Drawing.Size(78, 12);
            this.URL_LABEL.TabIndex = 2;
            this.URL_LABEL.Text = "Youtube URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Divided Frames Count";
            // 
            // AUTODELETE_CHECK
            // 
            this.AUTODELETE_CHECK.AutoSize = true;
            this.AUTODELETE_CHECK.Enabled = false;
            this.AUTODELETE_CHECK.Location = new System.Drawing.Point(244, 259);
            this.AUTODELETE_CHECK.Name = "AUTODELETE_CHECK";
            this.AUTODELETE_CHECK.Size = new System.Drawing.Size(164, 16);
            this.AUTODELETE_CHECK.TabIndex = 7;
            this.AUTODELETE_CHECK.Text = "Auto delete source video";
            this.AUTODELETE_CHECK.UseVisualStyleBackColor = true;
            // 
            // FRAME_PICTUREBOX
            // 
            this.FRAME_PICTUREBOX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FRAME_PICTUREBOX.Location = new System.Drawing.Point(31, 64);
            this.FRAME_PICTUREBOX.Name = "FRAME_PICTUREBOX";
            this.FRAME_PICTUREBOX.Size = new System.Drawing.Size(374, 256);
            this.FRAME_PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FRAME_PICTUREBOX.TabIndex = 13;
            this.FRAME_PICTUREBOX.TabStop = false;
            // 
            // FRAME_TRACKBAR
            // 
            this.FRAME_TRACKBAR.Enabled = false;
            this.FRAME_TRACKBAR.Location = new System.Drawing.Point(31, 330);
            this.FRAME_TRACKBAR.Maximum = 100;
            this.FRAME_TRACKBAR.Name = "FRAME_TRACKBAR";
            this.FRAME_TRACKBAR.Size = new System.Drawing.Size(374, 45);
            this.FRAME_TRACKBAR.TabIndex = 14;
            this.FRAME_TRACKBAR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FRAME_TRACKBAR_MOUSEUP);
            // 
            // SETSTART_BTN
            // 
            this.SETSTART_BTN.Enabled = false;
            this.SETSTART_BTN.Location = new System.Drawing.Point(35, 407);
            this.SETSTART_BTN.Name = "SETSTART_BTN";
            this.SETSTART_BTN.Size = new System.Drawing.Size(85, 23);
            this.SETSTART_BTN.TabIndex = 17;
            this.SETSTART_BTN.Text = "SET START";
            this.SETSTART_BTN.UseVisualStyleBackColor = true;
            this.SETSTART_BTN.Click += new System.EventHandler(this.SETSTARTCLICK);
            // 
            // SETEND_BTN
            // 
            this.SETEND_BTN.Enabled = false;
            this.SETEND_BTN.Location = new System.Drawing.Point(126, 407);
            this.SETEND_BTN.Name = "SETEND_BTN";
            this.SETEND_BTN.Size = new System.Drawing.Size(85, 23);
            this.SETEND_BTN.TabIndex = 18;
            this.SETEND_BTN.Text = "SET END";
            this.SETEND_BTN.UseVisualStyleBackColor = true;
            this.SETEND_BTN.Click += new System.EventHandler(this.SETENDCLICK);
            // 
            // FRAMEBAR_LABEL
            // 
            this.FRAMEBAR_LABEL.AutoSize = true;
            this.FRAMEBAR_LABEL.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRAMEBAR_LABEL.Location = new System.Drawing.Point(305, 378);
            this.FRAMEBAR_LABEL.Name = "FRAMEBAR_LABEL";
            this.FRAMEBAR_LABEL.Size = new System.Drawing.Size(38, 18);
            this.FRAMEBAR_LABEL.TabIndex = 19;
            this.FRAMEBAR_LABEL.Text = "0/0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(244, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 16);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Auto delete sample video";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FRAMELEFT_BTN
            // 
            this.FRAMELEFT_BTN.Enabled = false;
            this.FRAMELEFT_BTN.Location = new System.Drawing.Point(35, 378);
            this.FRAMELEFT_BTN.Name = "FRAMELEFT_BTN";
            this.FRAMELEFT_BTN.Size = new System.Drawing.Size(25, 21);
            this.FRAMELEFT_BTN.TabIndex = 34;
            this.FRAMELEFT_BTN.Text = "<<";
            this.FRAMELEFT_BTN.UseVisualStyleBackColor = true;
            this.FRAMELEFT_BTN.Click += new System.EventHandler(this.FRAMELEFT_BTN_Click);
            // 
            // FRAMERIGHT_BTN
            // 
            this.FRAMERIGHT_BTN.Enabled = false;
            this.FRAMERIGHT_BTN.Location = new System.Drawing.Point(64, 378);
            this.FRAMERIGHT_BTN.Name = "FRAMERIGHT_BTN";
            this.FRAMERIGHT_BTN.Size = new System.Drawing.Size(25, 21);
            this.FRAMERIGHT_BTN.TabIndex = 35;
            this.FRAMERIGHT_BTN.Text = ">>";
            this.FRAMERIGHT_BTN.UseVisualStyleBackColor = true;
            this.FRAMERIGHT_BTN.Click += new System.EventHandler(this.FRAMERIGHT_BTN_Click);
            // 
            // SAVEIMAGE_BTN
            // 
            this.SAVEIMAGE_BTN.BackColor = System.Drawing.SystemColors.Window;
            this.SAVEIMAGE_BTN.Enabled = false;
            this.SAVEIMAGE_BTN.Font = new System.Drawing.Font("Prestige Elite Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEIMAGE_BTN.Location = new System.Drawing.Point(17, 399);
            this.SAVEIMAGE_BTN.Name = "SAVEIMAGE_BTN";
            this.SAVEIMAGE_BTN.Size = new System.Drawing.Size(212, 47);
            this.SAVEIMAGE_BTN.TabIndex = 38;
            this.SAVEIMAGE_BTN.Text = "SAMPLE ALL";
            this.SAVEIMAGE_BTN.UseVisualStyleBackColor = false;
            this.SAVEIMAGE_BTN.Click += new System.EventHandler(this.SAVEIMAGE_BTN_Click);
            // 
            // WHATFRAME_TEXT
            // 
            this.WHATFRAME_TEXT.Location = new System.Drawing.Point(163, 360);
            this.WHATFRAME_TEXT.Name = "WHATFRAME_TEXT";
            this.WHATFRAME_TEXT.Size = new System.Drawing.Size(66, 21);
            this.WHATFRAME_TEXT.TabIndex = 39;
            this.WHATFRAME_TEXT.Text = "30";
            // 
            // DOWNSTATE_TEXT
            // 
            this.DOWNSTATE_TEXT.AutoSize = true;
            this.DOWNSTATE_TEXT.Font = new System.Drawing.Font("Prestige Elite Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOWNSTATE_TEXT.ForeColor = System.Drawing.Color.Blue;
            this.DOWNSTATE_TEXT.Location = new System.Drawing.Point(310, 61);
            this.DOWNSTATE_TEXT.Name = "DOWNSTATE_TEXT";
            this.DOWNSTATE_TEXT.Size = new System.Drawing.Size(63, 14);
            this.DOWNSTATE_TEXT.TabIndex = 40;
            this.DOWNSTATE_TEXT.Text = "ready...";
            this.DOWNSTATE_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "Local File";
            // 
            // LOCALOPEN_BTN
            // 
            this.LOCALOPEN_BTN.Location = new System.Drawing.Point(119, 57);
            this.LOCALOPEN_BTN.Name = "LOCALOPEN_BTN";
            this.LOCALOPEN_BTN.Size = new System.Drawing.Size(30, 23);
            this.LOCALOPEN_BTN.TabIndex = 42;
            this.LOCALOPEN_BTN.Text = "...";
            this.LOCALOPEN_BTN.UseVisualStyleBackColor = true;
            this.LOCALOPEN_BTN.Click += new System.EventHandler(this.LOCALOPEN_BTN_Click);
            // 
            // VIDEONAME_TEXT
            // 
            this.VIDEONAME_TEXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.VIDEONAME_TEXT.Font = new System.Drawing.Font("배달의민족 연성", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VIDEONAME_TEXT.Location = new System.Drawing.Point(31, 31);
            this.VIDEONAME_TEXT.Name = "VIDEONAME_TEXT";
            this.VIDEONAME_TEXT.ReadOnly = true;
            this.VIDEONAME_TEXT.Size = new System.Drawing.Size(374, 22);
            this.VIDEONAME_TEXT.TabIndex = 43;
            this.VIDEONAME_TEXT.Text = "Video Path None";
            this.VIDEONAME_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRAMEBOX_TEXT
            // 
            this.FRAMEBOX_TEXT.Enabled = false;
            this.FRAMEBOX_TEXT.Location = new System.Drawing.Point(107, 378);
            this.FRAMEBOX_TEXT.Name = "FRAMEBOX_TEXT";
            this.FRAMEBOX_TEXT.Size = new System.Drawing.Size(73, 21);
            this.FRAMEBOX_TEXT.TabIndex = 44;
            this.FRAMEBOX_TEXT.Text = "0";
            this.FRAMEBOX_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FRAMEBOX_TEXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SETFRAMEKEYDOWN);
            // 
            // SAVEVIDEO_LABEL
            // 
            this.SAVEVIDEO_LABEL.AutoSize = true;
            this.SAVEVIDEO_LABEL.Font = new System.Drawing.Font("Prestige Elite Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEVIDEO_LABEL.ForeColor = System.Drawing.Color.Blue;
            this.SAVEVIDEO_LABEL.Location = new System.Drawing.Point(27, 466);
            this.SAVEVIDEO_LABEL.Name = "SAVEVIDEO_LABEL";
            this.SAVEVIDEO_LABEL.Size = new System.Drawing.Size(63, 14);
            this.SAVEVIDEO_LABEL.TabIndex = 45;
            this.SAVEVIDEO_LABEL.Text = "ready...";
            this.SAVEVIDEO_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SAVEPROGRESS_BACKGROUNDWORKER
            // 
            this.SAVEPROGRESS_BACKGROUNDWORKER.WorkerReportsProgress = true;
            this.SAVEPROGRESS_BACKGROUNDWORKER.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SAVEDOWORK);
            this.SAVEPROGRESS_BACKGROUNDWORKER.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SAVEPROGRESS);
            this.SAVEPROGRESS_BACKGROUNDWORKER.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SAVECOMPLETE);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DOWN_BTN);
            this.groupBox1.Controls.Add(this.URL_TEXT);
            this.groupBox1.Controls.Add(this.URL_LABEL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LOCALOPEN_BTN);
            this.groupBox1.Controls.Add(this.DOWNSTATE_TEXT);
            this.groupBox1.Location = new System.Drawing.Point(29, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 89);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Load Video";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DELETE_BTN);
            this.groupBox3.Controls.Add(this.SAVEIMAGE_BTN);
            this.groupBox3.Controls.Add(this.SAVEVIDEO_LABEL);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.WHATFRAME_TEXT);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(932, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 506);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Sample Video";
            // 
            // DELETE_BTN
            // 
            this.DELETE_BTN.Enabled = false;
            this.DELETE_BTN.Location = new System.Drawing.Point(65, 294);
            this.DELETE_BTN.Name = "DELETE_BTN";
            this.DELETE_BTN.Size = new System.Drawing.Size(96, 23);
            this.DELETE_BTN.TabIndex = 52;
            this.DELETE_BTN.Text = "DELETE";
            this.DELETE_BTN.UseVisualStyleBackColor = true;
            this.DELETE_BTN.Click += new System.EventHandler(this.DELETE_BTN_Click);
            // 
            // CHECK_ISFRONT
            // 
            this.CHECK_ISFRONT.AutoSize = true;
            this.CHECK_ISFRONT.Location = new System.Drawing.Point(229, 409);
            this.CHECK_ISFRONT.Name = "CHECK_ISFRONT";
            this.CHECK_ISFRONT.Size = new System.Drawing.Size(52, 16);
            this.CHECK_ISFRONT.TabIndex = 48;
            this.CHECK_ISFRONT.Text = "Front";
            this.CHECK_ISFRONT.UseVisualStyleBackColor = true;
            this.CHECK_ISFRONT.CheckedChanged += new System.EventHandler(this.CHECK_ISFRONT_CheckedChanged);
            // 
            // CHECK_ISLEFTSIDE
            // 
            this.CHECK_ISLEFTSIDE.AutoSize = true;
            this.CHECK_ISLEFTSIDE.Location = new System.Drawing.Point(229, 431);
            this.CHECK_ISLEFTSIDE.Name = "CHECK_ISLEFTSIDE";
            this.CHECK_ISLEFTSIDE.Size = new System.Drawing.Size(44, 16);
            this.CHECK_ISLEFTSIDE.TabIndex = 53;
            this.CHECK_ISLEFTSIDE.Text = "Left";
            this.CHECK_ISLEFTSIDE.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LABEL_OPENPOSESTATE);
            this.groupBox4.Controls.Add(this.SAMPLEDVIDEOCOUNTSIDE_LABEL);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.SAMPLEDVIDEOCOUNTFRONT_LABEL);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.CHECK_NOBLENDING);
            this.groupBox4.Controls.Add(this.CHECK_NODISPLAY);
            this.groupBox4.Controls.Add(this.OPENPOSE_BTN);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.OPENPOSEOUTPUT_BTN);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.OPENPOSEDEMO_BTN);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.COMBO_OUTPUTFORMAT);
            this.groupBox4.Controls.Add(this.AUTODELETE_CHECK);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(29, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 400);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Open Pose [VIDEO => JSON, VIDEO] 18 Keypoints";
            // 
            // SAMPLEDVIDEOCOUNTSIDE_LABEL
            // 
            this.SAMPLEDVIDEOCOUNTSIDE_LABEL.AutoSize = true;
            this.SAMPLEDVIDEOCOUNTSIDE_LABEL.Location = new System.Drawing.Point(130, 285);
            this.SAMPLEDVIDEOCOUNTSIDE_LABEL.Name = "SAMPLEDVIDEOCOUNTSIDE_LABEL";
            this.SAMPLEDVIDEOCOUNTSIDE_LABEL.Size = new System.Drawing.Size(11, 12);
            this.SAMPLEDVIDEOCOUNTSIDE_LABEL.TabIndex = 52;
            this.SAMPLEDVIDEOCOUNTSIDE_LABEL.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "Side Samples : ";
            // 
            // SAMPLEDVIDEOCOUNTFRONT_LABEL
            // 
            this.SAMPLEDVIDEOCOUNTFRONT_LABEL.AutoSize = true;
            this.SAMPLEDVIDEOCOUNTFRONT_LABEL.Location = new System.Drawing.Point(130, 257);
            this.SAMPLEDVIDEOCOUNTFRONT_LABEL.Name = "SAMPLEDVIDEOCOUNTFRONT_LABEL";
            this.SAMPLEDVIDEOCOUNTFRONT_LABEL.Size = new System.Drawing.Size(11, 12);
            this.SAMPLEDVIDEOCOUNTFRONT_LABEL.TabIndex = 49;
            this.SAMPLEDVIDEOCOUNTFRONT_LABEL.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "Front Samples : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 22);
            this.button2.TabIndex = 47;
            this.button2.Text = "OPEN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "Detect people max : 1";
            // 
            // CHECK_NOBLENDING
            // 
            this.CHECK_NOBLENDING.AutoSize = true;
            this.CHECK_NOBLENDING.Location = new System.Drawing.Point(19, 169);
            this.CHECK_NOBLENDING.Name = "CHECK_NOBLENDING";
            this.CHECK_NOBLENDING.Size = new System.Drawing.Size(92, 16);
            this.CHECK_NOBLENDING.TabIndex = 11;
            this.CHECK_NOBLENDING.Text = "No blending";
            this.CHECK_NOBLENDING.UseVisualStyleBackColor = true;
            // 
            // CHECK_NODISPLAY
            // 
            this.CHECK_NODISPLAY.AutoSize = true;
            this.CHECK_NODISPLAY.Location = new System.Drawing.Point(119, 169);
            this.CHECK_NODISPLAY.Name = "CHECK_NODISPLAY";
            this.CHECK_NODISPLAY.Size = new System.Drawing.Size(133, 16);
            this.CHECK_NODISPLAY.TabIndex = 10;
            this.CHECK_NODISPLAY.Text = "No display window";
            this.CHECK_NODISPLAY.UseVisualStyleBackColor = true;
            // 
            // OPENPOSE_BTN
            // 
            this.OPENPOSE_BTN.BackColor = System.Drawing.SystemColors.Window;
            this.OPENPOSE_BTN.Font = new System.Drawing.Font("Prestige Elite Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPENPOSE_BTN.Location = new System.Drawing.Point(21, 325);
            this.OPENPOSE_BTN.Name = "OPENPOSE_BTN";
            this.OPENPOSE_BTN.Size = new System.Drawing.Size(387, 47);
            this.OPENPOSE_BTN.TabIndex = 8;
            this.OPENPOSE_BTN.Text = "O P E N P O S E";
            this.OPENPOSE_BTN.UseVisualStyleBackColor = false;
            this.OPENPOSE_BTN.Click += new System.EventHandler(this.OPENPOSE_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(155, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 21);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "None";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // OPENPOSEOUTPUT_BTN
            // 
            this.OPENPOSEOUTPUT_BTN.Location = new System.Drawing.Point(290, 79);
            this.OPENPOSEOUTPUT_BTN.Name = "OPENPOSEOUTPUT_BTN";
            this.OPENPOSEOUTPUT_BTN.Size = new System.Drawing.Size(26, 22);
            this.OPENPOSEOUTPUT_BTN.TabIndex = 6;
            this.OPENPOSEOUTPUT_BTN.Text = "...";
            this.OPENPOSEOUTPUT_BTN.UseVisualStyleBackColor = true;
            this.OPENPOSEOUTPUT_BTN.Click += new System.EventHandler(this.OPENPOSEOUTPUT_BTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(155, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(123, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "Output Directory";
            // 
            // OPENPOSEDEMO_BTN
            // 
            this.OPENPOSEDEMO_BTN.Location = new System.Drawing.Point(290, 36);
            this.OPENPOSEDEMO_BTN.Name = "OPENPOSEDEMO_BTN";
            this.OPENPOSEDEMO_BTN.Size = new System.Drawing.Size(26, 21);
            this.OPENPOSEDEMO_BTN.TabIndex = 3;
            this.OPENPOSEDEMO_BTN.Text = "...";
            this.OPENPOSEDEMO_BTN.UseVisualStyleBackColor = true;
            this.OPENPOSEDEMO_BTN.Click += new System.EventHandler(this.OPENPOSEDEMO_BTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "OpenPoseDemo.exe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Output Format";
            // 
            // COMBO_OUTPUTFORMAT
            // 
            this.COMBO_OUTPUTFORMAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_OUTPUTFORMAT.FormattingEnabled = true;
            this.COMBO_OUTPUTFORMAT.Items.AddRange(new object[] {
            "JSON",
            "JSON + VIDEO"});
            this.COMBO_OUTPUTFORMAT.Location = new System.Drawing.Point(285, 123);
            this.COMBO_OUTPUTFORMAT.Name = "COMBO_OUTPUTFORMAT";
            this.COMBO_OUTPUTFORMAT.Size = new System.Drawing.Size(121, 20);
            this.COMBO_OUTPUTFORMAT.TabIndex = 0;
            // 
            // FRAMESAMPLE_LISTBOX
            // 
            this.FRAMESAMPLE_LISTBOX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FRAMESAMPLE_LISTBOX.Font = new System.Drawing.Font("Prestige Elite Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRAMESAMPLE_LISTBOX.FormattingEnabled = true;
            this.FRAMESAMPLE_LISTBOX.ItemHeight = 14;
            this.FRAMESAMPLE_LISTBOX.Location = new System.Drawing.Point(950, 53);
            this.FRAMESAMPLE_LISTBOX.Name = "FRAMESAMPLE_LISTBOX";
            this.FRAMESAMPLE_LISTBOX.ScrollAlwaysVisible = true;
            this.FRAMESAMPLE_LISTBOX.Size = new System.Drawing.Size(212, 256);
            this.FRAMESAMPLE_LISTBOX.TabIndex = 51;
            this.FRAMESAMPLE_LISTBOX.SelectedIndexChanged += new System.EventHandler(this.FRAMESAMPLE_LISTBOX_SelectedIndexChanged);
            // 
            // STARTTEXT_TEXT
            // 
            this.STARTTEXT_TEXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.STARTTEXT_TEXT.Font = new System.Drawing.Font("Prestige Elite Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STARTTEXT_TEXT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.STARTTEXT_TEXT.Location = new System.Drawing.Point(35, 436);
            this.STARTTEXT_TEXT.Name = "STARTTEXT_TEXT";
            this.STARTTEXT_TEXT.ReadOnly = true;
            this.STARTTEXT_TEXT.Size = new System.Drawing.Size(85, 22);
            this.STARTTEXT_TEXT.TabIndex = 48;
            this.STARTTEXT_TEXT.Text = "0";
            this.STARTTEXT_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ENDTEXT_TEXT
            // 
            this.ENDTEXT_TEXT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ENDTEXT_TEXT.Font = new System.Drawing.Font("Prestige Elite Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDTEXT_TEXT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ENDTEXT_TEXT.Location = new System.Drawing.Point(126, 436);
            this.ENDTEXT_TEXT.Name = "ENDTEXT_TEXT";
            this.ENDTEXT_TEXT.ReadOnly = true;
            this.ENDTEXT_TEXT.Size = new System.Drawing.Size(85, 22);
            this.ENDTEXT_TEXT.TabIndex = 52;
            this.ENDTEXT_TEXT.Text = "0";
            this.ENDTEXT_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.Enabled = false;
            this.ADD_BTN.Location = new System.Drawing.Point(296, 407);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(85, 23);
            this.ADD_BTN.TabIndex = 54;
            this.ADD_BTN.Text = "ADD";
            this.ADD_BTN.UseVisualStyleBackColor = true;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VIDEONAME_TEXT);
            this.groupBox2.Controls.Add(this.CHECK_ISFRONT);
            this.groupBox2.Controls.Add(this.FRAME_PICTUREBOX);
            this.groupBox2.Controls.Add(this.CHECK_ISLEFTSIDE);
            this.groupBox2.Controls.Add(this.FRAME_TRACKBAR);
            this.groupBox2.Controls.Add(this.ADD_BTN);
            this.groupBox2.Controls.Add(this.SETSTART_BTN);
            this.groupBox2.Controls.Add(this.ENDTEXT_TEXT);
            this.groupBox2.Controls.Add(this.SETEND_BTN);
            this.groupBox2.Controls.Add(this.STARTTEXT_TEXT);
            this.groupBox2.Controls.Add(this.FRAMEBAR_LABEL);
            this.groupBox2.Controls.Add(this.FRAMELEFT_BTN);
            this.groupBox2.Controls.Add(this.FRAMERIGHT_BTN);
            this.groupBox2.Controls.Add(this.FRAMEBOX_TEXT);
            this.groupBox2.Location = new System.Drawing.Point(468, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 506);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Controller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(1048, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 12);
            this.label4.TabIndex = 56;
            this.label4.Text = "2018 GIST WING G.P.E";
            // 
            // COMBO_WHO
            // 
            this.COMBO_WHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_WHO.FormattingEnabled = true;
            this.COMBO_WHO.Items.AddRange(new object[] {
            "1. MMJ",
            "2. KJE",
            "3. BJH",
            "4. KDH",
            "5. KIH",
            "6. KHG"});
            this.COMBO_WHO.Location = new System.Drawing.Point(148, 538);
            this.COMBO_WHO.Name = "COMBO_WHO";
            this.COMBO_WHO.Size = new System.Drawing.Size(121, 20);
            this.COMBO_WHO.TabIndex = 57;
            this.COMBO_WHO.SelectedIndexChanged += new System.EventHandler(this.COMBO_WHO_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 12);
            this.label5.TabIndex = 58;
            this.label5.Text = "당신은 누구신가요";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkSalmon;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(278, 542);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 59;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "랭킹보기";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LABEL_SOCKETSTATE
            // 
            this.LABEL_SOCKETSTATE.AutoSize = true;
            this.LABEL_SOCKETSTATE.Location = new System.Drawing.Point(463, 542);
            this.LABEL_SOCKETSTATE.Name = "LABEL_SOCKETSTATE";
            this.LABEL_SOCKETSTATE.Size = new System.Drawing.Size(135, 12);
            this.LABEL_SOCKETSTATE.TabIndex = 60;
            this.LABEL_SOCKETSTATE.Text = "Socket State : 연결중...";
            // 
            // LABEL_SUBMITSTATE
            // 
            this.LABEL_SUBMITSTATE.AutoSize = true;
            this.LABEL_SUBMITSTATE.Location = new System.Drawing.Point(337, 542);
            this.LABEL_SUBMITSTATE.Name = "LABEL_SUBMITSTATE";
            this.LABEL_SUBMITSTATE.Size = new System.Drawing.Size(80, 12);
            this.LABEL_SUBMITSTATE.TabIndex = 62;
            this.LABEL_SUBMITSTATE.Text = "Submit : 준비";
            // 
            // LABEL_OPENPOSESTATE
            // 
            this.LABEL_OPENPOSESTATE.AutoSize = true;
            this.LABEL_OPENPOSESTATE.Font = new System.Drawing.Font("Prestige Elite Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_OPENPOSESTATE.ForeColor = System.Drawing.Color.Blue;
            this.LABEL_OPENPOSESTATE.Location = new System.Drawing.Point(287, 375);
            this.LABEL_OPENPOSESTATE.Name = "LABEL_OPENPOSESTATE";
            this.LABEL_OPENPOSESTATE.Size = new System.Drawing.Size(63, 14);
            this.LABEL_OPENPOSESTATE.TabIndex = 43;
            this.LABEL_OPENPOSESTATE.Text = "ready...";
            this.LABEL_OPENPOSESTATE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpenPose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 567);
            this.Controls.Add(this.LABEL_SUBMITSTATE);
            this.Controls.Add(this.LABEL_SOCKETSTATE);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.COMBO_WHO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FRAMESAMPLE_LISTBOX);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OpenPose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouFO 1.14v - MJ studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FRAME_PICTUREBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME_TRACKBAR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DOWN_BTN;
        private System.Windows.Forms.TextBox URL_TEXT;
        private System.Windows.Forms.Label URL_LABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AUTODELETE_CHECK;
        private System.Windows.Forms.PictureBox FRAME_PICTUREBOX;
        private System.Windows.Forms.TrackBar FRAME_TRACKBAR;
        private System.Windows.Forms.Button SETSTART_BTN;
        private System.Windows.Forms.Button SETEND_BTN;
        private System.Windows.Forms.Label FRAMEBAR_LABEL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button FRAMELEFT_BTN;
        private System.Windows.Forms.Button FRAMERIGHT_BTN;
        private System.Windows.Forms.Button SAVEIMAGE_BTN;
        private System.Windows.Forms.TextBox WHATFRAME_TEXT;
        private System.Windows.Forms.Label DOWNSTATE_TEXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LOCALOPEN_BTN;
        private System.Windows.Forms.TextBox VIDEONAME_TEXT;
        private System.Windows.Forms.TextBox FRAMEBOX_TEXT;
        private System.Windows.Forms.Label SAVEVIDEO_LABEL;
        private System.ComponentModel.BackgroundWorker SAVEPROGRESS_BACKGROUNDWORKER;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button OPENPOSEDEMO_BTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox COMBO_OUTPUTFORMAT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button OPENPOSEOUTPUT_BTN;
        private System.Windows.Forms.Button OPENPOSE_BTN;
        private System.Windows.Forms.CheckBox CHECK_NOBLENDING;
        private System.Windows.Forms.CheckBox CHECK_NODISPLAY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox FRAMESAMPLE_LISTBOX;
        private System.Windows.Forms.Button DELETE_BTN;
        private System.Windows.Forms.CheckBox CHECK_ISFRONT;
        private System.Windows.Forms.CheckBox CHECK_ISLEFTSIDE;
        private System.Windows.Forms.TextBox STARTTEXT_TEXT;
        private System.Windows.Forms.TextBox ENDTEXT_TEXT;
        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SAMPLEDVIDEOCOUNTFRONT_LABEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMBO_WHO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LABEL_SOCKETSTATE;
        private System.Windows.Forms.Label LABEL_SUBMITSTATE;
        private System.Windows.Forms.Label SAMPLEDVIDEOCOUNTSIDE_LABEL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LABEL_OPENPOSESTATE;
    }
}

