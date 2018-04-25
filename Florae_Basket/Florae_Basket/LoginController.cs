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

        public LoginController(int userAcctType, string user, string pass) {
            fail = false;
             
            Database_Manager dbMngr = new Database_Manager();

            if (dbMngr.checkUsername(user)) {
				//checks the db password against the salted version of the provided password
				string dbPass = dbMngr.FetchPassword(user);

				if (dbPass != (pass)) { // making this comment so I can commit again
					//+".cs.is.fun.team.dirk." // testing to see if the inclusion of this part is necessary

					MessageBox.Show("Your password was not correct. Please enter the right credentials.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fail = true;   
                }
                else
                {
                    //Proceed to Main Menu
                    new MainMenu(userAcctType).Show();
                }
            }
            else
                MessageBox.Show("Your username was not correct. Please enter the right credentials.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fail = true;
            }

        public bool Fail() { return fail; }

    }
}
