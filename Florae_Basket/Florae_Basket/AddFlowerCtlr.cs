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
 * Last Edited Date/Time: March 18, 2018 12:09 AM
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
		public bool verifyFlower(Flower customFlower)
		{

			// test user-given Flower object with dummy Flower object instantiated here until database is implemented
			Flower dummyFlower = new Flower("Rosis Maxumis", "Rose", "Fam", 0);

			// if just one of the attributes for the two flowers are the same,
			// then the flower we want to add cannot be added until the user changes one of the attributes' values
			if ((customFlower.getLatinName() == dummyFlower.getLatinName()) || (customFlower.getEnglishName() == dummyFlower.getEnglishName()) || (customFlower.getBotanicalFam() == dummyFlower.getBotanicalFam()) || (customFlower.getFlowerID() == dummyFlower.getFlowerID()))
			{


			}

			return true;
		}

		// constructors

		public AddFlowerCtlr()
		{


		}

	}
}
