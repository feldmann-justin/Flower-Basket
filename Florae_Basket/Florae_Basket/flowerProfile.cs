using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florae_Basket
{
    public partial class flowerProfile : Form
    {
        public flowerProfile()
        {
            InitializeComponent();
        }

        private void flowerProfile_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //calls the delete flower class when clicked
        private void deleteFlower_click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this flower?", "Confirm Delete", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Flower not deleted.");
            }
        }
    }
}
