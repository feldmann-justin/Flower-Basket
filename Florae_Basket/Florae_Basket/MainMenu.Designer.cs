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
            this.MainToProfileButton = new System.Windows.Forms.Button();
            this.userOptions_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFlowerMainMenuBtn
            // 
            this.addFlowerMainMenuBtn.Location = new System.Drawing.Point(48, 43);
            this.addFlowerMainMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addFlowerMainMenuBtn.Name = "addFlowerMainMenuBtn";
            this.addFlowerMainMenuBtn.Size = new System.Drawing.Size(159, 38);
            this.addFlowerMainMenuBtn.TabIndex = 0;
            this.addFlowerMainMenuBtn.Text = "Add a Flower";
            this.addFlowerMainMenuBtn.UseVisualStyleBackColor = true;
            this.addFlowerMainMenuBtn.Click += new System.EventHandler(this.addFlowerMainMenuBtn_Click);
            // 
            // searchFlowerMainMenuBtn
            // 
            this.searchFlowerMainMenuBtn.Location = new System.Drawing.Point(48, 109);
            this.searchFlowerMainMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchFlowerMainMenuBtn.Name = "searchFlowerMainMenuBtn";
            this.searchFlowerMainMenuBtn.Size = new System.Drawing.Size(159, 38);
            this.searchFlowerMainMenuBtn.TabIndex = 1;
            this.searchFlowerMainMenuBtn.Text = "Search for a Flower";
            this.searchFlowerMainMenuBtn.UseVisualStyleBackColor = true;
            this.searchFlowerMainMenuBtn.Click += new System.EventHandler(this.searchFlowerMainMenuBtn_Click);
            // 
            // MainToProfileButton
            // 
            this.MainToProfileButton.Location = new System.Drawing.Point(48, 173);
            this.MainToProfileButton.Margin = new System.Windows.Forms.Padding(2);
            this.MainToProfileButton.Name = "MainToProfileButton";
            this.MainToProfileButton.Size = new System.Drawing.Size(159, 38);
            this.MainToProfileButton.TabIndex = 2;
            this.MainToProfileButton.Text = "Go to Flower Profile";
            this.MainToProfileButton.UseVisualStyleBackColor = true;
            this.MainToProfileButton.Click += new System.EventHandler(this.MainToProfileButton_click);
            // 
            // userOptions_button
            // 
            this.userOptions_button.Location = new System.Drawing.Point(48, 232);
            this.userOptions_button.Margin = new System.Windows.Forms.Padding(2);
            this.userOptions_button.Name = "userOptions_button";
            this.userOptions_button.Size = new System.Drawing.Size(159, 38);
            this.userOptions_button.TabIndex = 3;
            this.userOptions_button.Text = "User Options";
            this.userOptions_button.UseVisualStyleBackColor = true;
            this.userOptions_button.Click += new System.EventHandler(this.userOptions_click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(48, 358);
            this.exit_button.Margin = new System.Windows.Forms.Padding(2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(159, 38);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 430);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.userOptions_button);
            this.Controls.Add(this.MainToProfileButton);
            this.Controls.Add(this.searchFlowerMainMenuBtn);
            this.Controls.Add(this.addFlowerMainMenuBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_leave_click);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addFlowerMainMenuBtn;
		private System.Windows.Forms.Button searchFlowerMainMenuBtn;
        private System.Windows.Forms.Button MainToProfileButton;
        private System.Windows.Forms.Button userOptions_button;
        private System.Windows.Forms.Button exit_button;
    }
}