using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florae_Basket
{
    class deleteFlower
    {

        // get the current flowers id # in the database
        int flowerID()
        {
            int id = Flower.getID();
            return id;
        }

        // remove the flower from the database
        void removeFlower(int id)
        {
            // database connection variables and info



            // try to open the database and delete
            try
            {
                // database connection info

                // successful deletion message
                MessageBox.Show("Flower deleted.");
            }
            // if error is thrown, return false
            catch(Exception ex)
            {
                // error in deletion message
                MessageBox.Show("Error when deleting. Flower not deleted.");
                return;
            }
        }

        void main()
        {
            int id = flowerID();
            removeFlower(id);
            return;
        }
    }
}
