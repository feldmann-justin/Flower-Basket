using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Justin Feldmann
 * Class: CS 325-002
 * Semester: Spring 2018
 * Filename: Picture.cs
 * Professor: Dr. Gary Mayer
 * Last Edited Date/Time: March 17, 2018 11:59 PM
 * 
 * Description: This class contains the necessary constructors, class attributes,
 * getters and setters for a Picture object.
 */

namespace Florae_Basket
{
	class Picture
	{

		// class attributes
		private string time; // time stamp for a picture
		private string date; // date stamp for a picture
		private string photographer; // photographer credit for a picture
		private string location; // location where the picture was taken
		private string color; // strongest color in a picture (determined by the picture's histogram) to be used when searching
		private string filePath; // file path which contains the picture

		// getters
		public string getTime() { return time; }
		public string getDate() { return date; }
		public string getPhotographer() { return photographer; }
		public string getLocation() { return location; }
		public string getColor() { return color; }
		public string getFilePath() { return filePath; }

		// setters
		public void setTime(string newTime) { time = newTime; }
		public void setDate(string newDate) { date = newDate; }
		public void setPhotographer(string newPhotographer) { photographer = newPhotographer; }
		public void setLocation(string newLocation) { location = newLocation; }
		public void setColor(string newColor) { color = newColor; }
		public void setFilePath(string newFilePath) { filePath = newFilePath; }

		// constructors

		/* No-args Picture constructor. Sets each tag attribute as an empty string. */
		public Picture()
		{

			setTime("");
			setDate("");
			setPhotographer("");
			setLocation("");
			setColor("");
			setFilePath("");

		}

		/* Constructor that takes in parameters of a time, date, photographer, location taken, color used in a search, and a file path for a picture. */
		public Picture(string customTime, string customDate, string customPhotographer, string customLocation, string customColor, string customFilePath)
		{

			setTime(customTime);
			setDate(customDate);
			setPhotographer(customPhotographer);
			setLocation(customLocation);
			setColor(customColor);
			setFilePath(customFilePath);

		}

	}
}
