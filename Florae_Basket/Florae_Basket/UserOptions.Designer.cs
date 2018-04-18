namespace Florae_Basket
{
    partial class UserOptions
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
            this.AddUser_button = new System.Windows.Forms.Button();
            this.userOpts_label = new System.Windows.Forms.Label();
            this.ChangeUserbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUser_button
            // 
            this.AddUser_button.Location = new System.Drawing.Point(84, 129);
            this.AddUser_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddUser_button.Name = "AddUser_button";
            this.AddUser_button.Size = new System.Drawing.Size(199, 41);
            this.AddUser_button.TabIndex = 0;
            this.AddUser_button.Text = "Add User";
            this.AddUser_button.UseVisualStyleBackColor = true;
            this.AddUser_button.Click += new System.EventHandler(this.addUser_click);
            // 
            // userOpts_label
            // 
            this.userOpts_label.AutoSize = true;
            this.userOpts_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userOpts_label.Location = new System.Drawing.Point(45, 33);
            this.userOpts_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userOpts_label.Name = "userOpts_label";
            this.userOpts_label.Size = new System.Drawing.Size(278, 52);
            this.userOpts_label.TabIndex = 1;
            this.userOpts_label.Text = "User Options";
            // 
            // ChangeUserbtn
            // 
            this.ChangeUserbtn.Location = new System.Drawing.Point(84, 196);
            this.ChangeUserbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeUserbtn.Name = "ChangeUserbtn";
            this.ChangeUserbtn.Size = new System.Drawing.Size(199, 41);
            this.ChangeUserbtn.TabIndex = 2;
            this.ChangeUserbtn.Text = "Change Account Settings";
            this.ChangeUserbtn.UseVisualStyleBackColor = true;
            this.ChangeUserbtn.Click += new System.EventHandler(this.ChangeUserbtn_Click);
            // 
            // UserOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 359);
            this.Controls.Add(this.ChangeUserbtn);
            this.Controls.Add(this.userOpts_label);
            this.Controls.Add(this.AddUser_button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserOptions_FormClosing);
            this.Load += new System.EventHandler(this.UserOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUser_button;
        private System.Windows.Forms.Label userOpts_label;
        private System.Windows.Forms.Button ChangeUserbtn;
    }
}