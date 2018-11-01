using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJL.Books.UI
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare the variable
            
            int pages;
            Book book;

            int.TryParse(txtNumPages.Text, out pages);

            //instantiate
            book = new Book();

            //set the num pages value in the object
            book.NumPages = pages;

            //get the num pages value in the object
            lblResult.Text = book.NumPages.ToString();

            //Call the method
            book.TellStory();

            //Clean up
            book = null;
        }
    }
}
