namespace DigitalCircuitSystem.TestForm
{
    partial class EyeDiagramsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EyeDiagramsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rate = new System.Windows.Forms.ComboBox();
            this.elect = new System.Windows.Forms.NumericUpDown();
            this.volt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HC123GB = new System.Windows.Forms.GroupBox();
            this.runCurBtn = new System.Windows.Forms.Button();
            this.closeAllBtn = new System.Windows.Forms.Button();
            this.openAllBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eleOut4 = new System.Windows.Forms.NumericUpDown();
            this.eleOut3 = new System.Windows.Forms.NumericUpDown();
            this.eleOut2 = new System.Windows.Forms.NumericUpDown();
            this.eleOut1 = new System.Windows.Forms.NumericUpDown();
            this.volOut4 = new System.Windows.Forms.NumericUpDown();
            this.volOut3 = new System.Windows.Forms.NumericUpDown();
            this.volOut2 = new System.Windows.Forms.NumericUpDown();
            this.volOut1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pupleSecondCB = new System.Windows.Forms.CheckBox();
            this.pupleThirdCB = new System.Windows.Forms.CheckBox();
            this.pupleFourthCB = new System.Windows.Forms.CheckBox();
            this.pupleFirstCB = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.bgWork = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HC123GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleOut4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleOut3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleOut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleOut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volOut4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volOut3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volOut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volOut1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rate);
            this.groupBox1.Controls.Add(this.elect);
            this.groupBox1.Controls.Add(this.volt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13F);
            this.groupBox1.Location = new System.Drawing.Point(12, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 362);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agilent N81160A设置";
            // 
            // rate
            // 
            this.rate.FormattingEnabled = true;
            this.rate.Items.AddRange(new object[] {
            "1",
            "4",
            "10.23",
            "50",
            "100"});
            this.rate.Location = new System.Drawing.Point(110, 80);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(121, 25);
            this.rate.TabIndex = 51;
            // 
            // elect
            // 
            this.elect.DecimalPlaces = 1;
            this.elect.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.elect.Location = new System.Drawing.Point(114, 172);
            this.elect.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.elect.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.elect.Name = "elect";
            this.elect.ReadOnly = true;
            this.elect.Size = new System.Drawing.Size(120, 27);
            this.elect.TabIndex = 50;
            this.elect.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // volt
            // 
            this.volt.DecimalPlaces = 1;
            this.volt.Location = new System.Drawing.Point(114, 127);
            this.volt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.volt.Name = "volt";
            this.volt.ReadOnly = true;
            this.volt.Size = new System.Drawing.Size(120, 27);
            this.volt.TabIndex = 49;
            this.volt.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "MHZ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(110, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 18);
            this.label17.TabIndex = 45;
            this.label17.Text = "正弦";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 41;
            this.label13.Text = "信号偏置：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "V";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(324, 214);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(90, 37);
            this.btnSet.TabIndex = 35;
            this.btnSet.Text = "启动";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "信号电压：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "信号频率：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "信号波形：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(768, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "眼图测试结果显示";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(506, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 510);
            this.panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DigitalCurcitTestSystem.Properties.Resources.load;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HC123GB
            // 
            this.HC123GB.Controls.Add(this.runCurBtn);
            this.HC123GB.Controls.Add(this.closeAllBtn);
            this.HC123GB.Controls.Add(this.openAllBtn);
            this.HC123GB.Controls.Add(this.label6);
            this.HC123GB.Controls.Add(this.label5);
            this.HC123GB.Controls.Add(this.label4);
            this.HC123GB.Controls.Add(this.eleOut4);
            this.HC123GB.Controls.Add(this.eleOut3);
            this.HC123GB.Controls.Add(this.eleOut2);
            this.HC123GB.Controls.Add(this.eleOut1);
            this.HC123GB.Controls.Add(this.volOut4);
            this.HC123GB.Controls.Add(this.volOut3);
            this.HC123GB.Controls.Add(this.volOut2);
            this.HC123GB.Controls.Add(this.volOut1);
            this.HC123GB.Controls.Add(this.label3);
            this.HC123GB.Controls.Add(this.label2);
            this.HC123GB.Controls.Add(this.pupleSecondCB);
            this.HC123GB.Controls.Add(this.pupleThirdCB);
            this.HC123GB.Controls.Add(this.pupleFourthCB);
            this.HC123GB.Controls.Add(this.pupleFirstCB);
            this.HC123GB.Controls.Add(this.label16);
            this.HC123GB.Font = new System.Drawing.Font("宋体", 13F);
            this.HC123GB.Location = new System.Drawing.Point(12, 13);
            this.HC123GB.Name = "HC123GB";
            this.HC123GB.Size = new System.Drawing.Size(471, 288);
            this.HC123GB.TabIndex = 44;
            this.HC123GB.TabStop = false;
            this.HC123GB.Text = "Agilent N6705B电源设置";
            // 
            // runCurBtn
            // 
            this.runCurBtn.Location = new System.Drawing.Point(309, 232);
            this.runCurBtn.Name = "runCurBtn";
            this.runCurBtn.Size = new System.Drawing.Size(132, 37);
            this.runCurBtn.TabIndex = 37;
            this.runCurBtn.Text = "执行当前设置";
            this.runCurBtn.UseVisualStyleBackColor = true;
            this.runCurBtn.Click += new System.EventHandler(this.runCurBtn_Click);
            // 
            // closeAllBtn
            // 
            this.closeAllBtn.Location = new System.Drawing.Point(210, 232);
            this.closeAllBtn.Name = "closeAllBtn";
            this.closeAllBtn.Size = new System.Drawing.Size(89, 37);
            this.closeAllBtn.TabIndex = 36;
            this.closeAllBtn.Text = "关闭所有";
            this.closeAllBtn.UseVisualStyleBackColor = true;
            this.closeAllBtn.Click += new System.EventHandler(this.closeAllBtn_Click);
            // 
            // openAllBtn
            // 
            this.openAllBtn.Location = new System.Drawing.Point(110, 232);
            this.openAllBtn.Name = "openAllBtn";
            this.openAllBtn.Size = new System.Drawing.Size(90, 37);
            this.openAllBtn.TabIndex = 35;
            this.openAllBtn.Text = "打开所有";
            this.openAllBtn.UseVisualStyleBackColor = true;
            this.openAllBtn.Click += new System.EventHandler(this.openAllBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "手动控制";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "V";
            // 
            // eleOut4
            // 
            this.eleOut4.BackColor = System.Drawing.Color.Orchid;
            this.eleOut4.DecimalPlaces = 1;
            this.eleOut4.Enabled = false;
            this.eleOut4.Location = new System.Drawing.Point(319, 122);
            this.eleOut4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.eleOut4.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.eleOut4.Name = "eleOut4";
            this.eleOut4.Size = new System.Drawing.Size(48, 27);
            this.eleOut4.TabIndex = 14;
            this.eleOut4.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // eleOut3
            // 
            this.eleOut3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.eleOut3.DecimalPlaces = 1;
            this.eleOut3.Enabled = false;
            this.eleOut3.Location = new System.Drawing.Point(250, 122);
            this.eleOut3.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.eleOut3.Name = "eleOut3";
            this.eleOut3.Size = new System.Drawing.Size(49, 27);
            this.eleOut3.TabIndex = 13;
            this.eleOut3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // eleOut2
            // 
            this.eleOut2.BackColor = System.Drawing.Color.LimeGreen;
            this.eleOut2.DecimalPlaces = 1;
            this.eleOut2.Location = new System.Drawing.Point(181, 122);
            this.eleOut2.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.eleOut2.Name = "eleOut2";
            this.eleOut2.Size = new System.Drawing.Size(47, 27);
            this.eleOut2.TabIndex = 12;
            this.eleOut2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // eleOut1
            // 
            this.eleOut1.BackColor = System.Drawing.Color.Khaki;
            this.eleOut1.DecimalPlaces = 1;
            this.eleOut1.Location = new System.Drawing.Point(112, 122);
            this.eleOut1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.eleOut1.Name = "eleOut1";
            this.eleOut1.Size = new System.Drawing.Size(49, 27);
            this.eleOut1.TabIndex = 11;
            this.eleOut1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // volOut4
            // 
            this.volOut4.BackColor = System.Drawing.Color.Orchid;
            this.volOut4.DecimalPlaces = 1;
            this.volOut4.Enabled = false;
            this.volOut4.Location = new System.Drawing.Point(320, 77);
            this.volOut4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.volOut4.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.volOut4.Name = "volOut4";
            this.volOut4.Size = new System.Drawing.Size(49, 27);
            this.volOut4.TabIndex = 10;
            this.volOut4.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // volOut3
            // 
            this.volOut3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.volOut3.DecimalPlaces = 1;
            this.volOut3.Enabled = false;
            this.volOut3.Location = new System.Drawing.Point(251, 77);
            this.volOut3.Maximum = new decimal(new int[] {
            66,
            0,
            0,
            65536});
            this.volOut3.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            65536});
            this.volOut3.Name = "volOut3";
            this.volOut3.Size = new System.Drawing.Size(49, 27);
            this.volOut3.TabIndex = 9;
            this.volOut3.Value = new decimal(new int[] {
            45,
            0,
            0,
            65536});
            // 
            // volOut2
            // 
            this.volOut2.BackColor = System.Drawing.Color.LimeGreen;
            this.volOut2.DecimalPlaces = 1;
            this.volOut2.Location = new System.Drawing.Point(182, 77);
            this.volOut2.Maximum = new decimal(new int[] {
            66,
            0,
            0,
            65536});
            this.volOut2.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            65536});
            this.volOut2.Name = "volOut2";
            this.volOut2.Size = new System.Drawing.Size(49, 27);
            this.volOut2.TabIndex = 8;
            this.volOut2.Value = new decimal(new int[] {
            45,
            0,
            0,
            65536});
            // 
            // volOut1
            // 
            this.volOut1.BackColor = System.Drawing.Color.Khaki;
            this.volOut1.DecimalPlaces = 1;
            this.volOut1.Location = new System.Drawing.Point(113, 77);
            this.volOut1.Name = "volOut1";
            this.volOut1.Size = new System.Drawing.Size(49, 27);
            this.volOut1.TabIndex = 7;
            this.volOut1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "电流限制";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "电压输出";
            // 
            // pupleSecondCB
            // 
            this.pupleSecondCB.AutoSize = true;
            this.pupleSecondCB.Location = new System.Drawing.Point(188, 35);
            this.pupleSecondCB.Name = "pupleSecondCB";
            this.pupleSecondCB.Size = new System.Drawing.Size(36, 22);
            this.pupleSecondCB.TabIndex = 4;
            this.pupleSecondCB.Text = "2";
            this.pupleSecondCB.UseVisualStyleBackColor = true;
            // 
            // pupleThirdCB
            // 
            this.pupleThirdCB.AutoSize = true;
            this.pupleThirdCB.Enabled = false;
            this.pupleThirdCB.Location = new System.Drawing.Point(257, 35);
            this.pupleThirdCB.Name = "pupleThirdCB";
            this.pupleThirdCB.Size = new System.Drawing.Size(36, 22);
            this.pupleThirdCB.TabIndex = 3;
            this.pupleThirdCB.Text = "3";
            this.pupleThirdCB.UseVisualStyleBackColor = true;
            // 
            // pupleFourthCB
            // 
            this.pupleFourthCB.AutoSize = true;
            this.pupleFourthCB.Enabled = false;
            this.pupleFourthCB.Location = new System.Drawing.Point(324, 35);
            this.pupleFourthCB.Name = "pupleFourthCB";
            this.pupleFourthCB.Size = new System.Drawing.Size(36, 22);
            this.pupleFourthCB.TabIndex = 2;
            this.pupleFourthCB.Text = "4";
            this.pupleFourthCB.UseVisualStyleBackColor = true;
            // 
            // pupleFirstCB
            // 
            this.pupleFirstCB.AutoSize = true;
            this.pupleFirstCB.Location = new System.Drawing.Point(114, 35);
            this.pupleFirstCB.Name = "pupleFirstCB";
            this.pupleFirstCB.Size = new System.Drawing.Size(36, 22);
            this.pupleFirstCB.TabIndex = 1;
            this.pupleFirstCB.Text = "1";
            this.pupleFirstCB.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "电源通道";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("宋体", 13F);
            this.BtnSave.Location = new System.Drawing.Point(1152, 9);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 33);
            this.BtnSave.TabIndex = 45;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // bgWork
            // 
            this.bgWork.WorkerReportsProgress = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(509, 564);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(726, 23);
            this.progressBar1.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1159, 590);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "未进行测试...";
            // 
            // EyeDiagramsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 710);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.HC123GB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EyeDiagramsForm";
            this.Text = "信号眼图测试";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volt)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HC123GB.ResumeLayout(false);
            this.HC123GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleOut4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleOut3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleOut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleOut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volOut4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volOut3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volOut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volOut1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox HC123GB;
        private System.Windows.Forms.Button runCurBtn;
        private System.Windows.Forms.Button closeAllBtn;
        private System.Windows.Forms.Button openAllBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown eleOut4;
        private System.Windows.Forms.NumericUpDown eleOut3;
        private System.Windows.Forms.NumericUpDown eleOut2;
        public System.Windows.Forms.NumericUpDown eleOut1;
        private System.Windows.Forms.NumericUpDown volOut4;
        private System.Windows.Forms.NumericUpDown volOut3;
        private System.Windows.Forms.NumericUpDown volOut2;
        private System.Windows.Forms.NumericUpDown volOut1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox pupleSecondCB;
        private System.Windows.Forms.CheckBox pupleThirdCB;
        private System.Windows.Forms.CheckBox pupleFourthCB;
        private System.Windows.Forms.CheckBox pupleFirstCB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown elect;
        private System.Windows.Forms.NumericUpDown volt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSave;
        private System.ComponentModel.BackgroundWorker bgWork;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox rate;
    }
}