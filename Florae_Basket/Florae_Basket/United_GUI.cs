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

        //for use with each different function.
        //Admin:      3
        //Researcher: 2
        //Student:    1
        private int accType = 0;

        /////////////////////
        //// LOGIN START ////
        /////////////////////

        private string user;
        private string pass;
        private int attempts = 0;

        //Username textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
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
        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void LoginClear()
        {
            attempts = 0;
            Username_txt.Clear();
            Password_txt.Clear();
            Username_txt.Enabled = false;
            Password_txt.Enabled = false;
            Incorrect_Login_Warning.Visible = false;

            //TODO: delete red outline on textboxes.
        }

        //Login submit button
        private void button1_Click(object sender, EventArgs e)
        {
            user = Username_txt.Text;
            pass = Password_txt.Text;

            LoginController loginController = new LoginController(accType, user, pass);
            user = pass = "";

            if (loginController.Fail())
            {
                attempts++;
                LoginError();
            }
            else
            {
                LoginClear();
            }
        }

        /////////////////////
        ////  LOGIN END  ////
        /////////////////////

    }
}
