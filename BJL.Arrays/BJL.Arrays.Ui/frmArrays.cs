using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace BJL.Arrays.Ui
{
    public partial class frmArrays : Form
    {
        //modular variables

        string[] names;
        int[] numbers = { -4, 3, 7, 234, -643, 54, 12, 6541555 };

        public frmArrays()
        {
            InitializeComponent();
        }

        private void btnCreateScores_Click(object sender, EventArgs e)
        {


            //declare and initialize an array
            double[] scores = { 33.5, 44.7, 55.3 };


            //Add array elements to the lbxOutput
            displayContents(scores);


        }

        private void btnCreateScoresLoop_Click(object sender, EventArgs e)
        {


            //declare and initialize an empty array of size 3
            double[] scores = new double[3];
            scores[0] = 33.5;
            scores[1] = 44.7;
            scores[2] = 55.3;


            //display
            displayContents(scores);
        }

        private void btnCreateNames_Click(object sender, EventArgs e)
        {
            //NO BUENO : names = {"Homer", "Marge", "Bart", "Lisa", "Maggie"};
            names = new string[5];
            names[0] = "Homer";
            names[1] = "Marge";
            names[2] = "Bart";
            names[3] = "Lisa";
            names[4] = "Maggie";

            btnDisplayNames.Enabled = true;
            btnSort.Enabled = true;
            btnSortDesc.Enabled = true;
        }

        private void btnDisplayNames_Click(object sender, EventArgs e)
        {
            displayContents(names);
        }

        private void displayContents(double[] info)
        {
            lbxOutput.Items.Clear();

            //loop through the doubles and print to lbxOutput.
            for (int i = 0; i < info.Length; i++)
            {
                lbxOutput.Items.Add(info[i].ToString());
            }
        }

        private void displayContents(double[,] info)
        {
            lbxOutput.Items.Clear();

            //loop through the doubles and print to lbxOutput.
            for (int i = 0; i < info.GetLength(0); i++)
            {
                for (int j = 0; j < info.GetLength(1); j++)
                {
                    lbxOutput.Items.Add(info[i,j].ToString());
                }
            }

        }

        private void displayContents(string[] info)
        {
            lbxOutput.Items.Clear();

            //loop through the strings and print to lbxOutput.
            foreach(string s in info)
            {
                lbxOutput.Items.Add(s);
            }

        }

        private void displayContents(int[] info)
        {
            lbxOutput.Items.Clear();

            //loop through the ints and print to lbxOutput.
            for (int i = 0; i < info.Length; i++)
            {
                lbxOutput.Items.Add(info[i].ToString());
            }

        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();

            speaker.Rate = 5;
            speaker.Volume = 100;

            speaker.SetOutputToWaveFile(@"output.wav");

            speaker.Speak(txtInput.Text);

            speaker = null;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Sort an array
            Array.Sort(names);

            displayContents(names);
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            //Sort an array
            Array.Sort(names);
            Array.Reverse(names);

            displayContents(names);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = @"output.wav";
            player.Play();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Array.Resize(ref names, names.Length + 1);
            names[names.Length - 1] = "Flanders";
            displayContents(names);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int searchNumber;
            if (int.TryParse(txtUserInput.Text, out searchNumber))
            {
                int iFoundIt = Array.BinarySearch(numbers, searchNumber);

                if (iFoundIt < 0)
                {
                    //It's not there
                    lbxOutput.Items.Add("Element found between " +
                                       (~iFoundIt - 1).ToString() +
                                       " and " +
                                       (~iFoundIt).ToString());
                }
                else
                {
                    //It is there
                    lbxOutput.Items.Add("Element found at position " + iFoundIt.ToString());

                }
            }
            else
            {
                MessageBox.Show("Bad input");
                txtUserInput.Focus();
                txtUserInput.SelectAll();
            }

        }

        private void frmArrays_Load(object sender, EventArgs e)
        {
            //sort numbers
            Array.Sort(numbers);
            displayContents(numbers);
        }

        private void btnCreate2d_Click(object sender, EventArgs e)
        {
            //Create 2D array with 2 rows, 3 columns
            double[,] numbers = new double[2, 3];

            numbers[0, 0] = 2.3;
            numbers[0, 1] = 3.5;
            numbers[0, 2] = 7.2;
            numbers[1, 0] = 1.6;
            numbers[1, 1] = 6.9;
            numbers[1, 2] = 7.2;

            displayContents(numbers);

            double[,] numbers1 = { { 1.2, 12.3, 123.3 }, { 1.2, 23.3, 123.43 } };
        }
    }
}
