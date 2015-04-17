using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using System.Drawing.Printing;

namespace CrewMemberGradeSlip
{
       
    public partial class Form1 : Form
    {
        
        //creates a new form (page1) and enters the data
        Form4507Page1 gs1 = new Form4507Page1();

        //creates a new form (page2) 
        Form4507Page2 gs2 = new Form4507Page2();

        public Form1()
        {
            InitializeComponent();
        }

        
        
        public void BTNenter_Click(object sender, EventArgs e)
        {

            string aircraftSimmed;

            if (simCB.Checked == true)
                aircraftSimmed = CBactype.Text + " -SIM";
            else
                aircraftSimmed = CBactype.Text;


            
            gs1.Left = 400;
            gs1.setStudentName(TBname.Text);
            gs1.setStudentRank(CBrank.Text);
            gs1.setStudentPID(CBpid.Text);
            gs1.setStudentUnit(TBunit.Text);
            gs1.setStudentAircraft(aircraftSimmed);
            gs1.setStudentPurpose(TBpurpose.Text);
            gs1.setStudentStartDate(DTPstartdate.Text);
            gs1.setStudentCompleteByDate(DTPcompletebydate.Text);
            gs1.Show();
            gs2.Show();

            //open a Word document form
            //Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            //Document Page1_4507 = ap.Documents.Open(@"C:\Users\Michael\Documents\DA Form 4507-R.docx");
            
            //Page1_4507.LoadFromFile("DA Form 4507-R.docx");


            


            //update the database with the new entry
            //first, open the connection
            

            //first, query the database on the first open row



        }

        


        //ensures the complete by date equals the start by date
        private void InitializeEndDate(object sender, EventArgs e)
        {
            DTPcompletebydate.Text = DTPstartdate.Text;
        }




        //defines what happens when the STUDENT SEARCH menu item is clicked
        private void studentSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hides the current form
            //this.Visible = false; 

            //creates a new form
            SearchForm sf1 = new SearchForm(); 
            
            sf1.Show();
        }

        private void sf1_FormClosed(object sender, FormClosingEventArgs e)
        {
            this.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void DTPcompletebydate_ValueChanged(object sender, EventArgs e)
        {

        }

        

        

        
    }

    
}
