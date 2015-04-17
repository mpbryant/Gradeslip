using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Printing;
using System.Drawing.Printing;

namespace CrewMemberGradeSlip
{
    public partial class TimeEntryForm : Form
    {
        private string flightDate;
        private string flightTimeTotal;
        private string dayFlightTime1;
        private string nightFlightTime1;
        private string nvgFlightTime1;
        private string dayFlightTime2;
        private string nightFlightTime2;
        private string nvgFlightTime2;
        private string dayFlightTime3;
        private string nightFlightTime3;
        private string nvgFlightTime3;
        private string dayFlightTime4;
        private string nightFlightTime4;
        private string nvgFlightTime4;
        private string ffStartTime;
        private string ffAmPm;
        private string comment;
        private string startTime2;
        private string amPm2;
        private string comment2;
        
        

        public TimeEntryForm()
        {
            InitializeComponent();


            
        }
        
        private void flightTimeBox1_TextChanged(object sender, EventArgs e)
        {

            
            try
            {

                Decimal totalTime = (decimal.Parse(flightTimeBox1.Text) + decimal.Parse(flightTimeBox2.Text) + decimal.Parse(flightTimeBox3.Text) + decimal.Parse(flightTimeBox4.Text));
                flightTimeTotalLBL.Text = totalTime.ToString();

                comboBox2.Enabled = true;
                flightTimeBox2.Enabled = true;
            }

            catch
            {
                MessageBox.Show("Time entry must be hours and tenths of hours in x.x format", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flightTimeBox1.Text = "0.0";
                comboBox2.Enabled = false;
                flightTimeBox2.Enabled = false;
            }
             
        }

        private void flightTimeBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Decimal totalTime = (decimal.Parse(flightTimeBox1.Text) + decimal.Parse(flightTimeBox2.Text) + decimal.Parse(flightTimeBox3.Text) + decimal.Parse(flightTimeBox4.Text));
                flightTimeTotalLBL.Text = totalTime.ToString();

                comboBox3.Enabled = true;
                flightTimeBox3.Enabled = true;

            }

            catch
            {
                MessageBox.Show("Time entry must be hours and tenths of hours in x.x format", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flightTimeBox2.Text = "0.0";
                comboBox3.Enabled = false;
                flightTimeBox3.Enabled = false;
            }
        }

        private void flightTimeBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Decimal totalTime = (decimal.Parse(flightTimeBox1.Text) + decimal.Parse(flightTimeBox2.Text) + decimal.Parse(flightTimeBox3.Text) + decimal.Parse(flightTimeBox4.Text));
                flightTimeTotalLBL.Text = totalTime.ToString();

                comboBox4.Enabled = true;
                flightTimeBox4.Enabled = true;

            }

            catch
            {
                MessageBox.Show("Time entry must be hours and tenths of hours in x.x format", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flightTimeBox3.Text = "0.0";
                comboBox4.Enabled = false;
                flightTimeBox4.Enabled = false;
            }
        }

