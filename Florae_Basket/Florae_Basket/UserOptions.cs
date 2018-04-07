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
    public partial class UserOptions : Form
    {
        private bool forward = false;
        public UserOptions()
        {
            InitializeComponent();
        }

        private void addUser_click(object sender, EventArgs e)
        {
            new addUserGUI().Show();
            forward = true;
            this.Close();
        }

        private void UserOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(forward == false)
                new MainMenu().Show();
        }

        private void UserOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
