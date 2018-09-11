using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BJL.FileIO.UI
{
    public partial class frmFileIO : Form
    {
        public frmFileIO()
        {
            InitializeComponent();
        }

        private void btnWriteText_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            string fileName = @"c:\Users\public\data.txt";

            try
            {
                //write out the contents of the textbox to a flat file

                StreamWriter sw;

                //Hook the writer to the file
                sw = File.CreateText(fileName);

                //put the data in the file
                sw.WriteLine(txtInput.Text);

                // Cleanup
                sw.Close();

                sw = null;

                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Data Written to File: " + fileName;
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void btnReadAll_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            string fileName = "c:\\users\\public\\data.txt";

            try
            {
                StreamReader sr;

                // check to see if file exists
                if (File.Exists(fileName))
                {
                    sr = File.OpenText(fileName);

                    //get file contents
                    lblOutput.Text = sr.ReadToEnd();

                    //Cleanup
                    sr.Close();
                    sr = null;

                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "File Read:  " + fileName;
                }
                else
                {
                    throw new Exception("404: File not found - " + fileName);
                }
                



            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }


    }
}
