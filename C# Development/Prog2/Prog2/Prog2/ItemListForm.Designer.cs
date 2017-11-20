namespace LibraryItems
{
    partial class ItemListForm
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
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itemTextBox
            // 
            this.itemTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemTextBox.Location = new System.Drawing.Point(0, 0);
            this.itemTextBox.Multiline = true;
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.ReadOnly = true;
            this.itemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemTextBox.Size = new System.Drawing.Size(480, 506);
            this.itemTextBox.TabIndex = 1;
            // 
            // ItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 506);
            this.Controls.Add(this.itemTextBox);
            this.Name = "ItemListForm";
            this.Text = "ItemListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox itemTextBox;
    }
}