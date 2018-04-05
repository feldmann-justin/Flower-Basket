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
		public ChangeFlowerGUI()
		{
			InitializeComponent();
		}

		private void changeFlowerSubmit_Click(object sender, EventArgs e)
		{

		}

		private void ChangeToFlowerProfileBtn_Click(object sender, EventArgs e)
		{

			new flowerProfile().Show();
			this.Hide();

		}
	}
}
