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
 * Filename: ChangeFlowerCtlr.cs
 * Professor: Dr. Gary Mayer
 * Last Edited Date/Time: April 6, 2018 1:19 AM
 * 
 * Description: This class contains the necessary constructors, class attributes,
 * getters and setters for a ChangeFlower controller object.
 */

namespace Florae_Basket
{
	public class ChangeFlowerCtlr
	{

		// global variables
		int flowerId;

		// member functions


		// This version of verifyFlower() will verify that the flower entry
		// passed as an argument does not exist within the database, rather than 
		// comparing with the contents of a pseudo-database, or a dummy Flower instantiation,
		// like what was done for Iteration I.
		public string verifyFlower(string userEnteredEnglish, string userEnteredLatin, string userEnteredBotan, string userEnteredNote, string userEnteredImgPath)
		{

			string msgToDisplay;
			Database_Manager DBMngr = new Database_Manager();

			// need to be able to get the flower entry from the database
			// which matches the id of 'customFlower'

			
			// if a change is made to the english name AND that change does not result in it being blank
			if ((userEnteredEnglish != DBMngr.FetchEnglish(flowerId)) && (userEnteredEnglish != ""))
			{
				DBMngr.changeEnglishName(userEnteredEnglish, flowerId);
				msgToDisplay = "Changes successfully saved!";
			}
			else
				msgToDisplay = "Changes unable to be saved: One of the three minimum attributes is missing.";
			// same structure for latin name and botanical family
			if ((userEnteredLatin != DBMngr.FetchLatin(flowerId)) && (userEnteredLatin != ""))
			{
				DBMngr.changeLatinName(userEnteredLatin, flowerId);
				msgToDisplay = "Changes successfully saved!";
			}
			else
				msgToDisplay = "Changes unable to be saved: One of the three minimum attributes is missing.";
			if ((userEnteredBotan != DBMngr.FetchBotan(flowerId)) && (userEnteredBotan != ""))
			{
				DBMngr.changeBotanicalFam(userEnteredBotan, flowerId);
				msgToDisplay = "Changes successfully saved!";
			}
			else
				msgToDisplay = "Changes unable to be saved: One of the three minimum attributes is missing.";


			if (userEnteredNote != DBMngr.FetchNote(flowerId) && userEnteredNote != "")
			{
				DBMngr.changeNote(userEnteredNote, flowerId);
				msgToDisplay = "Changes successfully saved!";
			}

			if (userEnteredImgPath != DBMngr.FetchFilePath(flowerId) && userEnteredImgPath != "")
			{
                userEnteredImgPath = ChangeFilePath(userEnteredImgPath);
				DBMngr.changeImgPath(userEnteredImgPath, flowerId);
				msgToDisplay = "Changes successfully saved!";
			}


			return msgToDisplay;

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

        public void displayChangeFlowerGUI(int acctType)
		{

			ChangeFlowerGUI changeFlowerGUI = new ChangeFlowerGUI(flowerId, acctType);
			changeFlowerGUI.Visible = true;

		}

		// constructors

		public ChangeFlowerCtlr(int primaryKey)
		{

			flowerId = primaryKey;

		}

	}
}
