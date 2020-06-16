using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_PA9_Karen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double convertedvalue;

            try
            {
                //checking for null values
                if ((rdb_USdollars.Checked == false) || (rdb_JapaneseYen.Checked == false) || rdb_malaysianringgit.Checked == false)
                {
                    txt_convertedAmt.Text = "Select at least one currency to convert";
                }

                //convert SGD to US dollars
                if (rdb_USdollars.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 0.74;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }

                //convert SGD to Japanese Yen
                if (rdb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 81.97;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }

                if(rdb_malaysianringgit.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedvalue = AmountEntered * 3.01;

                    txt_convertedAmt.Text = convertedvalue.ToString();
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "";
            txt_convertedAmt.Text = "";
            rdb_malaysianringgit.Checked = false;
            rdb_JapaneseYen.Checked = false;
            rdb_USdollars.Checked = false;
        }
    }
}
