using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Justin Feldmann
 * Class: CS 325-002
 * Semester: Spring 2018
 * Filename: ChangeFlowerGUI.cs
 * Professor: Dr. Gary Mayer
 * Last Edited Date/Time: April 10, 2018 2:14 PM
 * 
 * Description: This class contains the necessary event handlers and constructors
 * for the Change Flower GUI.
 */

namespace Florae_Basket
{
	public partial class ChangeFlowerGUI : Form
	{

		int copyOfFlowerId;

		public ChangeFlowerGUI(int key)
		{
			InitializeComponent();
			copyOfFlowerId = key;
		}

		private void changeFlowerSubmit_Click(object sender, EventArgs e)
		{

			// can't change latin name, as it's used to find the id
			//string changedLatinName = latinNameEntryBox.Text;

			string changedEnglishName = englishNameEntryBox.Text;

			string changedLatinName = latinNameEntryBox.Text;

			string changedBotanicalFam = botanicalFamEntryBox.Text;

			string changedNote = noteEntryBox.Text;

			string changedImgPath = imgPathView.Text;

			ChangeFlowerCtlr changeFlowerCtlrReference = new ChangeFlowerCtlr(copyOfFlowerId);

			// begin the checking of the database for an existing entry with these parameters
			string msgToDisplay = changeFlowerCtlrReference.verifyFlower(changedEnglishName, changedLatinName, changedBotanicalFam, changedNote, changedImgPath);

			MessageBox.Show(msgToDisplay);

		}

		private void ChangeToFlowerProfileBtn_Click(object sender, EventArgs e)
		{
			Database_Manager DBMngrInstance = new Database_Manager(); 
			new flowerProfile(DBMngrInstance.FetchEnglish(copyOfFlowerId), DBMngrInstance.FetchLatin(copyOfFlowerId), DBMngrInstance.FetchBotan(copyOfFlowerId), DBMngrInstance.FetchNote(copyOfFlowerId), DBMngrInstance.FetchFilePath(copyOfFlowerId), copyOfFlowerId).Show();
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
