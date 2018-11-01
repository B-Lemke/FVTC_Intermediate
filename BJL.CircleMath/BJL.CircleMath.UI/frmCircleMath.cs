using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJL.CircleMath.UI
{
    public partial class frmCircleMath : Form
    {
        public frmCircleMath()
        {
            InitializeComponent();
        }
                
        private double findArea(double radius)
        {
            //calculate math
            double area;

            area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        private void findCircumerence(double radius, out double circumference)
        {
            circumference = Math.PI * 2 * radius;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Clear lblStatus
                lblStatus.Text = String.Empty;

                double radius;

                if (double.TryParse(txtInputRadius.Text, out radius))
                {
                    if (radius >= 0)
                    {
                        //calculate math
                        double area;

                        area = findArea(radius);

                        //Show result
                        lblDisplay.Text = "The area of the circle with a radius of " + radius.ToString() + " is " + Math.Round(area,2).ToString();
                    }
                    else
                    {
                        lblStatus.Text = "Radius must be positive";
                        lblStatus.ForeColor = Color.Red;
                    }
                }
                else
                {
                    //input could not be parsed
                    lblStatus.Text = "Radius must be numeric";
                    lblStatus.ForeColor = Color.Red;
                }


            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }
        
        private void btnCircumference_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = String.Empty;

                double radius;

                if (double.TryParse(txtInputRadius.Text, out radius))
                {
                    if (radius >= 0)
                    {
                        //calculate math
                        double circumference;

                        findCircumerence(radius, out circumference);

                        //Show result
                        lblDisplay.Text = "The circumference of the circle with a radius of " + radius.ToString() + " is " + Math.Round(circumference,2).ToString();
                    }
                    else
                    {
                        lblStatus.Text = "Radius must be positive";
                        lblStatus.ForeColor = Color.Red;
                    }
                }
                else
                {
                    //input could not be parsed
                    lblStatus.Text = "Radius must be numeric";
                    lblStatus.ForeColor = Color.Red;
                }


            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void txtInputRadius_TextChanged(object sender, EventArgs e)
        {
            //Clear the display label when new number is typed
            lblDisplay.Text = String.Empty;
        }
    }
}
