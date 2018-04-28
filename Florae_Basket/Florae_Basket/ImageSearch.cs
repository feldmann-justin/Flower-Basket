using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

/* 
 Dipak Subramaniam     Team: Dirk    CP03
     */

namespace Florae_Basket
{
    public partial class ImageSearch : Form
    {
        //Instance Variables
        private string filename;
        private bool wordSearchOption = false;
        private bool freqColorOption = false;
        private string wordSearch;
        private string freqColor;
		private int userAcctType;

        public ImageSearch(int acctType)
        {
			InitializeComponent();
			userAcctType = acctType;
        }

        private void ImageSearch_Load(object sender, EventArgs e) { }

        private void imgSelectButton_Click(object sender, EventArgs e)
        {
            //Open File Dialog Code
            errorLabel.Visible = false;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files | *.png; *.jpg; *.jpeg; *.gif; *.gifv;...";
            fileDialog.InitialDirectory = "%USERPROFILE%\\Documents";
            fileDialog.Title = "Select an image file";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = fileDialog.FileName;
                System.Console.WriteLine(System.IO.File.ReadAllText(filename));
            }
            else
            {
                errorLabel.Visible = true;
            }

            Bitmap img = new Bitmap(filename);
            Bitmap resized = new Bitmap(img, 256, 256);
            pictureBox.Image = resized;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        
        private void wordSearchSelect_CheckedChanged(object sender, EventArgs e) { wordSearchOption = true; }
        private void freqColorCheckBox_CheckedChanged(object sender, EventArgs e) { freqColorOption = true; }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            wordSearch = wordSearchBox.Text;

            ImageSearchController imgSrchCtrlr = (new ImageSearchController(filename, wordSearch, freqColor));
            Console.WriteLine(imgSrchCtrlr.getTopthree() + " " +  imgSrchCtrlr.getChiValues());
            int[] topResults = imgSrchCtrlr.getTopthree();
            double[] topValues = imgSrchCtrlr.getChiValues();
            int[] topIndexes = imgSrchCtrlr.getTopIndex();
            for (int i = 0; i < 3; i++) {
                string flowerName = "";
                switch (topIndexes[i]) {
                    case 0:
                        flowerName = "bulk";
                        break;
                    case 1:
                        flowerName = "button";
                        break;
                    case 2:
                        flowerName = "cherry";
                        break;
                    case 3:
                        flowerName = "cool";
                        break;
                    case 4:
                        flowerName = "dahlia";
                        break;
                    case 5:
                        flowerName = "daisy";
                        break;
                    case 6:
                        flowerName = "flower";
                        break;
                    case 7:
                        flowerName = "hibuscus";
                        break;
                    case 8:
                        flowerName = "orange";
                        break;
                    case 9:
                        flowerName = "salmon";
                        break;
                    case 10:
                        flowerName = "sun";
                        break;
                    case 11:
                        flowerName = "sunflower";
                        break;
                    case 12:
                        flowerName = "yellow";
                        break;
                }
                //decimal.Round(topValues[i], 2, MidpointRounding.AwayFromZero);
                if (i != 0) { 
                    resultsLabel.Text += ("\nFlower Name: " + flowerName + ", Index: " + topIndexes[i] + " ");
                }
                else
                {
                    resultsLabel.Text += ("Flower Name: " + flowerName + ", Index: " + topIndexes[i] + " ");
                }
                if (i + 1 == 1) { valueLabel.Text += (i + 1) + "st) " + Math.Round(topValues[i], 2) + " "; }
                if (i + 1 == 2) { valueLabel.Text += (i + 1) + "nd) " + Math.Round(topValues[i], 2) + " "; }
                if (i + 1 == 3) { valueLabel.Text += (i + 1) + "rd) " + Math.Round(topValues[i], 2) + " "; }
                            
            }
            
        }

        //Useless Handler
        private void imgNoteLabel_Click(object sender, EventArgs e)
        {

        }

        private void ImageSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            new MainMenu(userAcctType).Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void redButton_CheckedChanged(object sender, EventArgs e) { freqColor = "red"; }
        private void blueButton_CheckedChanged(object sender, EventArgs e) { freqColor = "blue"; }
        private void greenButton_CheckedChanged(object sender, EventArgs e) { freqColor = "green"; }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu(userAcctType).Show();
        }

        private void chiLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
