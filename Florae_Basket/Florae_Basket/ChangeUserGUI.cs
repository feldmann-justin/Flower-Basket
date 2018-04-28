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
    public partial class ChangeUserGUI : Form
    {
        ChangeUserCtlr controller;
        private string first = "";
        private string last = "";
        private string user = "";
        private string pass = "";
        private string accType = "";

        public ChangeUserGUI(ChangeUserCtlr userCtrl)
        {
            InitializeComponent();
            account.SelectedIndex = 0;
            controller = userCtrl;
        }

        /*private void ChangeUserGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            new MainMenu().Show();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            first = firstname.Text;
            last = lastname.Text;
            user = username.Text;
            pass = password.Text;
            accType = account.Text;
            controller.Main(first, last, user, pass, accType);
            firstname.Text = "";
            lastname.Text = "";
            username.Text = "";
            password.Text = "";
            account.Text = "";
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private bool Isvalid()
        {
            return (((password.Text != "" && password != null) ||
                    (firstname.Text != "" && firstname.Text != null) ||
                    (lastname.Text != "" && lastname.Text != null) ||
                    (account.Text != "(No change)")) &&
                    (username.Text != "" && username.Text != null));
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }
        }

        private void ChangeUserGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
