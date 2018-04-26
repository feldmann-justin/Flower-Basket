using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

/* Name: Justin Feldmann
 * Class: CS 325-002
 * Semester: Spring 2018
 * Filename: AddFlowerCtlr.cs
 * Professor: Dr. Gary Mayer
 * Last Edited Date/Time: April 6, 2018 1:19 AM
 * 
 * Description: This class contains the necessary constructors, class attributes,
 * getters and setters for a Flower controller object.
 */

namespace Florae_Basket
{
    public class AddFlowerCtlr
    {

        // member functions



        /* Function which prompts the checking of the database manager for a currently-existing
		 * Flower object with the same attributes. */
        public static string verifyFlower(Flower customFlower)
        {

            string msgToDisplay = "";
            Database_Manager DBMngr = new Database_Manager();

            // test user-given Flower object with dummy Flower object instantiated here until database is implemented
            //Flower dummyFlower = new Flower("Rosus Maximus", "Rose", "Stabby Flowers");
            //dummyFlower.setFlowerID(customFlower.getFlowerID() + 1);

            // if at least one of the three required attributes for a flower, the Latin name, English name, and botanical family is missing
            if ((customFlower.getLatinName() == "") || (customFlower.getEnglishName() == "") || (customFlower.getBotanicalFam() == ""))
                msgToDisplay = "Flower unable to be added: One of the three minimum attributes is missing.";
            // else, the flower can be added to the database
            else
            {
                bool exists = DBMngr.checkFlower(customFlower.getLatinName());
                if (exists == false)
                {
                    string newpath = "";
                    if(customFlower.getImgPath() != "")
                    {
                        newpath = ChangeFilePath(customFlower.getImgPath());
                    }
                    DBMngr.InsertFlower(customFlower.getEnglishName(), customFlower.getLatinName(), customFlower.getBotanicalFam(), customFlower.getNote(), newpath);
                    msgToDisplay = "Flower successfully added!";
                }
                else
                {
                    msgToDisplay = "Flower already exists. Flower not added.";
                }
            }
            return msgToDisplay;
        }

        //This method will retrieve the selected image and copies it to the pics folder in the repo
        private static string ChangeFilePath(string filepath)
        {
            string directory = "..\\Pics\\";
            string newpath = directory + Path.GetFileName(filepath);

            //checks to see if a file with that name exists, if it does it will append
            //the end of the filename to contain a version number.
            int i = 1;
            while (File.Exists(newpath))
            {
                //gets the filenamem
                string without = Path.GetFileNameWithoutExtension(newpath);
                int j = i - 1;
                string test = without.Substring(without.Length - 3);
                if (without.Substring(without.Length - 3) == ("(" + j + ")"))
                {
                    without = without.Substring(0, without.Length - 3);
                }
                //adds the version number to the end of the file
                string with = without + "(" + i + ")";
                newpath = Path.GetDirectoryName(newpath) + "\\" + with + Path.GetExtension(newpath);
                i++;
            }
            //copies the file to the pics folder
            File.Copy(filepath, newpath);
            return newpath;
        }

		public void DisplayAddFlowerGUI(int acctType)
		{

			AddFlowerGUI addFlowerGUI = new AddFlowerGUI(this, acctType);
			addFlowerGUI.Show();

		}

		// constructors

		public AddFlowerCtlr()
		{


		}

	}
}
