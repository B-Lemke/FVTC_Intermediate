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
    public partial class frmParent : Form
    {

        public frmParent()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            try
            {
                //Make and show a new document 
                makeNewChildForm();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCloseall_Click(object sender, EventArgs e)
        {
            //close all child forms
            foreach (frmChild childForm in this.MdiChildren)
            {
                childForm.Close();
            }
                
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuMakeForms_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    makeNewChildForm();
                }

            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        public void DisplayMessage(int childID)
        {
            lblStatus.Text = "Saving child number: " + childID.ToString();
        }

        private void makeNewChildForm()
        {
            frmChild newDocument = new frmChild(this.MdiChildren.Count() + 1);
            newDocument.MdiParent = this;
            newDocument.Show();
        }
    }
}
