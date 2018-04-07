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

namespace Florae_Basket
{
    public partial class ResultsGUI : Form
    {
        public bool exit = true;
        public int[] ids = new int[3];
        public Flower[] flowers = new Flower[3];
        public string[] notes = new string[3];
        public string[] result1_pics;
        public string[] result2_pics;
        public string[] result3_pics;

        public ResultsGUI(int[] id, Flower[] flow, string[] note, string[] result1, string[] result2, string[] result3)
        {
            InitializeComponent();
            flowers = flow;
            ids = id;
            notes = note;
            result1_pics = result1;
            result2_pics = result2;
            result3_pics = result3;
            Result1box.Text = flowers[0].getEnglishName();
            Result2box.Text = flowers[1].getEnglishName();
            Result3box.Text = flowers[2].getEnglishName();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //opens temporary flower result profile
        private void Display_Flower(int result, string[] images)
        {
            flowerProfile prof = new flowerProfile(flowers[result].getEnglishName(), flowers[result].getLatinName(), 
                                                   flowers[result].getBotanicalFam(), notes[result], images, ids[result]);
            prof.ShowDialog(this);
        }

        private void Result1btn_Click(object sender, EventArgs e)
        {
            Display_Flower(0, result1_pics);
        }

        private void Result2btn_Click(object sender, EventArgs e)
        {
            Display_Flower(1, result2_pics);
        }

        private void Result3btn_Click(object sender, EventArgs e)
        {
            Display_Flower(2, result3_pics);
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
    }
}
