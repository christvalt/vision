namespace ObjectTracking_MeanShift
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
            this.buttonSelectTarget = new System.Windows.Forms.Button();
            this.buttonLoadvideo = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxFirstFrame = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackProj = new System.Windows.Forms.PictureBox();
            this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownMaxValidH = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinValidH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownMaxValidS = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMinValidS = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMinValidV = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxValidV = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxRoi = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoiMasked = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoiHist = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValidH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValidH)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValidS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValidS)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValidV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValidV)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoiMasked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoiHist)).BeginInit();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1312, 826);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStopTracking);
            this.panel1.Controls.Add(this.buttonStartTracking);
            this.panel1.Controls.Add(this.buttonSelectTarget);
            this.panel1.Controls.Add(this.buttonLoadvideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 31);
            this.panel1.TabIndex = 0;
            // 
            // buttonStopTracking
            // 
            this.buttonStopTracking.Location = new System.Drawing.Point(296, 3);
            this.buttonStopTracking.Name = "buttonStopTracking";
            this.buttonStopTracking.Size = new System.Drawing.Size(90, 23);
            this.buttonStopTracking.TabIndex = 3;
            this.buttonStopTracking.Text = "Stop tracking";
            this.buttonStopTracking.UseVisualStyleBackColor = true;
            this.buttonStopTracking.Click += new System.EventHandler(this.buttonStopTracking_Click);
            // 
            // buttonStartTracking
            // 
            this.buttonStartTracking.Location = new System.Drawing.Point(200, 3);
            this.buttonStartTracking.Name = "buttonStartTracking";
            this.buttonStartTracking.Size = new System.Drawing.Size(90, 23);
            this.buttonStartTracking.TabIndex = 2;
            this.buttonStartTracking.Text = "Start tracking";
            this.buttonStartTracking.UseVisualStyleBackColor = true;
            this.buttonStartTracking.Click += new System.EventHandler(this.buttonStartTracking_Click);
            // 
            // buttonSelectTarget
            // 
            this.buttonSelectTarget.Location = new System.Drawing.Point(119, 3);
            this.buttonSelectTarget.Name = "buttonSelectTarget";
            this.buttonSelectTarget.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectTarget.TabIndex = 1;
            this.buttonSelectTarget.Text = "Select target";
            this.buttonSelectTarget.UseVisualStyleBackColor = true;
            this.buttonSelectTarget.Click += new System.EventHandler(this.buttonSelectTarget_Click);
            // 
            // buttonLoadvideo
            // 
            this.buttonLoadvideo.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadvideo.Name = "buttonLoadvideo";
            this.buttonLoadvideo.Size = new System.Drawing.Size(110, 23);
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
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxFirstFrame, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxBackProj, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxVideo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1306, 783);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBoxFirstFrame
            // 
            this.pictureBoxFirstFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFirstFrame.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxFirstFrame.Name = "pictureBoxFirstFrame";
            this.pictureBoxFirstFrame.Size = new System.Drawing.Size(647, 385);
            this.pictureBoxFirstFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFirstFrame.TabIndex = 0;
            this.pictureBoxFirstFrame.TabStop = false;
            this.pictureBoxFirstFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxFirstFrame_Paint);
            this.pictureBoxFirstFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFirstFrame_MouseDown);
            this.pictureBoxFirstFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFirstFrame_MouseMove);
            this.pictureBoxFirstFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFirstFrame_MouseUp);
            // 
            // pictureBoxBackProj
            // 
            this.pictureBoxBackProj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackProj.Location = new System.Drawing.Point(655, 393);
            this.pictureBoxBackProj.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBackProj.Name = "pictureBoxBackProj";
            this.pictureBoxBackProj.Size = new System.Drawing.Size(649, 388);
            this.pictureBoxBackProj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackProj.TabIndex = 2;
            this.pictureBoxBackProj.TabStop = false;
            this.pictureBoxBackProj.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBackProj_Paint);
            // 
            // pictureBoxVideo
            // 
            this.pictureBoxVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxVideo.Location = new System.Drawing.Point(656, 3);
            this.pictureBoxVideo.Name = "pictureBoxVideo";
            this.pictureBoxVideo.Size = new System.Drawing.Size(647, 385);
            this.pictureBoxVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVideo.TabIndex = 1;
            this.pictureBoxVideo.TabStop = false;
            this.pictureBoxVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxVideo_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 394);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(647, 386);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(641, 44);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownMaxValidH);
            this.panel2.Controls.Add(this.numericUpDownMinValidH);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 38);
            this.panel2.TabIndex = 0;
            // 
            // numericUpDownMaxValidH
            // 
            this.numericUpDownMaxValidH.Location = new System.Drawing.Point(124, 3);
            this.numericUpDownMaxValidH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMaxValidH.Name = "numericUpDownMaxValidH";
            this.numericUpDownMaxValidH.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMaxValidH.TabIndex = 1;
            this.numericUpDownMaxValidH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMaxValidH.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMaxValidH.ValueChanged += new System.EventHandler(this.numericUpDownMinHsvRange_ValueChanged);
            // 
            // numericUpDownMinValidH
            // 
            this.numericUpDownMinValidH.Location = new System.Drawing.Point(50, 3);
            this.numericUpDownMinValidH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMinValidH.Name = "numericUpDownMinValidH";
            this.numericUpDownMinValidH.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMinValidH.TabIndex = 1;
            this.numericUpDownMinValidH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMinValidH.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownMinValidH.ValueChanged += new System.EventHandler(this.numericUpDownMinHsvRange_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "H from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDownMaxValidS);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numericUpDownMinValidS);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(216, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 38);
            this.panel3.TabIndex = 1;
            // 
            // numericUpDownMaxValidS
            // 
            this.numericUpDownMaxValidS.Location = new System.Drawing.Point(124, 3);
            this.numericUpDownMaxValidS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMaxValidS.Name = "numericUpDownMaxValidS";
            this.numericUpDownMaxValidS.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMaxValidS.TabIndex = 4;
            this.numericUpDownMaxValidS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMaxValidS.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMaxValidS.ValueChanged += new System.EventHandler(this.numericUpDownMinHsvRange_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "to:";
            // 
            // numericUpDownMinValidS
            // 
            this.numericUpDownMinValidS.Location = new System.Drawing.Point(50, 3);
            this.numericUpDownMinValidS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMinValidS.Name = "numericUpDownMinValidS";
            this.numericUpDownMinValidS.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMinValidS.TabIndex = 5;
            this.numericUpDownMinValidS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMinValidS.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMinValidS.ValueChanged += new System.EventHandler(this.numericUpDownMinHsvRange_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "S from:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.numericUpDownMinValidV);
            this.panel4.Controls.Add(this.numericUpDownMaxValidV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(429, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 38);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "to:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "V from:";
            // 
            // numericUpDownMinValidV
            // 
            this.numericUpDownMinValidV.Location = new System.Drawing.Point(50, 3);
            this.numericUpDownMinValidV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMinValidV.Name = "numericUpDownMinValidV";
            this.numericUpDownMinValidV.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMinValidV.TabIndex = 5;
            this.numericUpDownMinValidV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMinValidV.ValueChanged += new System.EventHandler(this.numericUpDownMinHsvRange_ValueChanged);
            // 
            // numericUpDownMaxValidV
            // 
            this.numericUpDownMaxValidV.Location = new System.Drawing.Point(124, 3);
            this.numericUpDownMaxValidV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMaxValidV.Name = "numericUpDownMaxValidV";
            this.numericUpDownMaxValidV.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMaxValidV.TabIndex = 4;
            this.numericUpDownMaxValidV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMaxValidV.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownMaxValidV.ValueChanged += new System.EventHandler(this.numericUpDownMinHsvRange_ValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxRoi, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxRoiMasked, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxRoiHist, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 52);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(643, 332);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // pictureBoxRoi
            // 
            this.pictureBoxRoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRoi.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxRoi.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRoi.Name = "pictureBoxRoi";
            this.pictureBoxRoi.Size = new System.Drawing.Size(208, 328);
            this.pictureBoxRoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoi.TabIndex = 0;
            this.pictureBoxRoi.TabStop = false;
            // 
            // pictureBoxRoiMasked
            // 
            this.pictureBoxRoiMasked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRoiMasked.Location = new System.Drawing.Point(214, 2);
            this.pictureBoxRoiMasked.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRoiMasked.Name = "pictureBoxRoiMasked";
            this.pictureBoxRoiMasked.Size = new System.Drawing.Size(208, 328);
            this.pictureBoxRoiMasked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoiMasked.TabIndex = 1;
            this.pictureBoxRoiMasked.TabStop = false;
            // 
            // pictureBoxRoiHist
            // 
            this.pictureBoxRoiHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRoiHist.Location = new System.Drawing.Point(427, 3);
            this.pictureBoxRoiHist.Name = "pictureBoxRoiHist";
            this.pictureBoxRoiHist.Size = new System.Drawing.Size(213, 326);
            this.pictureBoxRoiHist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoiHist.TabIndex = 2;
            this.pictureBoxRoiHist.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 826);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Object Tracking - Mean shift";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValidH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValidH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValidS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValidS)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValidV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValidV)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoiMasked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoiHist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLoadvideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxFirstFrame;
        private System.Windows.Forms.Button buttonSelectTarget;
        private System.Windows.Forms.Button buttonStartTracking;
        private System.Windows.Forms.PictureBox pictureBoxVideo;
        private System.Windows.Forms.Button buttonStopTracking;
        private System.Windows.Forms.PictureBox pictureBoxBackProj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBoxRoi;
        private System.Windows.Forms.PictureBox pictureBoxRoiMasked;
        private System.Windows.Forms.PictureBox pictureBoxRoiHist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxValidH;
        private System.Windows.Forms.NumericUpDown numericUpDownMinValidH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxValidS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMinValidS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMinValidV;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxValidV;
    }
}

