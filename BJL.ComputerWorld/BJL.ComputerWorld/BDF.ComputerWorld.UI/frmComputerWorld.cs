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
using BJL.Utilities.CustomExceptions;

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
                Rebind();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.DarkRed;
            }
        }

        private void dgvComputers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                lblStatus.ForeColor = Color.Blue;

                Computer computer = computerList[dgvComputers.CurrentRow.Index];

                txtDescription.Text = computer.Description;
                txtHardDriveSize.Text = computer.HardDriveSize.ToString();
                txtManufacturer.Text = computer.Manufacturer;
                txtModel.Text = computer.Model;
                txtPrice.Text = computer.Price.ToString();
                txtRAM.Text = computer.RAM.ToString();
                txtSerialNo.Text = computer.SerialNo;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnMakeComputer_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                lblStatus.ForeColor = Color.Blue;

                //Create a new Computer
                Computer computer = new Computer();

                //Set the properties from the screen
                computer.Description = txtDescription.Text;
                computer.EquipmentType = 1;
                computer.HardDriveSize = Convert.ToInt32(txtHardDriveSize.Text);
                computer.Manufacturer = txtManufacturer.Text;
                computer.SerialNo = txtSerialNo.Text;
                computer.RAM = Convert.ToInt32(txtRAM.Text);
                computer.Price = Convert.ToDouble(txtPrice.Text);
                computer.Model = txtModel.Text;

                if (computerList == null)
                {
                    //Instantiate new computer list if not created already
                    computerList = new ComputerList();
                }

                computerList.Add(computer);

                Rebind();

            }
            catch (BadHardDriveException ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
                txtHardDriveSize.Focus();
                txtHardDriveSize.SelectAll();
                txtHardDriveSize.BackColor = Color.LightYellow;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void Rebind()
        {
            dgvComputers.DataSource = null;
            dgvComputers.DataSource = computerList;
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "Look, a computer";
            txtHardDriveSize.Text = "1024";
            txtManufacturer.Text = "Dell";
            txtModel.Text = "Wow, it's made";
            txtPrice.Text = "69.99";
            txtRAM.Text = "8";
            txtSerialNo.Text = "xxx-xx-xx3c";
        }

        private void txtHardDriveSize_TextChanged(object sender, EventArgs e)
        {
            txtHardDriveSize.BackColor = SystemColors.Window;
            lblStatus.Text = string.Empty;
            lblStatus.ForeColor = Color.Blue;
        }
    }
}
