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
			// brings up the Add Flower GUI
			new AddFlowerGUI().Show();

			// hides the Main Menu GUI
			this.Hide();
		}

		private void searchFlowerMainMenuBtn_Click(object sender, EventArgs e)
		{

			Test_WS_GUI test = new Test_WS_GUI();

            // hides the Main Menu GUI
            //this.Hide();
            this.Visible = false;

            // brings up the Search Flower GUI
            //test.Show();
            test.ShowDialog();

            

			
			if ((test.egn_name != null && test.egn_name != "") ||
				(test.latin_word != null && test.latin_word != "") ||
				(test.botanical != null && test.botanical != "") ||
                (test.note_keywords != null && test.note_keywords != ""))
			{
				Word_Search word = new Word_Search(test.egn_name, test.latin_word, test.botanical, test.note_keywords);
				word.Search();
                ResultsCtrl results = new ResultsCtrl(word.Get_results()[0].id, word.Get_results()[1].id, word.Get_results()[2].id);
                results.Run();
			}
		}

        private void MainToProfileButton_click(object sender, EventArgs e)
        {
            new flowerProfile().Show();
            this.Hide();
        }

        private void Main_leave_click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
