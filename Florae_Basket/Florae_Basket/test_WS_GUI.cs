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
    public partial class Test_WS_GUI : Form
    {
        public string egn_name;
        public string latin_word;
        public string botanical;

        public Test_WS_GUI()
        {
            InitializeComponent();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Latin.Text = "";
            EName.Text = "";
            Botan.Text = "";
        }

        private void Latin_TextChanged(object sender, EventArgs e)
        {
            latin_word = Latin.Text;
        }

        private void EName_TextChanged(object sender, EventArgs e)
        {
            egn_name = EName.Text;
        }

        private void Botan_TextChanged(object sender, EventArgs e)
        {
            botanical = Botan.Text;
        }
    }
}
