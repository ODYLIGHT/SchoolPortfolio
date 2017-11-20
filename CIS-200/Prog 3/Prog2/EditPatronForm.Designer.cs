namespace LibraryItems
{
    partial class EditPatronForm
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
            this.components = new System.ComponentModel.Container();
            this.editPatronListBox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // editPatronListBox
            // 
            this.editPatronListBox.FormattingEnabled = true;
            this.editPatronListBox.ItemHeight = 24;
            this.editPatronListBox.Location = new System.Drawing.Point(357, 22);
            this.editPatronListBox.Name = "editPatronListBox";
            this.editPatronListBox.Size = new System.Drawing.Size(299, 172);
            this.editPatronListBox.TabIndex = 0;
            this.editPatronListBox.Click += new System.EventHandler(this.editPatronListBox_Click);
            this.editPatronListBox.Validating += new System.ComponentModel.CancelEventHandler(this.editPatronListBox_Validating);
            this.editPatronListBox.Validated += new System.EventHandler(this.editPatronListBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditPatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 221);
            this.Controls.Add(this.editPatronListBox);
            this.Name = "EditPatronForm";
            this.Text = "Edit Patron Form";
            this.Load += new System.EventHandler(this.EditPatronForm_Load);
            this.Controls.SetChildIndex(this.patronNameLbl, 0);
            this.Controls.SetChildIndex(this.patronNameTxt, 0);
            this.Controls.SetChildIndex(this.patronIdLbl, 0);
            this.Controls.SetChildIndex(this.patronIdTxt, 0);
            this.Controls.SetChildIndex(this.cancelBtn, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.editPatronListBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox editPatronListBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}