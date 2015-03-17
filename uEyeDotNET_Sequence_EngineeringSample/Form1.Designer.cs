namespace uEyeDotNET_Sequence_EngineeringSample
{
    partial class uEye_DotNet_Sequence_EngineeringSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayWindow = new System.Windows.Forms.PictureBox();
            this.btn_StartLiveVideo = new System.Windows.Forms.Button();
            this.btn_StopLiveVideo = new System.Windows.Forms.Button();
            this.btn_FreezeVideo = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_SeqID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SequenceCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StopAndReplay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_GetCameraList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayWindow
            // 
            this.DisplayWindow.Location = new System.Drawing.Point(16, 15);
            this.DisplayWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayWindow.Name = "DisplayWindow";
            this.DisplayWindow.Size = new System.Drawing.Size(752, 480);
            this.DisplayWindow.TabIndex = 0;
            this.DisplayWindow.TabStop = false;
            this.DisplayWindow.Click += new System.EventHandler(this.DisplayWindow_Click);
            // 
            // btn_StartLiveVideo
            // 
            this.btn_StartLiveVideo.Location = new System.Drawing.Point(819, 15);
            this.btn_StartLiveVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_StartLiveVideo.Name = "btn_StartLiveVideo";
            this.btn_StartLiveVideo.Size = new System.Drawing.Size(179, 38);
            this.btn_StartLiveVideo.TabIndex = 1;
            this.btn_StartLiveVideo.Text = "Start Live";
            this.btn_StartLiveVideo.UseVisualStyleBackColor = true;
            this.btn_StartLiveVideo.Click += new System.EventHandler(this.btn_StartLiveVideo_Click);
            // 
            // btn_StopLiveVideo
            // 
            this.btn_StopLiveVideo.Location = new System.Drawing.Point(819, 60);
            this.btn_StopLiveVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_StopLiveVideo.Name = "btn_StopLiveVideo";
            this.btn_StopLiveVideo.Size = new System.Drawing.Size(179, 38);
            this.btn_StopLiveVideo.TabIndex = 2;
            this.btn_StopLiveVideo.Text = "Stop Live";
            this.btn_StopLiveVideo.UseVisualStyleBackColor = true;
            this.btn_StopLiveVideo.Click += new System.EventHandler(this.btn_StopLiveVideo_Click);
            // 
            // btn_FreezeVideo
            // 
            this.btn_FreezeVideo.Location = new System.Drawing.Point(819, 106);
            this.btn_FreezeVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FreezeVideo.Name = "btn_FreezeVideo";
            this.btn_FreezeVideo.Size = new System.Drawing.Size(179, 38);
            this.btn_FreezeVideo.TabIndex = 3;
            this.btn_FreezeVideo.Text = "Freeze";
            this.btn_FreezeVideo.UseVisualStyleBackColor = true;
            this.btn_FreezeVideo.Click += new System.EventHandler(this.btn_FreezeVideo_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(819, 422);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(179, 38);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(819, 204);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 28);
            this.progressBar1.TabIndex = 5;
            // 
            // txt_SeqID
            // 
            this.txt_SeqID.Location = new System.Drawing.Point(921, 241);
            this.txt_SeqID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SeqID.Name = "txt_SeqID";
            this.txt_SeqID.Size = new System.Drawing.Size(69, 22);
            this.txt_SeqID.TabIndex = 6;
            this.txt_SeqID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sequence ID";
            // 
            // txt_SequenceCount
            // 
            this.txt_SequenceCount.Location = new System.Drawing.Point(921, 286);
            this.txt_SequenceCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SequenceCount.Name = "txt_SequenceCount";
            this.txt_SequenceCount.Size = new System.Drawing.Size(69, 22);
            this.txt_SequenceCount.TabIndex = 8;
            this.txt_SequenceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seq Count";
            // 
            // btn_StopAndReplay
            // 
            this.btn_StopAndReplay.Location = new System.Drawing.Point(819, 480);
            this.btn_StopAndReplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_StopAndReplay.Name = "btn_StopAndReplay";
            this.btn_StopAndReplay.Size = new System.Drawing.Size(179, 38);
            this.btn_StopAndReplay.TabIndex = 10;
            this.btn_StopAndReplay.Text = "Stop and Replay";
            this.btn_StopAndReplay.UseVisualStyleBackColor = true;
            this.btn_StopAndReplay.Click += new System.EventHandler(this.btn_StopAndReplay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 565);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 80);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(136, 565);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 80);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(256, 565);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 80);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(376, 565);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(112, 80);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(496, 565);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(112, 80);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // btn_GetCameraList
            // 
            this.btn_GetCameraList.Location = new System.Drawing.Point(819, 538);
            this.btn_GetCameraList.Name = "btn_GetCameraList";
            this.btn_GetCameraList.Size = new System.Drawing.Size(179, 38);
            this.btn_GetCameraList.TabIndex = 16;
            this.btn_GetCameraList.Text = "Get Camera List";
            this.btn_GetCameraList.UseVisualStyleBackColor = true;
            this.btn_GetCameraList.Click += new System.EventHandler(this.btn_GetCameraList_Click);
            // 
            // uEye_DotNet_Sequence_EngineeringSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 713);
            this.Controls.Add(this.btn_GetCameraList);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_StopAndReplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SequenceCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SeqID);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_FreezeVideo);
            this.Controls.Add(this.btn_StopLiveVideo);
            this.Controls.Add(this.btn_StartLiveVideo);
            this.Controls.Add(this.DisplayWindow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uEye_DotNet_Sequence_EngineeringSample";
            this.Text = "uEye DotNet C# - Sequence";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayWindow;
        private System.Windows.Forms.Button btn_StartLiveVideo;
        private System.Windows.Forms.Button btn_StopLiveVideo;
        private System.Windows.Forms.Button btn_FreezeVideo;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txt_SeqID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SequenceCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_StopAndReplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_GetCameraList;
    }
}

