using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		// attributes
		string latin;
		string english;
		string botan;

		// member functions


		// This version of verifyFlower() will verify that the flower entry
		// passed as an argument does not exist within the database, rather than 
		// comparing with the contents of a pseudo-database, or a dummy Flower instantiation,
		// like what was done for Iteration I.
		public int verifyFlower(Flower customFlower)
		{

			return 0;

		}

		public void displayChangeFlowerGUI()
		{

			ChangeFlowerGUI changeFlowerGUI = new ChangeFlowerGUI();
			changeFlowerGUI.Visible = true;

		}

		// constructors

		public ChangeFlowerCtlr()
		{



		}

	}
}
