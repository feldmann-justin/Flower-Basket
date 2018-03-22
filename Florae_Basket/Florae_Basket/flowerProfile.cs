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
        private string englishName;
        private string latinName;
        private string botanicalFamily;
        private string note = " ";
        private string imageName = "flower.jpg";
        private int primaryKey = 0;
        public flowerProfile()
        {
            InitializeComponent();
        }

        private void flowerProfile_Load(object sender, EventArgs e)
        {
            // start file path and add black background to the picture box
            string filePath = "..\\Pics\\";
            flowerImage.BackColor = Color.Black;

            // for testing purposes. It chooses a random flower in the testDB to display.
            testDB TDB = new testDB();
            int flowerAmount = TDB.getFlowerAmount();
            if (flowerAmount == 0)
            {
                MessageBox.Show("No Flower to display.");
                imageName = "";
                englishName = "";
                latinName = "";
                note = "";
                filePath = "";
            }
            else
            {
                Random rnd = new Random();
                int choice = 0;
                while (choice == 0)
                {
                    choice = rnd.Next(0, flowerAmount + 1);
                }
                englishName = TDB.getFlowerEng(choice - 1);
                latinName = TDB.getFlowerLat(choice - 1);
                botanicalFamily = TDB.getFlowerBot(choice - 1);
                primaryKey = choice;

                // get flower info
                //Flower f = new Flower();
                //Note n = new Note();
                //Picture p = new Picture();
                //englishName = f.getEnglishName();
                //latinName = f.getLatinName();
                //botanicalFamily = f.getBotanicalFam();
                //note = n.getContent();
                //imageName = p.getFilePath();

                // add the flower image name to the file path
                filePath += imageName;

                // display all flower info
                engNameTextBox.AppendText(englishName);
                latinNameTextBox.AppendText(latinName);
                botFamTextBox.AppendText(botanicalFamily);
                notesTextBox.AppendText(note);
                flowerImage.Image = Image.FromFile(filePath);
            }
        }


        //calls the delete flower class when clicked
        private void deleteFlower_click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this flower?", "Confirm Delete", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                //primaryKey = Flower.getIndex();
                // remove the flower
                bool done = deleteFlowerCtlr.removeFlower(primaryKey - 1);

                // return the user to the main menu
                if (done == true)
                {
                    new MainMenu().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Flower not deleted.");
            }
        }


        private void print_click(object sender, EventArgs e)
        {

        }

        private void deleteToMain_click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void profile_leave_click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
