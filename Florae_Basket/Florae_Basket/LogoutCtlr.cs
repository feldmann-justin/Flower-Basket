using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Name: Justin Feldmann
 * Class: CS 325-002
 * Semester: Spring 2018
 * Filename: LogoutCtlr.cs
 * Professor: Dr. Gary Mayer
 * Last Edited Date/Time: April 18, 2018 8:24 PM
 * 
 * Description: This class contains the necessary constructors, class attributes,
 * getters and setters for a Logout use case controller object.
 */

namespace Florae_Basket
{
	class LogoutCtlr
	{

		// constructors
		public LogoutCtlr()
		{


		}

		// member functions

		public DialogResult DisplayLogoutConfirm()
		{

			DialogResult confirm;

			// confirmation message is displayed to the user; no logic is done within this member function
			confirm = MessageBox.Show("Are you sure you want to logout?", "Logout?", MessageBoxButtons.YesNo);

			return confirm;

		}

		public bool LogoutConfirm(DialogResult result)
		{
			bool userSelection;

			if (result == DialogResult.Yes)
				return true;
			else
				return false;

		}

		public void displayMainMenu()
		{


		}

	}
}
