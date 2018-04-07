using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	class AddFlowerCtlr
	{

		// member functions

		

		/* Function which prompts the checking of the database manager for a currently-existing
		 * Flower object with the same attributes. */
		public static string verifyFlower(Flower customFlower)
		{

			string msgToDisplay;

			// test user-given Flower object with dummy Flower object instantiated here until database is implemented
			Flower dummyFlower = new Flower("Rosus Maximus", "Rose", "Stabby Flowers");
			//dummyFlower.setFlowerID(customFlower.getFlowerID() + 1);

			// if just one of the attributes for the two flowers are the same,
			// then the flower we want to add cannot be added until the user changes one of the attributes' values
			if ((customFlower.getLatinName() == dummyFlower.getLatinName()) || (customFlower.getEnglishName() == dummyFlower.getEnglishName()) || (customFlower.getFlowerID() == dummyFlower.getFlowerID()))
				msgToDisplay = "Flower unable to be added: Entry already exists in database.";
			// if at least one of the three required attributes for a flower, the Latin name, English name, and botanical family is missing
			else if ((customFlower.getLatinName() == "") || (customFlower.getEnglishName() == "") || (customFlower.getBotanicalFam() == ""))
				msgToDisplay = "Flower unable to be added: One of the three minimum attributes is missing.";
			else
				// else, the flower can be added to the database
				msgToDisplay = "Flower successfully added!";
			// will physically add the flower entry to the DB here

			return msgToDisplay;
		}

		public void displayAddFlowerGUI()
		{

			AddFlowerGUI addFlowerGUI = new AddFlowerGUI();
			addFlowerGUI.Visible = true;

		}

		// constructors

		public AddFlowerCtlr()
		{


		}

	}
}