        private void flightTimeBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Decimal totalTime = (decimal.Parse(flightTimeBox1.Text) + decimal.Parse(flightTimeBox2.Text) + decimal.Parse(flightTimeBox3.Text) + decimal.Parse(flightTimeBox4.Text));
                flightTimeTotalLBL.Text = totalTime.ToString();

            }

            catch
            {
                MessageBox.Show("Time entry must be hours and tenths of hours in x.x format", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flightTimeBox4.Text = "0.0";
                
            }
        }

        


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateBox1;
            dateBox1 = this.dateTimePicker1.Value;
            string date1;
            date1 = dateBox1.ToString("MM-dd-yy");
            

            
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

            //make sure the first flight is not 0.0
            if (flightTimeBox1.Text=="0.0")
            {
                MessageBox.Show("First flight must be longer than 0.0", "Zero Flight Time Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //get the day flight time from time entry form
            
            flightDate = dateTimePicker1.Text;
            flightTimeTotal = flightTimeTotalLBL.Text;






            //checks if the times are day, night, or nvg
            //first, determine what combobox1 has 
            
            switch (comboBox1.Text)
            {
                case "Day Flight Time":
                    dayFlightTime1 = flightTimeBox1.Text;//take the information from the associated flighttime box
                    break;
                case "Night Flight Time":
                    nightFlightTime1 = flightTimeBox1.Text;
                    break;
                case "NVG Flight Time":
                    nvgFlightTime1 = flightTimeBox1.Text;
                    break;
            }


            //checks if the times are day, night, or nvg
            //determine what combobox2 has 
            

            switch (comboBox2.Text)
            {
                case "Day Flight Time":
                    dayFlightTime2 = flightTimeBox2.Text;//take the information from the associated flighttime box
                    break;
                case "Night Flight Time":
                    nightFlightTime2 = flightTimeBox2.Text;
                    break;
                case "NVG Flight Time":
                    nvgFlightTime2 = flightTimeBox2.Text;
                    break;
            }

            //checks if the times are day, night, or nvg
            //determine what combobox3 has 


            switch (comboBox3.Text)
            {
                case "Day Flight Time":
                    dayFlightTime3 = flightTimeBox3.Text;//take the information from the associated flighttime box
                    break;
                case "Night Flight Time":
                    nightFlightTime3 = flightTimeBox3.Text;
                    break;
                case "NVG Flight Time":
                    nvgFlightTime3 = flightTimeBox3.Text;
                    break;
            }

            //checks if the times are day, night, or nvg
            //determine what combobox4 has 


            switch (comboBox4.Text)
            {
                case "Day Flight Time":
                    dayFlightTime4 = flightTimeBox4.Text;//take the information from the associated flighttime box
                    break;
                case "Night Flight Time":
                    nightFlightTime4 = flightTimeBox4.Text;
                    break;
                case "NVG Flight Time":
                    nvgFlightTime4 = flightTimeBox4.Text;
                    break;
            }


            #region Comment box logic
            //sets the variables from the time entry form so the GET statements can retrieve data

            ffStartTime = ffStartTimeMTB.Text;
            ffAmPm = ffAmPmCB.Text;
            comment = ffTB.Text;

            amPm2 = amPm2CB.Text;
            startTime2 = maskedTextBox2.Text;
            comment2 = secondFlightTB.Text;

            

            #endregion





            //display the information on the form
            Application.OpenForms.OfType<Form4507Page1>().First().Get4507Flights(flightDate);//sends the flight date to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetTotalTime(flightTimeTotal);//sends total flight time to the form
            
            Application.OpenForms.OfType<Form4507Page1>().First().GetDayFilghtTime(dayFlightTime1);//sends the day flight time of combobox1 to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetNightFilghtTime(nightFlightTime1);//sends the night flight time of combobox1 to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetNVGFilghtTime(nvgFlightTime1);//sends the nvg flight time of combobox1 to the form

            Application.OpenForms.OfType<Form4507Page1>().First().GetDayFilghtTime2(dayFlightTime2);//sends the day flight time of combobox2 to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetNightFilghtTime2(nightFlightTime2);//sends the night flight time of combobox2 to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetNVGFilghtTime2(nvgFlightTime2);//sends the nvg flight time of combobox2 to the form

            Application.OpenForms.OfType<Form4507Page1>().First().GetDayFilghtTime3(dayFlightTime3);//sends the day flight time of combobox3 to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetNightFilghtTime3(nightFlightTime3);//sends the night flight time of combobox3 to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetNVGFilghtTime3(nvgFlightTime3);//sends the nvg flight time of combobox3 to the form

            Application.OpenForms.OfType<Form4507Page1>().First().GetDayFilghtTime4(dayFlightTime4);//sends the day flight time of combobox4 to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetNightFilghtTime4(nightFlightTime4);//sends the night flight time of combobox4 to the form
            Application.OpenForms.OfType<Form4507Page1>().First().GetNVGFilghtTime4(nvgFlightTime4);//sends the nvg flight time of combobox4 to the form
            
            Application.OpenForms.OfType<Form4507Page1>().First().WhereToPutData();
            Application.OpenForms.OfType<Form4507Page1>().First().Repaint();//repaints the string so it shows up without having to move the form on the screen


            //used to get the data from the first flight
            Application.OpenForms.OfType<Form4507Page2>().First().GetComment(flightDate, ffStartTime, ffAmPm, comment);

            //used to get the data from the second flight
            if (flightTimeBox2.Text != "0.0")
            {
                Application.OpenForms.OfType<Form4507Page2>().First().Getcomment2(flightDate, 
            }


        }













        public void printBTN_Click(object sender, EventArgs e)
        {
            

            
           
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            commentsTC.SelectedTab = firstFlightTP;
            comboBox1.Focus();
        }

        
        private void flightTimeBox1_Leave(object sender, EventArgs e)
        {
            commentsTC.SelectedTab = firstFlightTP;//auto selects comment tab
        }




        

    }
}
