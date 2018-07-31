namespace Florae_Basket
{
    partial class United_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(United_GUI));
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignIn_Title = new System.Windows.Forms.Label();
            this.Login_Title = new System.Windows.Forms.Label();
            this.Login_submit = new System.Windows.Forms.Button();
            this.Incorrect_Login_Warning = new System.Windows.Forms.Label();
            this.LandingPage = new System.Windows.Forms.Panel();
            this.UserControlButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddFlowerButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SignInPage = new System.Windows.Forms.Panel();
            this.AddFlowerPage = new System.Windows.Forms.Panel();
            this.NotesTextbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BotanicalFamilyTextbox = new System.Windows.Forms.TextBox();
            this.LatinNameTextbox = new System.Windows.Forms.TextBox();
            this.EnglishNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddFlowerSubmitButton = new System.Windows.Forms.Button();
            this.LandingPage.SuspendLayout();
            this.SignInPage.SuspendLayout();
            this.AddFlowerPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username_txt
            // 
            this.Username_txt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Username_txt.Location = new System.Drawing.Point(478, 179);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(274, 26);
            this.Username_txt.TabIndex = 0;
            this.Username_txt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password_txt.Location = new System.Drawing.Point(478, 248);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(274, 26);
            this.Password_txt.TabIndex = 1;
            this.Password_txt.UseSystemPasswordChar = true;
            this.Password_txt.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(566, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(566, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // SignIn_Title
            // 
            this.SignIn_Title.AutoSize = true;
            this.SignIn_Title.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignIn_Title.Location = new System.Drawing.Point(505, 17);
            this.SignIn_Title.Name = "SignIn_Title";
            this.SignIn_Title.Size = new System.Drawing.Size(231, 73);
            this.SignIn_Title.TabIndex = 4;
            this.SignIn_Title.Text = "Sign In";
            this.SignIn_Title.Click += new System.EventHandler(this.SignIn_Title_Click);
            // 
            // Login_Title
            // 
            this.Login_Title.AutoSize = true;
            this.Login_Title.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_Title.Location = new System.Drawing.Point(429, 47);
            this.Login_Title.Name = "Login_Title";
            this.Login_Title.Size = new System.Drawing.Size(424, 73);
            this.Login_Title.TabIndex = 5;
            this.Login_Title.Text = "Flower Basket";
            // 
            // Login_submit
            // 
            this.Login_submit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Login_submit.Enabled = false;
            this.Login_submit.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_submit.Location = new System.Drawing.Point(518, 334);
            this.Login_submit.Name = "Login_submit";
            this.Login_submit.Size = new System.Drawing.Size(188, 92);
            this.Login_submit.TabIndex = 6;
            this.Login_submit.Text = "Submit";
            this.Login_submit.UseVisualStyleBackColor = false;
            this.Login_submit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Incorrect_Login_Warning
            // 
            this.Incorrect_Login_Warning.AutoSize = true;
            this.Incorrect_Login_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incorrect_Login_Warning.ForeColor = System.Drawing.Color.Red;
            this.Incorrect_Login_Warning.Location = new System.Drawing.Point(528, 277);
            this.Incorrect_Login_Warning.Name = "Incorrect_Login_Warning";
            this.Incorrect_Login_Warning.Size = new System.Drawing.Size(178, 20);
            this.Incorrect_Login_Warning.TabIndex = 7;
            this.Incorrect_Login_Warning.Text = "Incorrect Information";
            this.Incorrect_Login_Warning.Visible = false;
            // 
            // LandingPage
            // 
            this.LandingPage.Controls.Add(this.UserControlButton);
            this.LandingPage.Controls.Add(this.SearchButton);
            this.LandingPage.Controls.Add(this.AddFlowerButton);
            this.LandingPage.Location = new System.Drawing.Point(12, 123);
            this.LandingPage.Name = "LandingPage";
            this.LandingPage.Size = new System.Drawing.Size(1284, 529);
            this.LandingPage.TabIndex = 8;
            this.LandingPage.Visible = false;
            // 
            // UserControlButton
            // 
            this.UserControlButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserControlButton.Enabled = false;
            this.UserControlButton.Image = global::Florae_Basket.Properties.Resources.UserIcon;
            this.UserControlButton.Location = new System.Drawing.Point(898, 109);
            this.UserControlButton.Name = "UserControlButton";
            this.UserControlButton.Size = new System.Drawing.Size(364, 364);
            this.UserControlButton.TabIndex = 2;
            this.UserControlButton.UseVisualStyleBackColor = false;
            this.UserControlButton.Click += new System.EventHandler(this.UserControlButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.Enabled = false;
            this.SearchButton.Image = global::Florae_Basket.Properties.Resources.SearchIcon;
            this.SearchButton.Location = new System.Drawing.Point(454, 109);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(364, 364);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddFlowerButton
            // 
            this.AddFlowerButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFlowerButton.Enabled = false;
            this.AddFlowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlowerButton.Image = global::Florae_Basket.Properties.Resources.PlusIcon;
            this.AddFlowerButton.Location = new System.Drawing.Point(20, 109);
            this.AddFlowerButton.Name = "AddFlowerButton";
            this.AddFlowerButton.Size = new System.Drawing.Size(364, 364);
            this.AddFlowerButton.TabIndex = 0;
            this.AddFlowerButton.UseVisualStyleBackColor = false;
            this.AddFlowerButton.Click += new System.EventHandler(this.AddFlowerButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LogOutButton.Enabled = false;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOutButton.Location = new System.Drawing.Point(1188, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(108, 39);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Sign Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Visible = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SignInPage
            // 
            this.SignInPage.Controls.Add(this.SignIn_Title);
            this.SignInPage.Controls.Add(this.Login_submit);
            this.SignInPage.Controls.Add(this.Username_txt);
            this.SignInPage.Controls.Add(this.label1);
            this.SignInPage.Controls.Add(this.Incorrect_Login_Warning);
            this.SignInPage.Controls.Add(this.label2);
            this.SignInPage.Controls.Add(this.Password_txt);
            this.SignInPage.Location = new System.Drawing.Point(12, 123);
            this.SignInPage.Name = "SignInPage";
            this.SignInPage.Size = new System.Drawing.Size(1284, 529);
            this.SignInPage.TabIndex = 10;
            // 
            // AddFlowerPage
            // 
            this.AddFlowerPage.Controls.Add(this.AddFlowerSubmitButton);
            this.AddFlowerPage.Controls.Add(this.NotesTextbox);
            this.AddFlowerPage.Controls.Add(this.label6);
            this.AddFlowerPage.Controls.Add(this.BotanicalFamilyTextbox);
            this.AddFlowerPage.Controls.Add(this.LatinNameTextbox);
            this.AddFlowerPage.Controls.Add(this.EnglishNameTextbox);
            this.AddFlowerPage.Controls.Add(this.label5);
            this.AddFlowerPage.Controls.Add(this.label4);
            this.AddFlowerPage.Controls.Add(this.label3);
            this.AddFlowerPage.Location = new System.Drawing.Point(12, 123);
            this.AddFlowerPage.Name = "AddFlowerPage";
            this.AddFlowerPage.Size = new System.Drawing.Size(1284, 529);
            this.AddFlowerPage.TabIndex = 11;
            this.AddFlowerPage.Visible = false;
            // 
            // NotesTextbox
            // 
            this.NotesTextbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NotesTextbox.Enabled = false;
            this.NotesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NotesTextbox.Location = new System.Drawing.Point(59, 343);
            this.NotesTextbox.Name = "NotesTextbox";
            this.NotesTextbox.Size = new System.Drawing.Size(325, 147);
            this.NotesTextbox.TabIndex = 7;
            this.NotesTextbox.Text = "";
            this.NotesTextbox.TextChanged += new System.EventHandler(this.NotesTextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(172, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Notes";
            // 
            // BotanicalFamilyTextbox
            // 
            this.BotanicalFamilyTextbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BotanicalFamilyTextbox.Enabled = false;
            this.BotanicalFamilyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotanicalFamilyTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotanicalFamilyTextbox.Location = new System.Drawing.Point(59, 239);
            this.BotanicalFamilyTextbox.Name = "BotanicalFamilyTextbox";
            this.BotanicalFamilyTextbox.Size = new System.Drawing.Size(325, 26);
            this.BotanicalFamilyTextbox.TabIndex = 5;
            this.BotanicalFamilyTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LatinNameTextbox
            // 
            this.LatinNameTextbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LatinNameTextbox.Enabled = false;
            this.LatinNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatinNameTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LatinNameTextbox.Location = new System.Drawing.Point(59, 143);
            this.LatinNameTextbox.Name = "LatinNameTextbox";
            this.LatinNameTextbox.Size = new System.Drawing.Size(325, 26);
            this.LatinNameTextbox.TabIndex = 4;
            this.LatinNameTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // EnglishNameTextbox
            // 
            this.EnglishNameTextbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EnglishNameTextbox.Enabled = false;
            this.EnglishNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishNameTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnglishNameTextbox.Location = new System.Drawing.Point(59, 48);
            this.EnglishNameTextbox.Name = "EnglishNameTextbox";
            this.EnglishNameTextbox.Size = new System.Drawing.Size(325, 26);
            this.EnglishNameTextbox.TabIndex = 3;
            this.EnglishNameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(113, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Botanical Family";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(136, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Latin Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(125, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "English Name";
            // 
            // AddFlowerSubmitButton
            // 
            this.AddFlowerSubmitButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddFlowerSubmitButton.Enabled = false;
            this.AddFlowerSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlowerSubmitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFlowerSubmitButton.Location = new System.Drawing.Point(1174, 161);
            this.AddFlowerSubmitButton.Name = "AddFlowerSubmitButton";
            this.AddFlowerSubmitButton.Size = new System.Drawing.Size(110, 56);
            this.AddFlowerSubmitButton.TabIndex = 8;
            this.AddFlowerSubmitButton.Text = "Add ";
            this.AddFlowerSubmitButton.UseVisualStyleBackColor = false;
            this.AddFlowerSubmitButton.Click += new System.EventHandler(this.AddFlowerSubmitButton_Click);
            // 
            // United_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1308, 664);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.Login_Title);
            this.Controls.Add(this.AddFlowerPage);
            this.Controls.Add(this.LandingPage);
            this.Controls.Add(this.SignInPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "United_GUI";
            this.Text = "Flower Basket";
            this.LandingPage.ResumeLayout(false);
            this.SignInPage.ResumeLayout(false);
            this.SignInPage.PerformLayout();
            this.AddFlowerPage.ResumeLayout(false);
            this.AddFlowerPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SignIn_Title;
        private System.Windows.Forms.Label Login_Title;
        private System.Windows.Forms.Button Login_submit;
        private System.Windows.Forms.Label Incorrect_Login_Warning;
        private System.Windows.Forms.Panel LandingPage;
        private System.Windows.Forms.Button UserControlButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddFlowerButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Panel SignInPage;
        private System.Windows.Forms.Panel AddFlowerPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BotanicalFamilyTextbox;
        private System.Windows.Forms.TextBox LatinNameTextbox;
        private System.Windows.Forms.TextBox EnglishNameTextbox;
        private System.Windows.Forms.RichTextBox NotesTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddFlowerSubmitButton;
    }
}