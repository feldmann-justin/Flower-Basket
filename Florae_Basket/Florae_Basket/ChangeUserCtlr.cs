using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//////////////////////
/// by Brady Smith ///
//////////////////////


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
                    // salt and hash the password
                    password = Salt(password);
                    int hashPass = Hash(password);
                    password = Convert.ToString(hashPass);
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
                if (accType != null && accType != "" && accType != "(No change)")
                {
                    db.ChangeAccType(username, accType);
                }
                if (verify(username, password, first, last, accType))
                {
                    MessageBox.Show("User account successfully changed.");
                }
                else
                {
                    MessageBox.Show("ERROR: User info was not changed");
                }
            }
            else
            {
                MessageBox.Show("ERROR: User account does not exist");
            }
        }

        // salt the password by adding on to the end of it
        public string Salt(string pwd)
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

        public bool verify(string username, string password, string first, string last, string acct)
        {
            Database_Manager db = new Database_Manager();

            if (password != "" && password != null)
            {
                string salted = Salt(password);
                int temp = Hash(salted);
                salted = temp.ToString();
                if (db.FetchPassword(username) != password)
                {
                    return false;
                }
            }
            if (first != "" && first != null)
            {
                if (db.Fetchfirst(username) != first)
                {
                    return false;
                }
            }
            if (last != "" && last != null)
            {
                if (db.FetchLast(username) != last)
                {
                    return false;
                }
            }
            if (acct != "(No change)")
            {
                if (db.Fetchaccttype(username) != acct)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
