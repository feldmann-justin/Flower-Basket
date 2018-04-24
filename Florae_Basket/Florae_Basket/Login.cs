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
    public partial class Login : Form
    {
        private string user;
        private string pass;
        private int accType;

        public Login()
        {
            InitializeComponent();
            accType = 0;
        }

        public Login(int userType)
        {
            InitializeComponent();
            accType = userType;
        }






    }
}
