namespace Florae_Basket
{
    partial class ImageSearch
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
            this.searchButton = new System.Windows.Forms.Button();
            this.imgSelectLabel = new System.Windows.Forms.Label();
            this.imgSelectButton = new System.Windows.Forms.Button();
            this.imgNoteLabel = new System.Windows.Forms.Label();
            this.wordSearchSelect = new System.Windows.Forms.CheckBox();
            this.wordSearchBox = new System.Windows.Forms.TextBox();
            this.freqColorLabel = new System.Windows.Forms.Label();
            this.freqColorBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(291, 349);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 34);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // imgSelectLabel
            // 
            this.imgSelectLabel.AutoSize = true;
            this.imgSelectLabel.Location = new System.Drawing.Point(79, 86);
            this.imgSelectLabel.Name = "imgSelectLabel";
            this.imgSelectLabel.Size = new System.Drawing.Size(197, 13);
            this.imgSelectLabel.TabIndex = 1;
            this.imgSelectLabel.Text = "Select an image file to search by image: ";
            // 
            // imgSelectButton
            // 
            this.imgSelectButton.Location = new System.Drawing.Point(319, 86);
            this.imgSelectButton.Name = "imgSelectButton";
            this.imgSelectButton.Size = new System.Drawing.Size(103, 48);
            this.imgSelectButton.TabIndex = 2;
            this.imgSelectButton.Text = "Select Image File";
            this.imgSelectButton.UseVisualStyleBackColor = true;
            this.imgSelectButton.Click += new System.EventHandler(this.imgSelectButton_Click);
            // 
            // imgNoteLabel
            // 
            this.imgNoteLabel.AutoSize = true;
            this.imgNoteLabel.Location = new System.Drawing.Point(79, 121);
            this.imgNoteLabel.Name = "imgNoteLabel";
            this.imgNoteLabel.Size = new System.Drawing.Size(176, 13);
            this.imgNoteLabel.TabIndex = 3;
            this.imgNoteLabel.Text = "Note: Must be in .jpeg, .png, or .gif  ";
            // 
            // wordSearchSelect
            // 
            this.wordSearchSelect.AutoSize = true;
            this.wordSearchSelect.Location = new System.Drawing.Point(82, 199);
            this.wordSearchSelect.Name = "wordSearchSelect";
            this.wordSearchSelect.Size = new System.Drawing.Size(155, 17);
            this.wordSearchSelect.TabIndex = 4;
            this.wordSearchSelect.Text = "Combine with Word Search";
            this.wordSearchSelect.UseVisualStyleBackColor = true;
            this.wordSearchSelect.CheckedChanged += new System.EventHandler(this.wordSearchSelect_CheckedChanged);
            // 
            // wordSearchBox
            // 
            this.wordSearchBox.Location = new System.Drawing.Point(322, 199);
            this.wordSearchBox.Name = "wordSearchBox";
            this.wordSearchBox.Size = new System.Drawing.Size(100, 20);
            this.wordSearchBox.TabIndex = 5;
            // 
            // freqColorLabel
            // 
            this.freqColorLabel.AutoSize = true;
            this.freqColorLabel.Location = new System.Drawing.Point(79, 262);
            this.freqColorLabel.Name = "freqColorLabel";
            this.freqColorLabel.Size = new System.Drawing.Size(212, 13);
            this.freqColorLabel.TabIndex = 6;
            this.freqColorLabel.Text = "Enter a frequently occuring color (optional): ";
            // 
            // freqColorBox
            // 
            this.freqColorBox.Location = new System.Drawing.Point(322, 259);
            this.freqColorBox.Name = "freqColorBox";
            this.freqColorBox.Size = new System.Drawing.Size(100, 20);
            this.freqColorBox.TabIndex = 7;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(129, 158);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(253, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "You closed out of the File Selector. Please try again!";
            // 
            // ImageSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(692, 395);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.freqColorBox);
            this.Controls.Add(this.freqColorLabel);
            this.Controls.Add(this.wordSearchBox);
            this.Controls.Add(this.wordSearchSelect);
            this.Controls.Add(this.imgNoteLabel);
            this.Controls.Add(this.imgSelectButton);
            this.Controls.Add(this.imgSelectLabel);
            this.Controls.Add(this.searchButton);
            this.Name = "ImageSearch";
            this.Text = "Image Search";
            this.Load += new System.EventHandler(this.ImageSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label imgSelectLabel;
        private System.Windows.Forms.Button imgSelectButton;
        private System.Windows.Forms.Label imgNoteLabel;
        private System.Windows.Forms.CheckBox wordSearchSelect;
        private System.Windows.Forms.TextBox wordSearchBox;
        private System.Windows.Forms.Label freqColorLabel;
        private System.Windows.Forms.TextBox freqColorBox;
        private System.Windows.Forms.Label errorLabel;
    }
}

