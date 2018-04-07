using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 Dipak Subramaniam     Team: Dirk    CP02
     */

namespace Florae_Basket
{
    class DBManager
    {
        /* 
        public Database_Manager(Bitmap img) {
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

            //Pass Value Bins Back To Controller
        } 
        */
    }
}
