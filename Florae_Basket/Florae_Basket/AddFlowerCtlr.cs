using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                bool exists = DBMngr.checkFlower(customFlower.getEnglishName(), customFlower.getLatinName(), customFlower.getBotanicalFam());
                if (exists == false)
                {
                    DBMngr.InsertFlower(customFlower.getEnglishName(), customFlower.getLatinName(), customFlower.getBotanicalFam(), customFlower.getNote(), customFlower.getImgPath());
                    msgToDisplay = "Flower successfully added!";
                }
                else
                {
                    msgToDisplay = "Flower already exists. Flower not added.";
                }
			}
			return msgToDisplay;
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
