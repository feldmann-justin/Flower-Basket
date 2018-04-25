namespace Florae_Basket
{
    partial class SearchGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.TextBox();
            this.Latin = new System.Windows.Forms.TextBox();
            this.Botan = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WSToMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latin name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Botanical Family";
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(95, 58);
            this.EName.Margin = new System.Windows.Forms.Padding(2);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(76, 20);
            this.EName.TabIndex = 3;
            this.EName.TextChanged += new System.EventHandler(this.EName_TextChanged);
            // 
            // Latin
            // 
            this.Latin.Location = new System.Drawing.Point(95, 108);
            this.Latin.Margin = new System.Windows.Forms.Padding(2);
            this.Latin.Name = "Latin";
            this.Latin.Size = new System.Drawing.Size(76, 20);
            this.Latin.TabIndex = 4;
            this.Latin.TextChanged += new System.EventHandler(this.Latin_TextChanged);
            // 
            // Botan
            // 
            this.Botan.Location = new System.Drawing.Point(95, 154);
            this.Botan.Margin = new System.Windows.Forms.Padding(2);
            this.Botan.Name = "Botan";
            this.Botan.Size = new System.Drawing.Size(76, 20);
            this.Botan.TabIndex = 5;
            this.Botan.TextChanged += new System.EventHandler(this.Botan_TextChanged);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Enabled = false;
            this.SearchBTN.Location = new System.Drawing.Point(108, 202);
            this.SearchBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(56, 19);
            this.SearchBTN.TabIndex = 6;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image Search(File Path)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notes(keywords)";
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(274, 108);
            this.Notes.Margin = new System.Windows.Forms.Padding(2);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(168, 20);
            this.Notes.TabIndex = 10;
            this.Notes.TextChanged += new System.EventHandler(this.Notes_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 19);
            this.button1.TabIndex = 11;
            this.button1.Text = "Select image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WSToMainButton
            // 
            this.WSToMainButton.Location = new System.Drawing.Point(12, 253);
            this.WSToMainButton.Name = "WSToMainButton";
            this.WSToMainButton.Size = new System.Drawing.Size(140, 23);
            this.WSToMainButton.TabIndex = 12;
            this.WSToMainButton.Text = "Return to Main Menu";
            this.WSToMainButton.UseVisualStyleBackColor = true;
            this.WSToMainButton.Click += new System.EventHandler(this.WSToMainButton_click);
            // 
            // SearchGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 288);
            this.Controls.Add(this.WSToMainButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.Botan);
            this.Controls.Add(this.Latin);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Florae Basket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WSGUI_leave_click);
            this.Load += new System.EventHandler(this.Test_WS_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox EName;
        public System.Windows.Forms.TextBox Latin;
        public System.Windows.Forms.TextBox Botan;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button WSToMainButton;
    }
}