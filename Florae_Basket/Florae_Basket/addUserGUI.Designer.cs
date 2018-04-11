namespace Florae_Basket
{
    partial class addUserGUI
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
            this.addUserSubmit_button = new System.Windows.Forms.Button();
            this.file_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.first_textBox = new System.Windows.Forms.TextBox();
            this.accType_textBox = new System.Windows.Forms.ComboBox();
            this.file_label = new System.Windows.Forms.Label();
            this.first_label = new System.Windows.Forms.Label();
            this.last_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.accType_label = new System.Windows.Forms.Label();
            this.chooseFile_button = new System.Windows.Forms.Button();
            this.last_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "------------ OR -------------";
            // 
            // addUserSubmit_button
            // 
            this.addUserSubmit_button.Location = new System.Drawing.Point(209, 459);
            this.addUserSubmit_button.Name = "addUserSubmit_button";
            this.addUserSubmit_button.Size = new System.Drawing.Size(108, 32);
            this.addUserSubmit_button.TabIndex = 7;
            this.addUserSubmit_button.Text = "Submit";
            this.addUserSubmit_button.UseVisualStyleBackColor = true;
            this.addUserSubmit_button.Click += new System.EventHandler(this.addUserSubmit_click);
            // 
            // file_textBox
            // 
            this.file_textBox.Location = new System.Drawing.Point(174, 51);
            this.file_textBox.Name = "file_textBox";
            this.file_textBox.ReadOnly = true;
            this.file_textBox.Size = new System.Drawing.Size(312, 20);
            this.file_textBox.TabIndex = 0;
            this.file_textBox.TextChanged += new System.EventHandler(this.file_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(175, 327);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(312, 20);
            this.password_textBox.TabIndex = 5;
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(175, 289);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(312, 20);
            this.username_textBox.TabIndex = 4;
            // 
            // first_textBox
            // 
            this.first_textBox.Location = new System.Drawing.Point(175, 212);
            this.first_textBox.Name = "first_textBox";
            this.first_textBox.Size = new System.Drawing.Size(312, 20);
            this.first_textBox.TabIndex = 2;
            // 
            // accType_textBox
            // 
            this.accType_textBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accType_textBox.FormattingEnabled = true;
            this.accType_textBox.Items.AddRange(new object[] {
            "Administrator",
            "Researcher",
            "Student"});
            this.accType_textBox.Location = new System.Drawing.Point(175, 371);
            this.accType_textBox.Name = "accType_textBox";
            this.accType_textBox.Size = new System.Drawing.Size(311, 21);
            this.accType_textBox.TabIndex = 6;
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(99, 54);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(46, 13);
            this.file_label.TabIndex = 9;
            this.file_label.Text = ".csv file:";
            // 
            // first_label
            // 
            this.first_label.AutoSize = true;
            this.first_label.Location = new System.Drawing.Point(89, 215);
            this.first_label.Name = "first_label";
            this.first_label.Size = new System.Drawing.Size(60, 13);
            this.first_label.TabIndex = 10;
            this.first_label.Text = "First Name:";
            // 
            // last_label
            // 
            this.last_label.AutoSize = true;
            this.last_label.Location = new System.Drawing.Point(89, 254);
            this.last_label.Name = "last_label";
            this.last_label.Size = new System.Drawing.Size(61, 13);
            this.last_label.TabIndex = 11;
            this.last_label.Text = "Last Name:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(89, 292);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(58, 13);
            this.username_label.TabIndex = 12;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(89, 330);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 13;
            this.password_label.Text = "Password:";
            // 
            // accType_label
            // 
            this.accType_label.AutoSize = true;
            this.accType_label.Location = new System.Drawing.Point(35, 374);
            this.accType_label.Name = "accType_label";
            this.accType_label.Size = new System.Drawing.Size(110, 13);
            this.accType_label.TabIndex = 14;
            this.accType_label.Text = "Select Account Type:";
            // 
            // chooseFile_button
            // 
            this.chooseFile_button.Location = new System.Drawing.Point(209, 103);
            this.chooseFile_button.Name = "chooseFile_button";
            this.chooseFile_button.Size = new System.Drawing.Size(108, 32);
            this.chooseFile_button.TabIndex = 1;
            this.chooseFile_button.Text = "Choose File";
            this.chooseFile_button.UseVisualStyleBackColor = true;
            this.chooseFile_button.Click += new System.EventHandler(this.chooseFile_click);
            // 
            // last_textBox
            // 
            this.last_textBox.Location = new System.Drawing.Point(175, 251);
            this.last_textBox.Name = "last_textBox";
            this.last_textBox.Size = new System.Drawing.Size(312, 20);
            this.last_textBox.TabIndex = 3;
            this.last_textBox.TextChanged += new System.EventHandler(this.last_textBox_TextChanged);
            // 
            // addUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 522);
            this.Controls.Add(this.chooseFile_button);
            this.Controls.Add(this.accType_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.last_label);
            this.Controls.Add(this.first_label);
            this.Controls.Add(this.file_label);
            this.Controls.Add(this.accType_textBox);
            this.Controls.Add(this.first_textBox);
            this.Controls.Add(this.last_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.file_textBox);
            this.Controls.Add(this.addUserSubmit_button);
            this.Controls.Add(this.label1);
            this.Name = "addUserGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addUserGUI_FormClosing);
            this.Load += new System.EventHandler(this.addUserGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUserSubmit_button;
        private System.Windows.Forms.TextBox file_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox first_textBox;
        private System.Windows.Forms.ComboBox accType_textBox;
        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.Label first_label;
        private System.Windows.Forms.Label last_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label accType_label;
        private System.Windows.Forms.Button chooseFile_button;
        private System.Windows.Forms.TextBox last_textBox;
    }
}