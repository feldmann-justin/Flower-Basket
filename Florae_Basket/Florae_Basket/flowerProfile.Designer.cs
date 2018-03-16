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
            this.deleteFlowerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowerImage
            // 
            this.flowerImage.Location = new System.Drawing.Point(420, 67);
            this.flowerImage.Name = "flowerImage";
            this.flowerImage.Size = new System.Drawing.Size(297, 320);
            this.flowerImage.TabIndex = 1;
            this.flowerImage.TabStop = false;
            // 
            // engNameTextBox
            // 
            this.engNameTextBox.Location = new System.Drawing.Point(141, 67);
            this.engNameTextBox.Name = "engNameTextBox";
            this.engNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.engNameTextBox.TabIndex = 2;
            // 
            // botFamTextBox
            // 
            this.botFamTextBox.Location = new System.Drawing.Point(141, 172);
            this.botFamTextBox.Name = "botFamTextBox";
            this.botFamTextBox.Size = new System.Drawing.Size(216, 20);
            this.botFamTextBox.TabIndex = 3;
            this.botFamTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // latinNameTextBox
            // 
            this.latinNameTextBox.Location = new System.Drawing.Point(141, 120);
            this.latinNameTextBox.Name = "latinNameTextBox";
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
            this.englishNameLabel.Click += new System.EventHandler(this.label1_Click);
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
            // flowerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 455);
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
            this.Name = "flowerProfile";
            this.Text = "flowerProfile";
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
    }
}