using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Florae_Basket
{
    class addUserCtrl
    {
        private string[] failedItems;
        List<string> addedUserList = new List<string>();
        List<string> failedUserList = new List<string>();

        public void main(string first, string last, string username, string password, string accType, string file)
        {
            Database_Manager dbm = new Database_Manager();
            string msg = "";
            int addedCount = 0;
            int failedCount = 0;
            bool valid;
            bool added = false;
            bool exists = true;
            string line;

            // entries from a batch file
            if (file != "")
            {
                // while not at the end of the csv file, read the line and save the data in the corresponding variables
                using (StreamReader sr = File.OpenText(file))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = new string[5] { "", "", "", "", "" }; // sets initial values to 0
                        string[] tempValues = line.Split(',');                 // creates a temp array, so if something is missing, it doesnt mess up assigning values below
                        for (int i = 0; i < tempValues.Length; i++)
                        {
                            values[i] = tempValues[i];
                        }
                        // set values
                        first = values[0];
                        last = values[1];
                        username = values[2];
                        password = values[3];
                        accType = values[4];
                        // verify that required info is provided
                        failedItems = new string[5];
                        valid = verifyInfo(first, last, username, password, accType);
                        // if it is
                        if (valid == true)
                        {
                            // check database to see if username exists
                            exists = dbm.checkUsername(username);
                            if (exists == false)
                            {
                                // salt and hash pasword
                                password = Salt(password);
                                int hashPass = Hash(password);
                                // add to database
                                added = dbm.addUser(first, last, username, password, accType);
                                // if the user was added, keep track of the addition
                                if (added == true)
                                {
                                    // user was added, update added info
                                    addedCount = updateAddedCount(addedCount);
                                    addedUserList.Add(first + " " + last + ": " + username);
                                }
                                else
                                {
                                    // user was not added, update failed info
                                    failedCount = updateFailedCount(failedCount);
                                    failedUserList.Add(first + " " + last + ": " + username);
                                }
                            }
                            else
                            {
                                // username already exists in DB
                                failedCount = updateFailedCount(failedCount);
                                failedUserList.Add(first + " " + last + ": " + username);
                            }
                        }
                        else
                        {
                            // if user was not added, keep track of failed additions
                            failedCount = updateFailedCount(failedCount);
                            failedUserList.Add(first + " " + last + ": " + username);
                        }
                    }
                    // create a message of how many added and failed users from batch file
                    msg = createBatchMsg(addedCount, failedCount);
                }
            }

            // used for text box entries 
            else
            {
                // verify that required info is provided
                failedItems = new string[5];
                valid = verifyInfo(first, last, username, password, accType);
                // if it is
                if (valid == true)
                {
                    // check database to see if username exists
                    exists = dbm.checkUsername(username);
                    if (exists == false)
                    {
                        // salt and hash pasword
                        password = Salt(password);
                        int hashPass = Hash(password);
                        // add to database
                        added = dbm.addUser(first, last, username, password, accType);
                        // provide confirmation
                        msg = confirmMsg(username);
                    }
                    else
                    {
                        msg = userExistsMsg(username);
                    }
                }
                else
                    // provide feedback why it didn't get added
                    msg = failMsg(username);
            }
            // display success/fail message
            ShowMsg(msg);
        }

        // confirms that the required info for a new user was provided
        // if not provided, it adds the item to a list to display to the users 
        private bool verifyInfo(string first, string last, string username, string password, string accType)
        {
            bool valid = true;
            if (first == "")
            {
                failedItems[0] = " First Name";
                valid = false;
            }
            if (last == "")
            {
                failedItems[1] = " Last Name";
                valid = false;
            }
            if (username == "")
            {
                failedItems[2] = " Username";
                valid = false;
            }
            if (password == "")
            {
                failedItems[3] = " Password";
                valid = false;
            }
            if (accType != "Administrator" && accType != "Researcher" && accType != "Student")
            {
                failedItems[4] = " Account Type";
                valid = false;
            }
            return valid;
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

        // provide reasons why user wasnt added to database
        private string failMsg(string username)
        {
            string msg = "Unable to add user " + username + " because of the following missing information:";
            for (int i = 0; i < failedItems.Length; i++)
            {
                msg += failedItems[i];

            }
            return msg;
        }

        // provide successful addition message
        private string confirmMsg(string username)
        {
            string msg = "User " + username + " added.";
            return msg;
        }

        // display the success/fail message to the user
        private void ShowMsg(string msg)
        {
            MessageBox.Show(msg);
        }

        // update the added count
        private int updateAddedCount(int addedCount)
        {
            return addedCount + 1;
        }

        // update the failed count
        private int updateFailedCount(int failedCount)
        {
            return failedCount + 1;
        }

        // create the message for a batch file
        private string createBatchMsg(int addedCount, int failedCount)
        {
            string msg;
            msg = "Users added: " + addedCount + " , Users not added: " + failedCount + "\n";
            msg += "\nAdded Users:\n";
            for(int i = 0; i < addedUserList.Count; i++)
            {
                msg += addedUserList[i] + "\n";
            }
            msg += "\nFailed Users: \n";
            for (int i = 0; i < failedUserList.Count; i++)
            {
                msg += failedUserList[i] + "\n";
            }
            return msg;
        }

        // creats a string letting the admin know that the username already exists and can not be duplicated.
        private string userExistsMsg(string username)
        {
            string msg = "Please use a different username. " + username + " is already used.";
            return msg;
        }
    }
}
