namespace Bootloader_v1._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboComPort = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.connectionTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProgramStatus1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bootloaderTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProgram = new System.Windows.Forms.Button();
            this.btnResetSystem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTakeBootMode = new System.Windows.Forms.Button();
            this.txtBoxReceivedData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProgramStatus2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bootModeCheck_Timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.connectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bootloaderTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboComPort
            // 
            this.comboComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboComPort.FormattingEnabled = true;
            this.comboComPort.Location = new System.Drawing.Point(146, 26);
            this.comboComPort.Name = "comboComPort";
            this.comboComPort.Size = new System.Drawing.Size(121, 21);
            this.comboComPort.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.connectionTab);
            this.tabControl1.Controls.Add(this.bootloaderTab);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 584);
            this.tabControl1.TabIndex = 1;
            // 
            // connectionTab
            // 
            this.connectionTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectionTab.Controls.Add(this.pictureBox1);
            this.connectionTab.Controls.Add(this.label17);
            this.connectionTab.Controls.Add(this.label18);
            this.connectionTab.Controls.Add(this.label19);
            this.connectionTab.Controls.Add(this.label14);
            this.connectionTab.Controls.Add(this.label15);
            this.connectionTab.Controls.Add(this.label16);
            this.connectionTab.Controls.Add(this.label11);
            this.connectionTab.Controls.Add(this.label12);
            this.connectionTab.Controls.Add(this.label13);
            this.connectionTab.Controls.Add(this.label10);
            this.connectionTab.Controls.Add(this.label9);
            this.connectionTab.Controls.Add(this.label7);
            this.connectionTab.Controls.Add(this.lblProgramStatus1);
            this.connectionTab.Controls.Add(this.label8);
            this.connectionTab.Controls.Add(this.groupBox1);
            this.connectionTab.Location = new System.Drawing.Point(4, 22);
            this.connectionTab.Name = "connectionTab";
            this.connectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionTab.Size = new System.Drawing.Size(1014, 558);
            this.connectionTab.TabIndex = 0;
            this.connectionTab.Text = "Connection Tab";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label17.Location = new System.Drawing.Point(46, 352);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 15);
            this.label17.TabIndex = 17;
            this.label17.Text = "SECTOR 11 -> For App";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label18.Location = new System.Drawing.Point(105, 333);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 15);
            this.label18.TabIndex = 18;
            this.label18.Text = "V";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label19.Location = new System.Drawing.Point(107, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 15);
            this.label19.TabIndex = 19;
            this.label19.Text = "|";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label14.Location = new System.Drawing.Point(107, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "|";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label15.Location = new System.Drawing.Point(107, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "|";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label16.Location = new System.Drawing.Point(107, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label11.Location = new System.Drawing.Point(107, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "|";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label12.Location = new System.Drawing.Point(46, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "SECTOR 4 -> For App";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label13.Location = new System.Drawing.Point(46, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "SECTOR 3 -> For App";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label10.Location = new System.Drawing.Point(46, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "SECTOR 2 -> For App";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label9.Location = new System.Drawing.Point(46, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "SECTOR 1 -> Bootloader";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label7.Location = new System.Drawing.Point(46, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "SECTOR 0 -> Bootloader";
            // 
            // lblProgramStatus1
            // 
            this.lblProgramStatus1.AutoSize = true;
            this.lblProgramStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProgramStatus1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblProgramStatus1.Location = new System.Drawing.Point(897, 534);
            this.lblProgramStatus1.Name = "lblProgramStatus1";
            this.lblProgramStatus1.Size = new System.Drawing.Size(95, 13);
            this.lblProgramStatus1.TabIndex = 8;
            this.lblProgramStatus1.Text = "XXXXXXXXXXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label8.Location = new System.Drawing.Point(787, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Program Durumu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.comboBaudrate);
            this.groupBox1.Controls.Add(this.comboComPort);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Location = new System.Drawing.Point(358, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnConnect.Location = new System.Drawing.Point(41, 107);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(137, 42);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200",
            "230400"});
            this.comboBaudrate.Location = new System.Drawing.Point(146, 65);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(121, 21);
            this.comboBaudrate.TabIndex = 5;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnDisconnect.Location = new System.Drawing.Point(184, 107);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(132, 42);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Bağlantıyı Kes";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(83, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate:";
            // 
            // bootloaderTab
            // 
            this.bootloaderTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bootloaderTab.Controls.Add(this.groupBox4);
            this.bootloaderTab.Controls.Add(this.groupBox3);
            this.bootloaderTab.Controls.Add(this.label5);
            this.bootloaderTab.Controls.Add(this.lblProgramStatus2);
            this.bootloaderTab.Controls.Add(this.label6);
            this.bootloaderTab.Controls.Add(this.groupBox2);
            this.bootloaderTab.Controls.Add(this.progressBar);
            this.bootloaderTab.Location = new System.Drawing.Point(4, 22);
            this.bootloaderTab.Name = "bootloaderTab";
            this.bootloaderTab.Padding = new System.Windows.Forms.Padding(3);
            this.bootloaderTab.Size = new System.Drawing.Size(1014, 558);
            this.bootloaderTab.TabIndex = 1;
            this.bootloaderTab.Text = "Bootloader Tab";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProgram);
            this.groupBox4.Controls.Add(this.btnResetSystem);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox4.Location = new System.Drawing.Point(149, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(676, 78);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // btnProgram
            // 
            this.btnProgram.Enabled = false;
            this.btnProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgram.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnProgram.Location = new System.Drawing.Point(154, 19);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(137, 42);
            this.btnProgram.TabIndex = 4;
            this.btnProgram.Text = "Program";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // btnResetSystem
            // 
            this.btnResetSystem.Enabled = false;
            this.btnResetSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSystem.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnResetSystem.Location = new System.Drawing.Point(382, 19);
            this.btnResetSystem.Name = "btnResetSystem";
            this.btnResetSystem.Size = new System.Drawing.Size(137, 42);
            this.btnResetSystem.TabIndex = 8;
            this.btnResetSystem.Text = "Software Reset";
            this.btnResetSystem.UseVisualStyleBackColor = true;
            this.btnResetSystem.Click += new System.EventHandler(this.btnResetSystem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTakeBootMode);
            this.groupBox3.Controls.Add(this.txtBoxReceivedData);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(149, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 78);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // btnTakeBootMode
            // 
            this.btnTakeBootMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeBootMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTakeBootMode.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnTakeBootMode.Location = new System.Drawing.Point(444, 19);
            this.btnTakeBootMode.Name = "btnTakeBootMode";
            this.btnTakeBootMode.Size = new System.Drawing.Size(137, 42);
            this.btnTakeBootMode.TabIndex = 1;
            this.btnTakeBootMode.Text = "Boot Moduna Al";
            this.btnTakeBootMode.UseVisualStyleBackColor = true;
            this.btnTakeBootMode.Click += new System.EventHandler(this.btnTakeBootMode_Click);
            // 
            // txtBoxReceivedData
            // 
            this.txtBoxReceivedData.Location = new System.Drawing.Point(201, 33);
            this.txtBoxReceivedData.Name = "txtBoxReceivedData";
            this.txtBoxReceivedData.Size = new System.Drawing.Size(148, 20);
            this.txtBoxReceivedData.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(84, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gelen Veri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label5.Location = new System.Drawing.Point(21, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Program İlerleme Durumu:";
            // 
            // lblProgramStatus2
            // 
            this.lblProgramStatus2.AutoSize = true;
            this.lblProgramStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProgramStatus2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblProgramStatus2.Location = new System.Drawing.Point(897, 534);
            this.lblProgramStatus2.Name = "lblProgramStatus2";
            this.lblProgramStatus2.Size = new System.Drawing.Size(95, 13);
            this.lblProgramStatus2.TabIndex = 9;
            this.lblProgramStatus2.Text = "XXXXXXXXXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label6.Location = new System.Drawing.Point(787, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Program Durumu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxFilePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox2.Location = new System.Drawing.Point(149, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtBoxFilePath
            // 
            this.txtBoxFilePath.Location = new System.Drawing.Point(98, 30);
            this.txtBoxFilePath.Name = "txtBoxFilePath";
            this.txtBoxFilePath.Size = new System.Drawing.Size(421, 22);
            this.txtBoxFilePath.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dosya Yolu:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnBrowse.Location = new System.Drawing.Point(528, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(137, 42);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Yazılımı Seç";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(205, 531);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(576, 21);
            this.progressBar.TabIndex = 7;
            // 
            // bootModeCheck_Timer
            // 
            this.bootModeCheck_Timer.Tick += new System.EventHandler(this.bootModeCheck_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1012, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bootloader Interface v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.connectionTab.ResumeLayout(false);
            this.connectionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bootloaderTab.ResumeLayout(false);
            this.bootloaderTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboComPort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage connectionTab;
        private System.Windows.Forms.TabPage bootloaderTab;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxReceivedData;
        private System.Windows.Forms.Button btnTakeBootMode;
        private System.Windows.Forms.Timer bootModeCheck_Timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnResetSystem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProgramStatus1;
        private System.Windows.Forms.Label lblProgramStatus2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

