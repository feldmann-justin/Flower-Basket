using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Florae_Basket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBManager db = new DBManager();
            //FOR TESTING ONLY, FLOWERS SHOULD NOT BE INSERTED HERE
            db.InsertFlower("violet", "violat", "vio fam", "vio note", "flower.jpg");
            db.InsertFlower("rose", "roselat", "ros fam", "ros  note", "flower.jpg");
            db.InsertFlower("tulip", "tulilat", "tul fam", "tul note", "flower.jpg");
            //FOR TESTING ONLY, FLOWERS SHOULD NOT BE INSERTED HERE
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}