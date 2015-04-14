namespace CrewMemberGradeSlip
{
    partial class SearchForm
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
            System.Windows.Forms.Label studentPIDLabel;
            System.Windows.Forms.Label studentNameLabel;
            System.Windows.Forms.Label studentRankLabel;
            System.Windows.Forms.Label studentUnitLabel;
            System.Windows.Forms.Label studentPurposeLabel;
            System.Windows.Forms.Label studentACtypeLabel;
            System.Windows.Forms.Label dateSartedLabel;
            System.Windows.Forms.Label mustCompleteByLabel;
            System.Windows.Forms.Label entryNumberLabel;
            System.Windows.Forms.Label flightIdLabel;
            System.Windows.Forms.Label timeTodayLabel;
            System.Windows.Forms.Label cumulativeTimeLabel;
            System.Windows.Forms.Label dayFlightTodayLabel;
            System.Windows.Forms.Label dayFlightCumulativeLabel;
            System.Windows.Forms.Label flightDateLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSISstudentsDataSet = new CrewMemberGradeSlip.ISISstudentsDataSet();
            this.studentsTableAdapter = new CrewMemberGradeSlip.ISISstudentsDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new CrewMemberGradeSlip.ISISstudentsDataSetTableAdapters.TableAdapterManager();
            this.studentPIDTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentRankTextBox = new System.Windows.Forms.TextBox();
            this.studentUnitTextBox = new System.Windows.Forms.TextBox();
            this.studentPurposeTextBox = new System.Windows.Forms.TextBox();
            this.studentACtypeTextBox = new System.Windows.Forms.TextBox();
            this.dateSartedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mustCompleteByDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.entryNumberTextBox = new System.Windows.Forms.TextBox();
            this.flightDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightDataTableAdapter = new CrewMemberGradeSlip.ISISstudentsDataSetTableAdapters.FlightDataTableAdapter();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.timeTodayTextBox = new System.Windows.Forms.TextBox();
            this.cumulativeTimeTextBox = new System.Windows.Forms.TextBox();
            this.dayFlightTodayTextBox = new System.Windows.Forms.TextBox();
            this.dayFlightCumulativeTextBox = new System.Windows.Forms.TextBox();
            this.flightDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            studentPIDLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            studentRankLabel = new System.Windows.Forms.Label();
            studentUnitLabel = new System.Windows.Forms.Label();
            studentPurposeLabel = new System.Windows.Forms.Label();
            studentACtypeLabel = new System.Windows.Forms.Label();
            dateSartedLabel = new System.Windows.Forms.Label();
            mustCompleteByLabel = new System.Windows.Forms.Label();
            entryNumberLabel = new System.Windows.Forms.Label();
            flightIdLabel = new System.Windows.Forms.Label();
            timeTodayLabel = new System.Windows.Forms.Label();
            cumulativeTimeLabel = new System.Windows.Forms.Label();
            dayFlightTodayLabel = new System.Windows.Forms.Label();
            dayFlightCumulativeLabel = new System.Windows.Forms.Label();
            flightDateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSISstudentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search For:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(266, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Data Entry";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 1;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.iSISstudentsDataSet;
            // 
            // iSISstudentsDataSet
            // 
            this.iSISstudentsDataSet.DataSetName = "ISISstudentsDataSet";
            this.iSISstudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FlightDataTableAdapter = this.flightDataTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CrewMemberGradeSlip.ISISstudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentPIDLabel
            // 
            studentPIDLabel.AutoSize = true;
            studentPIDLabel.Location = new System.Drawing.Point(12, 9);
            studentPIDLabel.Name = "studentPIDLabel";
            studentPIDLabel.Size = new System.Drawing.Size(68, 13);
            studentPIDLabel.TabIndex = 1;
            studentPIDLabel.Text = "Student PID:";
            // 
            // studentPIDTextBox
            // 
            this.studentPIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentPID", true));
            this.studentPIDTextBox.Location = new System.Drawing.Point(113, 6);
            this.studentPIDTextBox.Name = "studentPIDTextBox";
            this.studentPIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentPIDTextBox.TabIndex = 2;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(12, 35);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(78, 13);
            studentNameLabel.TabIndex = 3;
            studentNameLabel.Text = "Student Name:";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentName", true));
            this.studentNameTextBox.Location = new System.Drawing.Point(113, 32);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentNameTextBox.TabIndex = 4;
            // 
            // studentRankLabel
            // 
            studentRankLabel.AutoSize = true;
            studentRankLabel.Location = new System.Drawing.Point(12, 61);
            studentRankLabel.Name = "studentRankLabel";
            studentRankLabel.Size = new System.Drawing.Size(76, 13);
            studentRankLabel.TabIndex = 5;
            studentRankLabel.Text = "Student Rank:";
            // 
            // studentRankTextBox
            // 
            this.studentRankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentRank", true));
            this.studentRankTextBox.Location = new System.Drawing.Point(113, 58);
            this.studentRankTextBox.Name = "studentRankTextBox";
            this.studentRankTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentRankTextBox.TabIndex = 6;
            // 
            // studentUnitLabel
            // 
            studentUnitLabel.AutoSize = true;
            studentUnitLabel.Location = new System.Drawing.Point(12, 87);
            studentUnitLabel.Name = "studentUnitLabel";
            studentUnitLabel.Size = new System.Drawing.Size(69, 13);
            studentUnitLabel.TabIndex = 7;
            studentUnitLabel.Text = "Student Unit:";
            // 
            // studentUnitTextBox
            // 
            this.studentUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentUnit", true));
            this.studentUnitTextBox.Location = new System.Drawing.Point(113, 84);
            this.studentUnitTextBox.Name = "studentUnitTextBox";
            this.studentUnitTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentUnitTextBox.TabIndex = 8;
            // 
            // studentPurposeLabel
            // 
            studentPurposeLabel.AutoSize = true;
            studentPurposeLabel.Location = new System.Drawing.Point(12, 113);
            studentPurposeLabel.Name = "studentPurposeLabel";
            studentPurposeLabel.Size = new System.Drawing.Size(89, 13);
            studentPurposeLabel.TabIndex = 9;
            studentPurposeLabel.Text = "Student Purpose:";
            // 
            // studentPurposeTextBox
            // 
            this.studentPurposeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentPurpose", true));
            this.studentPurposeTextBox.Location = new System.Drawing.Point(113, 110);
            this.studentPurposeTextBox.Name = "studentPurposeTextBox";
            this.studentPurposeTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentPurposeTextBox.TabIndex = 10;
            // 
            // studentACtypeLabel
            // 
            studentACtypeLabel.AutoSize = true;
            studentACtypeLabel.Location = new System.Drawing.Point(12, 139);
            studentACtypeLabel.Name = "studentACtypeLabel";
            studentACtypeLabel.Size = new System.Drawing.Size(84, 13);
            studentACtypeLabel.TabIndex = 11;
            studentACtypeLabel.Text = "Student ACtype:";
            // 
            // studentACtypeTextBox
            // 
            this.studentACtypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentACtype", true));
            this.studentACtypeTextBox.Location = new System.Drawing.Point(113, 136);
            this.studentACtypeTextBox.Name = "studentACtypeTextBox";
            this.studentACtypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentACtypeTextBox.TabIndex = 12;
            // 
            // dateSartedLabel
            // 
            dateSartedLabel.AutoSize = true;
            dateSartedLabel.Location = new System.Drawing.Point(12, 166);
            dateSartedLabel.Name = "dateSartedLabel";
            dateSartedLabel.Size = new System.Drawing.Size(67, 13);
            dateSartedLabel.TabIndex = 13;
            dateSartedLabel.Text = "Date Sarted:";
            // 
            // dateSartedDateTimePicker
            // 
            this.dateSartedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "DateSarted", true));
            this.dateSartedDateTimePicker.Location = new System.Drawing.Point(113, 162);
            this.dateSartedDateTimePicker.Name = "dateSartedDateTimePicker";
            this.dateSartedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateSartedDateTimePicker.TabIndex = 14;
            // 
            // mustCompleteByLabel
            // 
            mustCompleteByLabel.AutoSize = true;
            mustCompleteByLabel.Location = new System.Drawing.Point(12, 192);
            mustCompleteByLabel.Name = "mustCompleteByLabel";
            mustCompleteByLabel.Size = new System.Drawing.Size(95, 13);
            mustCompleteByLabel.TabIndex = 15;
            mustCompleteByLabel.Text = "Must Complete By:";
            // 
            // mustCompleteByDateTimePicker
            // 
            this.mustCompleteByDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "MustCompleteBy", true));
            this.mustCompleteByDateTimePicker.Location = new System.Drawing.Point(113, 188);
            this.mustCompleteByDateTimePicker.Name = "mustCompleteByDateTimePicker";
            this.mustCompleteByDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.mustCompleteByDateTimePicker.TabIndex = 16;
            // 
            // entryNumberLabel
            // 
            entryNumberLabel.AutoSize = true;
            entryNumberLabel.Location = new System.Drawing.Point(12, 217);
            entryNumberLabel.Name = "entryNumberLabel";
            entryNumberLabel.Size = new System.Drawing.Size(74, 13);
            entryNumberLabel.TabIndex = 17;
            entryNumberLabel.Text = "Entry Number:";
            // 
            // entryNumberTextBox
            // 
            this.entryNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "EntryNumber", true));
            this.entryNumberTextBox.Location = new System.Drawing.Point(113, 214);
            this.entryNumberTextBox.Name = "entryNumberTextBox";
            this.entryNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.entryNumberTextBox.TabIndex = 18;
            // 
            // flightDataBindingSource
            // 
            this.flightDataBindingSource.DataMember = "FlightData";
            this.flightDataBindingSource.DataSource = this.iSISstudentsDataSet;
            // 
            // flightDataTableAdapter
            // 
            this.flightDataTableAdapter.ClearBeforeFill = true;
            // 
            // flightIdLabel
            // 
            flightIdLabel.AutoSize = true;
            flightIdLabel.Location = new System.Drawing.Point(338, 9);
            flightIdLabel.Name = "flightIdLabel";
            flightIdLabel.Size = new System.Drawing.Size(47, 13);
            flightIdLabel.TabIndex = 19;
            flightIdLabel.Text = "Flight Id:";
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightDataBindingSource, "FlightId", true));
            this.flightIdTextBox.Location = new System.Drawing.Point(456, 6);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.flightIdTextBox.TabIndex = 20;
            // 
            // timeTodayLabel
            // 
            timeTodayLabel.AutoSize = true;
            timeTodayLabel.Location = new System.Drawing.Point(338, 35);
            timeTodayLabel.Name = "timeTodayLabel";
            timeTodayLabel.Size = new System.Drawing.Size(66, 13);
            timeTodayLabel.TabIndex = 21;
            timeTodayLabel.Text = "Time Today:";
            // 
            // timeTodayTextBox
            // 
            this.timeTodayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightDataBindingSource, "TimeToday", true));
            this.timeTodayTextBox.Location = new System.Drawing.Point(456, 32);
            this.timeTodayTextBox.Name = "timeTodayTextBox";
            this.timeTodayTextBox.Size = new System.Drawing.Size(200, 20);
            this.timeTodayTextBox.TabIndex = 22;
            // 
            // cumulativeTimeLabel
            // 
            cumulativeTimeLabel.AutoSize = true;
            cumulativeTimeLabel.Location = new System.Drawing.Point(338, 61);
            cumulativeTimeLabel.Name = "cumulativeTimeLabel";
            cumulativeTimeLabel.Size = new System.Drawing.Size(88, 13);
            cumulativeTimeLabel.TabIndex = 23;
            cumulativeTimeLabel.Text = "Cumulative Time:";
            // 
            // cumulativeTimeTextBox
            // 
            this.cumulativeTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightDataBindingSource, "CumulativeTime", true));
            this.cumulativeTimeTextBox.Location = new System.Drawing.Point(456, 58);
            this.cumulativeTimeTextBox.Name = "cumulativeTimeTextBox";
            this.cumulativeTimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cumulativeTimeTextBox.TabIndex = 24;
            // 
            // dayFlightTodayLabel
            // 
            dayFlightTodayLabel.AutoSize = true;
            dayFlightTodayLabel.Location = new System.Drawing.Point(338, 87);
            dayFlightTodayLabel.Name = "dayFlightTodayLabel";
            dayFlightTodayLabel.Size = new System.Drawing.Size(90, 13);
            dayFlightTodayLabel.TabIndex = 25;
            dayFlightTodayLabel.Text = "Day Flight Today:";
            // 
            // dayFlightTodayTextBox
            // 
            this.dayFlightTodayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightDataBindingSource, "DayFlightToday", true));
            this.dayFlightTodayTextBox.Location = new System.Drawing.Point(456, 84);
            this.dayFlightTodayTextBox.Name = "dayFlightTodayTextBox";
            this.dayFlightTodayTextBox.Size = new System.Drawing.Size(200, 20);
            this.dayFlightTodayTextBox.TabIndex = 26;
            // 
            // dayFlightCumulativeLabel
            // 
            dayFlightCumulativeLabel.AutoSize = true;
            dayFlightCumulativeLabel.Location = new System.Drawing.Point(338, 113);
            dayFlightCumulativeLabel.Name = "dayFlightCumulativeLabel";
            dayFlightCumulativeLabel.Size = new System.Drawing.Size(112, 13);
            dayFlightCumulativeLabel.TabIndex = 27;
            dayFlightCumulativeLabel.Text = "Day Flight Cumulative:";
            // 
            // dayFlightCumulativeTextBox
            // 
            this.dayFlightCumulativeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightDataBindingSource, "DayFlightCumulative", true));
            this.dayFlightCumulativeTextBox.Location = new System.Drawing.Point(456, 110);
            this.dayFlightCumulativeTextBox.Name = "dayFlightCumulativeTextBox";
            this.dayFlightCumulativeTextBox.Size = new System.Drawing.Size(200, 20);
            this.dayFlightCumulativeTextBox.TabIndex = 28;
            // 
            // flightDateLabel
            // 
            flightDateLabel.AutoSize = true;
            flightDateLabel.Location = new System.Drawing.Point(338, 140);
            flightDateLabel.Name = "flightDateLabel";
            flightDateLabel.Size = new System.Drawing.Size(61, 13);
            flightDateLabel.TabIndex = 29;
            flightDateLabel.Text = "Flight Date:";
            // 
            // flightDateDateTimePicker
            // 
            this.flightDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flightDataBindingSource, "FlightDate", true));
            this.flightDateDateTimePicker.Location = new System.Drawing.Point(456, 136);
            this.flightDateDateTimePicker.Name = "flightDateDateTimePicker";
            this.flightDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.flightDateDateTimePicker.TabIndex = 30;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 381);
            this.Controls.Add(flightIdLabel);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(timeTodayLabel);
            this.Controls.Add(this.timeTodayTextBox);
            this.Controls.Add(cumulativeTimeLabel);
            this.Controls.Add(this.cumulativeTimeTextBox);
            this.Controls.Add(dayFlightTodayLabel);
            this.Controls.Add(this.dayFlightTodayTextBox);
            this.Controls.Add(dayFlightCumulativeLabel);
            this.Controls.Add(this.dayFlightCumulativeTextBox);
            this.Controls.Add(flightDateLabel);
            this.Controls.Add(this.flightDateDateTimePicker);
            this.Controls.Add(studentPIDLabel);
            this.Controls.Add(this.studentPIDTextBox);
            this.Controls.Add(studentNameLabel);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(studentRankLabel);
            this.Controls.Add(this.studentRankTextBox);
            this.Controls.Add(studentUnitLabel);
            this.Controls.Add(this.studentUnitTextBox);
            this.Controls.Add(studentPurposeLabel);
            this.Controls.Add(this.studentPurposeTextBox);
            this.Controls.Add(studentACtypeLabel);
            this.Controls.Add(this.studentACtypeTextBox);
            this.Controls.Add(dateSartedLabel);
            this.Controls.Add(this.dateSartedDateTimePicker);
            this.Controls.Add(mustCompleteByLabel);
            this.Controls.Add(this.mustCompleteByDateTimePicker);
            this.Controls.Add(entryNumberLabel);
            this.Controls.Add(this.entryNumberTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSISstudentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private ISISstudentsDataSet iSISstudentsDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private ISISstudentsDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private ISISstudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ISISstudentsDataSetTableAdapters.FlightDataTableAdapter flightDataTableAdapter;
        private System.Windows.Forms.TextBox studentPIDTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentRankTextBox;
        private System.Windows.Forms.TextBox studentUnitTextBox;
        private System.Windows.Forms.TextBox studentPurposeTextBox;
        private System.Windows.Forms.TextBox studentACtypeTextBox;
        private System.Windows.Forms.DateTimePicker dateSartedDateTimePicker;
        private System.Windows.Forms.DateTimePicker mustCompleteByDateTimePicker;
        private System.Windows.Forms.TextBox entryNumberTextBox;
        private System.Windows.Forms.BindingSource flightDataBindingSource;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.TextBox timeTodayTextBox;
        private System.Windows.Forms.TextBox cumulativeTimeTextBox;
        private System.Windows.Forms.TextBox dayFlightTodayTextBox;
        private System.Windows.Forms.TextBox dayFlightCumulativeTextBox;
        private System.Windows.Forms.DateTimePicker flightDateDateTimePicker;
    }
}