namespace ImageProcessingTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.save_Btn = new System.Windows.Forms.Button();
            this.openFile_Btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grayBtn = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Photo_WH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gaussianY = new System.Windows.Forms.TextBox();
            this.gaussianX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gaussianBtn = new System.Windows.Forms.Button();
            this.meanFilterY = new System.Windows.Forms.TextBox();
            this.meanFilterX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.meanFilterBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cannythreshold1 = new System.Windows.Forms.TrackBar();
            this.cannyThreshold1Lbl = new System.Windows.Forms.Label();
            this.cannyThreshold2Lbl = new System.Windows.Forms.Label();
            this.Cannythreshold2 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.cannyApertureSize = new System.Windows.Forms.TextBox();
            this.cannyBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sobelKsize = new System.Windows.Forms.TextBox();
            this.sobelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.laplacianKsize = new System.Windows.Forms.TextBox();
            this.laplacianBtn = new System.Windows.Forms.Button();
            this.thresholdBtn = new System.Windows.Forms.Button();
            this.thresholdThresh = new System.Windows.Forms.TextBox();
            this.hsvBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hsvLowVLbl = new System.Windows.Forms.Label();
            this.hsvHighVLbl = new System.Windows.Forms.Label();
            this.hsvLowV = new System.Windows.Forms.TrackBar();
            this.hsvHighV = new System.Windows.Forms.TrackBar();
            this.hsvLowSLbl = new System.Windows.Forms.Label();
            this.hsvHighSLbl = new System.Windows.Forms.Label();
            this.hsvLowS = new System.Windows.Forms.TrackBar();
            this.hsvHighS = new System.Windows.Forms.TrackBar();
            this.hsvLowHLbl = new System.Windows.Forms.Label();
            this.hsvHighHLbl = new System.Windows.Forms.Label();
            this.hsvLowH = new System.Windows.Forms.TrackBar();
            this.hsvHighH = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.erosionIteration = new System.Windows.Forms.TextBox();
            this.erosionSizeH = new System.Windows.Forms.TextBox();
            this.erosionSizeW = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ErosionBtn = new System.Windows.Forms.Button();
            this.dilationIteration = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dilationSizeH = new System.Windows.Forms.TextBox();
            this.dilationSizeW = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dilationBtn = new System.Windows.Forms.Button();
            this.closeIteration = new System.Windows.Forms.TextBox();
            this.openIteration = new System.Windows.Forms.TextBox();
            this.hmBtn = new System.Windows.Forms.Button();
            this.thinningBtn = new System.Windows.Forms.Button();
            this.prunBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.skltMorphShape = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.skeletonizationBtn = new System.Windows.Forms.Button();
            this.skltSizeH = new System.Windows.Forms.TextBox();
            this.closeSizeH = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.skltSizeW = new System.Windows.Forms.TextBox();
            this.closeSizeW = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.openSizeH = new System.Windows.Forms.TextBox();
            this.openSizeW = new System.Windows.Forms.TextBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gammaValue = new System.Windows.Forms.TextBox();
            this.gammaBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.equalizeHistBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.editImgBtn = new System.Windows.Forms.Button();
            this.selectImgBtn = new System.Windows.Forms.Button();
            this.otsuBtn = new System.Windows.Forms.Button();
            this.otsuLbl = new System.Windows.Forms.Label();
            this.connectedBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.connectedArea = new System.Windows.Forms.TextBox();
            this.cropImgBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cannythreshold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cannythreshold2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hsvLowV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvHighV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvLowS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvHighS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvLowH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvHighH)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_Btn
            // 
            this.save_Btn.Location = new System.Drawing.Point(121, 12);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.Size = new System.Drawing.Size(96, 20);
            this.save_Btn.TabIndex = 70;
            this.save_Btn.Text = "Save";
            this.save_Btn.UseVisualStyleBackColor = true;
            this.save_Btn.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFile_Btn
            // 
            this.openFile_Btn.Location = new System.Drawing.Point(15, 12);
            this.openFile_Btn.Name = "openFile_Btn";
            this.openFile_Btn.Size = new System.Drawing.Size(96, 20);
            this.openFile_Btn.TabIndex = 69;
            this.openFile_Btn.Text = "Open File";
            this.openFile_Btn.UseVisualStyleBackColor = true;
            this.openFile_Btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grayBtn
            // 
            this.grayBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grayBtn.Location = new System.Drawing.Point(982, 12);
            this.grayBtn.Name = "grayBtn";
            this.grayBtn.Size = new System.Drawing.Size(101, 25);
            this.grayBtn.TabIndex = 20;
            this.grayBtn.Text = "Gray Scale";
            this.grayBtn.UseVisualStyleBackColor = true;
            this.grayBtn.Click += new System.EventHandler(this.grayBtn_Click);
            // 
            // Undo
            // 
            this.Undo.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Undo.Location = new System.Drawing.Point(777, 11);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(93, 45);
            this.Undo.TabIndex = 54;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Photo_WH
            // 
            this.Photo_WH.AutoSize = true;
            this.Photo_WH.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Photo_WH.Location = new System.Drawing.Point(403, 39);
            this.Photo_WH.Name = "Photo_WH";
            this.Photo_WH.Size = new System.Drawing.Size(36, 19);
            this.Photo_WH.TabIndex = 48;
            this.Photo_WH.Text = "0x0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(495, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Result Image";
            // 
            // resultImg
            // 
            this.resultImg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultImg.Location = new System.Drawing.Point(499, 64);
            this.resultImg.Name = "resultImg";
            this.resultImg.Size = new System.Drawing.Size(470, 440);
            this.resultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultImg.TabIndex = 46;
            this.resultImg.TabStop = false;
            this.resultImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resultImg_MouseDown);
            this.resultImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resultImg_MouseMove);
            this.resultImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resultImg_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Original Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(14, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gaussianY);
            this.groupBox1.Controls.Add(this.gaussianX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gaussianBtn);
            this.groupBox1.Controls.Add(this.meanFilterY);
            this.groupBox1.Controls.Add(this.meanFilterX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.meanFilterBtn);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(982, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 93);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blur";
            // 
            // gaussianY
            // 
            this.gaussianY.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gaussianY.Location = new System.Drawing.Point(82, 54);
            this.gaussianY.Name = "gaussianY";
            this.gaussianY.Size = new System.Drawing.Size(40, 25);
            this.gaussianY.TabIndex = 79;
            this.gaussianY.Text = "3";
            // 
            // gaussianX
            // 
            this.gaussianX.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gaussianX.Location = new System.Drawing.Point(21, 54);
            this.gaussianX.Name = "gaussianX";
            this.gaussianX.Size = new System.Drawing.Size(40, 25);
            this.gaussianX.TabIndex = 78;
            this.gaussianX.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(63, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "x";
            // 
            // gaussianBtn
            // 
            this.gaussianBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gaussianBtn.Location = new System.Drawing.Point(133, 56);
            this.gaussianBtn.Name = "gaussianBtn";
            this.gaussianBtn.Size = new System.Drawing.Size(160, 23);
            this.gaussianBtn.TabIndex = 77;
            this.gaussianBtn.Text = "Gaussian";
            this.gaussianBtn.UseVisualStyleBackColor = true;
            this.gaussianBtn.Click += new System.EventHandler(this.gaussianBtn_Click);
            // 
            // meanFilterY
            // 
            this.meanFilterY.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.meanFilterY.Location = new System.Drawing.Point(82, 26);
            this.meanFilterY.Name = "meanFilterY";
            this.meanFilterY.Size = new System.Drawing.Size(40, 25);
            this.meanFilterY.TabIndex = 75;
            this.meanFilterY.Text = "3";
            // 
            // meanFilterX
            // 
            this.meanFilterX.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.meanFilterX.Location = new System.Drawing.Point(21, 26);
            this.meanFilterX.Name = "meanFilterX";
            this.meanFilterX.Size = new System.Drawing.Size(40, 25);
            this.meanFilterX.TabIndex = 74;
            this.meanFilterX.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(63, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "x";
            // 
            // meanFilterBtn
            // 
            this.meanFilterBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.meanFilterBtn.Location = new System.Drawing.Point(133, 28);
            this.meanFilterBtn.Name = "meanFilterBtn";
            this.meanFilterBtn.Size = new System.Drawing.Size(160, 23);
            this.meanFilterBtn.TabIndex = 73;
            this.meanFilterBtn.Text = "Mean Filter";
            this.meanFilterBtn.UseVisualStyleBackColor = true;
            this.meanFilterBtn.Click += new System.EventHandler(this.meanFilterBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cannythreshold1);
            this.groupBox2.Controls.Add(this.cannyThreshold1Lbl);
            this.groupBox2.Controls.Add(this.cannyThreshold2Lbl);
            this.groupBox2.Controls.Add(this.Cannythreshold2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cannyApertureSize);
            this.groupBox2.Controls.Add(this.cannyBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sobelKsize);
            this.groupBox2.Controls.Add(this.sobelBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.laplacianKsize);
            this.groupBox2.Controls.Add(this.laplacianBtn);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(982, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 211);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edge Detection";
            // 
            // Cannythreshold1
            // 
            this.Cannythreshold1.Enabled = false;
            this.Cannythreshold1.Location = new System.Drawing.Point(67, 161);
            this.Cannythreshold1.Maximum = 255;
            this.Cannythreshold1.Name = "Cannythreshold1";
            this.Cannythreshold1.Size = new System.Drawing.Size(232, 45);
            this.Cannythreshold1.SmallChange = 5;
            this.Cannythreshold1.TabIndex = 87;
            this.Cannythreshold1.Value = 50;
            this.Cannythreshold1.Scroll += new System.EventHandler(this.cannyThresholdScroll);
            // 
            // cannyThreshold1Lbl
            // 
            this.cannyThreshold1Lbl.AutoSize = true;
            this.cannyThreshold1Lbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cannyThreshold1Lbl.Location = new System.Drawing.Point(8, 161);
            this.cannyThreshold1Lbl.Name = "cannyThreshold1Lbl";
            this.cannyThreshold1Lbl.Size = new System.Drawing.Size(57, 16);
            this.cannyThreshold1Lbl.TabIndex = 90;
            this.cannyThreshold1Lbl.Text = "T1：50";
            // 
            // cannyThreshold2Lbl
            // 
            this.cannyThreshold2Lbl.AutoSize = true;
            this.cannyThreshold2Lbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cannyThreshold2Lbl.Location = new System.Drawing.Point(7, 133);
            this.cannyThreshold2Lbl.Name = "cannyThreshold2Lbl";
            this.cannyThreshold2Lbl.Size = new System.Drawing.Size(65, 16);
            this.cannyThreshold2Lbl.TabIndex = 89;
            this.cannyThreshold2Lbl.Text = "T2：150";
            // 
            // Cannythreshold2
            // 
            this.Cannythreshold2.Enabled = false;
            this.Cannythreshold2.Location = new System.Drawing.Point(67, 124);
            this.Cannythreshold2.Maximum = 255;
            this.Cannythreshold2.Name = "Cannythreshold2";
            this.Cannythreshold2.Size = new System.Drawing.Size(232, 45);
            this.Cannythreshold2.SmallChange = 5;
            this.Cannythreshold2.TabIndex = 88;
            this.Cannythreshold2.Value = 150;
            this.Cannythreshold2.Scroll += new System.EventHandler(this.cannyThresholdScroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 85;
            this.label7.Text = "apertureSize";
            // 
            // cannyApertureSize
            // 
            this.cannyApertureSize.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cannyApertureSize.Location = new System.Drawing.Point(109, 98);
            this.cannyApertureSize.Name = "cannyApertureSize";
            this.cannyApertureSize.Size = new System.Drawing.Size(58, 25);
            this.cannyApertureSize.TabIndex = 86;
            this.cannyApertureSize.Text = "3";
            // 
            // cannyBtn
            // 
            this.cannyBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cannyBtn.Location = new System.Drawing.Point(175, 97);
            this.cannyBtn.Name = "cannyBtn";
            this.cannyBtn.Size = new System.Drawing.Size(118, 26);
            this.cannyBtn.TabIndex = 84;
            this.cannyBtn.Text = "Canny（off）";
            this.cannyBtn.UseVisualStyleBackColor = true;
            this.cannyBtn.Click += new System.EventHandler(this.cannyBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(17, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 82;
            this.label6.Text = "ksize";
            // 
            // sobelKsize
            // 
            this.sobelKsize.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sobelKsize.Location = new System.Drawing.Point(67, 58);
            this.sobelKsize.Name = "sobelKsize";
            this.sobelKsize.Size = new System.Drawing.Size(51, 25);
            this.sobelKsize.TabIndex = 83;
            this.sobelKsize.Text = "3";
            // 
            // sobelBtn
            // 
            this.sobelBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sobelBtn.Location = new System.Drawing.Point(133, 58);
            this.sobelBtn.Name = "sobelBtn";
            this.sobelBtn.Size = new System.Drawing.Size(160, 26);
            this.sobelBtn.TabIndex = 81;
            this.sobelBtn.Text = "Sobel";
            this.sobelBtn.UseVisualStyleBackColor = true;
            this.sobelBtn.Click += new System.EventHandler(this.sobelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = "ksize";
            // 
            // laplacianKsize
            // 
            this.laplacianKsize.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.laplacianKsize.Location = new System.Drawing.Point(67, 26);
            this.laplacianKsize.Name = "laplacianKsize";
            this.laplacianKsize.Size = new System.Drawing.Size(51, 25);
            this.laplacianKsize.TabIndex = 80;
            this.laplacianKsize.Text = "3";
            // 
            // laplacianBtn
            // 
            this.laplacianBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.laplacianBtn.Location = new System.Drawing.Point(133, 26);
            this.laplacianBtn.Name = "laplacianBtn";
            this.laplacianBtn.Size = new System.Drawing.Size(160, 27);
            this.laplacianBtn.TabIndex = 73;
            this.laplacianBtn.Text = "Laplacian";
            this.laplacianBtn.UseVisualStyleBackColor = true;
            this.laplacianBtn.Click += new System.EventHandler(this.laplacianBtn_Click);
            // 
            // thresholdBtn
            // 
            this.thresholdBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.thresholdBtn.Location = new System.Drawing.Point(1177, 12);
            this.thresholdBtn.Name = "thresholdBtn";
            this.thresholdBtn.Size = new System.Drawing.Size(117, 25);
            this.thresholdBtn.TabIndex = 73;
            this.thresholdBtn.Text = "Threshold　  ";
            this.thresholdBtn.UseVisualStyleBackColor = true;
            this.thresholdBtn.Click += new System.EventHandler(this.thresholdBtn_Click);
            // 
            // thresholdThresh
            // 
            this.thresholdThresh.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.thresholdThresh.Location = new System.Drawing.Point(1263, 13);
            this.thresholdThresh.Name = "thresholdThresh";
            this.thresholdThresh.Size = new System.Drawing.Size(31, 23);
            this.thresholdThresh.TabIndex = 74;
            this.thresholdThresh.Text = "125";
            // 
            // hsvBtn
            // 
            this.hsvBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hsvBtn.Location = new System.Drawing.Point(96, 0);
            this.hsvBtn.Name = "hsvBtn";
            this.hsvBtn.Size = new System.Drawing.Size(118, 29);
            this.hsvBtn.TabIndex = 75;
            this.hsvBtn.Text = "HSV（off）";
            this.hsvBtn.UseVisualStyleBackColor = true;
            this.hsvBtn.Click += new System.EventHandler(this.hsvBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hsvLowVLbl);
            this.groupBox3.Controls.Add(this.hsvHighVLbl);
            this.groupBox3.Controls.Add(this.hsvLowV);
            this.groupBox3.Controls.Add(this.hsvHighV);
            this.groupBox3.Controls.Add(this.hsvLowSLbl);
            this.groupBox3.Controls.Add(this.hsvHighSLbl);
            this.groupBox3.Controls.Add(this.hsvLowS);
            this.groupBox3.Controls.Add(this.hsvHighS);
            this.groupBox3.Controls.Add(this.hsvBtn);
            this.groupBox3.Controls.Add(this.hsvLowHLbl);
            this.groupBox3.Controls.Add(this.hsvHighHLbl);
            this.groupBox3.Controls.Add(this.hsvLowH);
            this.groupBox3.Controls.Add(this.hsvHighH);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(14, 510);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 167);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HSV Filter";
            // 
            // hsvLowVLbl
            // 
            this.hsvLowVLbl.AutoSize = true;
            this.hsvLowVLbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hsvLowVLbl.Location = new System.Drawing.Point(440, 92);
            this.hsvLowVLbl.Name = "hsvLowVLbl";
            this.hsvLowVLbl.Size = new System.Drawing.Size(66, 16);
            this.hsvLowVLbl.TabIndex = 99;
            this.hsvLowVLbl.Text = "lowV：0";
            // 
            // hsvHighVLbl
            // 
            this.hsvHighVLbl.AutoSize = true;
            this.hsvHighVLbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hsvHighVLbl.Location = new System.Drawing.Point(440, 31);
            this.hsvHighVLbl.Name = "hsvHighVLbl";
            this.hsvHighVLbl.Size = new System.Drawing.Size(87, 16);
            this.hsvHighVLbl.TabIndex = 97;
            this.hsvHighVLbl.Text = "highV：255";
            // 
            // hsvLowV
            // 
            this.hsvLowV.Enabled = false;
            this.hsvLowV.Location = new System.Drawing.Point(433, 111);
            this.hsvLowV.Maximum = 255;
            this.hsvLowV.Name = "hsvLowV";
            this.hsvLowV.Size = new System.Drawing.Size(220, 45);
            this.hsvLowV.SmallChange = 5;
            this.hsvLowV.TabIndex = 98;
            this.hsvLowV.Scroll += new System.EventHandler(this.hsvThresholdScroll);
            // 
            // hsvHighV
            // 
            this.hsvHighV.Enabled = false;
            this.hsvHighV.Location = new System.Drawing.Point(433, 50);
            this.hsvHighV.Maximum = 255;
            this.hsvHighV.Name = "hsvHighV";
            this.hsvHighV.Size = new System.Drawing.Size(220, 45);
            this.hsvHighV.SmallChange = 5;
            this.hsvHighV.TabIndex = 96;
            this.hsvHighV.Value = 255;
            this.hsvHighV.Scroll += new System.EventHandler(this.hsvThresholdScroll);
            // 
            // hsvLowSLbl
            // 
            this.hsvLowSLbl.AutoSize = true;
            this.hsvLowSLbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hsvLowSLbl.Location = new System.Drawing.Point(222, 92);
            this.hsvLowSLbl.Name = "hsvLowSLbl";
            this.hsvLowSLbl.Size = new System.Drawing.Size(63, 16);
            this.hsvLowSLbl.TabIndex = 95;
            this.hsvLowSLbl.Text = "lowS：0";
            // 
            // hsvHighSLbl
            // 
            this.hsvHighSLbl.AutoSize = true;
            this.hsvHighSLbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hsvHighSLbl.Location = new System.Drawing.Point(222, 31);
            this.hsvHighSLbl.Name = "hsvHighSLbl";
            this.hsvHighSLbl.Size = new System.Drawing.Size(84, 16);
            this.hsvHighSLbl.TabIndex = 93;
            this.hsvHighSLbl.Text = "highS：255";
            // 
            // hsvLowS
            // 
            this.hsvLowS.Enabled = false;
            this.hsvLowS.Location = new System.Drawing.Point(215, 111);
            this.hsvLowS.Maximum = 255;
            this.hsvLowS.Name = "hsvLowS";
            this.hsvLowS.Size = new System.Drawing.Size(220, 45);
            this.hsvLowS.SmallChange = 5;
            this.hsvLowS.TabIndex = 94;
            this.hsvLowS.Scroll += new System.EventHandler(this.hsvThresholdScroll);
            // 
            // hsvHighS
            // 
            this.hsvHighS.Enabled = false;
            this.hsvHighS.Location = new System.Drawing.Point(215, 50);
            this.hsvHighS.Maximum = 255;
            this.hsvHighS.Name = "hsvHighS";
            this.hsvHighS.Size = new System.Drawing.Size(220, 45);
            this.hsvHighS.SmallChange = 5;
            this.hsvHighS.TabIndex = 92;
            this.hsvHighS.Value = 255;
            this.hsvHighS.Scroll += new System.EventHandler(this.hsvThresholdScroll);
            // 
            // hsvLowHLbl
            // 
            this.hsvLowHLbl.AutoSize = true;
            this.hsvLowHLbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hsvLowHLbl.Location = new System.Drawing.Point(11, 92);
            this.hsvLowHLbl.Name = "hsvLowHLbl";
            this.hsvLowHLbl.Size = new System.Drawing.Size(66, 16);
            this.hsvLowHLbl.TabIndex = 91;
            this.hsvLowHLbl.Text = "lowH：0";
            // 
            // hsvHighHLbl
            // 
            this.hsvHighHLbl.AutoSize = true;
            this.hsvHighHLbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hsvHighHLbl.Location = new System.Drawing.Point(11, 31);
            this.hsvHighHLbl.Name = "hsvHighHLbl";
            this.hsvHighHLbl.Size = new System.Drawing.Size(87, 16);
            this.hsvHighHLbl.TabIndex = 90;
            this.hsvHighHLbl.Text = "highH：180";
            // 
            // hsvLowH
            // 
            this.hsvLowH.Enabled = false;
            this.hsvLowH.Location = new System.Drawing.Point(4, 111);
            this.hsvLowH.Maximum = 180;
            this.hsvLowH.Name = "hsvLowH";
            this.hsvLowH.Size = new System.Drawing.Size(220, 45);
            this.hsvLowH.SmallChange = 5;
            this.hsvLowH.TabIndex = 90;
            this.hsvLowH.Scroll += new System.EventHandler(this.hsvThresholdScroll);
            // 
            // hsvHighH
            // 
            this.hsvHighH.Enabled = false;
            this.hsvHighH.Location = new System.Drawing.Point(4, 50);
            this.hsvHighH.Maximum = 180;
            this.hsvHighH.Name = "hsvHighH";
            this.hsvHighH.Size = new System.Drawing.Size(220, 45);
            this.hsvHighH.SmallChange = 5;
            this.hsvHighH.TabIndex = 89;
            this.hsvHighH.Value = 180;
            this.hsvHighH.Scroll += new System.EventHandler(this.hsvThresholdScroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.erosionIteration);
            this.groupBox4.Controls.Add(this.erosionSizeH);
            this.groupBox4.Controls.Add(this.erosionSizeW);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.ErosionBtn);
            this.groupBox4.Controls.Add(this.dilationIteration);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.dilationSizeH);
            this.groupBox4.Controls.Add(this.dilationSizeW);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.dilationBtn);
            this.groupBox4.Controls.Add(this.closeIteration);
            this.groupBox4.Controls.Add(this.openIteration);
            this.groupBox4.Controls.Add(this.hmBtn);
            this.groupBox4.Controls.Add(this.thinningBtn);
            this.groupBox4.Controls.Add(this.prunBtn);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.skltMorphShape);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.skeletonizationBtn);
            this.groupBox4.Controls.Add(this.skltSizeH);
            this.groupBox4.Controls.Add(this.closeSizeH);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.skltSizeW);
            this.groupBox4.Controls.Add(this.closeSizeW);
            this.groupBox4.Controls.Add(this.closeBtn);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.openSizeH);
            this.groupBox4.Controls.Add(this.openSizeW);
            this.groupBox4.Controls.Add(this.openBtn);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(681, 510);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(613, 167);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Morphology";
            // 
            // erosionIteration
            // 
            this.erosionIteration.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.erosionIteration.Location = new System.Drawing.Point(28, 72);
            this.erosionIteration.Name = "erosionIteration";
            this.erosionIteration.Size = new System.Drawing.Size(68, 25);
            this.erosionIteration.TabIndex = 124;
            this.erosionIteration.Text = "1";
            // 
            // erosionSizeH
            // 
            this.erosionSizeH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.erosionSizeH.Location = new System.Drawing.Point(165, 71);
            this.erosionSizeH.Name = "erosionSizeH";
            this.erosionSizeH.Size = new System.Drawing.Size(25, 25);
            this.erosionSizeH.TabIndex = 121;
            this.erosionSizeH.Text = "3";
            // 
            // erosionSizeW
            // 
            this.erosionSizeW.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.erosionSizeW.Location = new System.Drawing.Point(124, 71);
            this.erosionSizeW.Name = "erosionSizeW";
            this.erosionSizeW.Size = new System.Drawing.Size(25, 25);
            this.erosionSizeW.TabIndex = 120;
            this.erosionSizeW.Text = "3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(149, 73);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 20);
            this.label23.TabIndex = 119;
            this.label23.Text = "x";
            // 
            // ErosionBtn
            // 
            this.ErosionBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ErosionBtn.Location = new System.Drawing.Point(208, 72);
            this.ErosionBtn.Name = "ErosionBtn";
            this.ErosionBtn.Size = new System.Drawing.Size(67, 25);
            this.ErosionBtn.TabIndex = 118;
            this.ErosionBtn.Text = "Erosion";
            this.ErosionBtn.UseVisualStyleBackColor = true;
            this.ErosionBtn.Click += new System.EventHandler(this.ErosionBtn_Click);
            // 
            // dilationIteration
            // 
            this.dilationIteration.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dilationIteration.Location = new System.Drawing.Point(28, 43);
            this.dilationIteration.Name = "dilationIteration";
            this.dilationIteration.Size = new System.Drawing.Size(68, 25);
            this.dilationIteration.TabIndex = 117;
            this.dilationIteration.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(143, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 16);
            this.label16.TabIndex = 115;
            this.label16.Text = "Size";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(25, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 116;
            this.label19.Text = "iteration";
            // 
            // dilationSizeH
            // 
            this.dilationSizeH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dilationSizeH.Location = new System.Drawing.Point(165, 42);
            this.dilationSizeH.Name = "dilationSizeH";
            this.dilationSizeH.Size = new System.Drawing.Size(25, 25);
            this.dilationSizeH.TabIndex = 114;
            this.dilationSizeH.Text = "3";
            // 
            // dilationSizeW
            // 
            this.dilationSizeW.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dilationSizeW.Location = new System.Drawing.Point(124, 42);
            this.dilationSizeW.Name = "dilationSizeW";
            this.dilationSizeW.Size = new System.Drawing.Size(25, 25);
            this.dilationSizeW.TabIndex = 113;
            this.dilationSizeW.Text = "3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(149, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 20);
            this.label20.TabIndex = 112;
            this.label20.Text = "x";
            // 
            // dilationBtn
            // 
            this.dilationBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dilationBtn.Location = new System.Drawing.Point(208, 42);
            this.dilationBtn.Name = "dilationBtn";
            this.dilationBtn.Size = new System.Drawing.Size(67, 25);
            this.dilationBtn.TabIndex = 111;
            this.dilationBtn.Text = "Dilation";
            this.dilationBtn.UseVisualStyleBackColor = true;
            this.dilationBtn.Click += new System.EventHandler(this.dilationBtn_Click);
            // 
            // closeIteration
            // 
            this.closeIteration.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeIteration.Location = new System.Drawing.Point(28, 132);
            this.closeIteration.Name = "closeIteration";
            this.closeIteration.Size = new System.Drawing.Size(68, 25);
            this.closeIteration.TabIndex = 98;
            this.closeIteration.Text = "1";
            // 
            // openIteration
            // 
            this.openIteration.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openIteration.Location = new System.Drawing.Point(28, 102);
            this.openIteration.Name = "openIteration";
            this.openIteration.Size = new System.Drawing.Size(68, 25);
            this.openIteration.TabIndex = 92;
            this.openIteration.Text = "1";
            // 
            // hmBtn
            // 
            this.hmBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hmBtn.Location = new System.Drawing.Point(301, 123);
            this.hmBtn.Name = "hmBtn";
            this.hmBtn.Size = new System.Drawing.Size(155, 29);
            this.hmBtn.TabIndex = 110;
            this.hmBtn.Text = "Hit or Miss(還不能動)";
            this.hmBtn.UseVisualStyleBackColor = true;
            this.hmBtn.Click += new System.EventHandler(this.hmBtn_Click);
            // 
            // thinningBtn
            // 
            this.thinningBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.thinningBtn.Location = new System.Drawing.Point(301, 88);
            this.thinningBtn.Name = "thinningBtn";
            this.thinningBtn.Size = new System.Drawing.Size(155, 29);
            this.thinningBtn.TabIndex = 109;
            this.thinningBtn.Text = "Thinning(還不能動)";
            this.thinningBtn.UseVisualStyleBackColor = true;
            this.thinningBtn.Click += new System.EventHandler(this.thinningBtn_Click);
            // 
            // prunBtn
            // 
            this.prunBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.prunBtn.Location = new System.Drawing.Point(462, 92);
            this.prunBtn.Name = "prunBtn";
            this.prunBtn.Size = new System.Drawing.Size(138, 60);
            this.prunBtn.TabIndex = 108;
            this.prunBtn.Text = "Prunning(還不能動)";
            this.prunBtn.UseVisualStyleBackColor = true;
            this.prunBtn.Click += new System.EventHandler(this.prunBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(299, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 16);
            this.label18.TabIndex = 107;
            this.label18.Text = "Morph Shape";
            // 
            // skltMorphShape
            // 
            this.skltMorphShape.FormattingEnabled = true;
            this.skltMorphShape.Location = new System.Drawing.Point(391, 56);
            this.skltMorphShape.Name = "skltMorphShape";
            this.skltMorphShape.Size = new System.Drawing.Size(94, 27);
            this.skltMorphShape.TabIndex = 106;
            this.skltMorphShape.Text = "Rectangle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(351, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 16);
            this.label15.TabIndex = 103;
            this.label15.Text = "Size";
            // 
            // skeletonizationBtn
            // 
            this.skeletonizationBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.skeletonizationBtn.Location = new System.Drawing.Point(496, 23);
            this.skeletonizationBtn.Name = "skeletonizationBtn";
            this.skeletonizationBtn.Size = new System.Drawing.Size(104, 60);
            this.skeletonizationBtn.TabIndex = 104;
            this.skeletonizationBtn.Text = "Skeletonization";
            this.skeletonizationBtn.UseVisualStyleBackColor = true;
            this.skeletonizationBtn.Click += new System.EventHandler(this.skeletonizationBtn_Click);
            // 
            // skltSizeH
            // 
            this.skltSizeH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.skltSizeH.Location = new System.Drawing.Point(450, 23);
            this.skltSizeH.Name = "skltSizeH";
            this.skltSizeH.Size = new System.Drawing.Size(35, 25);
            this.skltSizeH.TabIndex = 102;
            this.skltSizeH.Text = "3";
            // 
            // closeSizeH
            // 
            this.closeSizeH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeSizeH.Location = new System.Drawing.Point(165, 132);
            this.closeSizeH.Name = "closeSizeH";
            this.closeSizeH.Size = new System.Drawing.Size(25, 25);
            this.closeSizeH.TabIndex = 95;
            this.closeSizeH.Text = "3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(429, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 20);
            this.label17.TabIndex = 100;
            this.label17.Text = "x";
            // 
            // skltSizeW
            // 
            this.skltSizeW.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.skltSizeW.Location = new System.Drawing.Point(391, 24);
            this.skltSizeW.Name = "skltSizeW";
            this.skltSizeW.Size = new System.Drawing.Size(35, 25);
            this.skltSizeW.TabIndex = 101;
            this.skltSizeW.Text = "3";
            // 
            // closeSizeW
            // 
            this.closeSizeW.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeSizeW.Location = new System.Drawing.Point(124, 132);
            this.closeSizeW.Name = "closeSizeW";
            this.closeSizeW.Size = new System.Drawing.Size(25, 25);
            this.closeSizeW.TabIndex = 94;
            this.closeSizeW.Text = "3";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeBtn.Location = new System.Drawing.Point(208, 132);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(67, 25);
            this.closeBtn.TabIndex = 97;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(148, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 93;
            this.label11.Text = "x";
            // 
            // openSizeH
            // 
            this.openSizeH.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openSizeH.Location = new System.Drawing.Point(165, 102);
            this.openSizeH.Name = "openSizeH";
            this.openSizeH.Size = new System.Drawing.Size(25, 25);
            this.openSizeH.TabIndex = 82;
            this.openSizeH.Text = "3";
            // 
            // openSizeW
            // 
            this.openSizeW.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openSizeW.Location = new System.Drawing.Point(124, 102);
            this.openSizeW.Name = "openSizeW";
            this.openSizeW.Size = new System.Drawing.Size(25, 25);
            this.openSizeW.TabIndex = 81;
            this.openSizeW.Text = "3";
            // 
            // openBtn
            // 
            this.openBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openBtn.Location = new System.Drawing.Point(208, 102);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(67, 25);
            this.openBtn.TabIndex = 91;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(149, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 80;
            this.label8.Text = "x";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gammaValue);
            this.groupBox5.Controls.Add(this.gammaBtn);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.equalizeHistBtn);
            this.groupBox5.Controls.Add(this.logBtn);
            this.groupBox5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(982, 150);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 103);
            this.groupBox5.TabIndex = 99;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contrast";
            // 
            // gammaValue
            // 
            this.gammaValue.Font = new System.Drawing.Font("新細明體", 10F);
            this.gammaValue.Location = new System.Drawing.Point(257, 62);
            this.gammaValue.Name = "gammaValue";
            this.gammaValue.Size = new System.Drawing.Size(35, 23);
            this.gammaValue.TabIndex = 102;
            this.gammaValue.Text = "0.5";
            // 
            // gammaBtn
            // 
            this.gammaBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gammaBtn.Location = new System.Drawing.Point(161, 61);
            this.gammaBtn.Name = "gammaBtn";
            this.gammaBtn.Size = new System.Drawing.Size(98, 25);
            this.gammaBtn.TabIndex = 101;
            this.gammaBtn.Text = "Gamma";
            this.gammaBtn.UseVisualStyleBackColor = true;
            this.gammaBtn.Click += new System.EventHandler(this.gammaBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(192, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 16);
            this.label14.TabIndex = 100;
            this.label14.Text = "Must Grayscale";
            // 
            // equalizeHistBtn
            // 
            this.equalizeHistBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.equalizeHistBtn.Location = new System.Drawing.Point(21, 29);
            this.equalizeHistBtn.Name = "equalizeHistBtn";
            this.equalizeHistBtn.Size = new System.Drawing.Size(272, 25);
            this.equalizeHistBtn.TabIndex = 97;
            this.equalizeHistBtn.Text = "Histogram Equalization";
            this.equalizeHistBtn.UseVisualStyleBackColor = true;
            this.equalizeHistBtn.Click += new System.EventHandler(this.equalizeHistBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.logBtn.Location = new System.Drawing.Point(20, 61);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(134, 25);
            this.logBtn.TabIndex = 91;
            this.logBtn.Text = "Logarithm(不能動)";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // editImgBtn
            // 
            this.editImgBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editImgBtn.Location = new System.Drawing.Point(876, 11);
            this.editImgBtn.Name = "editImgBtn";
            this.editImgBtn.Size = new System.Drawing.Size(93, 45);
            this.editImgBtn.TabIndex = 100;
            this.editImgBtn.Text = "Edit Image";
            this.editImgBtn.UseVisualStyleBackColor = true;
            this.editImgBtn.Click += new System.EventHandler(this.editImgBtn_Click);
            // 
            // selectImgBtn
            // 
            this.selectImgBtn.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectImgBtn.Location = new System.Drawing.Point(682, 11);
            this.selectImgBtn.Name = "selectImgBtn";
            this.selectImgBtn.Size = new System.Drawing.Size(89, 45);
            this.selectImgBtn.TabIndex = 101;
            this.selectImgBtn.Text = "Find Contours";
            this.selectImgBtn.UseVisualStyleBackColor = true;
            this.selectImgBtn.Click += new System.EventHandler(this.selectImgBtn_Click);
            // 
            // otsuBtn
            // 
            this.otsuBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.otsuBtn.Location = new System.Drawing.Point(1091, 12);
            this.otsuBtn.Name = "otsuBtn";
            this.otsuBtn.Size = new System.Drawing.Size(75, 25);
            this.otsuBtn.TabIndex = 102;
            this.otsuBtn.Text = "Otsu";
            this.otsuBtn.UseVisualStyleBackColor = true;
            this.otsuBtn.Click += new System.EventHandler(this.otsuBtn_Click);
            // 
            // otsuLbl
            // 
            this.otsuLbl.AutoSize = true;
            this.otsuLbl.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.otsuLbl.Location = new System.Drawing.Point(1090, 37);
            this.otsuLbl.Name = "otsuLbl";
            this.otsuLbl.Size = new System.Drawing.Size(52, 15);
            this.otsuLbl.TabIndex = 103;
            this.otsuLbl.Text = "Value : ";
            // 
            // connectedBtn
            // 
            this.connectedBtn.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.connectedBtn.Location = new System.Drawing.Point(1119, 474);
            this.connectedBtn.Name = "connectedBtn";
            this.connectedBtn.Size = new System.Drawing.Size(175, 27);
            this.connectedBtn.TabIndex = 104;
            this.connectedBtn.Text = "ConnectedComponents";
            this.connectedBtn.UseVisualStyleBackColor = true;
            this.connectedBtn.Click += new System.EventHandler(this.connectedBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(989, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 91;
            this.label9.Text = "Area";
            // 
            // connectedArea
            // 
            this.connectedArea.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.connectedArea.Location = new System.Drawing.Point(1042, 476);
            this.connectedArea.Name = "connectedArea";
            this.connectedArea.Size = new System.Drawing.Size(71, 25);
            this.connectedArea.TabIndex = 92;
            this.connectedArea.Text = "100";
            // 
            // cropImgBtn
            // 
            this.cropImgBtn.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cropImgBtn.Location = new System.Drawing.Point(611, 11);
            this.cropImgBtn.Name = "cropImgBtn";
            this.cropImgBtn.Size = new System.Drawing.Size(64, 45);
            this.cropImgBtn.TabIndex = 106;
            this.cropImgBtn.Text = "🔍";
            this.cropImgBtn.UseVisualStyleBackColor = true;
            this.cropImgBtn.Click += new System.EventHandler(this.cropImgBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 693);
            this.Controls.Add(this.cropImgBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.connectedBtn);
            this.Controls.Add(this.connectedArea);
            this.Controls.Add(this.otsuLbl);
            this.Controls.Add(this.otsuBtn);
            this.Controls.Add(this.selectImgBtn);
            this.Controls.Add(this.editImgBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.thresholdThresh);
            this.Controls.Add(this.thresholdBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grayBtn);
            this.Controls.Add(this.save_Btn);
            this.Controls.Add(this.openFile_Btn);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Photo_WH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.resultImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cannythreshold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cannythreshold2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hsvLowV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvHighV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvLowS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvHighS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvLowH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvHighH)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save_Btn;
        private System.Windows.Forms.Button openFile_Btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button grayBtn;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Label Photo_WH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox resultImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button meanFilterBtn;
        private System.Windows.Forms.TextBox meanFilterY;
        private System.Windows.Forms.TextBox meanFilterX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gaussianY;
        private System.Windows.Forms.TextBox gaussianX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gaussianBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button laplacianBtn;
        private System.Windows.Forms.Button thresholdBtn;
        private System.Windows.Forms.TextBox thresholdThresh;
        private System.Windows.Forms.TextBox laplacianKsize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sobelKsize;
        private System.Windows.Forms.Button sobelBtn;
        private System.Windows.Forms.Button cannyBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cannyApertureSize;
        private System.Windows.Forms.TrackBar Cannythreshold2;
        private System.Windows.Forms.TrackBar Cannythreshold1;
        private System.Windows.Forms.Label cannyThreshold1Lbl;
        private System.Windows.Forms.Label cannyThreshold2Lbl;
        private System.Windows.Forms.Button hsvBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label hsvLowVLbl;
        private System.Windows.Forms.Label hsvHighVLbl;
        private System.Windows.Forms.TrackBar hsvLowV;
        private System.Windows.Forms.TrackBar hsvHighV;
        private System.Windows.Forms.Label hsvLowSLbl;
        private System.Windows.Forms.Label hsvHighSLbl;
        private System.Windows.Forms.TrackBar hsvLowS;
        private System.Windows.Forms.TrackBar hsvHighS;
        private System.Windows.Forms.Label hsvLowHLbl;
        private System.Windows.Forms.Label hsvHighHLbl;
        private System.Windows.Forms.TrackBar hsvLowH;
        private System.Windows.Forms.TrackBar hsvHighH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TextBox openSizeH;
        private System.Windows.Forms.TextBox openIteration;
        private System.Windows.Forms.TextBox openSizeW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox closeSizeH;
        private System.Windows.Forms.TextBox closeIteration;
        private System.Windows.Forms.TextBox closeSizeW;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button equalizeHistBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button gammaBtn;
        private System.Windows.Forms.TextBox gammaValue;
        private System.Windows.Forms.Button editImgBtn;
        private System.Windows.Forms.Button selectImgBtn;
        private System.Windows.Forms.Button otsuBtn;
        private System.Windows.Forms.Label otsuLbl;
        private System.Windows.Forms.Button skeletonizationBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox skltSizeH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox skltSizeW;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox skltMorphShape;
        private System.Windows.Forms.Button prunBtn;
        private System.Windows.Forms.Button thinningBtn;
        private System.Windows.Forms.Button hmBtn;
        private System.Windows.Forms.Button dilationBtn;
        private System.Windows.Forms.TextBox erosionIteration;
        private System.Windows.Forms.TextBox erosionSizeH;
        private System.Windows.Forms.TextBox erosionSizeW;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button ErosionBtn;
        private System.Windows.Forms.TextBox dilationIteration;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox dilationSizeH;
        private System.Windows.Forms.TextBox dilationSizeW;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button connectedBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox connectedArea;
        private System.Windows.Forms.Button cropImgBtn;
    }
}

