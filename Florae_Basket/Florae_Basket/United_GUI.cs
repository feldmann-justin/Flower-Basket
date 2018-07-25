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
    public partial class United_GUI : Form
    {
        public United_GUI()
        {
            InitializeComponent();
        }

        ///////////////////////
        ////UNIVERSAL START////
        ///////////////////////
        
        //for use with each different function.
        //Admin:      3
        //Researcher: 2
        //Student:    1
        private int accType = 0;

        public int GetaccType() => accType;

        //Handles the actions needed to disable the correct panels in order to sign the user out.
        //iterates through each panel and disables their controls, then hides the panel itself.
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            foreach (Control pan in Controls)
            {
                if (pan is Panel)
                {
                    foreach (Control ctrl in pan.Controls)
                    {
                        ctrl.Enabled = false;
                    }
                    pan.Visible = false;
                }
            }
            LoginAcvtivate();
        }

        ///////////////////////
        //// UNIVERSAL END ////
        ///////////////////////

        //////////////////////
        //////////////////////

        /////////////////////
        //// LOGIN START ////
        /////////////////////

        private string user;
        private string pass;
        private int attempts = 0;

        //Enables the textboxes on the login page.
        //Disables the logout button as well.
        private void LoginAcvtivate()
        {
            accType = 0;
            Username_txt.Enabled = true;
            Password_txt.Enabled = true;
            Login_submit.Enabled = false;
            LogOutButton.Enabled = false;
            LogOutButton.Visible = false;
        }

        //Username textbox
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Password_txt.Text != "" && Username_txt.Text != "")
            {
                Login_submit.Enabled = true;
            }
            else
            {
                Login_submit.Enabled = false;
            }
        }

        //Password textbox
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (Password_txt.Text != "" && Username_txt.Text != "")
            {
                Login_submit.Enabled = true;
            }
            else
            {
                Login_submit.Enabled = false;
            }
        }

        //Called when incorrect info is given
        private void LoginError()
        {
            Incorrect_Login_Warning.Visible = true;

            //TODO: outline textboxes with red when called.
        }

        //clears the login information and disables all controls on the panel. 
        //Used when right username and password is provided in order to transition to the next panel.
        private void LoginClear()
        {
            attempts = 0;
            Username_txt.Clear();
            Password_txt.Clear();
            Username_txt.Enabled = false;
            Password_txt.Enabled = false;
            Login_submit.Enabled = false;
            Incorrect_Login_Warning.Visible = false;

            //TODO: delete red outline on textboxes.
        }

        //Login submit button
        private void Button1_Click(object sender, EventArgs e)
        {
            user = Username_txt.Text;
            pass = Password_txt.Text;

            LoginController loginController = new LoginController(ref accType, user, pass);
            user = pass = "";

            if (loginController.Fail())
            {
                attempts++;
                LoginError();
            }
            else
            {
                LoginClear();
                LandingActivate();
                LogOutButton.Enabled = LogOutButton.Visible = true;
            }
        }

        private void SignIn_Title_Click(object sender, EventArgs e)
        {

        }

        /////////////////////
        ////  LOGIN END  ////
        /////////////////////

        /////////////////////
        /////////////////////

        /////////////////////
        ////LANDING START////
        /////////////////////

        private void LandingActivate()
        {
            LandingPage.Visible       = true;
            AddFlowerButton.Enabled   = true;
            SearchButton.Enabled      = true;
            UserControlButton.Enabled = true;
        }

        private void AddFlowerButton_Click(object sender, EventArgs e)
        {
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void UserControlButton_Click(object sender, EventArgs e)
        {

        }

        private void LandingDeactivate()
        {
            AddFlowerButton.Enabled   = false;
            SearchButton.Enabled      = false;
            UserControlButton.Enabled = false;
            LandingPage.Visible       = false;
        }

        /////////////////////
        //// LANDING END ////
        /////////////////////
    }
}
