namespace Florae_Basket
{
	partial class MainMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.addFlowerMainMenuBtn = new System.Windows.Forms.Button();
			this.searchFlowerMainMenuBtn = new System.Windows.Forms.Button();
			this.userOptions_button = new System.Windows.Forms.Button();
			this.logoutBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addFlowerMainMenuBtn
			// 
			this.addFlowerMainMenuBtn.Location = new System.Drawing.Point(64, 53);
			this.addFlowerMainMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addFlowerMainMenuBtn.Name = "addFlowerMainMenuBtn";
			this.addFlowerMainMenuBtn.Size = new System.Drawing.Size(212, 47);
			this.addFlowerMainMenuBtn.TabIndex = 0;
			this.addFlowerMainMenuBtn.Text = "Add a Flower";
			this.addFlowerMainMenuBtn.UseVisualStyleBackColor = true;
			this.addFlowerMainMenuBtn.Click += new System.EventHandler(this.addFlowerMainMenuBtn_Click);
			// 
			// searchFlowerMainMenuBtn
			// 
			this.searchFlowerMainMenuBtn.Location = new System.Drawing.Point(64, 134);
			this.searchFlowerMainMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.searchFlowerMainMenuBtn.Name = "searchFlowerMainMenuBtn";
			this.searchFlowerMainMenuBtn.Size = new System.Drawing.Size(212, 47);
			this.searchFlowerMainMenuBtn.TabIndex = 1;
			this.searchFlowerMainMenuBtn.Text = "Search for a Flower";
			this.searchFlowerMainMenuBtn.UseVisualStyleBackColor = true;
			this.searchFlowerMainMenuBtn.Click += new System.EventHandler(this.searchFlowerMainMenuBtn_Click);
			// 
			// userOptions_button
			// 
			this.userOptions_button.Location = new System.Drawing.Point(64, 218);
			this.userOptions_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.userOptions_button.Name = "userOptions_button";
			this.userOptions_button.Size = new System.Drawing.Size(212, 47);
			this.userOptions_button.TabIndex = 3;
			this.userOptions_button.Text = "User Options";
			this.userOptions_button.UseVisualStyleBackColor = true;
			this.userOptions_button.Click += new System.EventHandler(this.userOptions_click);
			// 
			// logoutBtn
			// 
			this.logoutBtn.Location = new System.Drawing.Point(64, 441);
			this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.logoutBtn.Name = "logoutBtn";
			this.logoutBtn.Size = new System.Drawing.Size(212, 47);
			this.logoutBtn.TabIndex = 4;
			this.logoutBtn.Text = "Logout";
			this.logoutBtn.UseVisualStyleBackColor = true;
			this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 529);
			this.Controls.Add(this.logoutBtn);
			this.Controls.Add(this.userOptions_button);
			this.Controls.Add(this.searchFlowerMainMenuBtn);
			this.Controls.Add(this.addFlowerMainMenuBtn);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainMenu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_leave_click);
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addFlowerMainMenuBtn;
		private System.Windows.Forms.Button searchFlowerMainMenuBtn;
        private System.Windows.Forms.Button userOptions_button;
        private System.Windows.Forms.Button logoutBtn;
    }
}