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
    

    public partial class Form4507Page1 : Form
    {
        string myName;
        string myRank;
        string myPID;
        string myUnit;
        string myPurpose;
        string myAircraft;
        string myStartDate;
        string myCompleteByDate;
        int colLoc;
        public string dateTrained;
        int col;
        string timeTodayRow;
        string dayFlight1;
        private string nightFlight1;
        private string nvgFlight1;
        private string dayFlight2;
        private string nightFlight2;
        private string nvgFlight2;
        private string dayFlight3;
        private string nightflight3;
        private string nvgFlight3;
        private string dayFlight4;
        private string nightflight4;
        private string nvgFlight4;
        Bitmap memoryImage;

        




        internal void GetDayFilghtTime(string dayFlightTime1)
        {
            dayFlight1 = dayFlightTime1;
            
        }

        internal void GetNightFilghtTime(string nightFlightTime1)
        {
            nightFlight1 = nightFlightTime1;
            
        }

        internal void GetNVGFilghtTime(string nvgFlightTime1)
        {
            nvgFlight1 = nvgFlightTime1;

        }

        internal void GetDayFilghtTime2(string dayFlightTime2)
        {
            dayFlight2 = dayFlightTime2;
            
        }

        internal void GetNightFilghtTime2(string nightFlightTime2)
        {
            nightFlight2 = nightFlightTime2;

        }

        internal void GetNVGFilghtTime2(string nvgFlightTime2)
        {
            nvgFlight2 = nvgFlightTime2;

        }

        internal void GetDayFilghtTime3(string dayFlightTime3)
        {
            dayFlight3 = dayFlightTime3;
        }

        internal void GetNightFilghtTime3(string nightFlightTime3)
        {
            nightflight3 = nightFlightTime3;
        }

        internal void GetNVGFilghtTime3(string nvgFlightTime3)
        {
            nvgFlight3 = nvgFlightTime3;
        }

        internal void GetDayFilghtTime4(string dayFlightTime4)
        {
            dayFlight4 = dayFlightTime4;
        }

        internal void GetNightFilghtTime4(string nightFlightTime4)
        {
            nightflight4 = nightFlightTime4;
        }

        internal void GetNVGFilghtTime4(string nvgFlightTime4)
        {
            nvgFlight4 = nvgFlightTime4;
        }


        


        public void WhereToPutData()
        {
            


            int userRow;
            int userCol=0;//for now, set to 0 for development


            userRow= 0;

            //if (dayFlight1!=null && 
            


        }

        //public int CheckRowAvail(int userCol)
        //{
        //    ////array of labels
        //    //Label[,] myLabel = new Label[10, 10] { { row1col1lbl, row2col1lbl, row3col1lbl, row4col1lbl, row5col1lbl, row6col1lbl, row7col1lbl, row8col1lbl, row9col1lbl, row10col1lbl }, { row1col2lbl, row2col2lbl, row3col2lbl, row4col2lbl, row5col2lbl, row6col2lbl, row7col2lbl, row8col2lbl, row9col2lbl, row10col2lbl }, { row1col3lbl, row2col3lbl, row3col3lbl, row4col3lbl, row5col3lbl, row6col3lbl, row7col3lbl, row8col3lbl, row9col3lbl, row10col3lbl }, { row1col4lbl, row2col4lbl, row3col4lbl, row4col4lbl, row5col4lbl, row6col4lbl, row7col4lbl, row8col4lbl, row9col4lbl, row10col4lbl }, { row1col5lbl, row2col5lbl, row3col5lbl, row4col5lbl, row5col5lbl, row6col5lbl, row7col5lbl, row8col5lbl, row9col5lbl, row10col5lbl }, { row1col6lbl, row2col6lbl, row3col6lbl, row4col6lbl, row5col6lbl, row6col6lbl, row7col6lbl, row8col6lbl, row9col6lbl, row10col6lbl }, { row1col7lbl, row2col7lbl, row3col7lbl, row4col7lbl, row5col7lbl, row6col7lbl, row7col7lbl, row8col7lbl, row9col7lbl, row10col7lbl }, { row1col8lbl, row2col8lbl, row3col8lbl, row4col8lbl, row5col8lbl, row6col8lbl, row7col8lbl, row8col8lbl, row9col8lbl, row10col8lbl }, { row1col9lbl, row2col9lbl, row3col9lbl, row4col9lbl, row5col9lbl, row6col9lbl, row7col9lbl, row8col9lbl, row9col9lbl, row10col9lbl }, { row1col10lbl, row2col10lbl, row3col10lbl, row4col10lbl, row5col10lbl, row6col10lbl, row7col10lbl, row8col10lbl, row9col10lbl, row10col10lbl } };

        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    if (myLabel[userCol,i].Text == "")
        //    //    {
        //    //        return i;
        //    //    }
                
        //    //}
        //    //return 0;
        //}



        internal void GetTotalTime(string flightTimeTotal)
        {
            timeTodayRow = flightTimeTotal;
            row1col1lbl.Text = timeTodayRow;
        }

        public Label Row1Col1lbl
        {
            get
            {
                return row1col1lbl;
            }

        }




        public void Get4507Flights(string i)
        {
            dateTrained=i;

        }

        public void PrintMe()
        {
            
            printForm1.Print();
        }
        

        public string getStudentCompleteByDate()
        {
            return myCompleteByDate;
        }

        public void setStudentCompleteByDate(string stuCompleteByDate)
        {
            myCompleteByDate = stuCompleteByDate;
        }

        public string getStudentStartDate()
        {
            return myStartDate;
        }

        public void setStudentStartDate(string stuStartDate)
        {
            myStartDate = stuStartDate;
        }

        public string getStudentAircraft()
        {
            return myAircraft;
        }

        public void setStudentAircraft(string stuAircraft)
        {
            myAircraft = stuAircraft;
        }

        public string getStudentPurpose()
        {
            return myPurpose;
        }

        public void setStudentPurpose(string stuPurpose)
        {
            myPurpose = stuPurpose;
        }

        public string getStudentUnit()
        {
            return myUnit;
        }

        public void setStudentUnit(string stuUnit)
        {
            myUnit = stuUnit;
        }

        public string getStudentPID()
        {
            return myPID;
        }

        public void setStudentPID(string stuPID)
        {
            myPID = stuPID;
        }

        public string getStudentRank()
        {
            return myRank;
        }

        public void setStudentRank(string stuRank)
        {
            myRank = stuRank;
        }

        public string GetStudentName()
        {
            return myName;
        }

        public void setStudentName(string stuName)
        {
            myName = stuName;
        }



        public Form4507Page1()
        {
            
            InitializeComponent();

            //for testing purposes
            //dateTrained = "Dec 19, 2014";
            col = 0;
            colLoc=GetColumnLoc(col);
            //colLoc = 290;
            //end
        }

        public void Form4507Page1_Load(object sender, EventArgs e)
        {
             
            LBLp1Name.Text = myName;
            LBLpg1Rank.Text = myRank;
            LBLpg1PID.Text = myPID;
            LBLpg1Unit.Text = myUnit;
            LBLpg1Purpose.Text = myPurpose;
            LBLpg1ACtype.Text = myAircraft;
            LBLpg1StartDate.Text = myStartDate;
            LBLpg1CompleteByDate.Text = myCompleteByDate;

            // create an instance of the Time Entry Form and display it
            TimeEntryForm tef1 = new TimeEntryForm();
            tef1.Left = 0;
            tef1.Show();
            
        }

        private void Form4507Page1_Paint(object sender, PaintEventArgs e)
        {
            

            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Font myFont = new System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Regular);

            Brush myBrush = new SolidBrush(System.Drawing.Color.Black);

            graphicsObj.RotateTransform(-90);

            graphicsObj.DrawString(dateTrained, myFont, myBrush, -250, colLoc);

            

            
        }


        public void Repaint()
        {
            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Font myFont = new System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Regular);

            Brush myBrush = new SolidBrush(System.Drawing.Color.Black);

            graphicsObj.RotateTransform(-90);

            graphicsObj.DrawString(dateTrained, myFont, myBrush, -250, colLoc);
        }





        private int GetColumnLoc(int col)
        {
            return (col * 25) + 290;
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd1 = new PrintPreviewDialog();
            ppd1.Document = this.printDocument1;
            ppd1.FormBorderStyle = FormBorderStyle.Fixed3D;
            ppd1.SetBounds(20, 20, this.Width, this.Height);
            ppd1.ShowDialog();

        }



        #region PrintPage

        public void formPrint(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            CaptureScreen();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(this.ClientSize.Width, this.ClientSize.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X + 10, this.Location.Y + 32, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0, 834, 1050);
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            CaptureScreen();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }

        
 
    }

    class LabelTest : Form4507Page1
    {
        //Label row1col1lbl = Row1Col1lbl;
        Label myLabel = new Label();



        ////array of labels
        //Label[,] myLabel = new Label[10, 10] { { row1col1lbl, row2col1lbl, row3col1lbl, row4col1lbl, row5col1lbl, row6col1lbl, row7col1lbl, row8col1lbl, row9col1lbl, row10col1lbl }, { row1col2lbl, row2col2lbl, row3col2lbl, row4col2lbl, row5col2lbl, row6col2lbl, row7col2lbl, row8col2lbl, row9col2lbl, row10col2lbl }, { row1col3lbl, row2col3lbl, row3col3lbl, row4col3lbl, row5col3lbl, row6col3lbl, row7col3lbl, row8col3lbl, row9col3lbl, row10col3lbl }, { row1col4lbl, row2col4lbl, row3col4lbl, row4col4lbl, row5col4lbl, row6col4lbl, row7col4lbl, row8col4lbl, row9col4lbl, row10col4lbl }, { row1col5lbl, row2col5lbl, row3col5lbl, row4col5lbl, row5col5lbl, row6col5lbl, row7col5lbl, row8col5lbl, row9col5lbl, row10col5lbl }, { row1col6lbl, row2col6lbl, row3col6lbl, row4col6lbl, row5col6lbl, row6col6lbl, row7col6lbl, row8col6lbl, row9col6lbl, row10col6lbl }, { row1col7lbl, row2col7lbl, row3col7lbl, row4col7lbl, row5col7lbl, row6col7lbl, row7col7lbl, row8col7lbl, row9col7lbl, row10col7lbl }, { row1col8lbl, row2col8lbl, row3col8lbl, row4col8lbl, row5col8lbl, row6col8lbl, row7col8lbl, row8col8lbl, row9col8lbl, row10col8lbl }, { row1col9lbl, row2col9lbl, row3col9lbl, row4col9lbl, row5col9lbl, row6col9lbl, row7col9lbl, row8col9lbl, row9col9lbl, row10col9lbl }, { row1col10lbl, row2col10lbl, row3col10lbl, row4col10lbl, row5col10lbl, row6col10lbl, row7col10lbl, row8col10lbl, row9col10lbl, row10col10lbl } };
    }







    

    

}
