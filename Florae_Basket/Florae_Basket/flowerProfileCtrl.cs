using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florae_Basket
{
    public class flowerProfileCtrl
    {
        public void createGUI(string eng, string lat, string bot, string note, string image, int id, int acctType)
        {
            flowerProfile prof = new flowerProfile(eng, lat, bot, note, image, id, acctType);
            prof.ShowDialog();
        }

        public void createPrint(flowerProfile flowerProf)
        {
            printCtrl myPrint = new printCtrl();
            myPrint.main(flowerProf);
        }
    }
}
