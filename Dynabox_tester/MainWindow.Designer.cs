namespace Dynabox_tester
{
    partial class MainWindow
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
            this.preview = new System.Windows.Forms.RichTextBox();
            this.Preview_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.status = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sub_pos = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.set_pos = new System.Windows.Forms.CheckBox();
            this.electromagnet_status = new System.Windows.Forms.Label();
            this.state_door = new System.Windows.Forms.NumericUpDown();
            this.door_status = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.trans_val = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.TextBox();
            this.button_send_polling = new System.Windows.Forms.Button();
            this.stop_address = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start_address = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_send_single = new System.Windows.Forms.Button();
            this.single_address = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_send_led_trigger = new System.Windows.Forms.Button();
            this.button_send_led = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.queued = new System.Windows.Forms.CheckBox();
            this.checkBox_led_off = new System.Windows.Forms.CheckBox();
            this.led_quantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.delay_between_frames = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBar_connection_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_send = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_send_command = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_connection = new System.Windows.Forms.Button();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_preview = new System.Windows.Forms.GroupBox();
            this.groupBox_statistics = new System.Windows.Forms.GroupBox();
            this.label_incorrect_resp = new System.Windows.Forms.Label();
            this.label_correct_resp = new System.Windows.Forms.Label();
            this.label_queries = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Preview_menu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.state_door)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_address)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_address)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_between_frames)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.groupBox_send.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_preview.SuspendLayout();
            this.groupBox_statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.ContextMenuStrip = this.Preview_menu;
            this.preview.Location = new System.Drawing.Point(6, 19);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(184, 193);
            this.preview.TabIndex = 0;
            this.preview.Text = "";
            // 
            // Preview_menu
            // 
            this.Preview_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clear});
            this.Preview_menu.Name = "contextMenuStrip1";
            this.Preview_menu.Size = new System.Drawing.Size(111, 26);
            this.Preview_menu.Text = "Clear";
            this.Preview_menu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(152, 22);
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // serial
            // 
            this.serial.BaudRate = 19200;
            this.serial.PortName = "COM3";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(6, 18);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(45, 13);
            this.status.TabIndex = 1;
            this.status.Text = "Address";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 437);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Door";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sub_pos
            // 
            this.sub_pos.AutoSize = true;
            this.sub_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sub_pos.Location = new System.Drawing.Point(173, 65);
            this.sub_pos.Name = "sub_pos";
            this.sub_pos.Size = new System.Drawing.Size(84, 26);
            this.sub_pos.TabIndex = 10;
            this.sub_pos.Text = "---------";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(133, 74);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 13);
            this.label28.TabIndex = 9;
            this.label28.Text = "Subpos";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 13);
            this.label26.TabIndex = 7;
            this.label26.Text = "Transoptors";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sub_pos);
            this.groupBox5.Controls.Add(this.set_pos);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.electromagnet_status);
            this.groupBox5.Controls.Add(this.state_door);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.trans_val);
            this.groupBox5.Controls.Add(this.door_status);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(407, 94);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Command";
            // 
            // set_pos
            // 
            this.set_pos.AutoSize = true;
            this.set_pos.Location = new System.Drawing.Point(263, 39);
            this.set_pos.Name = "set_pos";
            this.set_pos.Size = new System.Drawing.Size(42, 17);
            this.set_pos.TabIndex = 7;
            this.set_pos.Text = "Set";
            this.set_pos.UseVisualStyleBackColor = true;
            // 
            // electromagnet_status
            // 
            this.electromagnet_status.AutoSize = true;
            this.electromagnet_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.electromagnet_status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.electromagnet_status.Location = new System.Drawing.Point(173, 12);
            this.electromagnet_status.Name = "electromagnet_status";
            this.electromagnet_status.Size = new System.Drawing.Size(84, 26);
            this.electromagnet_status.TabIndex = 4;
            this.electromagnet_status.Text = "---------";
            // 
            // state_door
            // 
            this.state_door.Location = new System.Drawing.Point(311, 38);
            this.state_door.Name = "state_door";
            this.state_door.Size = new System.Drawing.Size(53, 20);
            this.state_door.TabIndex = 3;
            // 
            // door_status
            // 
            this.door_status.AutoSize = true;
            this.door_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.door_status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.door_status.Location = new System.Drawing.Point(173, 35);
            this.door_status.Name = "door_status";
            this.door_status.Size = new System.Drawing.Size(84, 26);
            this.door_status.TabIndex = 5;
            this.door_status.Text = "---------";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CHT, Get, Set status";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(158, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Check electromagnet (0x01)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // trans_val
            // 
            this.trans_val.AutoSize = true;
            this.trans_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trans_val.Location = new System.Drawing.Point(64, 65);
            this.trans_val.Name = "trans_val";
            this.trans_val.Size = new System.Drawing.Size(52, 26);
            this.trans_val.TabIndex = 6;
            this.trans_val.Text = "-----";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.interval);
            this.groupBox4.Controls.Add(this.button_send_polling);
            this.groupBox4.Controls.Add(this.stop_address);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.start_address);
            this.groupBox4.Location = new System.Drawing.Point(128, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 73);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Polling";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Interval";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(196, 16);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(47, 20);
            this.interval.TabIndex = 8;
            this.interval.Text = "1000";
            this.interval.TextChanged += new System.EventHandler(this.interval_TextChanged);
            // 
            // button_send_polling
            // 
            this.button_send_polling.Location = new System.Drawing.Point(151, 42);
            this.button_send_polling.Name = "button_send_polling";
            this.button_send_polling.Size = new System.Drawing.Size(119, 23);
            this.button_send_polling.TabIndex = 0;
            this.button_send_polling.Text = "Start polling";
            this.button_send_polling.UseVisualStyleBackColor = true;
            this.button_send_polling.Click += new System.EventHandler(this.button_send_polling_Click);
            // 
            // stop_address
            // 
            this.stop_address.Location = new System.Drawing.Point(81, 42);
            this.stop_address.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stop_address.Name = "stop_address";
            this.stop_address.Size = new System.Drawing.Size(47, 20);
            this.stop_address.TabIndex = 6;
            this.stop_address.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start address";
            // 
            // start_address
            // 
            this.start_address.Location = new System.Drawing.Point(81, 16);
            this.start_address.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.start_address.Name = "start_address";
            this.start_address.Size = new System.Drawing.Size(47, 20);
            this.start_address.TabIndex = 5;
            this.start_address.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_send_single);
            this.groupBox3.Controls.Add(this.single_address);
            this.groupBox3.Controls.Add(this.status);
            this.groupBox3.Location = new System.Drawing.Point(6, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Single command";
            // 
            // button_send_single
            // 
            this.button_send_single.Location = new System.Drawing.Point(9, 42);
            this.button_send_single.Name = "button_send_single";
            this.button_send_single.Size = new System.Drawing.Size(100, 23);
            this.button_send_single.TabIndex = 5;
            this.button_send_single.Text = "Send command";
            this.button_send_single.UseVisualStyleBackColor = true;
            this.button_send_single.Click += new System.EventHandler(this.button_send_single_Click);
            // 
            // single_address
            // 
            this.single_address.Location = new System.Drawing.Point(57, 16);
            this.single_address.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.single_address.Name = "single_address";
            this.single_address.Size = new System.Drawing.Size(52, 20);
            this.single_address.TabIndex = 4;
            this.single_address.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Led";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox13);
            this.groupBox6.Controls.Add(this.comboBox12);
            this.groupBox6.Controls.Add(this.comboBox11);
            this.groupBox6.Controls.Add(this.comboBox10);
            this.groupBox6.Controls.Add(this.comboBox9);
            this.groupBox6.Controls.Add(this.comboBox8);
            this.groupBox6.Controls.Add(this.comboBox7);
            this.groupBox6.Controls.Add(this.comboBox6);
            this.groupBox6.Controls.Add(this.comboBox5);
            this.groupBox6.Controls.Add(this.comboBox4);
            this.groupBox6.Controls.Add(this.comboBox3);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.button_send_led_trigger);
            this.groupBox6.Controls.Add(this.button_send_led);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Location = new System.Drawing.Point(139, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(279, 399);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Commands";
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox13.Location = new System.Drawing.Point(31, 342);
            this.comboBox13.MaxDropDownItems = 13;
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(121, 21);
            this.comboBox13.TabIndex = 40;
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox12.Location = new System.Drawing.Point(31, 315);
            this.comboBox12.MaxDropDownItems = 13;
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(121, 21);
            this.comboBox12.TabIndex = 39;
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox11.Location = new System.Drawing.Point(31, 288);
            this.comboBox11.MaxDropDownItems = 13;
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 21);
            this.comboBox11.TabIndex = 38;
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox10.Location = new System.Drawing.Point(31, 261);
            this.comboBox10.MaxDropDownItems = 13;
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 21);
            this.comboBox10.TabIndex = 37;
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox9.Location = new System.Drawing.Point(31, 234);
            this.comboBox9.MaxDropDownItems = 13;
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 36;
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox8.Location = new System.Drawing.Point(31, 208);
            this.comboBox8.MaxDropDownItems = 13;
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 35;
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox7.Location = new System.Drawing.Point(31, 180);
            this.comboBox7.MaxDropDownItems = 13;
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 34;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox6.Location = new System.Drawing.Point(31, 153);
            this.comboBox6.MaxDropDownItems = 13;
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 33;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox5.Location = new System.Drawing.Point(31, 126);
            this.comboBox5.MaxDropDownItems = 13;
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 32;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox4.Location = new System.Drawing.Point(31, 99);
            this.comboBox4.MaxDropDownItems = 13;
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 31;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox3.Location = new System.Drawing.Point(31, 72);
            this.comboBox3.MaxDropDownItems = 13;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Diag"});
            this.comboBox2.Location = new System.Drawing.Point(31, 45);
            this.comboBox2.MaxDropDownItems = 13;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 29;
            // 
            // button_send_led_trigger
            // 
            this.button_send_led_trigger.Enabled = false;
            this.button_send_led_trigger.Location = new System.Drawing.Point(158, 19);
            this.button_send_led_trigger.Name = "button_send_led_trigger";
            this.button_send_led_trigger.Size = new System.Drawing.Size(75, 344);
            this.button_send_led_trigger.TabIndex = 4;
            this.button_send_led_trigger.Text = "Send trigger";
            this.button_send_led_trigger.UseVisualStyleBackColor = true;
            this.button_send_led_trigger.Click += new System.EventHandler(this.button_send_led_trigger_Click);
            // 
            // button_send_led
            // 
            this.button_send_led.Location = new System.Drawing.Point(90, 370);
            this.button_send_led.Name = "button_send_led";
            this.button_send_led.Size = new System.Drawing.Size(143, 23);
            this.button_send_led.TabIndex = 4;
            this.button_send_led.Text = "Send commands";
            this.button_send_led.UseVisualStyleBackColor = true;
            this.button_send_led.Click += new System.EventHandler(this.button_send_led_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 345);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "13";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 318);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "12";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 291);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "11";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "10";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 237);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "09";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "08";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "07";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "06";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "05";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "04";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "03";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "02";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "01";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OFF",
            "Green ON",
            "Red ON",
            "Green blink",
            "Red blink",
            "Green & red blink",
            "Green 1 pulse",
            "Red 1 pulse",
            "Green 2 pulses",
            "Red 2 pulses",
            "Green 3 pulses",
            "Red 3 pulses",
            "Green ON for 100 ms",
            "Diag"});
            this.comboBox1.Location = new System.Drawing.Point(31, 18);
            this.comboBox1.MaxDropDownItems = 13;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.queued);
            this.groupBox2.Controls.Add(this.checkBox_led_off);
            this.groupBox2.Controls.Add(this.led_quantity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.delay_between_frames);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // queued
            // 
            this.queued.AutoSize = true;
            this.queued.Location = new System.Drawing.Point(9, 148);
            this.queued.Name = "queued";
            this.queued.Size = new System.Drawing.Size(67, 17);
            this.queued.TabIndex = 10;
            this.queued.Text = "Queue ?";
            this.queued.UseVisualStyleBackColor = true;
            this.queued.CheckStateChanged += new System.EventHandler(this.queued_CheckStateChanged);
            // 
            // checkBox_led_off
            // 
            this.checkBox_led_off.AutoSize = true;
            this.checkBox_led_off.Location = new System.Drawing.Point(9, 125);
            this.checkBox_led_off.Name = "checkBox_led_off";
            this.checkBox_led_off.Size = new System.Drawing.Size(60, 17);
            this.checkBox_led_off.TabIndex = 4;
            this.checkBox_led_off.Text = "All OFF";
            this.checkBox_led_off.UseVisualStyleBackColor = true;
            // 
            // led_quantity
            // 
            this.led_quantity.Location = new System.Drawing.Point(9, 37);
            this.led_quantity.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.led_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.led_quantity.Name = "led_quantity";
            this.led_quantity.Size = new System.Drawing.Size(58, 20);
            this.led_quantity.TabIndex = 10;
            this.led_quantity.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Quantity";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(78, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "ms";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 72);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Delay between frames";
            // 
            // delay_between_frames
            // 
            this.delay_between_frames.Location = new System.Drawing.Point(9, 88);
            this.delay_between_frames.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delay_between_frames.Name = "delay_between_frames";
            this.delay_between_frames.Size = new System.Drawing.Size(63, 20);
            this.delay_between_frames.TabIndex = 1;
            this.delay_between_frames.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.delay_between_frames.ValueChanged += new System.EventHandler(this.leds_quantity_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar_connection_status});
            this.statusBar.Location = new System.Drawing.Point(0, 566);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(675, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBar_connection_status
            // 
            this.statusBar_connection_status.Name = "statusBar_connection_status";
            this.statusBar_connection_status.Size = new System.Drawing.Size(71, 17);
            this.statusBar_connection_status.Text = "Disconnected";
            // 
            // groupBox_send
            // 
            this.groupBox_send.Controls.Add(this.button_send);
            this.groupBox_send.Controls.Add(this.textBox_send_command);
            this.groupBox_send.Enabled = false;
            this.groupBox_send.Location = new System.Drawing.Point(244, 36);
            this.groupBox_send.Name = "groupBox_send";
            this.groupBox_send.Size = new System.Drawing.Size(407, 73);
            this.groupBox_send.TabIndex = 6;
            this.groupBox_send.TabStop = false;
            this.groupBox_send.Text = "Send";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(321, 32);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // textBox_send_command
            // 
            this.textBox_send_command.Location = new System.Drawing.Point(6, 34);
            this.textBox_send_command.Name = "textBox_send_command";
            this.textBox_send_command.Size = new System.Drawing.Size(309, 20);
            this.textBox_send_command.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_connection);
            this.groupBox1.Controls.Add(this.baudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ports);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // button_connection
            // 
            this.button_connection.Enabled = false;
            this.button_connection.Location = new System.Drawing.Point(143, 18);
            this.button_connection.Name = "button_connection";
            this.button_connection.Size = new System.Drawing.Size(75, 44);
            this.button_connection.TabIndex = 4;
            this.button_connection.Text = "Connect";
            this.button_connection.UseVisualStyleBackColor = true;
            this.button_connection.Click += new System.EventHandler(this.button_connection_Click);
            // 
            // baudrate
            // 
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "19200"});
            this.baudrate.Location = new System.Drawing.Point(62, 41);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(75, 21);
            this.baudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate";
            // 
            // ports
            // 
            this.ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ports.FormattingEnabled = true;
            this.ports.Location = new System.Drawing.Point(62, 18);
            this.ports.Name = "ports";
            this.ports.Size = new System.Drawing.Size(75, 21);
            this.ports.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ports";
            // 
            // groupBox_preview
            // 
            this.groupBox_preview.Controls.Add(this.preview);
            this.groupBox_preview.Enabled = false;
            this.groupBox_preview.Location = new System.Drawing.Point(450, 115);
            this.groupBox_preview.Name = "groupBox_preview";
            this.groupBox_preview.Size = new System.Drawing.Size(201, 225);
            this.groupBox_preview.TabIndex = 8;
            this.groupBox_preview.TabStop = false;
            this.groupBox_preview.Text = "Preview";
            // 
            // groupBox_statistics
            // 
            this.groupBox_statistics.Controls.Add(this.label_incorrect_resp);
            this.groupBox_statistics.Controls.Add(this.label_correct_resp);
            this.groupBox_statistics.Controls.Add(this.label_queries);
            this.groupBox_statistics.Controls.Add(this.label9);
            this.groupBox_statistics.Controls.Add(this.label8);
            this.groupBox_statistics.Controls.Add(this.label7);
            this.groupBox_statistics.Enabled = false;
            this.groupBox_statistics.Location = new System.Drawing.Point(451, 346);
            this.groupBox_statistics.Name = "groupBox_statistics";
            this.groupBox_statistics.Size = new System.Drawing.Size(200, 112);
            this.groupBox_statistics.TabIndex = 9;
            this.groupBox_statistics.TabStop = false;
            this.groupBox_statistics.Text = "Statistics";
            // 
            // label_incorrect_resp
            // 
            this.label_incorrect_resp.AutoSize = true;
            this.label_incorrect_resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_incorrect_resp.ForeColor = System.Drawing.Color.Red;
            this.label_incorrect_resp.Location = new System.Drawing.Point(95, 54);
            this.label_incorrect_resp.Name = "label_incorrect_resp";
            this.label_incorrect_resp.Size = new System.Drawing.Size(14, 13);
            this.label_incorrect_resp.TabIndex = 5;
            this.label_incorrect_resp.Text = "0";
            // 
            // label_correct_resp
            // 
            this.label_correct_resp.AutoSize = true;
            this.label_correct_resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_correct_resp.ForeColor = System.Drawing.Color.Blue;
            this.label_correct_resp.Location = new System.Drawing.Point(95, 35);
            this.label_correct_resp.Name = "label_correct_resp";
            this.label_correct_resp.Size = new System.Drawing.Size(14, 13);
            this.label_correct_resp.TabIndex = 4;
            this.label_correct_resp.Text = "0";
            // 
            // label_queries
            // 
            this.label_queries.AutoSize = true;
            this.label_queries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_queries.Location = new System.Drawing.Point(95, 16);
            this.label_queries.Name = "label_queries";
            this.label_queries.Size = new System.Drawing.Size(14, 13);
            this.label_queries.TabIndex = 3;
            this.label_queries.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Incorrect resp.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Correct resp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Queries";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 588);
            this.Controls.Add(this.groupBox_statistics);
            this.Controls.Add(this.groupBox_preview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_send);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynabox tester";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Preview_menu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.state_door)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stop_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_address)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_address)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_between_frames)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox_send.ResumeLayout(false);
            this.groupBox_send.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_preview.ResumeLayout(false);
            this.groupBox_statistics.ResumeLayout(false);
            this.groupBox_statistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox preview;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.GroupBox groupBox_send;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_send_command;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_connection_status;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_connection;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown single_address;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button_send_polling;
        private System.Windows.Forms.Button button_send_single;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.NumericUpDown stop_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown start_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_preview;
        private System.Windows.Forms.GroupBox groupBox_statistics;
        private System.Windows.Forms.Label label_incorrect_resp;
        private System.Windows.Forms.Label label_correct_resp;
        private System.Windows.Forms.Label label_queries;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown delay_between_frames;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_send_led_trigger;
        private System.Windows.Forms.Button button_send_led;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox_led_off;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ContextMenuStrip Preview_menu;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown led_quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown state_door;
        private System.Windows.Forms.Label electromagnet_status;
        private System.Windows.Forms.Label door_status;
        private System.Windows.Forms.CheckBox queued;
        private System.Windows.Forms.Label trans_val;
        private System.Windows.Forms.Label sub_pos;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox set_pos;
    }
}

