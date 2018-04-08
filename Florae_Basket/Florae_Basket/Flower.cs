using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
	public class Flower
	{

		// class attributes

		private static int flowerID = 0;
		private string latinName; // Latin/scientific name given to a flower
		private string englishName; // common English name given to a flower
		private string botanicalFam; // Family of genetically-similar flowers that the flower belongs to
		private string note; // note attribute used for Iteration 2; will try and use actual Note class if time for Iteration 3
		private string imgPath; // imgPath attribute used for Iteration 2; will try and use actual Picture class if time for Iteration 3
		private int uniqueFlowerID; // ID value given to a flower for use in the database

		// getters
		public string getLatinName() { return latinName; }
		public string getEnglishName() { return englishName; }
		public string getBotanicalFam() { return botanicalFam; }
		public string getNote() { return note; }
		public string getImgPath() { return imgPath; }
		public int getFlowerID() { return uniqueFlowerID; }

		// setters
		public void setLatinName(string ln) { latinName = ln; }
		public void setEnglishName(string en) { englishName = en; }
		public void setBotanicalFam(string bf) { botanicalFam = bf; }
		public void setNote(string n) { note = n; }
		public void setImgPath(string path) { imgPath = path; }
		public void setFlowerID(int myID) { uniqueFlowerID = myID; }

		// constructors

		/* No-args Flower constructor. Sets each name attribute as an empty string. */
		public Flower()
		{

			setLatinName("");
			setEnglishName("");
			setBotanicalFam("");
			setNote("");
			setImgPath("");

		}

		/* Constructor that takes in parameters of a Latin name, English name, and botanical family for a flower. */
		/* A new ID number is guaranteed to be made for each Flower object created by incrementing the 'flowerID' class attribute. */
		public Flower(string customLatinName, string customEnglishName, string customBotanicalFam, string customNote, string customImgPath)
		{

			setLatinName(customLatinName);
			setEnglishName(customEnglishName);
			setBotanicalFam(customBotanicalFam);
			setNote(customNote);
			setImgPath(customImgPath);

		}

	}
}
