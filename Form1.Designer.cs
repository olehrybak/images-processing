
namespace CG_Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rgbButton = new System.Windows.Forms.Button();
            this.ycbcrButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numberOfColors = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.popalgApplyButton = new System.Windows.Forms.Button();
            this.greyScaleButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ditheringK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ditheringApplyButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brigthnessButton = new System.Windows.Forms.Button();
            this.invertButton = new System.Windows.Forms.Button();
            this.contrastButton = new System.Windows.Forms.Button();
            this.gammaButton2 = new System.Windows.Forms.Button();
            this.contrastButton2 = new System.Windows.Forms.Button();
            this.gammaButton = new System.Windows.Forms.Button();
            this.brigthnessButton2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blurButton = new System.Windows.Forms.Button();
            this.embossButton = new System.Windows.Forms.Button();
            this.sharpenButton = new System.Windows.Forms.Button();
            this.edgeButton = new System.Windows.Forms.Button();
            this.gaussButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfColors)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rgbButton);
            this.splitContainer1.Panel2.Controls.Add(this.ycbcrButton);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.greyScaleButton);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.revertButton);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1206, 426);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(20);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Controls.Add(this.uploadButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1206, 242);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(266, 242);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // uploadButton
            // 
            this.uploadButton.AutoSize = true;
            this.uploadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uploadButton.ForeColor = System.Drawing.Color.Black;
            this.uploadButton.Location = new System.Drawing.Point(0, 0);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(266, 242);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(936, 242);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rgbButton
            // 
            this.rgbButton.Enabled = false;
            this.rgbButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgbButton.ForeColor = System.Drawing.Color.Black;
            this.rgbButton.Location = new System.Drawing.Point(1097, 97);
            this.rgbButton.Name = "rgbButton";
            this.rgbButton.Size = new System.Drawing.Size(97, 55);
            this.rgbButton.TabIndex = 20;
            this.rgbButton.Text = "Convert to RGB";
            this.rgbButton.UseVisualStyleBackColor = true;
            this.rgbButton.Click += new System.EventHandler(this.rgbButton_Click);
            // 
            // ycbcrButton
            // 
            this.ycbcrButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ycbcrButton.ForeColor = System.Drawing.Color.Black;
            this.ycbcrButton.Location = new System.Drawing.Point(1097, 31);
            this.ycbcrButton.Name = "ycbcrButton";
            this.ycbcrButton.Size = new System.Drawing.Size(97, 60);
            this.ycbcrButton.TabIndex = 19;
            this.ycbcrButton.Text = "Convert to YCbCr";
            this.ycbcrButton.UseVisualStyleBackColor = true;
            this.ycbcrButton.Click += new System.EventHandler(this.ycbcrButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numberOfColors);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.popalgApplyButton);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(814, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 133);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Popularity algorithm";
            // 
            // numberOfColors
            // 
            this.numberOfColors.Location = new System.Drawing.Point(41, 61);
            this.numberOfColors.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfColors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfColors.Name = "numberOfColors";
            this.numberOfColors.Size = new System.Drawing.Size(88, 25);
            this.numberOfColors.TabIndex = 3;
            this.numberOfColors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of colors:";
            // 
            // popalgApplyButton
            // 
            this.popalgApplyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.popalgApplyButton.ForeColor = System.Drawing.Color.Black;
            this.popalgApplyButton.Location = new System.Drawing.Point(41, 96);
            this.popalgApplyButton.Name = "popalgApplyButton";
            this.popalgApplyButton.Size = new System.Drawing.Size(88, 30);
            this.popalgApplyButton.TabIndex = 0;
            this.popalgApplyButton.Text = "Apply";
            this.popalgApplyButton.UseVisualStyleBackColor = true;
            this.popalgApplyButton.Click += new System.EventHandler(this.popalgApplyButton_Click);
            // 
            // greyScaleButton
            // 
            this.greyScaleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greyScaleButton.ForeColor = System.Drawing.Color.Black;
            this.greyScaleButton.Location = new System.Drawing.Point(992, 31);
            this.greyScaleButton.Name = "greyScaleButton";
            this.greyScaleButton.Size = new System.Drawing.Size(97, 60);
            this.greyScaleButton.TabIndex = 16;
            this.greyScaleButton.Text = "Convert to grayscale";
            this.greyScaleButton.UseVisualStyleBackColor = true;
            this.greyScaleButton.Click += new System.EventHandler(this.greyScaleButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ditheringK);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ditheringApplyButton);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(672, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 133);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordered Dithering";
            // 
            // ditheringK
            // 
            this.ditheringK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ditheringK.FormatString = "N0";
            this.ditheringK.FormattingEnabled = true;
            this.ditheringK.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "6",
            "16"});
            this.ditheringK.Location = new System.Drawing.Point(21, 60);
            this.ditheringK.Name = "ditheringK";
            this.ditheringK.Size = new System.Drawing.Size(87, 29);
            this.ditheringK.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrix size:";
            // 
            // ditheringApplyButton
            // 
            this.ditheringApplyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ditheringApplyButton.ForeColor = System.Drawing.Color.Black;
            this.ditheringApplyButton.Location = new System.Drawing.Point(20, 97);
            this.ditheringApplyButton.Name = "ditheringApplyButton";
            this.ditheringApplyButton.Size = new System.Drawing.Size(88, 30);
            this.ditheringApplyButton.TabIndex = 0;
            this.ditheringApplyButton.Text = "Apply";
            this.ditheringApplyButton.UseVisualStyleBackColor = true;
            this.ditheringApplyButton.Click += new System.EventHandler(this.ditheringApplyButton_Click);
            // 
            // revertButton
            // 
            this.revertButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.revertButton.ForeColor = System.Drawing.Color.Black;
            this.revertButton.Location = new System.Drawing.Point(992, 97);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(97, 55);
            this.revertButton.TabIndex = 14;
            this.revertButton.Text = "Revert Changes";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(667, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 15;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brigthnessButton);
            this.groupBox2.Controls.Add(this.invertButton);
            this.groupBox2.Controls.Add(this.contrastButton);
            this.groupBox2.Controls.Add(this.gammaButton2);
            this.groupBox2.Controls.Add(this.contrastButton2);
            this.groupBox2.Controls.Add(this.gammaButton);
            this.groupBox2.Controls.Add(this.brigthnessButton2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 133);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functional Filters";
            // 
            // brigthnessButton
            // 
            this.brigthnessButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brigthnessButton.ForeColor = System.Drawing.Color.Black;
            this.brigthnessButton.Location = new System.Drawing.Point(6, 24);
            this.brigthnessButton.Name = "brigthnessButton";
            this.brigthnessButton.Size = new System.Drawing.Size(131, 30);
            this.brigthnessButton.TabIndex = 2;
            this.brigthnessButton.Text = "Brightness(-10)";
            this.brigthnessButton.UseVisualStyleBackColor = true;
            this.brigthnessButton.Click += new System.EventHandler(this.brigthnessButton_Click);
            // 
            // invertButton
            // 
            this.invertButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invertButton.ForeColor = System.Drawing.Color.Black;
            this.invertButton.Location = new System.Drawing.Point(295, 96);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(90, 30);
            this.invertButton.TabIndex = 0;
            this.invertButton.Text = "Invert";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // contrastButton
            // 
            this.contrastButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contrastButton.ForeColor = System.Drawing.Color.Black;
            this.contrastButton.Location = new System.Drawing.Point(6, 60);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(131, 30);
            this.contrastButton.TabIndex = 1;
            this.contrastButton.Text = "Contrast (-10)";
            this.contrastButton.UseVisualStyleBackColor = true;
            this.contrastButton.Click += new System.EventHandler(this.contrastButton_Click);
            // 
            // gammaButton2
            // 
            this.gammaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gammaButton2.ForeColor = System.Drawing.Color.Black;
            this.gammaButton2.Location = new System.Drawing.Point(143, 96);
            this.gammaButton2.Name = "gammaButton2";
            this.gammaButton2.Size = new System.Drawing.Size(131, 30);
            this.gammaButton2.TabIndex = 6;
            this.gammaButton2.Text = "Gamma (+0.2)";
            this.gammaButton2.UseVisualStyleBackColor = true;
            this.gammaButton2.Click += new System.EventHandler(this.gammaButton2_Click);
            // 
            // contrastButton2
            // 
            this.contrastButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contrastButton2.ForeColor = System.Drawing.Color.Black;
            this.contrastButton2.Location = new System.Drawing.Point(143, 60);
            this.contrastButton2.Name = "contrastButton2";
            this.contrastButton2.Size = new System.Drawing.Size(131, 30);
            this.contrastButton2.TabIndex = 3;
            this.contrastButton2.Text = "Contrast (+10)";
            this.contrastButton2.UseVisualStyleBackColor = true;
            this.contrastButton2.Click += new System.EventHandler(this.contrastButton2_Click);
            // 
            // gammaButton
            // 
            this.gammaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gammaButton.ForeColor = System.Drawing.Color.Black;
            this.gammaButton.Location = new System.Drawing.Point(6, 96);
            this.gammaButton.Name = "gammaButton";
            this.gammaButton.Size = new System.Drawing.Size(131, 30);
            this.gammaButton.TabIndex = 5;
            this.gammaButton.Text = "Gamma (-0.2)";
            this.gammaButton.UseVisualStyleBackColor = true;
            this.gammaButton.Click += new System.EventHandler(this.gammaButton_Click);
            // 
            // brigthnessButton2
            // 
            this.brigthnessButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brigthnessButton2.ForeColor = System.Drawing.Color.Black;
            this.brigthnessButton2.Location = new System.Drawing.Point(143, 24);
            this.brigthnessButton2.Name = "brigthnessButton2";
            this.brigthnessButton2.Size = new System.Drawing.Size(131, 30);
            this.brigthnessButton2.TabIndex = 4;
            this.brigthnessButton2.Text = "Brightness(+10)";
            this.brigthnessButton2.UseVisualStyleBackColor = true;
            this.brigthnessButton2.Click += new System.EventHandler(this.brigthnessButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blurButton);
            this.groupBox1.Controls.Add(this.embossButton);
            this.groupBox1.Controls.Add(this.sharpenButton);
            this.groupBox1.Controls.Add(this.edgeButton);
            this.groupBox1.Controls.Add(this.gaussButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(422, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 133);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convolution filters";
            // 
            // blurButton
            // 
            this.blurButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blurButton.ForeColor = System.Drawing.Color.Black;
            this.blurButton.Location = new System.Drawing.Point(6, 25);
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(90, 30);
            this.blurButton.TabIndex = 8;
            this.blurButton.Text = "Blur";
            this.blurButton.UseVisualStyleBackColor = true;
            this.blurButton.Click += new System.EventHandler(this.blurButton_Click);
            // 
            // embossButton
            // 
            this.embossButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.embossButton.ForeColor = System.Drawing.Color.Black;
            this.embossButton.Location = new System.Drawing.Point(102, 25);
            this.embossButton.Name = "embossButton";
            this.embossButton.Size = new System.Drawing.Size(131, 30);
            this.embossButton.TabIndex = 12;
            this.embossButton.Text = "Emboss (South)";
            this.embossButton.UseVisualStyleBackColor = true;
            this.embossButton.Click += new System.EventHandler(this.embossButton_Click);
            // 
            // sharpenButton
            // 
            this.sharpenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sharpenButton.ForeColor = System.Drawing.Color.Black;
            this.sharpenButton.Location = new System.Drawing.Point(126, 61);
            this.sharpenButton.Name = "sharpenButton";
            this.sharpenButton.Size = new System.Drawing.Size(90, 30);
            this.sharpenButton.TabIndex = 9;
            this.sharpenButton.Text = "Sharpen";
            this.sharpenButton.UseVisualStyleBackColor = true;
            this.sharpenButton.Click += new System.EventHandler(this.sharpenButton_Click);
            // 
            // edgeButton
            // 
            this.edgeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edgeButton.ForeColor = System.Drawing.Color.Black;
            this.edgeButton.Location = new System.Drawing.Point(6, 97);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(199, 30);
            this.edgeButton.TabIndex = 11;
            this.edgeButton.Text = "Edge Detection (Diagonal)";
            this.edgeButton.UseVisualStyleBackColor = true;
            this.edgeButton.Click += new System.EventHandler(this.edgeButton_Click);
            // 
            // gaussButton
            // 
            this.gaussButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gaussButton.ForeColor = System.Drawing.Color.Black;
            this.gaussButton.Location = new System.Drawing.Point(6, 61);
            this.gaussButton.Name = "gaussButton";
            this.gaussButton.Size = new System.Drawing.Size(114, 30);
            this.gaussButton.TabIndex = 10;
            this.gaussButton.Text = "Gaussian blur";
            this.gaussButton.UseVisualStyleBackColor = true;
            this.gaussButton.Click += new System.EventHandler(this.gaussButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 65F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CGLab1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfColors)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.Button contrastButton;
        private System.Windows.Forms.Button brigthnessButton;
        private System.Windows.Forms.Button contrastButton2;
        private System.Windows.Forms.Button brigthnessButton2;
        private System.Windows.Forms.Button gammaButton;
        private System.Windows.Forms.Button gammaButton2;
        private System.Windows.Forms.Button blurButton;
        private System.Windows.Forms.Button sharpenButton;
        private System.Windows.Forms.Button embossButton;
        private System.Windows.Forms.Button edgeButton;
        private System.Windows.Forms.Button gaussButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ditheringApplyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button greyScaleButton;
        private System.Windows.Forms.ComboBox ditheringK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button popularityApplyButton;
        private System.Windows.Forms.Button popalgApplyButton;
        private System.Windows.Forms.NumericUpDown numberOfColors;
        private System.Windows.Forms.Button rgbButton;
        private System.Windows.Forms.Button ycbcrButton;
    }
}

