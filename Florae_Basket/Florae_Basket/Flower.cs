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
 * Last Edited Date/Time: March 17, 2018 12:19 AM
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

		// getters
		public string getLatinName() { return latinName; }
		public string getEnglishName() { return englishName; }
		public string getBotanicalFam() { return botanicalFam; }

		// setters
		public void setLatinName(string ln) { latinName = ln; }
		public void setEnglishName(string en) { englishName = en; }
		public void setBotanicalFam(string bf) { botanicalFam = bf; }

	}
}
