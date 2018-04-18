using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florae_Basket
{
    class ChangeUserCtlr
    {
        public ChangeUserCtlr()
        {

        }

        public void CreateGUI()
        {

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
