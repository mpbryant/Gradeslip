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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSISstudentsDataSet.FlightData' table. You can move, or remove it, as needed.
            this.flightDataTableAdapter.Fill(this.iSISstudentsDataSet.FlightData);
            // TODO: This line of code loads data into the 'iSISstudentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.iSISstudentsDataSet.Students);
            
        }

                
    }
}
