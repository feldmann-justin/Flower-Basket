using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florae_Basket
{
    class LoginController
    {
        private bool fail;

        public LoginController(int userAcctType, string user, string pass)
        {
            fail = false;
             
            Database_Manager dbMngr = new Database_Manager();

            if (dbMngr.checkUsername(user))
            {
                //checks the db password against the salted version of the provided password
                string dbPass = dbMngr.FetchPassword(user);
                string saltPass = (pass + ".cs.is.fun.team.dirk.");
                string hashPass = Convert.ToString(saltPass.GetHashCode());
                if (dbPass != (hashPass))
                {
                    MessageBox.Show("Your password was not correct. Please enter the right credentials.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fail = true;
                }
                else
                {
                    //Check user's account type
                    string type = dbMngr.Fetchaccttype(user);
                    Console.WriteLine(type);
                    if (type == "Administrator") userAcctType = 3;
                    else if (type == "Researcher") userAcctType = 2;
                    else if (type == "Student") userAcctType = 1;

                    //Proceed to Main Menu
                    new MainMenu(userAcctType).Show();
                }
            }
            else
            {
                MessageBox.Show("Your username was not correct. Please enter the right credentials.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fail = true;
            }
        }

		public LoginController()
		{


		}

        public bool Fail() { return fail; }

		public void displayLoginGUI()
		{

			// create instance of the Login GUI
			Login loginInstance = new Login();

			loginInstance.Show();

		}

    }
}
