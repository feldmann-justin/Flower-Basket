﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Florae_Basket
{
    public partial class flowerProfile : Form
    {
        // global flower info variables
        private string englishName;
        private string latinName;
        private string botanicalFamily;
        private string note = " ";
        private string imageName;
        private int primaryKey = 0;
		private int userAcctType;

        public flowerProfile(int acctType)
        {
            InitializeComponent();
			userAcctType = acctType;
        }

        public flowerProfile(string name, string latin, string botan, string note, string image, int id, int acctType)
        {
            InitializeComponent();
            englishName = name;
            latinName = latin;
            botanicalFamily = botan;
            this.note = note;
            imageName = image;
            primaryKey = id;
			userAcctType = acctType;
        }

        private void flowerProfile_Load(object sender, EventArgs e)
        {
            // start file path and add black background to the picture box
            string filePath = "";
            if (primaryKey < 7)
                //ONLY FOR TESTING REMOVE FROM FINAL PRODUCT
            {
                filePath = "..\\..\\Pics\\";
            }
            
            flowerImage.BackColor = Color.Black;

            // add the flower image name to the file path*/
            if (imageName.Length < 20)
            {
                filePath += imageName;
            }
            else
            {
                filePath = imageName;
            }
            

            // display all flower info
            engNameTextBox.AppendText(englishName);
            latinNameTextBox.AppendText(latinName);
            botFamTextBox.AppendText(botanicalFamily);
            notesTextBox.AppendText(note);
            flowerImage.Image = Image.FromFile(filePath);
           // }
        }

        //calls the delete flower class when clicked
        private void deleteFlower_click(object sender, EventArgs e)
        {
			// only execute the code for the Delete Flower event handler if the user is a Researcher or Admin
			if ((userAcctType == 2) || (userAcctType == 3))
			{

				bool deleted = deleteFlowerCtlr.main(primaryKey);
				if (deleted == true)
				{
					//new MainMenu().Show();
					this.Hide();
				}

			}
			else
				MessageBox.Show("Must be a researcher or administrator to use this feature.");

            
        }


        private void print_click(object sender, EventArgs e)
        {

        }

        private void deleteToMain_click(object sender, EventArgs e)
        {
            new MainMenu(userAcctType).Show();
            this.Hide();
        }

        private void profile_leave_click(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void flowerImage_Click(object sender, EventArgs e)
        {

        }

		private void flowerProfileChangeFlowerBtn_Click(object sender, EventArgs e)
		{

			// only execute the code for the Change Flower event handler if the user is a Researcher or Admin
			if ((userAcctType == 2) || (userAcctType == 3))
			{

				// have to pass along the displayed flower's primary key when displaying the Change Flower GUI
				// in order to change the attributes for the correct flower in the database
				ChangeFlowerCtlr ctlrToChangeFlower = new ChangeFlowerCtlr(primaryKey);

				ctlrToChangeFlower.displayChangeFlowerGUI(userAcctType);

				this.Hide();

			}
			else
				MessageBox.Show("Must be a researcher or administrator to use this feature.");

			

		}
	}
}
