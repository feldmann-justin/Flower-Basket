﻿using System;
using System.Windows.Forms;

namespace Florae_Basket
{
    public partial class SearchGUI : Form
    {
        public string egn_name;
        public string latin_word;
        public string botanical;
        public string filename;
        public string note_keywords;
		private int userAcctType;

        public SearchGUI(int acctType)
        {
            InitializeComponent();
            this.AcceptButton = SearchBTN;
            filename = "";
			userAcctType = acctType;
        }

        private void SearchBTN_Click(object sender, EventArgs e) => this.Hide();

        private void Latin_TextChanged(object sender, EventArgs e)
        {
            if (Latin.Text != "")
            {
                SearchBTN.Enabled = true;
            }
            else if (Latin.Text == "" && EName.Text == "" && Botan.Text == "" && filename == "" && Notes.Text == "")
            {
                SearchBTN.Enabled = false;
            }
            latin_word = Latin.Text;
        }

        private void EName_TextChanged(object sender, EventArgs e)
        {
            if (EName.Text != "")
            {
                SearchBTN.Enabled = true;
            }
            else if (Latin.Text == "" && EName.Text == "" && Botan.Text == "" && filename == "" && Notes.Text == "")
            {
                SearchBTN.Enabled = false;
            }
            egn_name = EName.Text;
        }

        private void Botan_TextChanged(object sender, EventArgs e)
        {
            if (Botan.Text != "")
            {
                SearchBTN.Enabled = true;
            }
            else if (Latin.Text == "" && EName.Text == "" && Botan.Text == "" && filename == "" && Notes.Text == "")
            {
                SearchBTN.Enabled = false;
            }
            botanical = Botan.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.gif; *gifv;...";
            //open.ShowDialog();
            //filename = open.FileName;
            //if (filename != "")
            //{
            //    SearchBTN.Enabled = true;
            //}
            ImageSearch ims = new ImageSearch(userAcctType);
            ims.ShowDialog();
            this.Hide();
        }

        private void Notes_TextChanged(object sender, EventArgs e)
        {
            if (Notes.Text != "")
            {
                SearchBTN.Enabled = true;
            }
            else if (Latin.Text == "" && EName.Text == "" && Botan.Text == "" && filename == "" && Notes.Text == "")
            {
                SearchBTN.Enabled = false;
            }
            note_keywords = Notes.Text;
        }

        private void WSToMainButton_click(object sender, EventArgs e)
        {
            //new MainMenu(userAcctType).Show();
            this.Hide();
        }

        private void Test_WS_GUI_Load(object sender, EventArgs e)
        {

        }
    }
}
