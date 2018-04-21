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
		private int userAcctType;

        public UserOptions(int acctType)
        {
            InitializeComponent();
			userAcctType = acctType;
        }

        private void addUser_click(object sender, EventArgs e)
        {
            new addUserCtrl().createGui(userAcctType);
            forward = true;
            this.Close();
        }

        private void UserOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(forward == false)
                new MainMenu(userAcctType).Show();
        }

        private void UserOptions_Load(object sender, EventArgs e)
        {

        }

        private void ChangeUserbtn_Click(object sender, EventArgs e)
        {
            new ChangeUserCtlr().CreateGUI();
            forward = true;
            this.Close();
        }
    }
}
