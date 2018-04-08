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
	public partial class ChangeFlowerGUI : Form
	{

		ChangeFlowerCtlr changeFlowerCtlrReference;

		Flower flowerToVerify;

		public ChangeFlowerGUI()
		{
			InitializeComponent();
		}

		private void changeFlowerSubmit_Click(object sender, EventArgs e)
		{

			string changedLatinName = latinNameEntryBox.Text;

			string changedEnglishName = englishNameEntryBox.Text;

			string changedBotanicalFam = botanicalFamEntryBox.Text;

			string enteredNote = noteEntryBox.Text;

			string enteredImgPath = imgPathView.Text;

			flowerToVerify = new Flower(changedLatinName, changedEnglishName, changedBotanicalFam, enteredNote, enteredImgPath);

			// begin the checking of the database for an existing entry with these parameters
			string msgToDisplay = ChangeFlowerCtlr.verifyFlower(flowerToVerify);

			MessageBox.Show(msgToDisplay);

		}

		private void ChangeToFlowerProfileBtn_Click(object sender, EventArgs e)
		{
			Database_Manager DBMngrInstance = new Database_Manager(); 
			new flowerProfile(flowerToVerify.getEnglishName(), flowerToVerify.getLatinName(), flowerToVerify.getBotanicalFam(), flowerToVerify.getNote(), flowerToVerify.getImgPath(), DBMngrInstance.FetchID(flowerToVerify.getLatinName())).Show();
			this.Hide();

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
