namespace Florae_Basket
{
	partial class ChangeFlowerGUI
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
			this.englishNameLbl = new System.Windows.Forms.Label();
			this.englishNameEntryBox = new System.Windows.Forms.TextBox();
			this.changeFlowerSubmit = new System.Windows.Forms.Button();
			this.ChangeToFlowerProfileBtn = new System.Windows.Forms.Button();
			this.botanicalFamLbl = new System.Windows.Forms.Label();
			this.latinNameLbl = new System.Windows.Forms.Label();
			this.botanicalFamEntryBox = new System.Windows.Forms.TextBox();
			this.latinNameEntryBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// englishNameLbl
			// 
			this.englishNameLbl.AutoSize = true;
			this.englishNameLbl.Location = new System.Drawing.Point(59, 101);
			this.englishNameLbl.Name = "englishNameLbl";
			this.englishNameLbl.Size = new System.Drawing.Size(99, 17);
			this.englishNameLbl.TabIndex = 4;
			this.englishNameLbl.Text = "English Name:";
			// 
			// englishNameEntryBox
			// 
			this.englishNameEntryBox.Location = new System.Drawing.Point(208, 101);
			this.englishNameEntryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.englishNameEntryBox.Name = "englishNameEntryBox";
			this.englishNameEntryBox.Size = new System.Drawing.Size(287, 22);
			this.englishNameEntryBox.TabIndex = 7;
			// 
			// changeFlowerSubmit
			// 
			this.changeFlowerSubmit.Location = new System.Drawing.Point(208, 410);
			this.changeFlowerSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.changeFlowerSubmit.Name = "changeFlowerSubmit";
			this.changeFlowerSubmit.Size = new System.Drawing.Size(100, 34);
			this.changeFlowerSubmit.TabIndex = 10;
			this.changeFlowerSubmit.Text = "Update!";
			this.changeFlowerSubmit.UseVisualStyleBackColor = true;
			this.changeFlowerSubmit.Click += new System.EventHandler(this.changeFlowerSubmit_Click);
			// 
			// ChangeToFlowerProfileBtn
			// 
			this.ChangeToFlowerProfileBtn.Location = new System.Drawing.Point(160, 506);
			this.ChangeToFlowerProfileBtn.Name = "ChangeToFlowerProfileBtn";
			this.ChangeToFlowerProfileBtn.Size = new System.Drawing.Size(199, 28);
			this.ChangeToFlowerProfileBtn.TabIndex = 11;
			this.ChangeToFlowerProfileBtn.Text = "Return to Flower Profile";
			this.ChangeToFlowerProfileBtn.UseVisualStyleBackColor = true;
			this.ChangeToFlowerProfileBtn.Click += new System.EventHandler(this.ChangeToFlowerProfileBtn_Click);
			// 
			// botanicalFamLbl
			// 
			this.botanicalFamLbl.AutoSize = true;
			this.botanicalFamLbl.Location = new System.Drawing.Point(59, 247);
			this.botanicalFamLbl.Name = "botanicalFamLbl";
			this.botanicalFamLbl.Size = new System.Drawing.Size(114, 17);
			this.botanicalFamLbl.TabIndex = 6;
			this.botanicalFamLbl.Text = "Botanical Family:";
			// 
			// latinNameLbl
			// 
			this.latinNameLbl.AutoSize = true;
			this.latinNameLbl.Location = new System.Drawing.Point(59, 174);
			this.latinNameLbl.Name = "latinNameLbl";
			this.latinNameLbl.Size = new System.Drawing.Size(84, 17);
			this.latinNameLbl.TabIndex = 5;
			this.latinNameLbl.Text = "Latin Name:";
			// 
			// botanicalFamEntryBox
			// 
			this.botanicalFamEntryBox.Location = new System.Drawing.Point(208, 244);
			this.botanicalFamEntryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.botanicalFamEntryBox.Name = "botanicalFamEntryBox";
			this.botanicalFamEntryBox.Size = new System.Drawing.Size(287, 22);
			this.botanicalFamEntryBox.TabIndex = 9;
			// 
			// latinNameEntryBox
			// 
			this.latinNameEntryBox.Location = new System.Drawing.Point(208, 174);
			this.latinNameEntryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.latinNameEntryBox.Name = "latinNameEntryBox";
			this.latinNameEntryBox.Size = new System.Drawing.Size(287, 22);
			this.latinNameEntryBox.TabIndex = 8;
			// 
			// ChangeFlowerGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 560);
			this.Controls.Add(this.ChangeToFlowerProfileBtn);
			this.Controls.Add(this.changeFlowerSubmit);
			this.Controls.Add(this.botanicalFamEntryBox);
			this.Controls.Add(this.latinNameEntryBox);
			this.Controls.Add(this.englishNameEntryBox);
			this.Controls.Add(this.botanicalFamLbl);
			this.Controls.Add(this.latinNameLbl);
			this.Controls.Add(this.englishNameLbl);
			this.Name = "ChangeFlowerGUI";
			this.Text = "ChangeFlowerGUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label englishNameLbl;
		private System.Windows.Forms.TextBox englishNameEntryBox;
		private System.Windows.Forms.Button changeFlowerSubmit;
		private System.Windows.Forms.Button ChangeToFlowerProfileBtn;
		private System.Windows.Forms.Label botanicalFamLbl;
		private System.Windows.Forms.Label latinNameLbl;
		private System.Windows.Forms.TextBox botanicalFamEntryBox;
		private System.Windows.Forms.TextBox latinNameEntryBox;
	}
}