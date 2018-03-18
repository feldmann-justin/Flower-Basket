using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Justin Feldmann
 * Class: CS 325-002
 * Semester: Spring 2018
 * Filename: Flower.cs
 * Professor: Dr. Gary Mayer
 * Last Edited Date/Time: March 17, 2018 11:55 AM
 * 
 * Description: This class contains the necessary constructors, class attributes,
 * getters and setters for a Flower object.
 */

namespace Florae_Basket
{
	class Flower
	{

		// class attributes

		private string latinName; // Latin/scientific name given to a flower
		private string englishName; // common English name given to a flower
		private string botanicalFam; // Family of genetically-similar flowers that the flower belongs to
		public int flowerID = 0; // ID value given to a flower for use in the database

		// getters
		public string getLatinName() { return latinName; }
		public string getEnglishName() { return englishName; }
		public string getBotanicalFam() { return botanicalFam; }
		public int getFlowerID() { return flowerID; }

		// setters
		public void setLatinName(string ln) { latinName = ln; }
		public void setEnglishName(string en) { englishName = en; }
		public void setBotanicalFam(string bf) { botanicalFam = bf; }
		public void setFlowerID(int myID) { flowerID = myID; }

		// constructors

		/* No-args Flower constructor. Sets each name attribute as an empty string. */
		public Flower()
		{

			setLatinName("");
			setEnglishName("");
			setBotanicalFam("");
			setFlowerID(flowerID);

		}

		/* Constructor that takes in parameters of a Latin name, English name, and botanical family for a flower. */
		/* A new ID number is guaranteed to be made for each Flower object created by incrementing the 'flowerID' class attribute. */
		public Flower(string customLatinName, string customEnglishName, string customBotanicalFam)
		{

			setLatinName(customLatinName);
			setEnglishName(customEnglishName);
			setBotanicalFam(customBotanicalFam);
			flowerID++;
			setFlowerID(flowerID);

		}

	}
}
