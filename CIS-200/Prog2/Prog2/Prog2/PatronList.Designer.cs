namespace LibraryItems
{
    partial class PatronListForm
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
            this.patronTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // patronTextBox
            // 
            this.patronTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patronTextBox.Location = new System.Drawing.Point(0, 0);
            this.patronTextBox.Multiline = true;
            this.patronTextBox.Name = "patronTextBox";
            this.patronTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.patronTextBox.Size = new System.Drawing.Size(636, 528);
            this.patronTextBox.TabIndex = 0;
            // 
            // PatronListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 528);
            this.Controls.Add(this.patronTextBox);
            this.Name = "PatronListForm";
            this.Text = "Patron List";
            this.Load += new System.EventHandler(this.PatronList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patronTextBox;
    }
}