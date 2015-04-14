namespace CrewMemberGradeSlip
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
            this.LBLname = new System.Windows.Forms.Label();
            this.LBLrank = new System.Windows.Forms.Label();
            this.LBLpid = new System.Windows.Forms.Label();
            this.LBLunit = new System.Windows.Forms.Label();
            this.LBLpurpose = new System.Windows.Forms.Label();
            this.LBLactype = new System.Windows.Forms.Label();
            this.LBLstartdate = new System.Windows.Forms.Label();
            this.LBLcompleteby = new System.Windows.Forms.Label();
            this.GBstudentinfo = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBactype = new System.Windows.Forms.ComboBox();
            this.CBpid = new System.Windows.Forms.ComboBox();
            this.CBrank = new System.Windows.Forms.ComboBox();
            this.BTNenter = new System.Windows.Forms.Button();
            this.DTPstartdate = new System.Windows.Forms.DateTimePicker();
            this.DTPcompletebydate = new System.Windows.Forms.DateTimePicker();
            this.TBpurpose = new System.Windows.Forms.TextBox();
            this.TBunit = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBstudentinfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLname
            // 
            this.LBLname.AutoSize = true;
            this.LBLname.Location = new System.Drawing.Point(6, 21);
            this.LBLname.Name = "LBLname";
            this.LBLname.Size = new System.Drawing.Size(38, 13);
            this.LBLname.TabIndex = 0;
            this.LBLname.Text = "Name:";
            // 
            // LBLrank
            // 
            this.LBLrank.AutoSize = true;
            this.LBLrank.Location = new System.Drawing.Point(6, 51);
            this.LBLrank.Name = "LBLrank";
            this.LBLrank.Size = new System.Drawing.Size(36, 13);
            this.LBLrank.TabIndex = 1;
            this.LBLrank.Text = "Rank:";
            // 
            // LBLpid
            // 
            this.LBLpid.AutoSize = true;
            this.LBLpid.Location = new System.Drawing.Point(6, 81);
            this.LBLpid.Name = "LBLpid";
            this.LBLpid.Size = new System.Drawing.Size(28, 13);
            this.LBLpid.TabIndex = 2;
            this.LBLpid.Text = "PID:";
            // 
            // LBLunit
            // 
            this.LBLunit.AutoSize = true;
            this.LBLunit.Location = new System.Drawing.Point(6, 111);
            this.LBLunit.Name = "LBLunit";
            this.LBLunit.Size = new System.Drawing.Size(29, 13);
            this.LBLunit.TabIndex = 3;
            this.LBLunit.Text = "Unit:";
            // 
            // LBLpurpose
            // 
            this.LBLpurpose.AutoSize = true;
            this.LBLpurpose.Location = new System.Drawing.Point(6, 141);
            this.LBLpurpose.Name = "LBLpurpose";
            this.LBLpurpose.Size = new System.Drawing.Size(49, 13);
            this.LBLpurpose.TabIndex = 4;
            this.LBLpurpose.Text = "Purpose:";
            // 
            // LBLactype
            // 
            this.LBLactype.AutoSize = true;
            this.LBLactype.Location = new System.Drawing.Point(6, 171);
            this.LBLactype.Name = "LBLactype";
            this.LBLactype.Size = new System.Drawing.Size(66, 13);
            this.LBLactype.TabIndex = 5;
            this.LBLactype.Text = "Aircraft type:";
            // 
            // LBLstartdate
            // 
            this.LBLstartdate.AutoSize = true;
            this.LBLstartdate.Location = new System.Drawing.Point(6, 201);
            this.LBLstartdate.Name = "LBLstartdate";
            this.LBLstartdate.Size = new System.Drawing.Size(68, 13);
            this.LBLstartdate.TabIndex = 6;
            this.LBLstartdate.Text = "Date started:";
            // 
            // LBLcompleteby
            // 
            this.LBLcompleteby.AutoSize = true;
            this.LBLcompleteby.Location = new System.Drawing.Point(6, 231);
            this.LBLcompleteby.Name = "LBLcompleteby";
            this.LBLcompleteby.Size = new System.Drawing.Size(93, 13);
            this.LBLcompleteby.TabIndex = 7;
            this.LBLcompleteby.Text = "Must complete by:";
            // 
            // GBstudentinfo
            // 
            this.GBstudentinfo.Controls.Add(this.comboBox1);
            this.GBstudentinfo.Controls.Add(this.simCB);
            this.GBstudentinfo.Controls.Add(this.label1);
            this.GBstudentinfo.Controls.Add(this.CBactype);
            this.GBstudentinfo.Controls.Add(this.CBpid);
            this.GBstudentinfo.Controls.Add(this.CBrank);
            this.GBstudentinfo.Controls.Add(this.BTNenter);
            this.GBstudentinfo.Controls.Add(this.DTPstartdate);
            this.GBstudentinfo.Controls.Add(this.DTPcompletebydate);
            this.GBstudentinfo.Controls.Add(this.TBpurpose);
            this.GBstudentinfo.Controls.Add(this.TBunit);
            this.GBstudentinfo.Controls.Add(this.TBname);
            this.GBstudentinfo.Controls.Add(this.LBLcompleteby);
            this.GBstudentinfo.Controls.Add(this.LBLname);
            this.GBstudentinfo.Controls.Add(this.LBLstartdate);
            this.GBstudentinfo.Controls.Add(this.LBLrank);
            this.GBstudentinfo.Controls.Add(this.LBLactype);
            this.GBstudentinfo.Controls.Add(this.LBLpid);
            this.GBstudentinfo.Controls.Add(this.LBLpurpose);
            this.GBstudentinfo.Controls.Add(this.LBLunit);
            this.GBstudentinfo.Location = new System.Drawing.Point(12, 38);
            this.GBstudentinfo.Name = "GBstudentinfo";
            this.GBstudentinfo.Size = new System.Drawing.Size(323, 366);
            this.GBstudentinfo.TabIndex = 8;
            this.GBstudentinfo.TabStop = false;
            this.GBstudentinfo.Text = "New Student Entry";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pilot/Co-Pilot",
            "AGPO",
            "GEOINT",
            "Evaluator",
            "Maintainer",
            "Instructor"});
            this.comboBox1.Location = new System.Drawing.Point(86, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // simCB
            // 
            this.simCB.AutoSize = true;
            this.simCB.Location = new System.Drawing.Point(225, 170);
            this.simCB.Name = "simCB";
            this.simCB.Size = new System.Drawing.Size(69, 17);
            this.simCB.TabIndex = 7;
            this.simCB.Text = "Simulator";
            this.simCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Crew Position:";
            // 
            // CBactype
            // 
            this.CBactype.FormattingEnabled = true;
            this.CBactype.Items.AddRange(new object[] {
            "C-12",
            "B-200",
            "B-350",
            "PC-12",
            "EMARSS",
            "MARSS",
            "Liberty",
            "Dash 6",
            "Dash 7",
            "Dash 8"});
            this.CBactype.Location = new System.Drawing.Point(78, 168);
            this.CBactype.Name = "CBactype";
            this.CBactype.Size = new System.Drawing.Size(121, 21);
            this.CBactype.TabIndex = 6;
            // 
            // CBpid
            // 
            this.CBpid.FormattingEnabled = true;
            this.CBpid.Items.AddRange(new object[] {
            "My PID"});
            this.CBpid.Location = new System.Drawing.Point(50, 78);
            this.CBpid.Name = "CBpid";
            this.CBpid.Size = new System.Drawing.Size(121, 21);
            this.CBpid.TabIndex = 3;
            // 
            // CBrank
            // 
            this.CBrank.FormattingEnabled = true;
            this.CBrank.Items.AddRange(new object[] {
            "E-1",
            "E-2",
            "E-3",
            "E-4",
            "E-5",
            "E-6",
            "E-7",
            "E-8",
            "E-9",
            "W-1",
            "W-2",
            "W-3",
            "W-4",
            "W-5",
            "O-1",
            "O-2",
            "O-3",
            "O-4",
            "O-5",
            "O-6",
            "O-7",
            "O-8",
            "O-9",
            "O-10",
            "Contractor",
            "DAC",
            "Foreign National"});
            this.CBrank.Location = new System.Drawing.Point(50, 48);
            this.CBrank.Name = "CBrank";
            this.CBrank.Size = new System.Drawing.Size(121, 21);
            this.CBrank.TabIndex = 2;
            // 
            // BTNenter
            // 
            this.BTNenter.Location = new System.Drawing.Point(124, 324);
            this.BTNenter.Name = "BTNenter";
            this.BTNenter.Size = new System.Drawing.Size(75, 23);
            this.BTNenter.TabIndex = 11;
            this.BTNenter.Text = "ENTER";
            this.BTNenter.UseVisualStyleBackColor = true;
            this.BTNenter.Click += new System.EventHandler(this.BTNenter_Click);
            // 
            // DTPstartdate
            // 
            this.DTPstartdate.CustomFormat = "dd MMM yyyy";
            this.DTPstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPstartdate.Location = new System.Drawing.Point(78, 198);
            this.DTPstartdate.Name = "DTPstartdate";
            this.DTPstartdate.Size = new System.Drawing.Size(200, 20);
            this.DTPstartdate.TabIndex = 8;
            this.DTPstartdate.ValueChanged += new System.EventHandler(this.InitializeEndDate);
            // 
            // DTPcompletebydate
            // 
            this.DTPcompletebydate.CustomFormat = "dd MMM yyyy";
            this.DTPcompletebydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPcompletebydate.Location = new System.Drawing.Point(105, 228);
            this.DTPcompletebydate.Name = "DTPcompletebydate";
            this.DTPcompletebydate.Size = new System.Drawing.Size(200, 20);
            this.DTPcompletebydate.TabIndex = 9;
            this.DTPcompletebydate.ValueChanged += new System.EventHandler(this.DTPcompletebydate_ValueChanged);
            // 
            // TBpurpose
            // 
            this.TBpurpose.Location = new System.Drawing.Point(61, 138);
            this.TBpurpose.Name = "TBpurpose";
            this.TBpurpose.Size = new System.Drawing.Size(244, 20);
            this.TBpurpose.TabIndex = 5;
            // 
            // TBunit
            // 
            this.TBunit.Location = new System.Drawing.Point(50, 108);
            this.TBunit.Name = "TBunit";
            this.TBunit.Size = new System.Drawing.Size(255, 20);
            this.TBunit.TabIndex = 4;
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(50, 18);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(255, 20);
            this.TBname.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentSearchToolStripMenuItem
            // 
            this.studentSearchToolStripMenuItem.Name = "studentSearchToolStripMenuItem";
            this.studentSearchToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.studentSearchToolStripMenuItem.Text = "DataBase Search";
            this.studentSearchToolStripMenuItem.Click += new System.EventHandler(this.studentSearchToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 416);
            this.Controls.Add(this.GBstudentinfo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crew Member Grade Slip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GBstudentinfo.ResumeLayout(false);
            this.GBstudentinfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLname;
        private System.Windows.Forms.Label LBLrank;
        private System.Windows.Forms.Label LBLpid;
        private System.Windows.Forms.Label LBLunit;
        private System.Windows.Forms.Label LBLpurpose;
        private System.Windows.Forms.Label LBLactype;
        private System.Windows.Forms.Label LBLstartdate;
        private System.Windows.Forms.Label LBLcompleteby;
        private System.Windows.Forms.GroupBox GBstudentinfo;
        private System.Windows.Forms.DateTimePicker DTPstartdate;
        private System.Windows.Forms.DateTimePicker DTPcompletebydate;
        private System.Windows.Forms.TextBox TBpurpose;
        private System.Windows.Forms.TextBox TBunit;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Button BTNenter;
        private System.Windows.Forms.ComboBox CBrank;
        private System.Windows.Forms.ComboBox CBactype;
        private System.Windows.Forms.ComboBox CBpid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentSearchToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox simCB;
    }
}

