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

            if (user == "")
            {
                MessageBox.Show("Username field is empty! Please enter a username", "Input Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pass == "")
            {
                MessageBox.Show("Password field is empty! Please enter a password", "Input Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LoginController lgc = new LoginController(accType, user, pass);
        }
    }
}
