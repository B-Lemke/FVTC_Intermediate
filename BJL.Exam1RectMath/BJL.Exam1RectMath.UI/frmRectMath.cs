using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJL.Exam1RectMath.UI
{
    public partial class frmRectMath : Form
    {
        public frmRectMath()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            //Clear labels for area and perimeter when length is updated
            lblArea.Text = String.Empty;
            lblPerimeter.Text = String.Empty;
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            //Clear labels for area and perimeter when width is updated
            lblArea.Text = String.Empty;
            lblPerimeter.Text = String.Empty;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                //Clear status label
                lblStatus.Text = String.Empty;


                double area, perimeter, width, length;
                
                //Parse the length and make sure it is positive
                if(double.TryParse(txtLength.Text, out length) && length > 0)
                {
                    //Parse width, make sure it is positive
                    if(double.TryParse(txtWidth.Text, out width) && width > 0)
                    {
                        //both have parse successfully, calculate the area and perimeter
                        area = findArea(width, length);
                        findPerimeter(width, length, out perimeter);


                        //display area and perimeter
                        lblArea.Text = area.ToString();
                        lblPerimeter.Text = perimeter.ToString();

                        //reset focus and select the first textbox
                        txtLength.Focus();
                        txtLength.SelectAll();

                    }
                    else
                    {
                        lblStatus.Text = "Width must be numeric and positive";
                        lblStatus.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblStatus.Text = "Length must be numeric and positive";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
            

        }

        private double findArea(double width, double length)
        {
            double area;

            area = width * length;

            return area;
        }

        private void findPerimeter(double width, double length, out double perimeter)
        {
            perimeter = (2 * width) + (2 * length);
        }

    }
}
