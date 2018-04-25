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

			// giving 'userAcctType' an initial value of 0
			// until a user logs in
			int userAcctType = 0;

            Database_Manager db = new Database_Manager();
            //FOR TESTING ONLY, FLOWERS SHOULD NOT BE INSERTED HERE
            //FOR TESTING ONLY, FLOWERS SHOULD NOT BE INSERTED HERE
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(userAcctType));
        }
    }
}