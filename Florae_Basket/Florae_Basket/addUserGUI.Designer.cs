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
            this.last_textBox = new System.Windows.Forms.TextBox();
            this.first_textBox = new System.Windows.Forms.TextBox();
            this.accType_textBox = new System.Windows.Forms.ComboBox();
            this.file_label = new System.Windows.Forms.Label();
            this.first_label = new System.Windows.Forms.Label();
            this.last_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.accType_label = new System.Windows.Forms.Label();
            this.chooseFile_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "------------ OR -------------";
            // 
            // addUserSubmit_button
            // 
            this.addUserSubmit_button.Location = new System.Drawing.Point(279, 565);
            this.addUserSubmit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addUserSubmit_button.Name = "addUserSubmit_button";
            this.addUserSubmit_button.Size = new System.Drawing.Size(144, 39);
            this.addUserSubmit_button.TabIndex = 2;
            this.addUserSubmit_button.Text = "Submit";
            this.addUserSubmit_button.UseVisualStyleBackColor = true;
            this.addUserSubmit_button.Click += new System.EventHandler(this.addUserSubmit_click);
            // 
            // file_textBox
            // 
            this.file_textBox.Location = new System.Drawing.Point(232, 63);
            this.file_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.file_textBox.Name = "file_textBox";
            this.file_textBox.ReadOnly = true;
            this.file_textBox.Size = new System.Drawing.Size(415, 22);
            this.file_textBox.TabIndex = 3;
            this.file_textBox.TextChanged += new System.EventHandler(this.file_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(233, 402);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(415, 22);
            this.password_textBox.TabIndex = 4;
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(233, 356);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(415, 22);
            this.username_textBox.TabIndex = 5;
            // 
            // last_textBox
            // 
            this.last_textBox.Location = new System.Drawing.Point(233, 309);
            this.last_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.last_textBox.Name = "last_textBox";
            this.last_textBox.Size = new System.Drawing.Size(415, 22);
            this.last_textBox.TabIndex = 6;
            // 
            // first_textBox
            // 
            this.first_textBox.Location = new System.Drawing.Point(233, 261);
            this.first_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.first_textBox.Name = "first_textBox";
            this.first_textBox.Size = new System.Drawing.Size(415, 22);
            this.first_textBox.TabIndex = 7;
            // 
            // accType_textBox
            // 
            this.accType_textBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accType_textBox.FormattingEnabled = true;
            this.accType_textBox.Items.AddRange(new object[] {
            "Administrator",
            "Researcher",
            "Student"});
            this.accType_textBox.Location = new System.Drawing.Point(233, 457);
            this.accType_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accType_textBox.Name = "accType_textBox";
            this.accType_textBox.Size = new System.Drawing.Size(413, 24);
            this.accType_textBox.TabIndex = 8;
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(132, 66);
            this.file_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(59, 17);
            this.file_label.TabIndex = 9;
            this.file_label.Text = ".csv file:";
            // 
            // first_label
            // 
            this.first_label.AutoSize = true;
            this.first_label.Location = new System.Drawing.Point(119, 265);
            this.first_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.first_label.Name = "first_label";
            this.first_label.Size = new System.Drawing.Size(80, 17);
            this.first_label.TabIndex = 10;
            this.first_label.Text = "First Name:";
            // 
            // last_label
            // 
            this.last_label.AutoSize = true;
            this.last_label.Location = new System.Drawing.Point(119, 313);
            this.last_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.last_label.Name = "last_label";
            this.last_label.Size = new System.Drawing.Size(80, 17);
            this.last_label.TabIndex = 11;
            this.last_label.Text = "Last Name:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(119, 359);
            this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(77, 17);
            this.username_label.TabIndex = 12;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(119, 406);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(73, 17);
            this.password_label.TabIndex = 13;
            this.password_label.Text = "Password:";
            // 
            // accType_label
            // 
            this.accType_label.AutoSize = true;
            this.accType_label.Location = new System.Drawing.Point(47, 460);
            this.accType_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accType_label.Name = "accType_label";
            this.accType_label.Size = new System.Drawing.Size(142, 17);
            this.accType_label.TabIndex = 14;
            this.accType_label.Text = "Select Account Type:";
            // 
            // chooseFile_button
            // 
            this.chooseFile_button.Location = new System.Drawing.Point(279, 127);
            this.chooseFile_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseFile_button.Name = "chooseFile_button";
            this.chooseFile_button.Size = new System.Drawing.Size(144, 39);
            this.chooseFile_button.TabIndex = 15;
            this.chooseFile_button.Text = "Choose File";
            this.chooseFile_button.UseVisualStyleBackColor = true;
            this.chooseFile_button.Click += new System.EventHandler(this.chooseFile_click);
            // 
            // addUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 642);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox last_textBox;
        private System.Windows.Forms.TextBox first_textBox;
        private System.Windows.Forms.ComboBox accType_textBox;
        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.Label first_label;
        private System.Windows.Forms.Label last_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label accType_label;
        private System.Windows.Forms.Button chooseFile_button;
    }
}