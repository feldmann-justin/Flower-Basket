namespace Florae_Basket
{
    partial class AddFlowerGUI
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
			this.latinNameEntryBox = new System.Windows.Forms.TextBox();
			this.englishNameEntryBox = new System.Windows.Forms.TextBox();
			this.botanicalFamEntryBox = new System.Windows.Forms.TextBox();
			this.englishNameLbl = new System.Windows.Forms.Label();
			this.latinNameLbl = new System.Windows.Forms.Label();
			this.botanicalFamLbl = new System.Windows.Forms.Label();
			this.addFlowerToDBBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// latinNameEntryBox
			// 
			this.latinNameEntryBox.Location = new System.Drawing.Point(208, 169);
			this.latinNameEntryBox.Name = "latinNameEntryBox";
			this.latinNameEntryBox.Size = new System.Drawing.Size(287, 22);
			this.latinNameEntryBox.TabIndex = 0;
			// 
			// englishNameEntryBox
			// 
			this.englishNameEntryBox.Location = new System.Drawing.Point(208, 101);
			this.englishNameEntryBox.Name = "englishNameEntryBox";
			this.englishNameEntryBox.Size = new System.Drawing.Size(287, 22);
			this.englishNameEntryBox.TabIndex = 1;
			// 
			// botanicalFamEntryBox
			// 
			this.botanicalFamEntryBox.Location = new System.Drawing.Point(208, 244);
			this.botanicalFamEntryBox.Name = "botanicalFamEntryBox";
			this.botanicalFamEntryBox.Size = new System.Drawing.Size(287, 22);
			this.botanicalFamEntryBox.TabIndex = 2;
			// 
			// englishNameLbl
			// 
			this.englishNameLbl.AutoSize = true;
			this.englishNameLbl.Location = new System.Drawing.Point(59, 101);
			this.englishNameLbl.Name = "englishNameLbl";
			this.englishNameLbl.Size = new System.Drawing.Size(99, 17);
			this.englishNameLbl.TabIndex = 3;
			this.englishNameLbl.Text = "English Name:";
			// 
			// latinNameLbl
			// 
			this.latinNameLbl.AutoSize = true;
			this.latinNameLbl.Location = new System.Drawing.Point(59, 174);
			this.latinNameLbl.Name = "latinNameLbl";
			this.latinNameLbl.Size = new System.Drawing.Size(84, 17);
			this.latinNameLbl.TabIndex = 4;
			this.latinNameLbl.Text = "Latin Name:";
			// 
			// botanicalFamLbl
			// 
			this.botanicalFamLbl.AutoSize = true;
			this.botanicalFamLbl.Location = new System.Drawing.Point(59, 247);
			this.botanicalFamLbl.Name = "botanicalFamLbl";
			this.botanicalFamLbl.Size = new System.Drawing.Size(114, 17);
			this.botanicalFamLbl.TabIndex = 5;
			this.botanicalFamLbl.Text = "Botanical Family:";
			// 
			// addFlowerToDBBtn
			// 
			this.addFlowerToDBBtn.Location = new System.Drawing.Point(208, 458);
			this.addFlowerToDBBtn.Name = "addFlowerToDBBtn";
			this.addFlowerToDBBtn.Size = new System.Drawing.Size(75, 23);
			this.addFlowerToDBBtn.TabIndex = 6;
			this.addFlowerToDBBtn.Text = "Add it!";
			this.addFlowerToDBBtn.UseVisualStyleBackColor = true;
			this.addFlowerToDBBtn.Click += new System.EventHandler(this.addFlowerToDBBtn_Click);
			// 
			// AddFlowerGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 560);
			this.Controls.Add(this.addFlowerToDBBtn);
			this.Controls.Add(this.botanicalFamLbl);
			this.Controls.Add(this.latinNameLbl);
			this.Controls.Add(this.englishNameLbl);
			this.Controls.Add(this.botanicalFamEntryBox);
			this.Controls.Add(this.englishNameEntryBox);
			this.Controls.Add(this.latinNameEntryBox);
			this.Name = "AddFlowerGUI";
			this.Text = "Add Flower";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox latinNameEntryBox;
		private System.Windows.Forms.TextBox englishNameEntryBox;
		private System.Windows.Forms.TextBox botanicalFamEntryBox;
		private System.Windows.Forms.Label englishNameLbl;
		private System.Windows.Forms.Label latinNameLbl;
		private System.Windows.Forms.Label botanicalFamLbl;
		private System.Windows.Forms.Button addFlowerToDBBtn;
	}
}

