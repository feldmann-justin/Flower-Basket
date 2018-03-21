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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu());

			// moved this code to 'searchFlowerMainMenuBtn' event handler in 'MainMenu.cs'

			//Test_WS_GUI test = new Test_WS_GUI();
			//Application.Run(test);
			//if ((test.egn_name != null && test.egn_name != "") ||
			//	(test.latin_word != null && test.latin_word != "") ||
			//	(test.botanical != null && test.botanical != ""))
			//{
			//	Word_Search word = new Word_Search(test.egn_name, test.latin_word, test.botanical);
			//	word.Search();
			//}
		}
    }
}