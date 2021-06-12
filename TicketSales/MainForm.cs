using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSales
{
    public partial class MainForm : Form
    {
       public MainForm(string[] Titles, string [] Type, float [] Prices,string [] Descs,int cc, int rc)
        {
            if (Titles is null)
            {
                throw new ArgumentNullException(nameof(Titles));
            }

            if (Type is null)
            {
                throw new ArgumentNullException(nameof(Type));
            }

            if (Prices is null)
            {
                throw new ArgumentNullException(nameof(Prices));
            }

            if (Descs is null)
            {
                throw new ArgumentNullException(nameof(Descs));
            }

            InitializeComponent();
            this.Title.Text = Titles[0];
            this.Cashier.Text = Titles[1];
            this.EventDate.Text = Titles[2];
            System.Diagnostics.Debug.WriteLine("Row Count=" + rc.ToString());

            // Loop through and populate or disable controls based on spreadsheet
            for (int i=0; i < 10; i++)
            {
                int i2 = i + 1;
                switch (i2)
                {
                    case (1):
                        if (i2 > rc)
                        {
                            buttonPlus1.Enabled = false;
                            qtyLabel1.Text = "";
                            buttonMinus1.Enabled = false;
                            TypeLabel1.Text = "";
                            PriceLabel1.Text = "";
                            LineTotalLabel1.Text = "";
                        } else
                        {
                            buttonPlus1.Enabled = true;
                            qtyLabel1.Text = "0";
                            buttonMinus1.Enabled = true;
                            TypeLabel1.Text = Type[i];
                            PriceLabel1.Text = Prices[i].ToString();
                            LineTotalLabel1.Text = "0.00";
                        }
                        TotalLabel.Text = "0.00";
                        break;
                    case (2):
                        if (i2 > rc)
                        {
                            buttonPlus2.Enabled = false;
                            qtyLabel2.Text = "";
                            buttonMinus2.Enabled = false;
                            TypeLabel2.Text = "";
                            PriceLabel2.Text = "";
                            LineTotalLabel2.Text = "";
                        }
                        else
                        {
                            buttonPlus2.Enabled = true;
                            qtyLabel2.Text = "0";
                            buttonMinus2.Enabled = true;
                            TypeLabel2.Text = Type[i];
                            PriceLabel2.Text = Prices[i].ToString();
                            LineTotalLabel2.Text = "0.00";
                        }
                        break;
                    case (3):
                        if (i2 > rc)
                        {
                            buttonPlus3.Enabled = false;
                            qtyLabel3.Text = "";
                            buttonMinus3.Enabled = false;
                            TypeLabel3.Text = "";
                            PriceLabel3.Text = "";
                            LineTotalLabel3.Text = "";

                        }
                        else
                        {
                            buttonPlus3.Enabled = true;
                            qtyLabel3.Text = "0";
                            buttonMinus3.Enabled = true;
                            TypeLabel3.Text = Type[i];
                            PriceLabel3.Text = Prices[i].ToString();
                            LineTotalLabel3.Text = "0.00";
                        }
                        break;
                    case (4):
                        if (i2 > rc)
                        {
                            buttonPlus4.Enabled = false;
                            qtyLabel4.Text = "";
                            buttonMinus4.Enabled = false;
                            TypeLabel4.Text = "";
                            PriceLabel4.Text = "";
                            LineTotalLabel4.Text = "";

                        }
                        else
                        {
                            buttonPlus4.Enabled = true;
                            qtyLabel4.Text = "0";
                            buttonMinus4.Enabled = true;
                            TypeLabel4.Text = Type[i];
                            PriceLabel4.Text = Prices[i].ToString();
                            LineTotalLabel4.Text = "0.00";
                        }
                        break;
                    case (5):
                        if (i2 > rc)
                        {
                            buttonPlus5.Enabled = false;
                            qtyLabel5.Text = "";
                            buttonMinus5.Enabled = false;
                            TypeLabel5.Text = "";
                            PriceLabel5.Text = "";
                            LineTotalLabel5.Text = "";

                        }
                        else
                        {
                            buttonPlus5.Enabled = true;
                            qtyLabel5.Text = "0";
                            buttonMinus5.Enabled = true;
                            TypeLabel5.Text = Type[i];
                            PriceLabel5.Text = Prices[i].ToString();
                            LineTotalLabel5.Text = "0.00";
                        }
                        break;
                    case (6):
                        if (i2 > rc)
                        {
                            buttonPlus6.Enabled = false;
                            qtyLabel6.Text = "";
                            buttonMinus6.Enabled = false;
                            TypeLabel6.Text = "";
                            PriceLabel6.Text = "";
                            LineTotalLabel6.Text = "";

                        }
                        else
                        {
                            buttonPlus6.Enabled = true;
                            qtyLabel6.Text = "0";
                            buttonMinus6.Enabled = true;
                            TypeLabel6.Text = Type[i];
                            PriceLabel6.Text = Prices[i].ToString();
                            LineTotalLabel6.Text = "0.00";
                        }
                        break;
                    case (7):
                        if (i2 > rc)
                        {
                            buttonPlus7.Enabled = false;
                            qtyLabel7.Text = "";
                            buttonMinus7.Enabled = false;
                            TypeLabel7.Text = "";
                            PriceLabel7.Text = "";
                            LineTotalLabel7.Text = "";

                        }
                        else
                        {
                            buttonPlus7.Enabled = true;
                            qtyLabel7.Text = "0";
                            buttonMinus7.Enabled = true;
                            TypeLabel7.Text = Type[i];
                            PriceLabel7.Text = Prices[i].ToString();
                            LineTotalLabel7.Text = "0.00";
                        }
                        break;
                    case (8):
                        if (i2 > rc)
                        {
                            buttonPlus8.Enabled = false;
                            qtyLabel8.Text = "";
                            buttonMinus8.Enabled = false;
                            TypeLabel8.Text = "";
                            PriceLabel8.Text = "";
                            LineTotalLabel8.Text = "";

                        }
                        else
                        {
                            buttonPlus8.Enabled = true;
                            qtyLabel8.Text = "0";
                            buttonMinus8.Enabled = true;
                            TypeLabel8.Text = Type[i];
                            PriceLabel8.Text = Prices[i].ToString();
                            LineTotalLabel8.Text = "0.00";
                        }
                        break; 
                    case (9):
                        if (i2 > rc)
                        {
                            buttonPlus9.Enabled = false;
                            qtyLabel9.Text = "";
                            buttonMinus9.Enabled = false;
                            TypeLabel9.Text = "";
                            PriceLabel9.Text = "";
                            LineTotalLabel9.Text = "";

                        }
                        else
                        {
                            buttonPlus9.Enabled = true;
                            qtyLabel9.Text = "0";
                            buttonMinus9.Enabled = true;
                            TypeLabel9.Text = Type[i];
                            PriceLabel9.Text = Prices[i].ToString();
                            LineTotalLabel9.Text = "0.00";
                        }
                        break;
                    case (10):
                        if (i2 > rc)
                        {
                            buttonPlus10.Enabled = false;
                            qtyLabel10.Text = "";
                            buttonMinus10.Enabled = false;
                            TypeLabel10.Text = "";
                            PriceLabel10.Text = "";
                            LineTotalLabel10.Text = "";

                        }
                        else
                        {
                            buttonPlus10.Enabled = true;
                            qtyLabel10.Text = "0";
                            buttonMinus10.Enabled = true;
                            TypeLabel10.Text = Type[i];
                            PriceLabel10.Text = Prices[i].ToString();
                            LineTotalLabel10.Text = "0.00";
                        }
                        break;
                    default:
                        throw new InvalidEnumArgumentException("Loop extracting spreadsheet");
                } // switch i
            } // for i = 0 to i < 10
        }
       public MainForm()
        {
            InitializeComponent();
        }

        public partial class ClearForm
        {
            //MainForm.qtyLabel1.Text = "0";
        }

    }
}
