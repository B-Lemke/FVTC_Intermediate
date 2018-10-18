using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDF.ComputerWorld.BL;

namespace BDF.ComputerWorld.UI
{
    public partial class frmComputerWorld : Form
    {
        //Store computers in a modular variable that is a ComputerList
        ComputerList computerList;


        public frmComputerWorld()
        {
            InitializeComponent();
        }

        private void btnLoadComputers_Click(object sender, EventArgs e)
        {
            try
            {
                computerList = new ComputerList();

                computerList.Seed();

                //bind the data to the screen
                dgvComputers.DataSource = null;
                dgvComputers.DataSource = computerList;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.DarkRed;
            }
        }

        private void dgvComputers_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
