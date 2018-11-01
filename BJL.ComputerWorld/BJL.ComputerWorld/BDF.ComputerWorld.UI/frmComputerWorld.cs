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

                cboEquipmentType.SelectedIndex = (int)computer.EquipmentType;

                lbxSoftware.DataSource = null;
                lbxSoftware.DataSource = computer.SoftwareList;
                lbxSoftware.DisplayMember = "Name";
                lbxSoftware.ValueMember = "Id";

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
                computer.EquipmentType = EquipmentType.Types.Desktop;
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
            cboEquipmentType.SelectedIndex = 2;
        }

        private void txtHardDriveSize_TextChanged(object sender, EventArgs e)
        {
            txtHardDriveSize.BackColor = SystemColors.Window;
            lblStatus.Text = string.Empty;
            lblStatus.ForeColor = Color.Blue;
        }

        private void frmComputerWorld_Load(object sender, EventArgs e)
        {
            // Populate the cboEquipmentTypes

            var types = Enum.GetNames(typeof(EquipmentType.Types));

            foreach (var type in types)
            {
                string name = Enum.Parse(typeof(EquipmentType.Types), type).ToString();
                cboEquipmentType.Items.Add(name);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                lblStatus.ForeColor = Color.Blue;

                // Creating a new computer
                Computer computer = new Computer();

                // Set the properties from the screen.
                computer.Description = txtDescription.Text;

                computer.EquipmentType = (EquipmentType.Types)cboEquipmentType.SelectedIndex;

                computer.HardDriveSize = Convert.ToInt32(txtHardDriveSize.Text);
                computer.Manufacturer = txtManufacturer.Text;
                computer.SerialNo = txtSerialNo.Text;
                computer.RAM = Convert.ToInt32(txtRAM.Text);
                computer.Model = txtModel.Text;
                computer.Price = Convert.ToDouble(txtPrice.Text);

                if (computerList == null)
                    computerList = new ComputerList();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                lblStatus.ForeColor = Color.Blue;

                Computer computer = computerList[dgvComputers.CurrentRow.Index];

                // Set the properties from the screen.
                computer.Description = txtDescription.Text;

                computer.EquipmentType = (EquipmentType.Types)cboEquipmentType.SelectedIndex;

                computer.HardDriveSize = Convert.ToInt32(txtHardDriveSize.Text);
                computer.Manufacturer = txtManufacturer.Text;
                computer.SerialNo = txtSerialNo.Text;
                computer.RAM = Convert.ToInt32(txtRAM.Text);
                computer.Model = txtModel.Text;
                computer.Price = Convert.ToDouble(txtPrice.Text);

                // Put my updated computer back on the list of computers;
                computerList[dgvComputers.CurrentRow.Index] = computer;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                lblStatus.ForeColor = Color.Blue;

                computerList.RemoveAt(dgvComputers.CurrentRow.Index);
                Rebind();


            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                lblStatus.ForeColor = Color.Blue;

                Computer computer = computerList[dgvComputers.CurrentRow.Index];

                computerList.Remove(computer);
                Rebind();


            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}
