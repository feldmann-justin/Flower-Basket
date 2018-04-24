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
            pictureBox.Image = img;
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
            for (int i = 0; i < 3; i++) {
                resultsLabel.Text += ("Img " + ": "  + topResults[i] + " ");
                valueLabel.Text += i + ") " + topValues[i] + " ";
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

        
    }
}
