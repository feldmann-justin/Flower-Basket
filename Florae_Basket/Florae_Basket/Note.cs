using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Justin Feldmann
 * Class: CS 325-002
 * Semester: Spring 2018
 * Filename: Note.cs
 * Professor: Dr. Gary Mayer
 * Last Edited Date/Time: March 18, 2018 12:05 AM
 * 
 * Description: This class contains the necessary constructors, class attributes,
 * getters and setters for a Note object.
 */

namespace Florae_Basket
{
	class Note
	{

		// class attributes
		private string time; // time stamp for a note
		private string date; // date stamp for a note
		private string content; // contents of a note (will allow for misc. text instead of photographer, location taken, etc.

		// getters
		public string getTime() { return time; }
		public string getDate() { return date; }
		public string getContent() { return content; }

		// setters
		public void setTime(string newTime) { time = newTime; }
		public void setDate(string newDate) { date = newDate; }
		public void setContent(string newContent) { content = newContent; }

		// constructors

		/* No-args Note constructor. Sets each tag attribute as an empty string. */
		public Note()
		{

			setTime("");
			setDate("");
			setContent("");

		}

		/* Constructor that takes in parameters of a Latin name, English name, and botanical family for a flower. */
		public Note(string customTime, string customDate, string customContent)
		{

			setTime(customTime);
			setDate(customDate);
			setContent(customContent);

		}
	}
}
