﻿namespace Florae_Basket
{
    partial class Test_WS_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.TextBox();
            this.Latin = new System.Windows.Forms.TextBox();
            this.Botan = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latin name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Botanical Family";
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(127, 71);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(100, 22);
            this.EName.TabIndex = 3;
            this.EName.TextChanged += new System.EventHandler(this.EName_TextChanged);
            // 
            // Latin
            // 
            this.Latin.Location = new System.Drawing.Point(127, 133);
            this.Latin.Name = "Latin";
            this.Latin.Size = new System.Drawing.Size(100, 22);
            this.Latin.TabIndex = 4;
            this.Latin.TextChanged += new System.EventHandler(this.Latin_TextChanged);
            // 
            // Botan
            // 
            this.Botan.Location = new System.Drawing.Point(127, 190);
            this.Botan.Name = "Botan";
            this.Botan.Size = new System.Drawing.Size(100, 22);
            this.Botan.TabIndex = 5;
            this.Botan.TextChanged += new System.EventHandler(this.Botan_TextChanged);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(144, 249);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 6;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // Test_WS_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 339);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.Botan);
            this.Controls.Add(this.Latin);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Test_WS_GUI";
            this.Text = "test_WS_GUI";
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
    }
}