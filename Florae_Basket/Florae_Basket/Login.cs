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
    public partial class Login : Form
    {
        private string user;
        private string pass;
        private int accType;
        private int attempts = 0;

        public Login()
        {
            InitializeComponent();
            accType = 0;
        }

        public Login(int userType)
        {
            InitializeComponent();
            accType = userType;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            user = userBox.Text;
            pass = passBox.Text; 

            if (attempts >= 3) {
                MessageBox.Show("Too many attempts! You cannot login at the moment.", "Security Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (user == "")
            {
                MessageBox.Show("Username field is empty! Please enter a username.", "Input Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pass == "")
            {
                MessageBox.Show("Password field is empty! Please enter a password.", "Input Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoginController lgc = new LoginController(accType, user, pass);
                if (lgc.Fail()) { attempts++; }
                else {
                    // this is to simply close out of the Login menu after a successful login
                    this.Hide();
                    //MessageBox.Show("You have entered into the Florae Basket Main Menu.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

			

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
