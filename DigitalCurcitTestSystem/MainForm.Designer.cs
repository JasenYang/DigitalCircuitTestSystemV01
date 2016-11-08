namespace DigitalCurcitTestSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstResourceManage = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button被测件管理 = new System.Windows.Forms.Button();
            this.button测试仪器管理 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Port1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFZTest = new System.Windows.Forms.Button();
            this.btnYTTest = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ipAddressControl3 = new IPAddressControlLib.IPAddressControl();
            this.label20 = new System.Windows.Forms.Label();
            this.Port3 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ipAddressControl2 = new IPAddressControlLib.IPAddressControl();
            this.label16 = new System.Windows.Forms.Label();
            this.Port2 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox0 = new System.Windows.Forms.GroupBox();
            this.button0 = new System.Windows.Forms.Button();
            this.ipAddressControl = new IPAddressControlLib.IPAddressControl();
            this.label4 = new System.Windows.Forms.Label();
            this.Port0 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label158 = new System.Windows.Forms.Label();
            this.GPIBNum = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port2)).BeginInit();
            this.groupBox0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port0)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GPIBNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstResourceManage);
            this.panel1.Controls.Add(this.button被测件管理);
            this.panel1.Controls.Add(this.button测试仪器管理);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 649);
            this.panel1.TabIndex = 0;
            // 
            // lstResourceManage
            // 
            this.lstResourceManage.LargeImageList = this.imageList1;
            this.lstResourceManage.Location = new System.Drawing.Point(2, 41);
            this.lstResourceManage.MultiSelect = false;
            this.lstResourceManage.Name = "lstResourceManage";
            this.lstResourceManage.Size = new System.Drawing.Size(163, 569);
            this.lstResourceManage.TabIndex = 18;
            this.lstResourceManage.UseCompatibleStateImageBehavior = false;
            this.lstResourceManage.Click += new System.EventHandler(this.lstResourceManage_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "电源.png");
            this.imageList1.Images.SetKeyName(1, "示波器.png");
            this.imageList1.Images.SetKeyName(2, "板卡.jpg");
            this.imageList1.Images.SetKeyName(3, "81160A.jpg");
            this.imageList1.Images.SetKeyName(4, "N5751A.jpg");
            this.imageList1.Images.SetKeyName(5, "N3300A.png");
            this.imageList1.Images.SetKeyName(6, "load.jpg");
            // 
            // button被测件管理
            // 
            this.button被测件管理.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button被测件管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(142)))), ((int)(((byte)(206)))));
            this.button被测件管理.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button被测件管理.Location = new System.Drawing.Point(0, 616);
            this.button被测件管理.Name = "button被测件管理";
            this.button被测件管理.Size = new System.Drawing.Size(164, 33);
            this.button被测件管理.TabIndex = 17;
            this.button被测件管理.Text = "被测件管理";
            this.button被测件管理.UseVisualStyleBackColor = false;
            this.button被测件管理.Click += new System.EventHandler(this.button被测件管理_Click);
            // 
            // button测试仪器管理
            // 
            this.button测试仪器管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(142)))), ((int)(((byte)(206)))));
            this.button测试仪器管理.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button测试仪器管理.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button测试仪器管理.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button测试仪器管理.Location = new System.Drawing.Point(1, 2);
            this.button测试仪器管理.Name = "button测试仪器管理";
            this.button测试仪器管理.Size = new System.Drawing.Size(166, 36);
            this.button测试仪器管理.TabIndex = 16;
            this.button测试仪器管理.Text = "测试仪器管理";
            this.button测试仪器管理.UseVisualStyleBackColor = false;
            this.button测试仪器管理.Click += new System.EventHandler(this.button测试仪器管理_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox0);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(228, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 649);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipAddressControl1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Port1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(693, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 260);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "示波器DSOS404A配置";
            this.groupBox1.Visible = false;
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipAddressControl1.Location = new System.Drawing.Point(133, 60);
            this.ipAddressControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(192, 28);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(192, 28);
            this.ipAddressControl1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "打开";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "端口号:";
            // 
            // Port1
            // 
            this.Port1.Location = new System.Drawing.Point(133, 114);
            this.Port1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Port1.Name = "Port1";
            this.Port1.Size = new System.Drawing.Size(172, 28);
            this.Port1.TabIndex = 7;
            this.Port1.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "IP地址:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFZTest);
            this.groupBox5.Controls.Add(this.btnYTTest);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 13.8F);
            this.groupBox5.Location = new System.Drawing.Point(367, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 246);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "测试项";
            this.groupBox5.Visible = false;
            // 
            // btnFZTest
            // 
            this.btnFZTest.Location = new System.Drawing.Point(62, 55);
            this.btnFZTest.Name = "btnFZTest";
            this.btnFZTest.Size = new System.Drawing.Size(194, 46);
            this.btnFZTest.TabIndex = 20;
            this.btnFZTest.Text = "电源负载测试";
            this.btnFZTest.UseVisualStyleBackColor = true;
            this.btnFZTest.Click += new System.EventHandler(this.btnFZTest_Click);
            // 
            // btnYTTest
            // 
            this.btnYTTest.Location = new System.Drawing.Point(62, 126);
            this.btnYTTest.Name = "btnYTTest";
            this.btnYTTest.Size = new System.Drawing.Size(194, 46);
            this.btnYTTest.TabIndex = 21;
            this.btnYTTest.Text = "信号眼图测试";
            this.btnYTTest.UseVisualStyleBackColor = true;
            this.btnYTTest.Click += new System.EventHandler(this.btnYTTest_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.ipAddressControl3);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.Port3);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(390, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 260);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "N5751A配置";
            this.groupBox3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "打开";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ipAddressControl3
            // 
            this.ipAddressControl3.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipAddressControl3.Location = new System.Drawing.Point(133, 63);
            this.ipAddressControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressControl3.MinimumSize = new System.Drawing.Size(192, 28);
            this.ipAddressControl3.Name = "ipAddressControl3";
            this.ipAddressControl3.ReadOnly = false;
            this.ipAddressControl3.Size = new System.Drawing.Size(192, 28);
            this.ipAddressControl3.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 19);
            this.label20.TabIndex = 8;
            this.label20.Text = "端口号:";
            // 
            // Port3
            // 
            this.Port3.Location = new System.Drawing.Point(133, 114);
            this.Port3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Port3.Name = "Port3";
            this.Port3.Size = new System.Drawing.Size(172, 28);
            this.Port3.TabIndex = 7;
            this.Port3.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(40, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 19);
            this.label21.TabIndex = 6;
            this.label21.Text = "IP地址:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.ipAddressControl2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.Port2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(16, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 260);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信号发生器81160A配置";
            this.groupBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "打开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ipAddressControl2
            // 
            this.ipAddressControl2.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipAddressControl2.Location = new System.Drawing.Point(133, 63);
            this.ipAddressControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressControl2.MinimumSize = new System.Drawing.Size(192, 28);
            this.ipAddressControl2.Name = "ipAddressControl2";
            this.ipAddressControl2.ReadOnly = false;
            this.ipAddressControl2.Size = new System.Drawing.Size(192, 28);
            this.ipAddressControl2.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 19);
            this.label16.TabIndex = 8;
            this.label16.Text = "端口号:";
            // 
            // Port2
            // 
            this.Port2.Location = new System.Drawing.Point(133, 114);
            this.Port2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Port2.Name = "Port2";
            this.Port2.Size = new System.Drawing.Size(172, 28);
            this.Port2.TabIndex = 7;
            this.Port2.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "IP地址:";
            // 
            // groupBox0
            // 
            this.groupBox0.Controls.Add(this.button0);
            this.groupBox0.Controls.Add(this.ipAddressControl);
            this.groupBox0.Controls.Add(this.label4);
            this.groupBox0.Controls.Add(this.Port0);
            this.groupBox0.Controls.Add(this.label5);
            this.groupBox0.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox0.Location = new System.Drawing.Point(16, 14);
            this.groupBox0.Name = "groupBox0";
            this.groupBox0.Size = new System.Drawing.Size(336, 260);
            this.groupBox0.TabIndex = 21;
            this.groupBox0.TabStop = false;
            this.groupBox0.Text = "电源N6705B配置";
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(133, 162);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(94, 35);
            this.button0.TabIndex = 16;
            this.button0.Text = "打开";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // ipAddressControl
            // 
            this.ipAddressControl.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipAddressControl.Location = new System.Drawing.Point(133, 63);
            this.ipAddressControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressControl.MinimumSize = new System.Drawing.Size(192, 28);
            this.ipAddressControl.Name = "ipAddressControl";
            this.ipAddressControl.ReadOnly = false;
            this.ipAddressControl.Size = new System.Drawing.Size(192, 28);
            this.ipAddressControl.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "端口号:";
            // 
            // Port0
            // 
            this.Port0.Location = new System.Drawing.Point(133, 114);
            this.Port0.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Port0.Name = "Port0";
            this.Port0.Size = new System.Drawing.Size(172, 28);
            this.Port0.TabIndex = 7;
            this.Port0.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP地址:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label158);
            this.groupBox4.Controls.Add(this.GPIBNum);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(732, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 237);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "N3300A配置";
            this.groupBox4.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(120, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "打开";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(17, 77);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(97, 19);
            this.label158.TabIndex = 13;
            this.label158.Text = "GPIB地址:";
            // 
            // GPIBNum
            // 
            this.GPIBNum.Location = new System.Drawing.Point(120, 73);
            this.GPIBNum.Name = "GPIBNum";
            this.GPIBNum.Size = new System.Drawing.Size(172, 28);
            this.GPIBNum.TabIndex = 12;
            this.GPIBNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(238, 164);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 19);
            this.label22.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(55, 164);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 19);
            this.label23.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DigitalCurcitTestSystem.Properties.Resources.电源;
            this.pictureBox1.Location = new System.Drawing.Point(420, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1309, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 17);
            this.toolStripStatusLabel1.Text = "北京星网联达科技有限公司";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 687);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "数字电路测试系统 BetaV01";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port2)).EndInit();
            this.groupBox0.ResumeLayout(false);
            this.groupBox0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port0)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GPIBNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.NumericUpDown GPIBNum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListView lstResourceManage;
        private System.Windows.Forms.Button button被测件管理;
        private System.Windows.Forms.Button button测试仪器管理;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFZTest;
        private System.Windows.Forms.Button btnYTTest;      
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Port1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private IPAddressControlLib.IPAddressControl ipAddressControl3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown Port3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private IPAddressControlLib.IPAddressControl ipAddressControl2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown Port2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox0;
        private IPAddressControlLib.IPAddressControl ipAddressControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Port0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button0;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

