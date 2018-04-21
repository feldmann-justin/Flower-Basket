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
        private string wordSearch;
        private string freqColor;
		private int userAcctType;
        
        //private Color[,] array;
        //private string[] databaseImages;
        //private int[,] redPixels;
        //private int[,] greenPixels;
        //private int[,] bluePixels;
        //private int[,] imageValueBins;
        //private double[] chiSquareDistances;
        //private int[] topThree = new int[3];
        ////Value Bin Instance Variables
        //private int zeroToSixyThreeRed = 0;
        //private int zeroToSixyThreeGreen = 0;
        //private int zeroToSixyThreeBlue = 0;
        //private int sixtyFourToOneTwentySevenRed = 0;
        //private int sixtyFourToOneTwentySevenGreen = 0;
        //private int sixtyFourToOneTwentySevenBlue = 0;
        //private int oneTwentyEightToOneNinetyOneRed = 0;
        //private int oneTwentyEightToOneNinetyOneGreen = 0;
        //private int oneTwentyEightToOneNinetyOneBlue = 0;
        //private int oneNinetyTwoToTwoFiftyFiveRed = 0;
        //private int oneNinetyTwoToTwoFiftyFiveGreen = 0;
        //private int oneNinetyTwoToTwoFiftyFiveBlue = 0;

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

        private void searchButton_Click(object sender, EventArgs e)
        {

            wordSearch = wordSearchBox.Text;
            freqColor = freqColorBox.Text;

            ImageSearchController imgSrchCtrlr = (new ImageSearchController(filename, wordSearch, freqColor));
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
    }
}
