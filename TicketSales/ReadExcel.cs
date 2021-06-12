using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TicketSales

{
    public class ReadExcel
    {
        private string[] _Type = new string[10];
        private float[] _Price = new float[10];
        private string[] _Desc = new string[10];
        private int _RowCount;
        private int _ColCount;
        public  bool Ok = true;
        private string ErrCaption = "Error";
        private MessageBoxButtons OkButton = MessageBoxButtons.OK;
        private string ErrMsg;

        public ReadExcel(string PathName)
        {
            Ok = false;
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application(); 
            xlApp.Visible = false; // TBD Turn off visible when debugged
            xlApp.DisplayAlerts = false;
            xlApp.ScreenUpdating = false;
//            xlApp.Calculation = Excel.XlCalculation.xlCalculationManual;
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(PathName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            _RowCount = xlRange.Rows.Count;
            _ColCount = xlRange.Columns.Count;
            System.Diagnostics.Debug.WriteLine(_RowCount + " " + _ColCount);
            // Test headers
            bool hdrOK = true;
            for (int hdrcol = 1; hdrcol <= _ColCount; hdrcol++)
            {
                switch (hdrcol) {
                    case 1:
                        Excel.Range HdrRange1 = (xlWorksheet.Cells[1,1] as Excel.Range);
                        string cellValue1 = HdrRange1.Value.ToString();
                        if (cellValue1 != "Button Number")
                        {
                            hdrOK = false;
                            ErrMsg = "Column 1 header should be 'Button Number'";
                        }
                        break;
                    case 2:
                        Excel.Range HdrRange2 = (xlWorksheet.Cells[1, 2] as Excel.Range);
                        string cellValue2 = HdrRange2.Value.ToString();
                        if (cellValue2 != "Type of ticket")
                        {
                            hdrOK = false;
                            ErrMsg = "Column 2 header should be 'Type of ticket'";
                        }
                        break;
                    case 3:
                        Excel.Range HdrRange3 = (xlWorksheet.Cells[1, 3] as Excel.Range);
                        string cellValue3 = HdrRange3.Value.ToString();
                        if (cellValue3 != "Price")
                        {
                            hdrOK = false;
                            ErrMsg = "Column 3 header should be 'Price'";
                        }
                        break;
                    case 4:
                        Excel.Range HdrRange4 = (xlWorksheet.Cells[1, 4] as Excel.Range);
                        string cellValue4 = HdrRange4.Value.ToString();
                        if (cellValue4 != "Long Description")
                        {
                            hdrOK = false;
                            ErrMsg = "Column 4 header should be 'Long Description'";
                        }
                        break;
                    default:
                        hdrOK = false;
                        ErrMsg = "Too many header columns in spreadsheet";
                        break;
                }

                // Check if there are any rows other than the header
                if (_RowCount < 2)
                {
                    hdrOK = false;
                    ErrMsg = "No Definition Rows in spreadsheet";
                }

                if (!hdrOK)
                {
                    Ok = false;
                    MessageBox.Show(ErrMsg, ErrCaption, OkButton);
                    return;
                }
                   
            } 
            for (int i = 2; i <= _RowCount; i++)
            {
                System.Diagnostics.Debug.Write("\n");
                for (int j = 1; j <= _ColCount; j++)
                {
                    Excel.Range Range = (xlWorksheet.Cells[i, j] as Excel.Range);
                    string CellValue = Range.Value.ToString();
                    System.Diagnostics.Debug.Write(CellValue + "\t");
                    // Add to Private Array Members
                    int CurRow = i - 2;
                    switch (j)
                    {
                        case (2):
                            _Type[CurRow] = CellValue;
                            break;
                        case (3):
                            _Price[CurRow] = float.Parse(CellValue);
                            break;
                        case (4):
                            _Desc[CurRow] = CellValue;
                            break;
                    }
                }
            }

            xlWorkbook.Close(false);
            xlApp.Quit();
            Ok = true;

        }
        // getters for class (don't need setters, as the spreadsheet provides the value
        public int Get_RowCount()
        {
            return _RowCount;
        }
        public int Get_ColCount()
        {
            return _ColCount;
        }
        public string[] Get_Types()
        {
            return this._Type;
        }
        public float[] Get_Price()
        {
            return this._Price;
        }
        public string[] Get_Desc()
        {
            return this._Desc;
        }
        public bool Get_OK()
        {
            return Ok;
        }
    }
}

