namespace Youtube_Download_Frame_Divide {
    partial class MJStudio {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MJStudio));
            this.DOWN_BTN = new System.Windows.Forms.Button();
            this.URL_TEXT = new System.Windows.Forms.TextBox();
            this.URL_LABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FRAME_PICTUREBOX = new System.Windows.Forms.PictureBox();
            this.FRAME_TRACKBAR = new System.Windows.Forms.TrackBar();
            this.SETSTART_BTN = new System.Windows.Forms.Button();
            this.SETEND_BTN = new System.Windows.Forms.Button();
            this.FRAMEBAR_LABEL = new System.Windows.Forms.Label();
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
            this.STARTTEXT_TEXT = new System.Windows.Forms.TextBox();
            this.ENDTEXT_TEXT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME_PICTUREBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME_TRACKBAR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DOWN_BTN
            // 
            this.DOWN_BTN.Location = new System.Drawing.Point(495, 49);
            this.DOWN_BTN.Margin = new System.Windows.Forms.Padding(5);
            this.DOWN_BTN.Name = "DOWN_BTN";
            this.DOWN_BTN.Size = new System.Drawing.Size(146, 40);
            this.DOWN_BTN.TabIndex = 0;
            this.DOWN_BTN.Text = "DOWNLOAD";
            this.DOWN_BTN.UseVisualStyleBackColor = true;
            this.DOWN_BTN.Click += new System.EventHandler(this.DOWN_BTN_Click);
            // 
            // URL_TEXT
            // 
            this.URL_TEXT.Location = new System.Drawing.Point(187, 51);
            this.URL_TEXT.Margin = new System.Windows.Forms.Padding(5);
            this.URL_TEXT.Name = "URL_TEXT";
            this.URL_TEXT.Size = new System.Drawing.Size(285, 32);
            this.URL_TEXT.TabIndex = 1;
            // 
            // URL_LABEL
            // 
            this.URL_LABEL.AutoSize = true;
            this.URL_LABEL.Location = new System.Drawing.Point(30, 58);
            this.URL_LABEL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.URL_LABEL.Name = "URL_LABEL";
            this.URL_LABEL.Size = new System.Drawing.Size(123, 21);
            this.URL_LABEL.TabIndex = 2;
            this.URL_LABEL.Text = "Youtube URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Divided Frames Count";
            // 
            // FRAME_PICTUREBOX
            // 
            this.FRAME_PICTUREBOX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FRAME_PICTUREBOX.Location = new System.Drawing.Point(49, 112);
            this.FRAME_PICTUREBOX.Margin = new System.Windows.Forms.Padding(5);
            this.FRAME_PICTUREBOX.Name = "FRAME_PICTUREBOX";
            this.FRAME_PICTUREBOX.Size = new System.Drawing.Size(585, 445);
            this.FRAME_PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FRAME_PICTUREBOX.TabIndex = 13;
            this.FRAME_PICTUREBOX.TabStop = false;
            // 
            // FRAME_TRACKBAR
            // 
            this.FRAME_TRACKBAR.Enabled = false;
            this.FRAME_TRACKBAR.Location = new System.Drawing.Point(49, 578);
            this.FRAME_TRACKBAR.Margin = new System.Windows.Forms.Padding(5);
            this.FRAME_TRACKBAR.Maximum = 100;
            this.FRAME_TRACKBAR.Name = "FRAME_TRACKBAR";
            this.FRAME_TRACKBAR.Size = new System.Drawing.Size(588, 80);
            this.FRAME_TRACKBAR.TabIndex = 14;
            this.FRAME_TRACKBAR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FRAME_TRACKBAR_MOUSEUP);
            // 
            // SETSTART_BTN
            // 
            this.SETSTART_BTN.Enabled = false;
            this.SETSTART_BTN.Location = new System.Drawing.Point(55, 712);
            this.SETSTART_BTN.Margin = new System.Windows.Forms.Padding(5);
            this.SETSTART_BTN.Name = "SETSTART_BTN";
            this.SETSTART_BTN.Size = new System.Drawing.Size(134, 40);
            this.SETSTART_BTN.TabIndex = 17;
            this.SETSTART_BTN.Text = "SET START";
            this.SETSTART_BTN.UseVisualStyleBackColor = true;
            this.SETSTART_BTN.Click += new System.EventHandler(this.SETSTARTCLICK);
            // 
            // SETEND_BTN
            // 
            this.SETEND_BTN.Enabled = false;
            this.SETEND_BTN.Location = new System.Drawing.Point(198, 712);
            this.SETEND_BTN.Margin = new System.Windows.Forms.Padding(5);
            this.SETEND_BTN.Name = "SETEND_BTN";
            this.SETEND_BTN.Size = new System.Drawing.Size(134, 40);
            this.SETEND_BTN.TabIndex = 18;
            this.SETEND_BTN.Text = "SET END";
            this.SETEND_BTN.UseVisualStyleBackColor = true;
            this.SETEND_BTN.Click += new System.EventHandler(this.SETENDCLICK);
            // 
            // FRAMEBAR_LABEL
            // 
            this.FRAMEBAR_LABEL.AutoSize = true;
            this.FRAMEBAR_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRAMEBAR_LABEL.Location = new System.Drawing.Point(479, 662);
            this.FRAMEBAR_LABEL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FRAMEBAR_LABEL.Name = "FRAMEBAR_LABEL";
            this.FRAMEBAR_LABEL.Size = new System.Drawing.Size(58, 32);
            this.FRAMEBAR_LABEL.TabIndex = 19;
            this.FRAMEBAR_LABEL.Text = "0/0";
            // 
            // FRAMELEFT_BTN
            // 
            this.FRAMELEFT_BTN.Enabled = false;
            this.FRAMELEFT_BTN.Location = new System.Drawing.Point(55, 662);
            this.FRAMELEFT_BTN.Margin = new System.Windows.Forms.Padding(5);
            this.FRAMELEFT_BTN.Name = "FRAMELEFT_BTN";
            this.FRAMELEFT_BTN.Size = new System.Drawing.Size(39, 37);
            this.FRAMELEFT_BTN.TabIndex = 34;
            this.FRAMELEFT_BTN.Text = "<<";
            this.FRAMELEFT_BTN.UseVisualStyleBackColor = true;
            this.FRAMELEFT_BTN.Click += new System.EventHandler(this.FRAMELEFT_BTN_Click);
            // 
            // FRAMERIGHT_BTN
            // 
            this.FRAMERIGHT_BTN.Enabled = false;
            this.FRAMERIGHT_BTN.Location = new System.Drawing.Point(101, 662);
            this.FRAMERIGHT_BTN.Margin = new System.Windows.Forms.Padding(5);
            this.FRAMERIGHT_BTN.Name = "FRAMERIGHT_BTN";
            this.FRAMERIGHT_BTN.Size = new System.Drawing.Size(39, 37);
            this.FRAMERIGHT_BTN.TabIndex = 35;
            this.FRAMERIGHT_BTN.Text = ">>";
            this.FRAMERIGHT_BTN.UseVisualStyleBackColor = true;
            this.FRAMERIGHT_BTN.Click += new System.EventHandler(this.FRAMERIGHT_BTN_Click);
            // 
            // SAVEIMAGE_BTN
            // 
            this.SAVEIMAGE_BTN.BackColor = System.Drawing.SystemColors.Window;
            this.SAVEIMAGE_BTN.Enabled = false;
            this.SAVEIMAGE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEIMAGE_BTN.Location = new System.Drawing.Point(300, 140);
            this.SAVEIMAGE_BTN.Margin = new System.Windows.Forms.Padding(5);
            this.SAVEIMAGE_BTN.Name = "SAVEIMAGE_BTN";
            this.SAVEIMAGE_BTN.Size = new System.Drawing.Size(320, 90);
            this.SAVEIMAGE_BTN.TabIndex = 38;
            this.SAVEIMAGE_BTN.Text = "SAMPLE";
            this.SAVEIMAGE_BTN.UseVisualStyleBackColor = false;
            this.SAVEIMAGE_BTN.Click += new System.EventHandler(this.SAVEIMAGE_BTN_Click);
            // 
            // WHATFRAME_TEXT
            // 
            this.WHATFRAME_TEXT.Location = new System.Drawing.Point(519, 70);
            this.WHATFRAME_TEXT.Margin = new System.Windows.Forms.Padding(5);
            this.WHATFRAME_TEXT.Name = "WHATFRAME_TEXT";
            this.WHATFRAME_TEXT.Size = new System.Drawing.Size(101, 32);
            this.WHATFRAME_TEXT.TabIndex = 39;
            this.WHATFRAME_TEXT.Text = "30";
            // 
            // DOWNSTATE_TEXT
            // 
            this.DOWNSTATE_TEXT.AutoSize = true;
            this.DOWNSTATE_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOWNSTATE_TEXT.ForeColor = System.Drawing.Color.Blue;
            this.DOWNSTATE_TEXT.Location = new System.Drawing.Point(487, 107);
            this.DOWNSTATE_TEXT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DOWNSTATE_TEXT.Name = "DOWNSTATE_TEXT";
            this.DOWNSTATE_TEXT.Size = new System.Drawing.Size(92, 25);
            this.DOWNSTATE_TEXT.TabIndex = 40;
            this.DOWNSTATE_TEXT.Text = "ready...";
            this.DOWNSTATE_TEXT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Local Video";
            // 
            // LOCALOPEN_BTN
            // 
            this.LOCALOPEN_BTN.Location = new System.Drawing.Point(187, 100);
            this.LOCALOPEN_BTN.Margin = new System.Windows.Forms.Padding(5);
            this.LOCALOPEN_BTN.Name = "LOCALOPEN_BTN";
            this.LOCALOPEN_BTN.Size = new System.Drawing.Size(47, 40);
            this.LOCALOPEN_BTN.TabIndex = 42;
            this.LOCALOPEN_BTN.Text = "...";
            this.LOCALOPEN_BTN.UseVisualStyleBackColor = true;
            this.LOCALOPEN_BTN.Click += new System.EventHandler(this.LOCALOPEN_BTN_Click);
            // 
            // VIDEONAME_TEXT
            // 
            this.VIDEONAME_TEXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VIDEONAME_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VIDEONAME_TEXT.Location = new System.Drawing.Point(49, 54);
            this.VIDEONAME_TEXT.Margin = new System.Windows.Forms.Padding(5);
            this.VIDEONAME_TEXT.Name = "VIDEONAME_TEXT";
            this.VIDEONAME_TEXT.ReadOnly = true;
            this.VIDEONAME_TEXT.Size = new System.Drawing.Size(585, 31);
            this.VIDEONAME_TEXT.TabIndex = 43;
            this.VIDEONAME_TEXT.Text = "Video Path None";
            this.VIDEONAME_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRAMEBOX_TEXT
            // 
            this.FRAMEBOX_TEXT.Enabled = false;
            this.FRAMEBOX_TEXT.Location = new System.Drawing.Point(168, 662);
            this.FRAMEBOX_TEXT.Margin = new System.Windows.Forms.Padding(5);
            this.FRAMEBOX_TEXT.Name = "FRAMEBOX_TEXT";
            this.FRAMEBOX_TEXT.Size = new System.Drawing.Size(112, 32);
            this.FRAMEBOX_TEXT.TabIndex = 44;
            this.FRAMEBOX_TEXT.Text = "0";
            this.FRAMEBOX_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FRAMEBOX_TEXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SETFRAMEKEYDOWN);
            // 
            // SAVEVIDEO_LABEL
            // 
            this.SAVEVIDEO_LABEL.AutoSize = true;
            this.SAVEVIDEO_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVEVIDEO_LABEL.ForeColor = System.Drawing.Color.Blue;
            this.SAVEVIDEO_LABEL.Location = new System.Drawing.Point(249, 275);
            this.SAVEVIDEO_LABEL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SAVEVIDEO_LABEL.Name = "SAVEVIDEO_LABEL";
            this.SAVEVIDEO_LABEL.Size = new System.Drawing.Size(92, 25);
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
            this.groupBox1.Location = new System.Drawing.Point(46, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(668, 156);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Download or Load Video";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 40);
            this.button1.TabIndex = 43;
            this.button1.Text = "OPEN RESULT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SAVEIMAGE_BTN);
            this.groupBox3.Controls.Add(this.SAVEVIDEO_LABEL);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.WHATFRAME_TEXT);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(46, 205);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(668, 349);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Sample Video";
            // 
            // STARTTEXT_TEXT
            // 
            this.STARTTEXT_TEXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.STARTTEXT_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STARTTEXT_TEXT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.STARTTEXT_TEXT.Location = new System.Drawing.Point(55, 763);
            this.STARTTEXT_TEXT.Margin = new System.Windows.Forms.Padding(5);
            this.STARTTEXT_TEXT.Name = "STARTTEXT_TEXT";
            this.STARTTEXT_TEXT.ReadOnly = true;
            this.STARTTEXT_TEXT.Size = new System.Drawing.Size(131, 31);
            this.STARTTEXT_TEXT.TabIndex = 48;
            this.STARTTEXT_TEXT.Text = "0";
            this.STARTTEXT_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ENDTEXT_TEXT
            // 
            this.ENDTEXT_TEXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ENDTEXT_TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDTEXT_TEXT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ENDTEXT_TEXT.Location = new System.Drawing.Point(198, 763);
            this.ENDTEXT_TEXT.Margin = new System.Windows.Forms.Padding(5);
            this.ENDTEXT_TEXT.Name = "ENDTEXT_TEXT";
            this.ENDTEXT_TEXT.ReadOnly = true;
            this.ENDTEXT_TEXT.Size = new System.Drawing.Size(131, 31);
            this.ENDTEXT_TEXT.TabIndex = 52;
            this.ENDTEXT_TEXT.Text = "0";
            this.ENDTEXT_TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VIDEONAME_TEXT);
            this.groupBox2.Controls.Add(this.FRAME_PICTUREBOX);
            this.groupBox2.Controls.Add(this.FRAME_TRACKBAR);
            this.groupBox2.Controls.Add(this.SETSTART_BTN);
            this.groupBox2.Controls.Add(this.ENDTEXT_TEXT);
            this.groupBox2.Controls.Add(this.SETEND_BTN);
            this.groupBox2.Controls.Add(this.STARTTEXT_TEXT);
            this.groupBox2.Controls.Add(this.FRAMEBAR_LABEL);
            this.groupBox2.Controls.Add(this.FRAMELEFT_BTN);
            this.groupBox2.Controls.Add(this.FRAMERIGHT_BTN);
            this.groupBox2.Controls.Add(this.FRAMEBOX_TEXT);
            this.groupBox2.Location = new System.Drawing.Point(735, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(683, 830);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Controller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 846);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "MJ Studio 2018";
            // 
            // MJStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1441, 895);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MJStudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Download & Frame Divide v1.0.0 - MJ Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FRAME_PICTUREBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME_TRACKBAR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.PictureBox FRAME_PICTUREBOX;
        private System.Windows.Forms.TrackBar FRAME_TRACKBAR;
        private System.Windows.Forms.Button SETSTART_BTN;
        private System.Windows.Forms.Button SETEND_BTN;
        private System.Windows.Forms.Label FRAMEBAR_LABEL;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox STARTTEXT_TEXT;
        private System.Windows.Forms.TextBox ENDTEXT_TEXT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}

