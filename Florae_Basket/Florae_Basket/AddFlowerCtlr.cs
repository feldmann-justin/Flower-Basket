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
    public static class AddFlowerCtlr
    {

        // member functions



        /* Function which prompts the checking of the database manager for a currently-existing
		 * Flower object with the same attributes. */
        public static bool verifyFlower(Flower customFlower)
        {

            bool added = false;
            Database_Manager DBMngr = new Database_Manager();

            // test user-given Flower object with dummy Flower object instantiated here until database is implemented
            //Flower dummyFlower = new Flower("Rosus Maximus", "Rose", "Stabby Flowers");
            //dummyFlower.setFlowerID(customFlower.getFlowerID() + 1);

            // if at least one of the three required attributes for a flower, the Latin name, English name, and botanical family is missing
            if ((customFlower.getLatinName() == "") || (customFlower.getEnglishName() == "") || (customFlower.getBotanicalFam() == ""))
                added = false;
            // else, the flower can be added to the database
            else
            {
                bool exists = DBMngr.checkFlower(customFlower.getLatinName());
                if (exists == false)
                {
                    string newpath = "";
                    if (customFlower.getImgPath() != "" && customFlower.getImgPath() != null)
                    {
                        newpath = ChangeFilePath(customFlower.getImgPath());
                    }
                    DBMngr.InsertFlower(customFlower.getEnglishName(), customFlower.getLatinName(), customFlower.getBotanicalFam(), customFlower.getNote(), newpath);
                    added = true;
                }
                else
                {
                    added = false;
                }
            }
            return added;
        }

        //This method will retrieve the selected image and copies it to the pics folder in the repo
        private static string ChangeFilePath(string filepath)
        {
            string directory = "..\\..\\Pics\\";
            string newpath = directory + Path.GetFileName(filepath);

            //checks to see if a file with that name exists, if it does it will append
            //the end of the filename to contain a version number.
            int i = 1;
            while (File.Exists(newpath))
            {
                //gets the filename
                string without = Path.GetFileNameWithoutExtension(newpath);
                int j = i - 1;
                //strips version number off end of file if one exists
                string test = without.Substring(without.Length - 3);
                if (test == ("(" + j + ")"))
                {
                    without = test;
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

		public static void DisplayAddFlowerGUI(int acctType)
		{

			AddFlowerGUI addFlowerGUI = new AddFlowerGUI(acctType);
			addFlowerGUI.Show();

		}
	}
}
