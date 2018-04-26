using System;
using System.IO;
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
    public partial class AddFlowerGUI : Form
    {

		AddFlowerCtlr guiControllerReference;
		private int userAcctType;

        public AddFlowerGUI(AddFlowerCtlr ctlr, int acctType)
        {

            InitializeComponent();
			guiControllerReference = ctlr;
			userAcctType = acctType;
		}

		private void addFlowerToDBBtn_Click(object sender, EventArgs e)
		{

			// grab the entered English name, Latin name, and botanical family from the text boxes
			string enteredEnglishName = englishNameEntryBox.Text;

			string enteredLatinName = latinNameEntryBox.Text;

			string enteredBotanicalFamily = botanicalFamEntryBox.Text;

			string enteredNote = noteEntryBox.Text;

			string enteredImgPath = imgPathView.Text;

			// instantiate a Flower object from the user entries
			Flower flowerToAdd = new Flower(enteredLatinName, enteredEnglishName, enteredBotanicalFamily, enteredNote, enteredImgPath);

			// checks the database for existence of a Flower object with the same attributes
			string displayedMsg = AddFlowerCtlr.verifyFlower(flowerToAdd);

			MessageBox.Show(displayedMsg);

            // reset the data in the textboxes
            englishNameEntryBox.Text = "";
            latinNameEntryBox.Text = "";
            botanicalFamEntryBox.Text = "";
            noteEntryBox.Text = "";
            imgPathView.Text = "";

            // flower entry will NOT be added in the GUI; will be added in verifyFlower() using an instantiation of the DBMngr class

                //testDB TDB = new testDB();
                //TDB.addIt(enteredEnglishName, enteredLatinName, enteredBotanicalFamily);
                //MessageBox.Show("Flower successfuly added!");
		
		}
        //
        private void AddToMain_click(object sender, EventArgs e)
        {
            new MainMenu(userAcctType).Show();
            this.Hide();
        }

        private void add_leave_click(object sender, FormClosedEventArgs e)
        {
            new MainMenu(userAcctType).Show();
            this.Hide();
        }

        private void AddFlowerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //new MainMenu().Show();
        }

        private void AddFlowerGUI_Load(object sender, EventArgs e)
        {

        }

		private void uploadImgBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog selectImgPath = new OpenFileDialog();
			selectImgPath.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.gif; *gifv;...";

			if (selectImgPath.ShowDialog() == DialogResult.OK)
				imgPathView.Text = selectImgPath.FileName;

		}
	}
}
