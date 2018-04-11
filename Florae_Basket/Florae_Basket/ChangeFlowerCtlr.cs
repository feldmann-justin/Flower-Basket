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


			if (userEnteredNote != DBMngr.FetchNote(flowerId))
			{
				DBMngr.changeNote(userEnteredNote, flowerId);
				msgToDisplay = "Changes successfully saved!";
			}

			if (userEnteredImgPath != DBMngr.FetchFilePath(flowerId))
			{
				DBMngr.changeImgPath(userEnteredImgPath, flowerId);
				msgToDisplay = "Changes successfully saved!";
			}


			return msgToDisplay;

		}

		public void displayChangeFlowerGUI()
		{

			ChangeFlowerGUI changeFlowerGUI = new ChangeFlowerGUI(flowerId);
			changeFlowerGUI.Visible = true;

		}

		// constructors

		public ChangeFlowerCtlr(int primaryKey)
		{

			flowerId = primaryKey;

		}

	}
}
