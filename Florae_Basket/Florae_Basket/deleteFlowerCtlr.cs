using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                             //                
// delete_flower_controller                                                                                    //
// By Kade Walter                                                                                              //
//                                                                                                             //
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Florae_Basket
{
    class deleteFlowerCtlr
    {
        // main method for flower controller. Takes the id of the flower currently being displayed on the profile
        public static bool main(int id)
        {
            bool confirm, removed;
            string msg;
            // asks the user for confirmation of deletion
            confirm = confirmation();
            // if they do want to delete the flower
            if (confirm == true)
            {
                // remove the flower
                removed = removeFlower(id);
                if (removed == true)
                {
                    msg = succMsg();
                    showMsg(msg);
                    return true;
                }
                else
                {
                    msg = failMsg();
                    showMsg(msg);
                    return false;
                }
            }
            else
            {
                msg = failMsg();
                showMsg(msg);
                return false;
            }
        }

        // asks the user if they really want to delete the flower
        private static bool confirmation()
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this flower?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // remove the flower from the database
        public static bool removeFlower(int id)
        {
            // database connection variables and info

            DBManager db = new DBManager();

            // try to open the database and delete
            try
            {
                // connect to DBMngr and execute the delete flower function
                db.DeleteFlower(id);
                return true;
            }
            // if error is thrown, return false
            catch(Exception ex)
            {
                return false;
            }
        }

        // successfully deleted message
        private static string succMsg()
        {
            string msg = "Flower deleted.";
            return msg;
        }

        // failed to delete message
        private static string failMsg()
        {
            string msg = "Flower was not deleted.";
            return msg;
        }

        // displays the message to the user
        private static void showMsg(string msg)
        {
            MessageBox.Show(msg);
        }

    }
}
