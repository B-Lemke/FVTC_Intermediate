using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJL.Notepad.UI
{
    public partial class frmChild : Form
    {

        string fileName = string.Empty;
        int id = 0;

        public frmChild()
        {
            InitializeComponent();

            Random generator = new Random();


            //Pick random values for RGB
            int r = generator.Next(0, 255);
            int g = generator.Next(0, 255);
            int b = generator.Next(0, 255);


            this.BackColor = Color.FromArgb(r,g,b);
            
        }


        public frmChild(int _id)
        {
            InitializeComponent();

            Random generator = new Random();


            //Pick random values for RGB
            int r = generator.Next(0, 255);
            int g = generator.Next(0, 255);
            int b = generator.Next(0, 255);

          


            this.BackColor = Color.FromArgb(r, g, b);
            id = _id;

        }

        private void frmChild_Load(object sender, EventArgs e)
        {
            this.Text = "Child : " + id;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            frmParent myParent = (frmParent)this.MdiParent;

            myParent.DisplayMessage(id);
        }

        private void mnuCloseChild_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
