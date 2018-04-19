using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Florae_Basket
{
    public partial class flowerProfile : Form
    {
        // global flower info variables
        private string englishName;
        private string latinName;
        private string botanicalFamily;
        private string note = " ";
        private string imageName;
        private int primaryKey = 0;
        public flowerProfile()
        {
            InitializeComponent();
        }

        public flowerProfile(string name, string latin, string botan, string note, string image, int id)
        {
            InitializeComponent();
            englishName = name;
            latinName = latin;
            botanicalFamily = botan;
            this.note = note;
            imageName = image;
            primaryKey = id;
        }

        private void flowerProfile_Load(object sender, EventArgs e)
        {
            // start file path and add black background to the picture box
            string filePath = "";
            if (primaryKey < 7)
            //ONLY FOR TESTING REMOVE FROM FINAL PRODUCT
            {
                filePath = "..\\..\\Pics\\";
            }

            flowerImage.BackColor = Color.Black;

            // add the flower image name to the file path*/
            if (imageName.Length < 20)
            {
                filePath += imageName;
            }
            else
            {
                filePath = imageName;
            }


            // display all flower info
            engNameTextBox.AppendText(englishName);
            latinNameTextBox.AppendText(latinName);
            botFamTextBox.AppendText(botanicalFamily);
            notesTextBox.AppendText(note);
            flowerImage.Image = Image.FromFile(filePath);
            // }
        }

        //calls the delete flower class when clicked
        private void deleteFlower_click(object sender, EventArgs e)
        {
            bool deleted = deleteFlowerCtlr.main(primaryKey);
            if (deleted == true)
            {
                //new MainMenu().Show();
                this.Hide();
            }
        }



        private void deleteToMain_click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void profile_leave_click(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void flowerImage_Click(object sender, EventArgs e)
        {

        }

        private void flowerProfileChangeFlowerBtn_Click(object sender, EventArgs e)
        {

            // have to pass along the displayed flower's primary key when displaying the Change Flower GUI
            // in order to change the attributes for the correct flower in the database
            ChangeFlowerCtlr ctlrToChangeFlower = new ChangeFlowerCtlr(primaryKey);

            ctlrToChangeFlower.displayChangeFlowerGUI();

            this.Hide();

        }

        //---------------------------------------------------------------------------------------------------------------------------------------//
        //                                                                                                                                       //
        //   print controls START. by Kade Walter                                                                                                //
        //                                                                                                                                       //
        //---------------------------------------------------------------------------------------------------------------------------------------//        
        Bitmap bmp;
        private void print_click(object sender, EventArgs e)
        {
            flowerProfileCtrl myController = new flowerProfileCtrl();
            myController.createPrint(this);
        }

        // When the print button is clicked in the printDialog,
        // it will print the document
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        public void createImage()
        {
            // variables from the GUI required for printing. //
            // makes a bmp image //
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            // show the print dialog menu //
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------//
        //                                                                                                                                       //
        //   print controls END. by Kade Walter                                                                                                  //
        //                                                                                                                                       //
        //---------------------------------------------------------------------------------------------------------------------------------------//        
    }
}
