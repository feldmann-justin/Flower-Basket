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
				(test.botanical != null && test.botanical != ""))
			{
				Word_Search word = new Word_Search(test.egn_name, test.latin_word, test.botanical);
				word.Search();
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

        private void userOptions_click(object sender, EventArgs e)
        {
            new UserOptions().Show();
            this.Hide();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
