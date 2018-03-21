using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        // remove the flower from the database
        public static void removeFlower(int id)
        {
            // database connection variables and info



            // try to open the database and delete
            try
            {
                // database connection info

                // successful deletion message
                MessageBox.Show("Flower " + id + " deleted.");
            }
            // if error is thrown, return false
            catch(Exception ex)
            {
                // error in deletion message
                MessageBox.Show("\nMessage ---\n{0}", ex.Message);
                return;
            }
        }
    }
}
