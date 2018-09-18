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
        string[] names;

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
    }
}
