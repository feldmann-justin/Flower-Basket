namespace Florae_Basket
{
    partial class flowerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flowerProfile));
            this.deleteFlowerButton = new System.Windows.Forms.Button();
            this.flowerImage = new System.Windows.Forms.PictureBox();
            this.engNameTextBox = new System.Windows.Forms.TextBox();
            this.botFamTextBox = new System.Windows.Forms.TextBox();
            this.latinNameTextBox = new System.Windows.Forms.TextBox();
            this.englishNameLabel = new System.Windows.Forms.Label();
            this.latinNameLabel = new System.Windows.Forms.Label();
            this.botanicalFamilyLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.DeleteToMain = new System.Windows.Forms.Button();
            this.flowerProfileChangeFlowerBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.flowerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteFlowerButton
            // 
            this.deleteFlowerButton.Location = new System.Drawing.Point(620, 420);
            this.deleteFlowerButton.Name = "deleteFlowerButton";
            this.deleteFlowerButton.Size = new System.Drawing.Size(97, 23);
            this.deleteFlowerButton.TabIndex = 0;
            this.deleteFlowerButton.Text = "Delete Flower";
            this.deleteFlowerButton.UseVisualStyleBackColor = true;
            this.deleteFlowerButton.Click += new System.EventHandler(this.deleteFlower_click);
            // 
            // flowerImage
            // 
            this.flowerImage.Location = new System.Drawing.Point(420, 67);
            this.flowerImage.Name = "flowerImage";
            this.flowerImage.Size = new System.Drawing.Size(297, 320);
            this.flowerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.flowerImage.TabIndex = 1;
            this.flowerImage.TabStop = false;
            this.flowerImage.Click += new System.EventHandler(this.flowerImage_Click);
            // 
            // engNameTextBox
            // 
            this.engNameTextBox.Location = new System.Drawing.Point(141, 67);
            this.engNameTextBox.Name = "engNameTextBox";
            this.engNameTextBox.ReadOnly = true;
            this.engNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.engNameTextBox.TabIndex = 2;
            // 
            // botFamTextBox
            // 
            this.botFamTextBox.Location = new System.Drawing.Point(141, 172);
            this.botFamTextBox.Name = "botFamTextBox";
            this.botFamTextBox.ReadOnly = true;
            this.botFamTextBox.Size = new System.Drawing.Size(216, 20);
            this.botFamTextBox.TabIndex = 3;
            // 
            // latinNameTextBox
            // 
            this.latinNameTextBox.Location = new System.Drawing.Point(141, 120);
            this.latinNameTextBox.Name = "latinNameTextBox";
            this.latinNameTextBox.ReadOnly = true;
            this.latinNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.latinNameTextBox.TabIndex = 4;
            // 
            // englishNameLabel
            // 
            this.englishNameLabel.AutoSize = true;
            this.englishNameLabel.Location = new System.Drawing.Point(28, 70);
            this.englishNameLabel.Name = "englishNameLabel";
            this.englishNameLabel.Size = new System.Drawing.Size(75, 13);
            this.englishNameLabel.TabIndex = 5;
            this.englishNameLabel.Text = "English Name:";
            // 
            // latinNameLabel
            // 
            this.latinNameLabel.AutoSize = true;
            this.latinNameLabel.Location = new System.Drawing.Point(39, 123);
            this.latinNameLabel.Name = "latinNameLabel";
            this.latinNameLabel.Size = new System.Drawing.Size(64, 13);
            this.latinNameLabel.TabIndex = 6;
            this.latinNameLabel.Text = "Latin Name:";
            // 
            // botanicalFamilyLabel
            // 
            this.botanicalFamilyLabel.AutoSize = true;
            this.botanicalFamilyLabel.Location = new System.Drawing.Point(17, 175);
            this.botanicalFamilyLabel.Name = "botanicalFamilyLabel";
            this.botanicalFamilyLabel.Size = new System.Drawing.Size(86, 13);
            this.botanicalFamilyLabel.TabIndex = 7;
            this.botanicalFamilyLabel.Text = "Botanical Family:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(141, 223);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(216, 164);
            this.notesTextBox.TabIndex = 8;
            this.notesTextBox.Text = "";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(65, 226);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(38, 13);
            this.notesLabel.TabIndex = 9;
            this.notesLabel.Text = "Notes:";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(506, 420);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(97, 23);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.print_click);
            // 
            // DeleteToMain
            // 
            this.DeleteToMain.Enabled = false;
            this.DeleteToMain.Location = new System.Drawing.Point(20, 420);
            this.DeleteToMain.Name = "DeleteToMain";
            this.DeleteToMain.Size = new System.Drawing.Size(131, 23);
            this.DeleteToMain.TabIndex = 11;
            this.DeleteToMain.Text = "Return to Main Menu";
            this.DeleteToMain.UseVisualStyleBackColor = true;
            this.DeleteToMain.Visible = false;
            this.DeleteToMain.Click += new System.EventHandler(this.deleteToMain_click);
            // 
            // flowerProfileChangeFlowerBtn
            // 
            this.flowerProfileChangeFlowerBtn.Location = new System.Drawing.Point(604, 22);
            this.flowerProfileChangeFlowerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.flowerProfileChangeFlowerBtn.Name = "flowerProfileChangeFlowerBtn";
            this.flowerProfileChangeFlowerBtn.Size = new System.Drawing.Size(112, 24);
            this.flowerProfileChangeFlowerBtn.TabIndex = 12;
            this.flowerProfileChangeFlowerBtn.Text = "Change Flower";
            this.flowerProfileChangeFlowerBtn.UseVisualStyleBackColor = true;
            this.flowerProfileChangeFlowerBtn.Click += new System.EventHandler(this.flowerProfileChangeFlowerBtn_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // flowerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(749, 455);
            this.Controls.Add(this.flowerProfileChangeFlowerBtn);
            this.Controls.Add(this.DeleteToMain);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.botanicalFamilyLabel);
            this.Controls.Add(this.latinNameLabel);
            this.Controls.Add(this.englishNameLabel);
            this.Controls.Add(this.latinNameTextBox);
            this.Controls.Add(this.botFamTextBox);
            this.Controls.Add(this.engNameTextBox);
            this.Controls.Add(this.flowerImage);
            this.Controls.Add(this.deleteFlowerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "flowerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Florae Basket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.profile_leave_click);
            this.Load += new System.EventHandler(this.flowerProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteFlowerButton;
        private System.Windows.Forms.PictureBox flowerImage;
        private System.Windows.Forms.TextBox engNameTextBox;
        private System.Windows.Forms.TextBox botFamTextBox;
        private System.Windows.Forms.TextBox latinNameTextBox;
        private System.Windows.Forms.Label englishNameLabel;
        private System.Windows.Forms.Label latinNameLabel;
        private System.Windows.Forms.Label botanicalFamilyLabel;
        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button DeleteToMain;
		private System.Windows.Forms.Button flowerProfileChangeFlowerBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}