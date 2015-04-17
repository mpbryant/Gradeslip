using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewMemberGradeSlip
{
    public partial class Form4507Page2 : Form
    {
        public Form4507Page2()
        {
            InitializeComponent();
        }


        //used to populate the comment text box from the time entry form
        internal void GetComment(string flightDate, string ffStartTime, string ffAmPm, string comment)
        {
            string myComment = "Flight Start Time " + ffStartTime + " " + ffAmPm + " - " + comment; 
            
            //test tableLayoutPanel
            int colWidth = tableLayoutPanel1.GetColumnWidths()[1];
                        

            tableLayoutPanel1.Controls.Add(new RichTextBox() { Text = flightDate, BorderStyle=BorderStyle.None }, 0, 0);
            tableLayoutPanel1.Controls.Add(new RichTextBox() { Text = myComment, Width = colWidth, BorderStyle = BorderStyle.None }, 1, 0);

            

            
        }


    }
}
