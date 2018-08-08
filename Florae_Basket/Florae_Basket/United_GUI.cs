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

        //Stack contains the activation methods for the previous panels
        private Stack<Action> PreviousPanels = new Stack<Action>();
        //Stack contains panel to be deactivated once back button is pushed.
        private Stack<Panel> CurrentPanels = new Stack<Panel>();

        //Handles the action of going back a single panel in the program.
        private void BackButton_Click(object sender, EventArgs e)
        {
            Panel temppan = CurrentPanels.Pop() as Panel;
            Action tempaction = PreviousPanels.Pop();
            DeactivatePanel(ref temppan);
            tempaction();
        }

        //Handles the actions needed to disable the correct panels in order to sign the user out.
        //iterates through each panel and disables their controls, then hides the panel itself.
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            foreach (Control pan in Controls)
            {
                if (pan is Panel)
                {
                    Panel temppan = pan as Panel;
                    DeactivatePanel(ref temppan);
                }
            }
            LoginAcvtivate();
        }

        private void DeactivatePanel(ref Panel pan)
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
                if (ctrl is PictureBox)
                {
                    PictureBox box = ctrl as PictureBox;
                    box.Image = null;
                }
            }
            pan.Visible = false;
        }

        ///////////////////////
        //// UNIVERSAL END ////
        ///////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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
            BackButton.Enabled = false;
            BackButton.Visible = false;
            CurrentPanels.Clear();
            PreviousPanels.Clear();
            CurrentPanels.Push(SignInPage);
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
                DeactivatePanel(ref SignInPage);
                Incorrect_Login_Warning.Visible = false;
                LandingActivate();
                LogOutButton.Enabled = LogOutButton.Visible = true;
                BackButton.Enabled = BackButton.Visible = true;
                PreviousPanels.Push(LoginAcvtivate);
                CurrentPanels.Push(LandingPage);
            }
        }

        /////////////////////
        ////  LOGIN END  ////
        /////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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
            DeactivatePanel(ref LandingPage);
            PreviousPanels.Push(LandingActivate);
            CurrentPanels.Push(AddFlowerPage);
            AddFlowerActivate();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DeactivatePanel(ref LandingPage);
            PreviousPanels.Push(LandingActivate);
            CurrentPanels.Push(SearchPage);
            SearchActivate();
        }

        private void UserControlButton_Click(object sender, EventArgs e)
        {
            DeactivatePanel(ref LandingPage);
            PreviousPanels.Push(LandingActivate);
        }

        /////////////////////
        //// LANDING END ////
        /////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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
        private void EnglishNameTextbox_TextChanged_1(object sender, EventArgs e)
        {
            AddFlowerSubmitValidate();
        }

        //Latin name textbox
        private void LatinNameTextbox_TextChanged_1(object sender, EventArgs e)
        {
            AddFlowerSubmitValidate();
        }

        //Botanical Family textbox
        private void BotanicalFamilyTextbox_TextChanged(object sender, EventArgs e)
        {
            AddFlowerSubmitValidate();
        }

        private void NotesTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFlowerPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImgPath = new OpenFileDialog
            {
                Filter = "Image Files| *.jpg; *.jpeg; *.png; *.gif; *gifv;...",
                InitialDirectory = "%USERPROFILE%\\Documents",
                Title = "Select an image file"
            };

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

        private void AddFlowerSubmitButton_Click_1(object sender, EventArgs e)
        {
            // grab the entered English name, Latin name, and botanical family from the text boxes
            string enteredEnglishName = EnglishNameTextbox.Text;
            string enteredLatinName = LatinNameTextbox.Text;
            string enteredBotanicalFamily = BotanicalFamilyTextbox.Text;
            string enteredNote = NotesTextbox.Text;
            string enteredImgPath = AddFlowerPicFileExt;

            // instantiate a Flower object from the user entries
            Flower flowerToAdd = new Flower(enteredLatinName, enteredEnglishName, enteredBotanicalFamily, enteredNote, enteredImgPath);

            bool added = AddFlowerCtlr.verifyFlower(flowerToAdd);

            if (added)
            {
                MessageBox.Show("Flower added to the database!");
                EnglishNameTextbox.Text = "";
                LatinNameTextbox.Text = "";
                BotanicalFamilyTextbox.Text = "";
                NotesTextbox.Text = "";
                AddFlowerPicFileExt = "";
                AddFlowerImageDisplay.Image = null;
                AddFlowerSubmitButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Flower was not added, it might already be in the database.");
            }
        }

        ///////////////////////
        //// ADDFLOWER END ////
        ///////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////
        //// SEARCH START ////
        //////////////////////

        private void SearchActivate()
        {
            SearchPage.Visible = true;
            EnglishSearchBox.Enabled = true;
            LatinSearchBox.Enabled = true;
            BotanicalSearchBox.Enabled = true;
        }

        //////////////////////
        ////  SEARCH END  ////
        //////////////////////
    }
}
