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
    public partial class AddFlowerGUI : Form
    {
        public AddFlowerGUI()
        {
            InitializeComponent();
        }

		private void addFlowerToDBBtn_Click(object sender, EventArgs e)
		{

			// grab the entered English name, Latin name, and botanical family from the text boxes
			string enteredEnglishName = englishNameEntryBox.Text;

			string enteredLatinName = latinNameEntryBox.Text;

			string enteredBotanicalFamily = botanicalFamEntryBox.Text;

			int uniqueFlowerID = 0;

			// instantiate a Flower object from the user entries
			Flower flowerToAdd = new Flower(enteredLatinName, enteredEnglishName, enteredBotanicalFamily, uniqueFlowerID);

			AddFlowerCtlr myController = new AddFlowerCtlr();

			bool doesEntryExist = myController.verifyFlower(flowerToAdd);

			

		}
	}
}
