namespace ObjectTracking_BackgroundSub
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStopTracking = new System.Windows.Forms.Button();
            this.buttonStartTracking = new System.Windows.Forms.Button();
            this.buttonLoadvideo = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBGSub = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGSub)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1363, 759);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStopTracking);
            this.panel1.Controls.Add(this.buttonStartTracking);
            this.panel1.Controls.Add(this.buttonLoadvideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 37);
            this.panel1.TabIndex = 0;
            // 
            // buttonStopTracking
            // 
            this.buttonStopTracking.Location = new System.Drawing.Point(287, 4);
            this.buttonStopTracking.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStopTracking.Name = "buttonStopTracking";
            this.buttonStopTracking.Size = new System.Drawing.Size(120, 28);
            this.buttonStopTracking.TabIndex = 3;
            this.buttonStopTracking.Text = "Stop tracking";
            this.buttonStopTracking.UseVisualStyleBackColor = true;
            this.buttonStopTracking.Click += new System.EventHandler(this.buttonStopTracking_Click);
            // 
            // buttonStartTracking
            // 
            this.buttonStartTracking.Location = new System.Drawing.Point(159, 4);
            this.buttonStartTracking.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartTracking.Name = "buttonStartTracking";
            this.buttonStartTracking.Size = new System.Drawing.Size(120, 28);
            this.buttonStartTracking.TabIndex = 2;
            this.buttonStartTracking.Text = "Start tracking";
            this.buttonStartTracking.UseVisualStyleBackColor = true;
            this.buttonStartTracking.Click += new System.EventHandler(this.buttonStartTracking_Click);
            // 
            // buttonLoadvideo
            // 
            this.buttonLoadvideo.Location = new System.Drawing.Point(4, 4);
            this.buttonLoadvideo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadvideo.Name = "buttonLoadvideo";
            this.buttonLoadvideo.Size = new System.Drawing.Size(147, 28);
            this.buttonLoadvideo.TabIndex = 0;
            this.buttonLoadvideo.Text = "Load video ...";
            this.buttonLoadvideo.UseVisualStyleBackColor = true;
            this.buttonLoadvideo.Click += new System.EventHandler(this.buttonLoadvideo_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxVideo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxBGSub, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 49);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1355, 706);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBoxVideo
            // 
            this.pictureBoxVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxVideo.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxVideo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxVideo.Name = "pictureBoxVideo";
            this.pictureBoxVideo.Size = new System.Drawing.Size(669, 698);
            this.pictureBoxVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVideo.TabIndex = 0;
            this.pictureBoxVideo.TabStop = false;
            this.pictureBoxVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxVideo_Paint);
            // 
            // pictureBoxBGSub
            // 
            this.pictureBoxBGSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBGSub.Location = new System.Drawing.Point(681, 4);
            this.pictureBoxBGSub.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBGSub.Name = "pictureBoxBGSub";
            this.pictureBoxBGSub.Size = new System.Drawing.Size(670, 698);
            this.pictureBoxBGSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBGSub.TabIndex = 1;
            this.pictureBoxBGSub.TabStop = false;
            this.pictureBoxBGSub.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxVideo_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 759);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Object Tracking - Background Subtraction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBGSub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLoadvideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxVideo;
        private System.Windows.Forms.Button buttonStartTracking;
        private System.Windows.Forms.PictureBox pictureBoxBGSub;
        private System.Windows.Forms.Button buttonStopTracking;
    }
}

