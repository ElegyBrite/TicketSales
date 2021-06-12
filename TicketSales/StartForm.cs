using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSales
{
    public partial class StartForm : Form
    {
        private string[] _Type = new string[10];
        private float[] _Price = new float[10];
        private string[] _Desc = new string[10];
        private int cc, rc;

        MessageBoxButtons OkButton = MessageBoxButtons.OK;
        string ErrCaption = "Error";
        bool EventOK = false;
        bool CashierOK = false;
        public StartForm()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("StartForm");
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form Load");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string[] Titles = new string[3];
            Titles[0] = this.EventName.Text;
            Titles[1] = this.CashierName.Text;
            Titles[2] = this.EventDate.Value.ToString("MM/dd/yy");
            // Form MainForm = new MainForm(Titles);
            Form MainForm = new MainForm(Titles, _Type, _Price, _Desc, cc, rc);
            MainForm.Show();
            MessageBox.Show("Got here", "Testing", OkButton);
            this.Hide();
            this.Close();

        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine("In click event");
            // Setup the initial parameters for Dialog
            using var openFileDialog = new OpenFileDialog();
            // System.Diagnostics.Debug.WriteLine("After dialog creation");
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Excel files|*.xls;*.xlsx";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            // System.Diagnostics.Debug.WriteLine("After parameters are set");
            // Put into text box
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                // System.Diagnostics.Debug.WriteLine("DialogResult not OK");
                string ErrMsg = "Invalid Selection Dialog";
                MessageBox.Show(ErrMsg, ErrCaption, OkButton);
                return;
            }
            // System.Diagnostics.Debug.WriteLine("should open dialog");
            String FileName = openFileDialog.FileName;
            DefFile.Enabled = true;
            DefFile.Text = FileName;
            DefFile.Enabled = false;
            ReadExcel ExcelObj = new ReadExcel(FileName);
            bool DefOK = ExcelObj.Get_OK();
            _Type = ExcelObj.Get_Types();
            _Price = ExcelObj.Get_Price();
            _Desc = ExcelObj.Get_Desc();
            cc = ExcelObj.Get_ColCount();
            rc = ExcelObj.Get_RowCount();

            if (DefOK & EventOK & CashierOK) StartButton.Enabled = true;
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {
            if (EventName.Text != "")
            {
                EventOK = true;

            }
        }

        private void CashierName_TextChanged(object sender, EventArgs e)
        {
            if (CashierName.Text != "")
            {
                CashierOK = true;
            }
        }
    }
}
