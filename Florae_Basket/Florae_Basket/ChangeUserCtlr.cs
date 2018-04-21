using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florae_Basket
{
    public class ChangeUserCtlr
    {

        public void CreateGUI(int acct)
        {
            ChangeUserGUI change = new ChangeUserGUI(this);
            change.ShowDialog();
            new MainMenu(acct).Show();
        }

        public void Main(string first, string last, string username, string password, string accType)
        {
            Database_Manager db = new Database_Manager();
            bool exists = false;

            exists = db.checkUsername(username);
            if (exists)
            {
                if (password != null && password != "")
                {
                    db.ChangePassword(username, password);
                }
                if (last != null && last != "")
                {
                    db.ChangeLastname(username, last);
                }
                if (first != null && first != "")
                {
                    db.ChangeFirstname(username, first);
                }
                if (accType != null && accType != "")
                {
                    db.ChangeAccType(username, accType);
                }
                MessageBox.Show("User account successfully changed.");
            }
            else
            {
                MessageBox.Show("ERROR: User account does not exist");
            }
        }

        // salt the password by adding on to the end of it
        private string Salt(string pwd)
        {
            pwd = pwd + ".cs.is.fun.team.dirk.";
            return pwd;
        }

        // hash the password
        private int Hash(string pwd)
        {
            int pwdHash = pwd.GetHashCode();
            return pwdHash;
        }
    }
}
