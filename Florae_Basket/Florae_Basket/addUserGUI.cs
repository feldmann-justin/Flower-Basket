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
    public partial class addUserGUI : Form
    {
        addUserCtrl controller;
		private int userAcctType;
        private string first = "";
        private string last = "";
        private string user = "";
        private string pass = "";
        private string accType = "";
        private string file = "";

        public addUserGUI(addUserCtrl u, int acctType)
        {
            InitializeComponent();
            controller = u;
			userAcctType = acctType;
        }

        private void addUserGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            new MainMenu(userAcctType).Show();
        }

        private void chooseFile_click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV|*.csv";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                file_textBox.Text = ofd.FileName;
            }
        }

        private void addUserSubmit_click(object sender, EventArgs e)
        {
            first = first_textBox.Text;
            last = last_textBox.Text;
            user = username_textBox.Text;
            pass = password_textBox.Text;
            accType = accType_textBox.Text;
            file = file_textBox.Text;
            controller.main(first, last, user, pass, accType, file);
            file_textBox.Text = "";
            first_textBox.Text = "";
            last_textBox.Text = "";
            username_textBox.Text = "";
            password_textBox.Text = "";
            accType_textBox.Text = "";
        }

        private void file_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUserGUI_Load(object sender, EventArgs e)
        {

        }

        private void last_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
