using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florae_Basket
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void addFlowerMainMenuBtn_Click(object sender, EventArgs e)
		{
			Application.Run(new AddFlowerGUI());
		}

		private void searchFlowerMainMenuBtn_Click(object sender, EventArgs e)
		{
			Test_WS_GUI test = new Test_WS_GUI();
			Application.Run(test);
			if ((test.egn_name != null && test.egn_name != "") ||
				(test.latin_word != null && test.latin_word != "") ||
				(test.botanical != null && test.botanical != ""))
			{
				Word_Search word = new Word_Search(test.egn_name, test.latin_word, test.botanical);
				word.Search();
			}
		}
	}
}
