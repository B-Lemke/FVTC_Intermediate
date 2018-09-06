using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJL.Review.UI
{
    public partial class frmReview : Form
    {
        public frmReview()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the screen
            lblResult.Text = string.Empty;
            txtInput.Text = string.Empty;

            lblStatus.Text = string.Empty;
            lblStatus.ForeColor = Color.Black;
        }


        private double DoMath(string sInput)
        {
            try
            {
                double dblInput;

                if(double.TryParse(sInput, out dblInput))
                {
                    //Successful parse, do math
                    return Math.Pow(dblInput, 2);
                }
                else
                {
                    throw new Exception("Input is not numeric, Try Again");
                }

            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
                return 0;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
            lblStatus.ForeColor = Color.Black;

            double dblOutput;
            dblOutput = DoMath(txtInput.Text);

            lblResult.Text = dblOutput.ToString();

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }
    }
}
