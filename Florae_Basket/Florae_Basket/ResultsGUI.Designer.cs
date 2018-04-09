namespace Florae_Basket
{
    partial class ResultsGUI
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
            this.Result1btn = new System.Windows.Forms.Button();
            this.Result2btn = new System.Windows.Forms.Button();
            this.Result3btn = new System.Windows.Forms.Button();
            this.Result1box = new System.Windows.Forms.TextBox();
            this.Result2box = new System.Windows.Forms.TextBox();
            this.Result3box = new System.Windows.Forms.TextBox();
            this.Mainbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top 3 Results";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Result1btn
            // 
            this.Result1btn.Location = new System.Drawing.Point(298, 92);
            this.Result1btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result1btn.Name = "Result1btn";
            this.Result1btn.Size = new System.Drawing.Size(56, 19);
            this.Result1btn.TabIndex = 4;
            this.Result1btn.Text = "View";
            this.Result1btn.UseVisualStyleBackColor = true;
            this.Result1btn.Click += new System.EventHandler(this.Result1btn_Click);
            // 
            // Result2btn
            // 
            this.Result2btn.Location = new System.Drawing.Point(298, 151);
            this.Result2btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result2btn.Name = "Result2btn";
            this.Result2btn.Size = new System.Drawing.Size(56, 19);
            this.Result2btn.TabIndex = 5;
            this.Result2btn.Text = "View";
            this.Result2btn.UseVisualStyleBackColor = true;
            this.Result2btn.Click += new System.EventHandler(this.Result2btn_Click);
            // 
            // Result3btn
            // 
            this.Result3btn.Location = new System.Drawing.Point(298, 213);
            this.Result3btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result3btn.Name = "Result3btn";
            this.Result3btn.Size = new System.Drawing.Size(56, 19);
            this.Result3btn.TabIndex = 6;
            this.Result3btn.Text = "View";
            this.Result3btn.UseVisualStyleBackColor = true;
            this.Result3btn.Click += new System.EventHandler(this.Result3btn_Click);
            // 
            // Result1box
            // 
            this.Result1box.Enabled = false;
            this.Result1box.Location = new System.Drawing.Point(70, 92);
            this.Result1box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result1box.Name = "Result1box";
            this.Result1box.Size = new System.Drawing.Size(158, 20);
            this.Result1box.TabIndex = 7;
            // 
            // Result2box
            // 
            this.Result2box.Enabled = false;
            this.Result2box.Location = new System.Drawing.Point(70, 151);
            this.Result2box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result2box.Name = "Result2box";
            this.Result2box.Size = new System.Drawing.Size(158, 20);
            this.Result2box.TabIndex = 8;
            // 
            // Result3box
            // 
            this.Result3box.Enabled = false;
            this.Result3box.Location = new System.Drawing.Point(70, 214);
            this.Result3box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result3box.Name = "Result3box";
            this.Result3box.Size = new System.Drawing.Size(158, 20);
            this.Result3box.TabIndex = 9;
            // 
            // Mainbtn
            // 
            this.Mainbtn.Location = new System.Drawing.Point(9, 269);
            this.Mainbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Mainbtn.Name = "Mainbtn";
            this.Mainbtn.Size = new System.Drawing.Size(74, 19);
            this.Mainbtn.TabIndex = 10;
            this.Mainbtn.Text = "Main Menu";
            this.Mainbtn.UseVisualStyleBackColor = true;
            this.Mainbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 297);
            this.Controls.Add(this.Mainbtn);
            this.Controls.Add(this.Result3box);
            this.Controls.Add(this.Result2box);
            this.Controls.Add(this.Result1box);
            this.Controls.Add(this.Result3btn);
            this.Controls.Add(this.Result2btn);
            this.Controls.Add(this.Result1btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResultsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultsGUI";
            this.Load += new System.EventHandler(this.ResultsGUI_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Result1box;
        private System.Windows.Forms.TextBox Result2box;
        private System.Windows.Forms.TextBox Result3box;
        private System.Windows.Forms.Button Mainbtn;
        public System.Windows.Forms.Button Result1btn;
        public System.Windows.Forms.Button Result2btn;
        public System.Windows.Forms.Button Result3btn;
    }
}