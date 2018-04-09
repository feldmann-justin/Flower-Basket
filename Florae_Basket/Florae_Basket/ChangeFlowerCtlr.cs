using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
	class ChangeFlowerCtlr
	{

		// member functions


		// This version of verifyFlower() will verify that the flower entry
		// passed as an argument does not exist within the database, rather than 
		// comparing with the contents of a pseudo-database, or a dummy Flower instantiation,
		// like what was done for Iteration I.
		public static string verifyFlower(Flower customFlower, string userEnteredEnglish, string userEnteredBotan)
		{

			string msgToDisplay;
			DBManager DBMngr = new DBManager();

			// need to be able to get the flower entry from the database
			// which matches the id of 'customFlower'

			// set the custom flower's id to that of whichever one in the database has the same note as this one (notes can't be changed as of yet)
			customFlower.setFlowerID(DBMngr.FetchID(customFlower.getLatinName()));

			// if any of the three required flower attributes are missing
			if ((userEnteredEnglish == "") || (userEnteredBotan == ""))
				msgToDisplay = "Changes unable to be saved: One of the three minimum attributes is missing.";
			else
			{
				// if a change is made to the english name
				if (customFlower.getEnglishName() != DBMngr.FetchEnglish(customFlower.getFlowerID()))
					DBMngr.changeEnglishName(customFlower.getEnglishName(), customFlower.getFlowerID());
				// if a change is made to the botanical family
				if (customFlower.getBotanicalFam() != DBMngr.FetchBotan(customFlower.getFlowerID()))
					DBMngr.changeBotanicalFam(customFlower.getBotanicalFam(), customFlower.getFlowerID());
				msgToDisplay = "Changes successfully saved!";

			}
				

			return msgToDisplay;

		}

		public void displayChangeFlowerGUI()
		{

			ChangeFlowerGUI changeFlowerGUI = new ChangeFlowerGUI();
			changeFlowerGUI.Visible = true;

		}

		// constructors

		public ChangeFlowerCtlr(int primaryKey)
		{

			int flowerId = primaryKey;

		}

	}
}
