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
                        //Labels cannot be disabled or else their forecolor will default to black.
                        if (!(ctrl is Label))
                        {
                            ctrl.Enabled = false;
                        }
                        if (ctrl is TextBox || ctrl is RichTextBox)
                        {
                            ctrl.Text = "";
                        }
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
            SignInPage.Visible = true;
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
            SignInPage.Visible = false;

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

        private void SignIn_Title_Click(object sender, EventArgs e){}

        /////////////////////
        ////  LOGIN END  ////
        /////////////////////

        /////////////////////
        /////////////////////

        /////////////////////
        ////LANDING START////
        /////////////////////

        //Activates and shows the landing page for the user. Also checks to see if user as clearance for adding of flowers and changing users.
        private void LandingActivate()
        {
            LandingPage.Visible = true;
            if (accType >= 2)
            {
                AddFlowerButton.Enabled = true;
            }
            if (accType == 3)
            {
                UserControlButton.Enabled = true;
            }
            SearchButton.Enabled = true;
        }

        private void AddFlowerButton_Click(object sender, EventArgs e)
        {
            LandingDeactivate();
            AddFlowerActivate();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LandingDeactivate();
        }

        private void UserControlButton_Click(object sender, EventArgs e)
        {
            LandingDeactivate();
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

        //////////////////////
        //////////////////////

        ///////////////////////
        ////ADDFLOWER START////
        ///////////////////////

        private string AddFlowerPicFileExt;
   
        private void AddFlowerActivate()
        {
            AddFlowerPage.Visible = true;
            EnglishNameTextbox.Enabled = true;
            LatinNameTextbox.Enabled = true;
            BotanicalFamilyTextbox.Enabled = true;
            NotesTextbox.Enabled = true;
            AddFlowerPictureButton.Enabled = true;
        }

        private void AddFlowerSubmitValidate()
        {
            if (EnglishNameTextbox.Text != "" && LatinNameTextbox.Text != "" && BotanicalFamilyTextbox.Text != "")
            {
                AddFlowerSubmitButton.Enabled = true;
            }
            else
            {
                AddFlowerSubmitButton.Enabled = false;
            }
        }

        //English name textbox
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            AddFlowerSubmitValidate();
        }

        //Latin name textbox
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            AddFlowerSubmitValidate();
        }

        //Botanical Family textbox
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            AddFlowerSubmitValidate();
        }

        private void NotesTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e){}

        private void AddFlowerPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImgPath = new OpenFileDialog();
            selectImgPath.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.gif; *gifv;...";
            selectImgPath.InitialDirectory = "%USERPROFILE%\\Documents";
            selectImgPath.Title = "Select an image file";

            if (selectImgPath.ShowDialog() == DialogResult.OK)
                AddFlowerPicFileExt = selectImgPath.FileName;

            if (AddFlowerPicFileExt != "" && AddFlowerPicFileExt != null)
            {
                Bitmap img = new Bitmap(AddFlowerPicFileExt);
                Bitmap resized = new Bitmap(img, 400, 400);
                AddFlowerImageDisplay.Image = resized;
                AddFlowerImageDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void AddFlowerSubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void AddFlowerDeactivate()
        {
            AddFlowerPage.Visible = false;
            EnglishNameTextbox.Text = "";
            LatinNameTextbox.Text = "";
            BotanicalFamilyTextbox.Text = "";
            NotesTextbox.Text = "";
            AddFlowerPicFileExt = "";
        }

        ///////////////////////
        //// ADDFLOWER END ////
        ///////////////////////
    }
}
