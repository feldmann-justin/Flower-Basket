namespace Florae_Basket
{
    partial class dummyTestForm
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
            this.dummyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dummyLabel
            // 
            this.dummyLabel.AutoSize = true;
            this.dummyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dummyLabel.Location = new System.Drawing.Point(58, 106);
            this.dummyLabel.Name = "dummyLabel";
            this.dummyLabel.Size = new System.Drawing.Size(158, 30);
            this.dummyLabel.TabIndex = 0;
            this.dummyLabel.Text = "\"Main Menu\"";
            // 
            // dummyTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dummyLabel);
            this.Name = "dummyTestForm";
            this.Text = "dummyTestForm";
            this.Load += new System.EventHandler(this.dummyTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dummyLabel;
    }
}