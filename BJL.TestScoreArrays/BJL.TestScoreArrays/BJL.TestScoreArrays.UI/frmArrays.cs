using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJL.TestScoreArrays.UI
{
    public partial class frmArrays : Form
    {
        int[] scores = new int[5];

        public frmArrays()
        {
            InitializeComponent();
        }

        private void btnAddArray1_Click(object sender, EventArgs e)
        {
            addToArray(0);
        }
        private void btnAddArray2_Click(object sender, EventArgs e)
        {
            addToArray(1);
        }

        private void btnAddArray3_Click(object sender, EventArgs e)
        {
            addToArray(2);
        }

        private void btnAddArray4_Click(object sender, EventArgs e)
        {
            addToArray(3);
        }

        private void btnAddArray5_Click(object sender, EventArgs e)
        {
            addToArray(4);
        }

        private void addToArray(int index)
        {
            try
            {
                int newScore;

                if (int.TryParse(txtInputScore.Text, out newScore))
                {
                    if (newScore >= 0 && newScore <= 10)
                    {
                        //If we reached this point, the input was valid and between 0 and 10

                        //Add the new score of the array at the spot specified
                        scores[index] = newScore;


                        //Update the status label with a success message :)
                        lblStatus.Text = newScore.ToString() + " added to array at spot " + (index+1).ToString();
                        lblStatus.ForeColor = Color.Blue;

                    }
                    else
                    {
                        //Not between 0 and 10, show error
                        showNumberEntryError();
                    }
                }
                else
                {
                    //Couldn't be parse, show error
                    showNumberEntryError();
                }


            }
            catch (Exception ex)
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void showNumberEntryError()
        {
            //Invalid input, display error message explaining valid inputs
            lblStatus.Text = "You must enter a valid number between 0 and 10";
            lblStatus.ForeColor = Color.Red;
        }

        private void btnDisplayArray_Click(object sender, EventArgs e)
        {
            try
            {
                //Clear the list box of old data
                lstDisplayArray.Items.Clear();

                //Variable for the sum of the array
                int sum = 0;

                //loop through the array
                for (int counter = 0; counter < scores.Length; counter++){
                    //Add score to the list box
                    lstDisplayArray.Items.Add(scores[counter]);

                    //Add score to the sum
                    sum += scores[counter];
                }


                //update the number of elements label
                lblNumOfElements.Text = (scores.Length).ToString();

                
                //update the sum of the elements
                lblSumOfElements.Text = sum.ToString();

                //update the average of the array
                lblAverageOfElements.Text = ((double)sum / (double)scores.Length).ToString();

             
                //Update status lable with congrats message
                lblStatus.Text = "Array has been displayed";
                lblStatus.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }
    }
}
