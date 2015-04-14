using System;
using System.Drawing;
using System.Drawing.Printing;



namespace MyPrintClass
{
    public class PCPrint : System.Drawing.Printing.PrintDocument
    {
        #region Property Variables
        //Property variable for the font the user wishes to use
        private Font _font;

        //Property variable for the text to be printed
        private string _text;
        #endregion

        #region Class Properties
        //Property to hold the text that is to be printed
        public string TextToPrint
        {
            get { return _text; }
            set { _text = value; }
        }

        //Property to hold the font that is to be printed
        public Font PrinterFont
        {
            //Allows the user to override the default font
            get { return _font; }
            set { _font = value; }
        }
        #endregion

        #region Static local variables
        //Static variable to hold the current variable
        //we're currently dealing with
        static int curChar;
        #endregion

        #region Class constructors
        //Empty constructor
        public PCPrint():base()
        {
            //set the file stream
            //instantiate out text property to an empty string
            _text = string.Empty;
        }

        //constructor to initializeour printing object
        //and the text it's supposed to be printing
        public PCPrint(string str):base()
        {
            //set the file stream
            //set the text property value
            _text = str;
        }
        #endregion

        #region onbeginPrint
        //Override the default onbeginPrint method of the PrintDocument Object
        protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
        {
            //Run base code
            base.OnBeginPrint(e);

            //Check to see if the user provided a font
            //If they didn't, we default to Times New Roman
            if (_font == null)
            {
                //Create the font we need
                _font = new Font("Times New Roman", 10);

            }
        }
        #endregion

        #region OnPrintPage
        //Override the default OnPrintPagemethodof the PrintDocument
        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Run base code
            base.OnPrintPage(e);

            //Declare local variables needed
            int printHeight;
            int printWidth;
            int leftMargin;
            int rightMargin;
            Int32 lines;
            Int32 chars;

            //Set print area size and margins
            {
                

                printHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom;

                printWidth = base.DefaultPageSettings.PaperSize.Width - base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right;

                leftMargin = base.DefaultPageSettings.Margins.Left; //X

                rightMargin = base.DefaultPageSettings.Margins.Top; //Y
            }

            //Check if the user selected to print in landscape mode
            //If they did, we need to swap height/width parameters
            if (base.DefaultPageSettings.Landscape)
            {
                int tmp;
                tmp = printHeight;
                printHeight = printWidth;
                printWidth = tmp;
            }

            //Now we need to determine the total number of lines
            //we're going to be printing
            Int32 numLines = (int)printHeight / PrinterFont.Height;

            //Create a rectangle printing area for our document
            RectangleF printArea = new RectangleF(leftMargin, rightMargin, printWidth, printHeight);

            //Use the StringFormat class for the text layout of our document
            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);

            //Fit as many characters as we can into the print area
            e.Graphics.MeasureString(_text.Substring(RemoveZeros(ref curChar)), PrinterFont, new SizeF(printWidth, printHeight), format, out chars, out lines);

            e.Graphics.DrawString(_text.Substring(RemoveZeros(ref curChar)), PrinterFont, Brushes.Black, printArea, format);

            //Increase current char count
            curChar += chars;

            //Determine if there is more text to print. 
            //If there is, tell the printer there is more coming.
            if (curChar+1 < _text.Length)
            {
                e.HasMorePages = true;

            }
            else 
            {
                e.HasMorePages = false;
                curChar = 0;

            }

            
        }
        #endregion

        #region RemoveZeros
        //Function to replace all zeros in size to a 1
        //Zeros will mess upa printing area
        public int RemoveZeros( ref int value)
        {
            //Check the value passed into thefunction,
            //if the value is 0 then return a 1,
            //otherwise, return the value passed in

            while (_text[value] == 0)
            {
                value++;
            }
            return value;

            //switch (value)
            //{
            //    case 0:
            //        return 1;
            //    default:
            //        return value;
            //}
        }
        #endregion

    }

}
