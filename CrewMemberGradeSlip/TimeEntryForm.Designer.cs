namespace CrewMemberGradeSlip
{
    partial class TimeEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.flightTimeBox1 = new System.Windows.Forms.TextBox();
            this.flightTimeBox2 = new System.Windows.Forms.TextBox();
            this.flightTimeBox3 = new System.Windows.Forms.TextBox();
            this.flightTimeTotalLBL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flightTimeBox4 = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.printBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.commentsTC = new System.Windows.Forms.TabControl();
            this.firstFlightTP = new System.Windows.Forms.TabPage();
            this.ffTB = new System.Windows.Forms.TextBox();
            this.ffAmPmCB = new System.Windows.Forms.ComboBox();
            this.ffStartTimeMTB = new System.Windows.Forms.MaskedTextBox();
            this.firstFlightStartTimeLBL = new System.Windows.Forms.Label();
            this.secondFlightTP = new System.Windows.Forms.TabPage();
            this.secondFlightTB = new System.Windows.Forms.TextBox();
            this.amPm2CB = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.secondFlightStartTimeLBL = new System.Windows.Forms.Label();
            this.thirdFlightTP = new System.Windows.Forms.TabPage();
            this.thirdFlightTB = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.thirdFlightStartTimeLBL = new System.Windows.Forms.Label();
            this.fourthFlightTP = new System.Windows.Forms.TabPage();
            this.fourthFlightTB = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.fourthFlightStartTimeLBL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.commentsTC.SuspendLayout();
            this.firstFlightTP.SuspendLayout();
            this.secondFlightTP.SuspendLayout();
            this.thirdFlightTP.SuspendLayout();
            this.fourthFlightTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total time flown today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Day Flight Time",
            "Night Flight Time",
            "NVG Flight Time"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Day Flight Time";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Day Flight Time",
            "Night Flight Time",
            "NVG Flight Time"});
            this.comboBox2.Location = new System.Drawing.Point(6, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Night Flight Time";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Day Flight Time",
            "Night Flight Time",
            "NVG Flight Time"});
            this.comboBox3.Location = new System.Drawing.Point(6, 73);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.Text = "NVG Flight Time";
            // 
            // flightTimeBox1
            // 
            this.flightTimeBox1.Location = new System.Drawing.Point(6, 19);
            this.flightTimeBox1.Name = "flightTimeBox1";
            this.flightTimeBox1.Size = new System.Drawing.Size(100, 20);
            this.flightTimeBox1.TabIndex = 3;
            this.flightTimeBox1.Text = "0.0";
            this.flightTimeBox1.TextChanged += new System.EventHandler(this.flightTimeBox1_TextChanged);
            this.flightTimeBox1.Leave += new System.EventHandler(this.flightTimeBox1_Leave);
            // 
            // flightTimeBox2
            // 
            this.flightTimeBox2.Enabled = false;
            this.flightTimeBox2.Location = new System.Drawing.Point(6, 46);
            this.flightTimeBox2.Name = "flightTimeBox2";
            this.flightTimeBox2.Size = new System.Drawing.Size(100, 20);
            this.flightTimeBox2.TabIndex = 8;
            this.flightTimeBox2.Text = "0.0";
            this.flightTimeBox2.TextChanged += new System.EventHandler(this.flightTimeBox2_TextChanged);
            // 
            // flightTimeBox3
            // 
            this.flightTimeBox3.Enabled = false;
            this.flightTimeBox3.Location = new System.Drawing.Point(6, 73);
            this.flightTimeBox3.Name = "flightTimeBox3";
            this.flightTimeBox3.Size = new System.Drawing.Size(100, 20);
            this.flightTimeBox3.TabIndex = 13;
            this.flightTimeBox3.Text = "0.0";
            this.flightTimeBox3.TextChanged += new System.EventHandler(this.flightTimeBox3_TextChanged);
            // 
            // flightTimeTotalLBL
            // 
            this.flightTimeTotalLBL.AutoSize = true;
            this.flightTimeTotalLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightTimeTotalLBL.Location = new System.Drawing.Point(257, 203);
            this.flightTimeTotalLBL.Name = "flightTimeTotalLBL";
            this.flightTimeTotalLBL.Size = new System.Drawing.Size(24, 15);
            this.flightTimeTotalLBL.TabIndex = 8;
            this.flightTimeTotalLBL.Text = "0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(110, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 136);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Flight Condition";
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Day Flight Time",
            "Night Flight Time",
            "NVG Flight Time"});
            this.comboBox4.Location = new System.Drawing.Point(6, 100);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 17;
            this.comboBox4.Text = "NVG Flight Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flightTimeBox4);
            this.groupBox2.Controls.Add(this.flightTimeBox1);
            this.groupBox2.Controls.Add(this.flightTimeBox2);
            this.groupBox2.Controls.Add(this.flightTimeBox3);
            this.groupBox2.Location = new System.Drawing.Point(251, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 136);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Flight Times";
            // 
            // flightTimeBox4
            // 
            this.flightTimeBox4.Enabled = false;
            this.flightTimeBox4.Location = new System.Drawing.Point(6, 100);
            this.flightTimeBox4.Name = "flightTimeBox4";
            this.flightTimeBox4.Size = new System.Drawing.Size(100, 20);
            this.flightTimeBox4.TabIndex = 18;
            this.flightTimeBox4.Text = "0.0";
            this.flightTimeBox4.TextChanged += new System.EventHandler(this.flightTimeBox4_TextChanged);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(58, 248);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 17;
            this.btnSaveData.TabStop = false;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // printBTN
            // 
            this.printBTN.Location = new System.Drawing.Point(148, 248);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(75, 23);
            this.printBTN.TabIndex = 18;
            this.printBTN.TabStop = false;
            this.printBTN.Text = "Print";
            this.printBTN.UseVisualStyleBackColor = true;
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Flight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Second Flight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Third Flight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fourth Flight:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.commentsTC);
            this.groupBox3.Location = new System.Drawing.Point(389, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 262);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comments";
            // 
            // commentsTC
            // 
            this.commentsTC.Controls.Add(this.firstFlightTP);
            this.commentsTC.Controls.Add(this.secondFlightTP);
            this.commentsTC.Controls.Add(this.thirdFlightTP);
            this.commentsTC.Controls.Add(this.fourthFlightTP);
            this.commentsTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentsTC.Location = new System.Drawing.Point(3, 16);
            this.commentsTC.Name = "commentsTC";
            this.commentsTC.SelectedIndex = 0;
            this.commentsTC.Size = new System.Drawing.Size(279, 243);
            this.commentsTC.TabIndex = 18;
            this.commentsTC.TabStop = false;
            // 
            // firstFlightTP
            // 
            this.firstFlightTP.Controls.Add(this.ffTB);
            this.firstFlightTP.Controls.Add(this.ffAmPmCB);
            this.firstFlightTP.Controls.Add(this.ffStartTimeMTB);
            this.firstFlightTP.Controls.Add(this.firstFlightStartTimeLBL);
            this.firstFlightTP.Location = new System.Drawing.Point(4, 22);
            this.firstFlightTP.Name = "firstFlightTP";
            this.firstFlightTP.Padding = new System.Windows.Forms.Padding(3);
            this.firstFlightTP.Size = new System.Drawing.Size(271, 217);
            this.firstFlightTP.TabIndex = 0;
            this.firstFlightTP.Text = "First Flight";
            this.firstFlightTP.UseVisualStyleBackColor = true;
            // 
            // ffTB
            // 
            this.ffTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ffTB.Location = new System.Drawing.Point(3, 24);
            this.ffTB.Multiline = true;
            this.ffTB.Name = "ffTB";
            this.ffTB.Size = new System.Drawing.Size(265, 190);
            this.ffTB.TabIndex = 6;
            // 
            // ffAmPmCB
            // 
            this.ffAmPmCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ffAmPmCB.FormattingEnabled = true;
            this.ffAmPmCB.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.ffAmPmCB.Location = new System.Drawing.Point(138, 0);
            this.ffAmPmCB.Name = "ffAmPmCB";
            this.ffAmPmCB.Size = new System.Drawing.Size(43, 21);
            this.ffAmPmCB.TabIndex = 5;
            this.ffAmPmCB.Text = "AM";
            // 
            // ffStartTimeMTB
            // 
            this.ffStartTimeMTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ffStartTimeMTB.Location = new System.Drawing.Point(95, 3);
            this.ffStartTimeMTB.Mask = "90:00";
            this.ffStartTimeMTB.Name = "ffStartTimeMTB";
            this.ffStartTimeMTB.Size = new System.Drawing.Size(37, 13);
            this.ffStartTimeMTB.TabIndex = 4;
            this.ffStartTimeMTB.ValidatingType = typeof(System.DateTime);
            // 
            // firstFlightStartTimeLBL
            // 
            this.firstFlightStartTimeLBL.AutoSize = true;
            this.firstFlightStartTimeLBL.Location = new System.Drawing.Point(6, 3);
            this.firstFlightStartTimeLBL.Name = "firstFlightStartTimeLBL";
            this.firstFlightStartTimeLBL.Size = new System.Drawing.Size(83, 13);
            this.firstFlightStartTimeLBL.TabIndex = 0;
            this.firstFlightStartTimeLBL.Text = "Flight Start Time";
            // 
            // secondFlightTP
            // 
            this.secondFlightTP.Controls.Add(this.secondFlightTB);
            this.secondFlightTP.Controls.Add(this.amPm2CB);
            this.secondFlightTP.Controls.Add(this.maskedTextBox2);
            this.secondFlightTP.Controls.Add(this.secondFlightStartTimeLBL);
            this.secondFlightTP.Location = new System.Drawing.Point(4, 22);
            this.secondFlightTP.Name = "secondFlightTP";
            this.secondFlightTP.Padding = new System.Windows.Forms.Padding(3);
            this.secondFlightTP.Size = new System.Drawing.Size(271, 217);
            this.secondFlightTP.TabIndex = 1;
            this.secondFlightTP.Text = "SecondFlight";
            this.secondFlightTP.UseVisualStyleBackColor = true;
            // 
            // secondFlightTB
            // 
            this.secondFlightTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.secondFlightTB.Location = new System.Drawing.Point(3, 24);
            this.secondFlightTB.Multiline = true;
            this.secondFlightTB.Name = "secondFlightTB";
            this.secondFlightTB.Size = new System.Drawing.Size(265, 190);
            this.secondFlightTB.TabIndex = 11;
            // 
            // amPm2CB
            // 
            this.amPm2CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.amPm2CB.FormattingEnabled = true;
            this.amPm2CB.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.amPm2CB.Location = new System.Drawing.Point(138, 0);
            this.amPm2CB.Name = "amPm2CB";
            this.amPm2CB.Size = new System.Drawing.Size(43, 21);
            this.amPm2CB.TabIndex = 10;
            this.amPm2CB.Text = "AM";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Location = new System.Drawing.Point(95, 3);
            this.maskedTextBox2.Mask = "90:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(37, 13);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // secondFlightStartTimeLBL
            // 
            this.secondFlightStartTimeLBL.AutoSize = true;
            this.secondFlightStartTimeLBL.Location = new System.Drawing.Point(6, 3);
            this.secondFlightStartTimeLBL.Name = "secondFlightStartTimeLBL";
            this.secondFlightStartTimeLBL.Size = new System.Drawing.Size(83, 13);
            this.secondFlightStartTimeLBL.TabIndex = 1;
            this.secondFlightStartTimeLBL.Text = "Flight Start Time";
            // 
            // thirdFlightTP
            // 
            this.thirdFlightTP.Controls.Add(this.thirdFlightTB);
            this.thirdFlightTP.Controls.Add(this.comboBox7);
            this.thirdFlightTP.Controls.Add(this.maskedTextBox3);
            this.thirdFlightTP.Controls.Add(this.thirdFlightStartTimeLBL);
            this.thirdFlightTP.Location = new System.Drawing.Point(4, 22);
            this.thirdFlightTP.Name = "thirdFlightTP";
            this.thirdFlightTP.Padding = new System.Windows.Forms.Padding(3);
            this.thirdFlightTP.Size = new System.Drawing.Size(271, 217);
            this.thirdFlightTP.TabIndex = 2;
            this.thirdFlightTP.Text = "Third Flight";
            this.thirdFlightTP.UseVisualStyleBackColor = true;
            // 
            // thirdFlightTB
            // 
            this.thirdFlightTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.thirdFlightTB.Location = new System.Drawing.Point(3, 24);
            this.thirdFlightTB.Multiline = true;
            this.thirdFlightTB.Name = "thirdFlightTB";
            this.thirdFlightTB.Size = new System.Drawing.Size(265, 190);
            this.thirdFlightTB.TabIndex = 16;
            // 
            // comboBox7
            // 
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox7.Location = new System.Drawing.Point(138, 0);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(43, 21);
            this.comboBox7.TabIndex = 15;
            this.comboBox7.Text = "AM";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox3.Location = new System.Drawing.Point(95, 3);
            this.maskedTextBox3.Mask = "90:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(37, 13);
            this.maskedTextBox3.TabIndex = 14;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // thirdFlightStartTimeLBL
            // 
            this.thirdFlightStartTimeLBL.AutoSize = true;
            this.thirdFlightStartTimeLBL.Location = new System.Drawing.Point(6, 3);
            this.thirdFlightStartTimeLBL.Name = "thirdFlightStartTimeLBL";
            this.thirdFlightStartTimeLBL.Size = new System.Drawing.Size(83, 13);
            this.thirdFlightStartTimeLBL.TabIndex = 1;
            this.thirdFlightStartTimeLBL.Text = "Flight Start Time";
            // 
            // fourthFlightTP
            // 
            this.fourthFlightTP.Controls.Add(this.fourthFlightTB);
            this.fourthFlightTP.Controls.Add(this.comboBox8);
            this.fourthFlightTP.Controls.Add(this.maskedTextBox4);
            this.fourthFlightTP.Controls.Add(this.fourthFlightStartTimeLBL);
            this.fourthFlightTP.Location = new System.Drawing.Point(4, 22);
            this.fourthFlightTP.Name = "fourthFlightTP";
            this.fourthFlightTP.Padding = new System.Windows.Forms.Padding(3);
            this.fourthFlightTP.Size = new System.Drawing.Size(271, 217);
            this.fourthFlightTP.TabIndex = 3;
            this.fourthFlightTP.Text = "Fourth Flight";
            this.fourthFlightTP.UseVisualStyleBackColor = true;
            // 
            // fourthFlightTB
            // 
            this.fourthFlightTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fourthFlightTB.Location = new System.Drawing.Point(3, 24);
            this.fourthFlightTB.Multiline = true;
            this.fourthFlightTB.Name = "fourthFlightTB";
            this.fourthFlightTB.Size = new System.Drawing.Size(265, 190);
            this.fourthFlightTB.TabIndex = 16;
            // 
            // comboBox8
            // 
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox8.Location = new System.Drawing.Point(138, 0);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(43, 21);
            this.comboBox8.TabIndex = 15;
            this.comboBox8.Text = "AM";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox4.Location = new System.Drawing.Point(95, 3);
            this.maskedTextBox4.Mask = "90:00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(37, 13);
            this.maskedTextBox4.TabIndex = 19;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // fourthFlightStartTimeLBL
            // 
            this.fourthFlightStartTimeLBL.AutoSize = true;
            this.fourthFlightStartTimeLBL.Location = new System.Drawing.Point(6, 3);
            this.fourthFlightStartTimeLBL.Name = "fourthFlightStartTimeLBL";
            this.fourthFlightStartTimeLBL.Size = new System.Drawing.Size(83, 13);
            this.fourthFlightStartTimeLBL.TabIndex = 1;
            this.fourthFlightStartTimeLBL.Text = "Flight Start Time";
            // 
            // TimeEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 284);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.printBTN);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flightTimeTotalLBL);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TimeEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Enter Times";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.commentsTC.ResumeLayout(false);
            this.firstFlightTP.ResumeLayout(false);
            this.firstFlightTP.PerformLayout();
            this.secondFlightTP.ResumeLayout(false);
            this.secondFlightTP.PerformLayout();
            this.thirdFlightTP.ResumeLayout(false);
            this.thirdFlightTP.PerformLayout();
            this.fourthFlightTP.ResumeLayout(false);
            this.fourthFlightTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox flightTimeBox1;
        private System.Windows.Forms.TextBox flightTimeBox2;
        private System.Windows.Forms.TextBox flightTimeBox3;
        private System.Windows.Forms.Label flightTimeTotalLBL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button printBTN;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox flightTimeBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl commentsTC;
        private System.Windows.Forms.TabPage firstFlightTP;
        private System.Windows.Forms.Label firstFlightStartTimeLBL;
        private System.Windows.Forms.TabPage secondFlightTP;
        private System.Windows.Forms.Label secondFlightStartTimeLBL;
        private System.Windows.Forms.TabPage thirdFlightTP;
        private System.Windows.Forms.Label thirdFlightStartTimeLBL;
        private System.Windows.Forms.TabPage fourthFlightTP;
        private System.Windows.Forms.Label fourthFlightStartTimeLBL;
        private System.Windows.Forms.MaskedTextBox ffStartTimeMTB;
        private System.Windows.Forms.ComboBox ffAmPmCB;
        private System.Windows.Forms.ComboBox amPm2CB;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TextBox ffTB;
        private System.Windows.Forms.TextBox secondFlightTB;
        private System.Windows.Forms.TextBox thirdFlightTB;
        private System.Windows.Forms.TextBox fourthFlightTB;
    }
}