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
 Dipak Subramaniam     Team: Dirk    CP02
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

        //To Be added to Controller
        private Color[,] array;
        private string[] databaseImages;
        private int[,] redPixels;
        private int[,] greenPixels;
        private int[,] bluePixels;
        private int[,] imageValueBins;
        private double[] chiSquareDistances;
        private int[] topThree = new int[3];
        //Value Bin Instance Variables
        private int zeroToSixyThreeRed = 0;
        private int zeroToSixyThreeGreen = 0;
        private int zeroToSixyThreeBlue = 0;
        private int sixtyFourToOneTwentySevenRed = 0;
        private int sixtyFourToOneTwentySevenGreen = 0;
        private int sixtyFourToOneTwentySevenBlue = 0;
        private int oneTwentyEightToOneNinetyOneRed = 0;
        private int oneTwentyEightToOneNinetyOneGreen = 0;
        private int oneTwentyEightToOneNinetyOneBlue = 0;
        private int oneNinetyTwoToTwoFiftyFiveRed = 0;
        private int oneNinetyTwoToTwoFiftyFiveGreen = 0;
        private int oneNinetyTwoToTwoFiftyFiveBlue = 0;

        public ImageSearch()
        {
            InitializeComponent();
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
        }
        
        private void wordSearchSelect_CheckedChanged(object sender, EventArgs e) { wordSearchOption = true; }

        private void searchButton_Click(object sender, EventArgs e)
        {

            wordSearch = wordSearchBox.Text;
            freqColor = freqColorBox.Text;

            Bitmap img = new Bitmap(filename);            
            array = new Color[img.Width, img.Height]; //Image Pixel Array
            redPixels = new int[img.Width, img.Height]; //RGB Arrays
            greenPixels = new int[img.Width, img.Height]; //RGB Arrays
            bluePixels = new int[img.Width, img.Height]; //RGB Arrays
            //loading 2D array with pixels of given search image
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    pixel = array[i, j];
                    //loading RGB arrays with RGB values of the pixels
                    redPixels[i, j] = (int) pixel.R;
                    greenPixels[i, j] = (int) pixel.G;
                    bluePixels[i, j] = (int) pixel.B;
                    Console.WriteLine((int)pixel.R);
                    Console.WriteLine((int)pixel.G);
                    Console.WriteLine((int)pixel.B);

                    //Pixel Range RGB subdivisions

                    //0-63
                    if (redPixels[i, j] >= 0 && redPixels[i, j] <= 63) { zeroToSixyThreeRed++; }
                    if (bluePixels[i, j] >= 0 && bluePixels[i, j] <= 63) { zeroToSixyThreeBlue++; }
                    if (greenPixels[i, j] >= 0 && greenPixels[i, j] <= 63) { zeroToSixyThreeGreen++; }

                    //64-127
                    if (redPixels[i, j] >= 64 && redPixels[i, j] <= 127) { sixtyFourToOneTwentySevenRed++; }
                    if (bluePixels[i, j] >= 64 && bluePixels[i, j] <= 127) { sixtyFourToOneTwentySevenBlue++; }
                    if (greenPixels[i, j] >= 64 && greenPixels[i, j] <= 127) { sixtyFourToOneTwentySevenGreen++; }

                    //128-191
                    if (redPixels[i, j] >= 128 && redPixels[i, j] <= 191) { oneTwentyEightToOneNinetyOneRed++; }
                    if (bluePixels[i, j] >= 128 && bluePixels[i, j] <= 191) { oneTwentyEightToOneNinetyOneBlue++; }
                    if (greenPixels[i, j] >= 128 && greenPixels[i, j] <= 191) { oneTwentyEightToOneNinetyOneGreen++; }

                    //192-255
                    if (redPixels[i, j] >= 192 && redPixels[i, j] <= 255) { oneNinetyTwoToTwoFiftyFiveRed++; }
                    if (bluePixels[i, j] >= 192 && bluePixels[i, j] <= 255) { oneNinetyTwoToTwoFiftyFiveBlue++; }
                    if (greenPixels[i, j] >= 192 && greenPixels[i, j] <= 255) { oneNinetyTwoToTwoFiftyFiveGreen++; }
                }
            }

            //Count of Pixel values: for each R, G, and B: [0-63], [64-127], [128-191], [192-255]
            imageValueBins = new int[3,4];
            imageValueBins[0, 0] = zeroToSixyThreeRed;
            imageValueBins[1, 0] = zeroToSixyThreeGreen;
            imageValueBins[2, 0] = zeroToSixyThreeBlue;
            imageValueBins[0, 1] = sixtyFourToOneTwentySevenRed;
            imageValueBins[1, 1] = sixtyFourToOneTwentySevenGreen;
            imageValueBins[2, 1] = sixtyFourToOneTwentySevenBlue;
            imageValueBins[0, 2] = oneTwentyEightToOneNinetyOneRed;
            imageValueBins[1, 2] = oneTwentyEightToOneNinetyOneGreen;
            imageValueBins[2, 2] = oneTwentyEightToOneNinetyOneBlue;
            imageValueBins[0, 3] = oneNinetyTwoToTwoFiftyFiveRed;
            imageValueBins[1, 3] = oneNinetyTwoToTwoFiftyFiveGreen;
            imageValueBins[2, 3] = oneNinetyTwoToTwoFiftyFiveBlue;

            //Database Manager
            /*
            
            for(int d = 0; d < database.imageFilePaths.length; d++) 
            {   
                */
                Color[,] dbArray;
                int[,] dbRedPixels;
                int[,] dbGreenPixels;
                int[,] dbBluePixels;
                int[,] dbImageValueBins;
                //Value Bin Instance Variables
                int dbZeroToSixyThreeRed = 0;
                int dbZeroToSixyThreeGreen = 0;
                int dbZeroToSixyThreeBlue = 0;
                int dbSixtyFourToOneTwentySevenRed = 0;
                int dbSixtyFourToOneTwentySevenGreen = 0;
                int dbSixtyFourToOneTwentySevenBlue = 0;
                int dbOneTwentyEightToOneNinetyOneRed = 0;
                int dbOneTwentyEightToOneNinetyOneGreen = 0;
                int dbOneTwentyEightToOneNinetyOneBlue = 0;
                int dbOneNinetyTwoToTwoFiftyFiveRed = 0;
                int dbOneNinetyTwoToTwoFiftyFiveGreen = 0;
                int dbOneNinetyTwoToTwoFiftyFiveBlue = 0;
                /*
                
                Bitmap dbImg = new Bitmap(imageFilePaths[d]); //iterating through array of database image filepaths
                dbArray = new Color[dbImg.Width, dbImg.Height]; //Image Pixel Array
                dbRedPixels = new int[dbImg.Width, dbImg.Height]; //RGB Arrays
                dbGreenPixels = new int[dbImg.Width, dbImg.Height]; //RGB Arrays
                dbBluePixels = new int[dbImg.Width, dbImg.Height]; //RGB Arrays
                //loading 2D array with pixels of the database image
                for (int i = 0; i < dbImg.Width; i++)
                {
                    for (int j = 0; j < dbImg.Height; j++)
                    {
                        Color dbPixel = dbImg.GetPixel(i, j);
                        dbPixel = dbArray[i, j];
                        //loading RGB arrays with RGB values of the pixels
                        dbRedPixels[i, j] = dbPixel.R;
                        dbGreenPixels[i, j] = dbPixel.G;
                        dbBluePixels[i, j] = dbPixel.B;

                        //Pixel Range RGB subdivisions

                        //0-63
                        if (dbRedPixels[i, j] >= 0 && dbRedPixels[i, j] <= 63) { dbZeroToSixyThreeRed++; }
                        if (dbBluePixels[i, j] >= 0 && dbBluePixels[i, j] <= 63) { dbZeroToSixyThreeBlue++; }
                        if (dbGreenPixels[i, j] >= 0 && dbGreenPixels[i, j] <= 63) { dbZeroToSixyThreeGreen++; }

                        //64-127
                        if (dbRedPixels[i, j] >= 64 && dbRedPixels[i, j] <= 127) { dbSixtyFourToOneTwentySevenRed++; }
                        if (dbBluePixels[i, j] >= 64 && dbBluePixels[i, j] <= 127) { dbSixtyFourToOneTwentySevenBlue++; }
                        if (dbGreenPixels[i, j] >= 64 && dbGreenPixels[i, j] <= 127) { dbSixtyFourToOneTwentySevenGreen++; }

                        //128-191
                        if (dbRedPixels[i, j] >= 128 && dbRedPixels[i, j] <= 191) { dbOneTwentyEightToOneNinetyOneRed++; }
                        if (dbBluePixels[i, j] >= 128 && dbBluePixels[i, j] <= 191) { dbOneTwentyEightToOneNinetyOneBlue++; }
                        if (dbGreenPixels[i, j] >= 128 && dbGreenPixels[i, j] <= 191) { dbOneTwentyEightToOneNinetyOneGreen++; }

                        //192-255
                        if (dbRedPixels[i, j] >= 192 && dbRedPixels[i, j] <= 255) { dbOneNinetyTwoToTwoFiftyFiveRed++; }
                        if (dbBluePixels[i, j] >= 192 && dbBluePixels[i, j] <= 255) { dbOneNinetyTwoToTwoFiftyFiveBlue++; }
                        if (dbGreenPixels[i, j] >= 192 && dbGreenPixels[i, j] <= 255) { dbOneNinetyTwoToTwoFiftyFiveGreen++; }
                    }
                }

                */
                //Count of Pixel values: for each R, G, and B: [0-63], [64-127], [128-191], [192-255]
                dbImageValueBins = new int[3,4];
                dbImageValueBins[0, 0] = dbZeroToSixyThreeRed;
                dbImageValueBins[1, 0] = dbZeroToSixyThreeGreen;
                dbImageValueBins[2, 0] = dbZeroToSixyThreeBlue;
                dbImageValueBins[0, 1] = dbSixtyFourToOneTwentySevenRed;
                dbImageValueBins[1, 1] = dbSixtyFourToOneTwentySevenGreen;
                dbImageValueBins[2, 1] = dbSixtyFourToOneTwentySevenBlue;
                dbImageValueBins[0, 2] = dbOneTwentyEightToOneNinetyOneRed;
                dbImageValueBins[1, 2] = dbOneTwentyEightToOneNinetyOneGreen;
                dbImageValueBins[2, 2] = dbOneTwentyEightToOneNinetyOneBlue;
                dbImageValueBins[0, 3] = dbOneNinetyTwoToTwoFiftyFiveRed;
                dbImageValueBins[1, 3] = dbOneNinetyTwoToTwoFiftyFiveGreen;
                dbImageValueBins[2, 3] = dbOneNinetyTwoToTwoFiftyFiveBlue;


                //Chi-Squared Distance Comparisons
                double chiRed;
                double chiGreen;
                double chiBlue;
                double chiThreshold;
                
                double redSum = 0;
                double greenSum = 0;
                double blueSum = 0;
                for (int color = 0; color < 3; color++) {
                    for (int range = 0; range < 4; range ++) {
                        if (color == 0) { redSum += ((Math.Pow((imageValueBins[color, range] - dbImageValueBins[color, range]), 2)) / (imageValueBins[color, range] + dbImageValueBins[color, range])); }
                        if (color == 1) { greenSum += ((Math.Pow((imageValueBins[color, range] - dbImageValueBins[color, range]), 2)) / (imageValueBins[color, range] + dbImageValueBins[color, range])); }
                        if (color == 2) { blueSum += ((Math.Pow((imageValueBins[color, range] - dbImageValueBins[color, range]), 2)) / (imageValueBins[color, range] + dbImageValueBins[color, range])); }
                    }
                }

                chiRed = (0.25) * (Math.Sqrt(redSum));
                chiGreen = (0.25) * (Math.Sqrt(greenSum));
                chiBlue = (0.25) * (Math.Sqrt(blueSum));
                chiThreshold = (1.0/3.0) * (redSum + greenSum + blueSum);
                Console.WriteLine(chiThreshold);

                /*
                chiSquaredDistances[d] = chiThreshold;
            }

            //Sorting Chi-Square Distance Values to Determine Smallest (Most Accurate) Results
            double[] sortedDistances = chiSquaredDistances;

            for (int write = 0; write < sortedDistances.Length; write++)
            {
                for (int sort = 0; sort < sortedDistances.Length - 1; sort++)
                {
                    if (sortedDistances[sort] > sortedDistances[sort + 1])
                    {
                        temp = sortedDistances[sort + 1];
                        sortedDistances[sort + 1] = sortedDistances[sort];
                        sortedDistances[sort] = temp;
                    }       
                }   
            }

            topThree[0] = chiSquaredDistances.indexOf(sortedDistances[0]);
            topThree[1] = chiSquaredDistances.indexOf(sortedDistances[1]);
            topThree[2] = chiSquaredDistances.indexOf(sortedDistances[2]);

            if(topThree[0] >= 1)) {
                topThree[0] = topThree[1];
                topThree[1] = topthree[2];
                topThree[2] = chiSquaredDistances.indexOf(sortedDistances[3]);
            }
            else if(topThree[1] >= 1) {
                topThree[1] = topthree[2];
                topThree[2] = chiSquaredDistances.indexOf(sortedDistances[3]);
            }

            else if(topThree[2] >= 1) {
                topThree[2] = chiSquaredDistances.indexOf(sortedDistances[3]);
            }

            //Display Top Three

            */
        }
    }
}
