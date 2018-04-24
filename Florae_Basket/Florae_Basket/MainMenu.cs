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
		private bool closeMainMenuYesNo = false;

		// will hold an integer value corresponding to a specific account type
		// 1 will be for Students
		// 2 will be for Researchers
		// 3 will be for Administrators
		private int userAcctType;

		public MainMenu(int acctType)
		{
			InitializeComponent();

			userAcctType = acctType;

		}
		private void addFlowerMainMenuBtn_Click(object sender, EventArgs e)
		{
			// only execute the code for the Add Flower event handler if the user is a Researcher or Admin
			if ((userAcctType == 2) || (userAcctType == 3))
			{

				// create a new instance of the AddFlowerCtlr, which will call displayAddFlowerGUI() to actually create the Add Flower GUI
				new AddFlowerCtlr().DisplayAddFlowerGUI(userAcctType);

				// set 'closeMainMenuYesNo' to true, so we will in fact close the main menu now
				closeMainMenuYesNo = true;

				// closes the Main Menu GUI
				this.Hide();

			}
			else
				MessageBox.Show("Must be a researcher or administrator to use this feature.");

		}

		private void searchFlowerMainMenuBtn_Click(object sender, EventArgs e)
		{
            bool res1 = false;
            bool res2 = false;
            bool res3 = false;
			SearchGUI test = new SearchGUI(userAcctType);

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
                results.Run(ref res1, ref res2, ref res3);
                ResultsGUI resultgui = new ResultsGUI(results.id, results.flowers, results.notes, results.images1, userAcctType);
                if (!res1)
                {
                    resultgui.Result1btn.Enabled = false;
                    MessageBox.Show("No results were found");
                }
                if (!res2)
                {
                    resultgui.Result2btn.Enabled = false;
                }
                if (!res3)
                {
                    resultgui.Result3btn.Enabled = false;
                }
                if (res1)
                {
                    resultgui.ShowDialog(this);
                }
                
                //This is to exit application if user X's out of resultGUI, couldn't get any other way to work for some reason.
                if (resultgui.exit == true)
                {
                    new MainMenu(userAcctType).Show();
                }
            }
		}

        //private void MainToProfileButton_click(object sender, EventArgs e)
        //{
        //    new flowerProfile().Show();
        //    this.Hide();
        //}

        private void Main_leave_click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userOptions_click(object sender, EventArgs e)
        {

			// only execute the code for the User Options event handler if the user is an Admin
			if (userAcctType == 3)
			{

				new UserOptions(userAcctType).Show();
				this.Hide();

			}
			else
				MessageBox.Show("Must be an administrator to use this feature.");

            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Application.Exit();

        }

		//private void exit_click(object sender, EventArgs e)
		//{
		//    Application.Exit();
		//}

		private void logoutBtn_Click(object sender, EventArgs e)
		{

			LogoutCtlr logoutCtlr = new LogoutCtlr();

			// first, display the confirmation message to the user
			DialogResult selection = logoutCtlr.DisplayLogoutConfirm();

			// second, return bool value based on the user's choice in logoutConfirm()
			bool userSelection = logoutCtlr.LogoutConfirm(selection);

			// lastly, the ACTUAL business logic is performed based on the user's choice
			if (userSelection == true)
			{
				// reset the counter which controls user permissions
				userAcctType = 0;

				// will display the login page, once Dipak's Login controller is integrated into the project

			}


		}

		private void MainMenu_Load(object sender, EventArgs e)
        {

        }

	}
}
