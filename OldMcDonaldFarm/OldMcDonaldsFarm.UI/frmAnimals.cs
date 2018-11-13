using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Animals.BL;
using Animals.Enumerations;

namespace OldMcDonaldsFarm.UI
{
    public partial class frmInstruments : Form
    {
        CatList oCats;
        public frmInstruments()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oCats = new CatList();
            
        }


        private void btnFillCat_Click(object sender, EventArgs e)
        {
            Cat oCat = new Cat("Black", AnimalType.Cat, 25, "Tabby");
            oCats.Add(oCat);

            oCat = new Cat("White", AnimalType.Tiger, 125, "Fluffy");
            oCats.Add(oCat);

            dgvCat.AutoGenerateColumns = true;
            dgvCat.DataSource = oCats;
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            try
            {
                oCats.SaveXML();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadCat_Click(object sender, EventArgs e)
        {
            try
            {
                oCats.LoadXML();
                dgvCat.AutoGenerateColumns = true;
                dgvCat.DataSource = oCats;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadWoodwinds_Click(object sender, EventArgs e)
        {
            try
            {
                oCats.LoadXML();
                dgvCat.AutoGenerateColumns = true;
                dgvCat.DataSource = oCats;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveWoodwinds_Click(object sender, EventArgs e)
        {
            try
            {
                oCats.SaveXML();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearCats_Click(object sender, EventArgs e)
        {
            dgvCat.DataSource = null;
            oCats = new CatList();
        }
    }
}
