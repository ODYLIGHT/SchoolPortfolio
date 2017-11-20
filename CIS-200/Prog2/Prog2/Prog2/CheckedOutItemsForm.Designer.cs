namespace LibraryItems
{
    partial class CheckedOutItemsForm
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
            this.checkedOutTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkedOutTextBox
            // 
            this.checkedOutTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedOutTextBox.Location = new System.Drawing.Point(0, 0);
            this.checkedOutTextBox.Multiline = true;
            this.checkedOutTextBox.Name = "checkedOutTextBox";
            this.checkedOutTextBox.ReadOnly = true;
            this.checkedOutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.checkedOutTextBox.Size = new System.Drawing.Size(533, 500);
            this.checkedOutTextBox.TabIndex = 2;
            // 
            // CheckedOutItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 500);
            this.Controls.Add(this.checkedOutTextBox);
            this.Name = "CheckedOutItemsForm";
            this.Text = "CheckedOutItemsForm";
            this.Load += new System.EventHandler(this.CheckedOutItemsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox checkedOutTextBox;
    }
}