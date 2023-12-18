
namespace Manual_Inspection
{
    partial class Form1
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
            this.load = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.deletePatternImage = new System.Windows.Forms.Button();
            this.addPatternImage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cannyNumText = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.thresholdNumText = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.maxGapNumText = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.minLineLengthNumText = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addROIchk = new System.Windows.Forms.CheckBox();
            this.selectedROIComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selROIwidthText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selROIHeightText = new System.Windows.Forms.TextBox();
            this.SelROISizeSaveBtn = new System.Windows.Forms.Button();
            this.deleteROIbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mainThresholdValueLabel = new System.Windows.Forms.Label();
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.selAnalizeTypeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainCursorPos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mainRGBValue = new System.Windows.Forms.Label();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.inspectONEPicture = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.patternWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.patternHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyNumText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxGapNumText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLineLengthNumText)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternHeightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.ForeColor = System.Drawing.Color.Black;
            this.load.Location = new System.Drawing.Point(133, 19);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 26);
            this.load.TabIndex = 3;
            this.load.Text = "Load image";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.97645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.02355F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1573, 1035);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.fileListBox);
            this.groupBox1.Controls.Add(this.inspectONEPicture);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.load);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1582, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 1035);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Gray;
            this.groupBox6.Controls.Add(this.patternHeightNumeric);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.patternWidthNumeric);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.deletePatternImage);
            this.groupBox6.Controls.Add(this.addPatternImage);
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(6, 809);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(307, 220);
            this.groupBox6.TabIndex = 68;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pattern image";
            // 
            // deletePatternImage
            // 
            this.deletePatternImage.Enabled = false;
            this.deletePatternImage.ForeColor = System.Drawing.Color.Black;
            this.deletePatternImage.Location = new System.Drawing.Point(15, 61);
            this.deletePatternImage.Name = "deletePatternImage";
            this.deletePatternImage.Size = new System.Drawing.Size(75, 23);
            this.deletePatternImage.TabIndex = 35;
            this.deletePatternImage.Text = "Delete";
            this.deletePatternImage.UseVisualStyleBackColor = true;
            this.deletePatternImage.Click += new System.EventHandler(this.deletePatternImage_Click);
            // 
            // addPatternImage
            // 
            this.addPatternImage.ForeColor = System.Drawing.Color.Black;
            this.addPatternImage.Location = new System.Drawing.Point(15, 32);
            this.addPatternImage.Name = "addPatternImage";
            this.addPatternImage.Size = new System.Drawing.Size(75, 23);
            this.addPatternImage.TabIndex = 34;
            this.addPatternImage.Text = "Add";
            this.addPatternImage.UseVisualStyleBackColor = true;
            this.addPatternImage.Click += new System.EventHandler(this.addPatternImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(101, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gray;
            this.groupBox5.Controls.Add(this.resultDataGrid);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(6, 507);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(307, 296);
            this.groupBox5.TabIndex = 67;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result";
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.AllowUserToAddRows = false;
            this.resultDataGrid.AllowUserToDeleteRows = false;
            this.resultDataGrid.AllowUserToResizeColumns = false;
            this.resultDataGrid.AllowUserToResizeRows = false;
            this.resultDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDataGrid.Location = new System.Drawing.Point(3, 16);
            this.resultDataGrid.MultiSelect = false;
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultDataGrid.Size = new System.Drawing.Size(301, 277);
            this.resultDataGrid.TabIndex = 68;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gray;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cannyNumText);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.thresholdNumText);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.maxGapNumText);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.minLineLengthNumText);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(6, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 114);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image processing";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "< OK";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(127, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 59;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "NG <";
            // 
            // cannyNumText
            // 
            this.cannyNumText.Location = new System.Drawing.Point(95, 19);
            this.cannyNumText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.cannyNumText.Name = "cannyNumText";
            this.cannyNumText.Size = new System.Drawing.Size(64, 20);
            this.cannyNumText.TabIndex = 49;
            this.cannyNumText.ValueChanged += new System.EventHandler(this.cannyNumText_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Canny:";
            // 
            // thresholdNumText
            // 
            this.thresholdNumText.Location = new System.Drawing.Point(234, 21);
            this.thresholdNumText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdNumText.Name = "thresholdNumText";
            this.thresholdNumText.Size = new System.Drawing.Size(64, 20);
            this.thresholdNumText.TabIndex = 47;
            this.thresholdNumText.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.thresholdNumText.ValueChanged += new System.EventHandler(this.thresholdNumText_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Threshold:";
            // 
            // maxGapNumText
            // 
            this.maxGapNumText.Location = new System.Drawing.Point(234, 47);
            this.maxGapNumText.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxGapNumText.Name = "maxGapNumText";
            this.maxGapNumText.Size = new System.Drawing.Size(64, 20);
            this.maxGapNumText.TabIndex = 57;
            this.maxGapNumText.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.maxGapNumText.ValueChanged += new System.EventHandler(this.maxGapNumText_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Max gap:";
            // 
            // minLineLengthNumText
            // 
            this.minLineLengthNumText.Location = new System.Drawing.Point(96, 47);
            this.minLineLengthNumText.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minLineLengthNumText.Name = "minLineLengthNumText";
            this.minLineLengthNumText.Size = new System.Drawing.Size(64, 20);
            this.minLineLengthNumText.TabIndex = 55;
            this.minLineLengthNumText.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.minLineLengthNumText.ValueChanged += new System.EventHandler(this.minLineLengthNumText_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Min line length:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gray;
            this.groupBox3.Controls.Add(this.addROIchk);
            this.groupBox3.Controls.Add(this.selectedROIComboBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.selROIwidthText);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.selROIHeightText);
            this.groupBox3.Controls.Add(this.SelROISizeSaveBtn);
            this.groupBox3.Controls.Add(this.deleteROIbtn);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(178, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 158);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ROI settings";
            // 
            // addROIchk
            // 
            this.addROIchk.AutoSize = true;
            this.addROIchk.Location = new System.Drawing.Point(7, 27);
            this.addROIchk.Name = "addROIchk";
            this.addROIchk.Size = new System.Drawing.Size(67, 17);
            this.addROIchk.TabIndex = 65;
            this.addROIchk.Text = "Add ROI";
            this.addROIchk.UseVisualStyleBackColor = true;
            // 
            // selectedROIComboBox
            // 
            this.selectedROIComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedROIComboBox.FormattingEnabled = true;
            this.selectedROIComboBox.Location = new System.Drawing.Point(43, 50);
            this.selectedROIComboBox.Name = "selectedROIComboBox";
            this.selectedROIComboBox.Size = new System.Drawing.Size(89, 21);
            this.selectedROIComboBox.TabIndex = 63;
            this.selectedROIComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedROIComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "ROI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "ROI width:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selROIwidthText
            // 
            this.selROIwidthText.Location = new System.Drawing.Point(81, 77);
            this.selROIwidthText.Name = "selROIwidthText";
            this.selROIwidthText.Size = new System.Drawing.Size(52, 20);
            this.selROIwidthText.TabIndex = 38;
            this.selROIwidthText.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "ROI height:";
            // 
            // selROIHeightText
            // 
            this.selROIHeightText.Location = new System.Drawing.Point(81, 104);
            this.selROIHeightText.Name = "selROIHeightText";
            this.selROIHeightText.Size = new System.Drawing.Size(52, 20);
            this.selROIHeightText.TabIndex = 40;
            this.selROIHeightText.Text = "100";
            // 
            // SelROISizeSaveBtn
            // 
            this.SelROISizeSaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SelROISizeSaveBtn.Location = new System.Drawing.Point(3, 131);
            this.SelROISizeSaveBtn.Name = "SelROISizeSaveBtn";
            this.SelROISizeSaveBtn.Size = new System.Drawing.Size(63, 21);
            this.SelROISizeSaveBtn.TabIndex = 42;
            this.SelROISizeSaveBtn.Text = "Save ROI";
            this.SelROISizeSaveBtn.UseVisualStyleBackColor = true;
            this.SelROISizeSaveBtn.Click += new System.EventHandler(this.SelROISizeSaveBtn_Click);
            // 
            // deleteROIbtn
            // 
            this.deleteROIbtn.ForeColor = System.Drawing.Color.Black;
            this.deleteROIbtn.Location = new System.Drawing.Point(72, 131);
            this.deleteROIbtn.Name = "deleteROIbtn";
            this.deleteROIbtn.Size = new System.Drawing.Size(61, 21);
            this.deleteROIbtn.TabIndex = 26;
            this.deleteROIbtn.Text = "Del ROI";
            this.deleteROIbtn.UseVisualStyleBackColor = true;
            this.deleteROIbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.mainThresholdValueLabel);
            this.groupBox2.Controls.Add(this.thresholdTrackBar);
            this.groupBox2.Controls.Add(this.selAnalizeTypeCombo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mainCursorPos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mainRGBValue);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 158);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Threshold:";
            // 
            // mainThresholdValueLabel
            // 
            this.mainThresholdValueLabel.AutoSize = true;
            this.mainThresholdValueLabel.Location = new System.Drawing.Point(80, 95);
            this.mainThresholdValueLabel.Name = "mainThresholdValueLabel";
            this.mainThresholdValueLabel.Size = new System.Drawing.Size(13, 13);
            this.mainThresholdValueLabel.TabIndex = 64;
            this.mainThresholdValueLabel.Text = "0";
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.LargeChange = 1;
            this.thresholdTrackBar.Location = new System.Drawing.Point(6, 111);
            this.thresholdTrackBar.Maximum = 255;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(154, 45);
            this.thresholdTrackBar.SmallChange = 0;
            this.thresholdTrackBar.TabIndex = 63;
            this.thresholdTrackBar.TickFrequency = 10;
            this.thresholdTrackBar.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll);
            // 
            // selAnalizeTypeCombo
            // 
            this.selAnalizeTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selAnalizeTypeCombo.FormattingEnabled = true;
            this.selAnalizeTypeCombo.Items.AddRange(new object[] {
            "Gray",
            "Bgr"});
            this.selAnalizeTypeCombo.Location = new System.Drawing.Point(79, 19);
            this.selAnalizeTypeCombo.Name = "selAnalizeTypeCombo";
            this.selAnalizeTypeCombo.Size = new System.Drawing.Size(77, 21);
            this.selAnalizeTypeCombo.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cursor position:";
            // 
            // mainCursorPos
            // 
            this.mainCursorPos.AutoSize = true;
            this.mainCursorPos.Location = new System.Drawing.Point(80, 72);
            this.mainCursorPos.Name = "mainCursorPos";
            this.mainCursorPos.Size = new System.Drawing.Size(10, 13);
            this.mainCursorPos.TabIndex = 22;
            this.mainCursorPos.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Analize type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Color value:";
            // 
            // mainRGBValue
            // 
            this.mainRGBValue.AutoSize = true;
            this.mainRGBValue.Location = new System.Drawing.Point(80, 50);
            this.mainRGBValue.Name = "mainRGBValue";
            this.mainRGBValue.Size = new System.Drawing.Size(10, 13);
            this.mainRGBValue.TabIndex = 24;
            this.mainRGBValue.Text = "-";
            // 
            // fileListBox
            // 
            this.fileListBox.Enabled = false;
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(6, 51);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(307, 108);
            this.fileListBox.TabIndex = 60;
            this.fileListBox.SelectedIndexChanged += new System.EventHandler(this.fileListBox_SelectedIndexChanged);
            // 
            // inspectONEPicture
            // 
            this.inspectONEPicture.BackColor = System.Drawing.Color.PaleGreen;
            this.inspectONEPicture.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectONEPicture.ForeColor = System.Drawing.Color.Black;
            this.inspectONEPicture.Location = new System.Drawing.Point(78, 449);
            this.inspectONEPicture.Name = "inspectONEPicture";
            this.inspectONEPicture.Size = new System.Drawing.Size(166, 52);
            this.inspectONEPicture.TabIndex = 43;
            this.inspectONEPicture.Text = "Inspection";
            this.inspectONEPicture.UseVisualStyleBackColor = false;
            this.inspectONEPicture.Click += new System.EventHandler(this.inspectPicture_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Width:";
            // 
            // patternWidthNumeric
            // 
            this.patternWidthNumeric.Location = new System.Drawing.Point(14, 121);
            this.patternWidthNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.patternWidthNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.patternWidthNumeric.Name = "patternWidthNumeric";
            this.patternWidthNumeric.Size = new System.Drawing.Size(81, 20);
            this.patternWidthNumeric.TabIndex = 37;
            this.patternWidthNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // patternHeightNumeric
            // 
            this.patternHeightNumeric.Location = new System.Drawing.Point(14, 171);
            this.patternHeightNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.patternHeightNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.patternHeightNumeric.Name = "patternHeightNumeric";
            this.patternHeightNumeric.Size = new System.Drawing.Size(81, 20);
            this.patternHeightNumeric.TabIndex = 39;
            this.patternHeightNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Height:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Manual Inspector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyNumText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxGapNumText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLineLengthNumText)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternHeightNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mainRGBValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mainCursorPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteROIbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SelROISizeSaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox selROIHeightText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selROIwidthText;
        private System.Windows.Forms.Button inspectONEPicture;
        private System.Windows.Forms.NumericUpDown thresholdNumText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cannyNumText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown maxGapNumText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown minLineLengthNumText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox selectedROIComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox selAnalizeTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox addROIchk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label mainThresholdValueLabel;
        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button deletePatternImage;
        private System.Windows.Forms.Button addPatternImage;
        private System.Windows.Forms.NumericUpDown patternHeightNumeric;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown patternWidthNumeric;
        private System.Windows.Forms.Label label15;
    }
}

