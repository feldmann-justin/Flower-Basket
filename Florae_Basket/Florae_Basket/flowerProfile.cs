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
        // global flower info variables
        private string englishName = "flower one";
        private string latinName = "flowero uno";
        private string botanicalFamily = "flower one fam";
        private string notes = "notes section";
        private string imageName = "flower.jpg";
        private int primaryKey;
        public flowerProfile()
        {
            InitializeComponent();
        }

        private void flowerProfile_Load(object sender, EventArgs e)
        {
            // start file path and add black background to the picture box
            string filePath = "..\\Pics\\";
            flowerImage.BackColor = Color.Black;

            // get flower info
            //englishName = Flower.getEnglishName();
            //latinName = Flower.getLatinName();
            //botanicalFamily = Flower.getBotanicalFam();
            //notes = Notes.getContents(); ;
            //imageName = Picture.getFilePath();

            // add the flower image name to the file path
            filePath += imageName;

            // display all flower info
            engNameTextBox.AppendText(englishName);
            latinNameTextBox.AppendText(latinName);
            botFamTextBox.AppendText(botanicalFamily);
            notesTextBox.AppendText(notes);
            flowerImage.Image = Image.FromFile(filePath);
        }


        //calls the delete flower class when clicked
        private void deleteFlower_click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this flower?", "Confirm Delete", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                //primaryKey = Flower.getIndex();
                // remove the flower
                deleteFlowerCtlr.removeFlower(primaryKey);

                // return the user to the main menu
                new dummyTestForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Flower not deleted.");
            }
        }


        private void print_click(object sender, EventArgs e)
        {

        }
    }
}
