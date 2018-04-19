using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


//////////////////////////////////////////////////
//                                              //
//  Word_Search                                 //
//  by Brady Smith                              //
//                                              //
//////////////////////////////////////////////////


namespace Florae_Basket
{
    public partial class ResultsGUI : Form
    {
        public bool exit = true;
        public int[] ids = new int[3];
        public Flower[] flowers = new Flower[3];
        public string[] notes = new string[3];
        public string[] result_pics;

        public ResultsGUI(int[] id, Flower[] flow, string[] note, string[] images)
        {
            InitializeComponent();
            flowers = flow;
            ids = id;
            notes = note;
            result_pics = images;
            Result1box.Text = flowers[0].getEnglishName();
            Result2box.Text = flowers[1].getEnglishName();
            Result3box.Text = flowers[2].getEnglishName();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //opens temporary flower result profile
        private void Display_Flower(int result, string images)
        {
            flowerProfileCtrl profCtrl = new flowerProfileCtrl();
            profCtrl.createGUI(flowers[result].getEnglishName(), flowers[result].getLatinName(), 
                                                   flowers[result].getBotanicalFam(), notes[result], images, ids[result]);
         
        }

        private void Result1btn_Click(object sender, EventArgs e)
        {
            Display_Flower(0, result_pics[0]);
        }

        private void Result2btn_Click(object sender, EventArgs e)
        {
            Display_Flower(1, result_pics[1]);
        }

        private void Result3btn_Click(object sender, EventArgs e)
        {
            Display_Flower(2, result_pics[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exit = false;
            new MainMenu().Show();
            this.Hide();
        }

        private void ResultsGUI_Load(object sender, EventArgs e)
        {

        }

        private void ResultsGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void ResultsGUI_leave_click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ResultsGUI_Load_1(object sender, EventArgs e)
        {

        }
    }
}
