namespace LibraryItems
{
    partial class EditBookForm
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
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemTitleLbl
            // 
            this.itemTitleLbl.Location = new System.Drawing.Point(522, 38);
            // 
            // itemTitleTxt
            // 
            this.itemTitleTxt.Location = new System.Drawing.Point(589, 34);
            // 
            // itemPublisherLbl
            // 
            this.itemPublisherLbl.Location = new System.Drawing.Point(480, 86);
            // 
            // itemPublisherTxt
            // 
            this.itemPublisherTxt.Location = new System.Drawing.Point(589, 82);
            // 
            // itemCopyrightLbl
            // 
            this.itemCopyrightLbl.Location = new System.Drawing.Point(478, 134);
            // 
            // itemCopyrightTxt
            // 
            this.itemCopyrightTxt.Location = new System.Drawing.Point(589, 130);
            // 
            // itemLoanPeriodLbl
            // 
            this.itemLoanPeriodLbl.Location = new System.Drawing.Point(454, 182);
            // 
            // itemLoanPeriodTxt
            // 
            this.itemLoanPeriodTxt.Location = new System.Drawing.Point(589, 178);
            // 
            // itemCallNumberLbl
            // 
            this.itemCallNumberLbl.Location = new System.Drawing.Point(454, 222);
            // 
            // itemCallNumberTxt
            // 
            this.itemCallNumberTxt.Location = new System.Drawing.Point(589, 221);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(400, 311);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(250, 311);
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 24;
            this.bookListBox.Location = new System.Drawing.Point(32, 25);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(413, 268);
            this.bookListBox.TabIndex = 0;
            this.bookListBox.SelectedIndexChanged += new System.EventHandler(this.bookListBox_SelectedIndexChanged);
            this.bookListBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookListBox_Validating);
            this.bookListBox.Validated += new System.EventHandler(this.bookListBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(589, 264);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(180, 29);
            this.authorTxtBox.TabIndex = 18;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(502, 264);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(81, 25);
            this.authorLabel.TabIndex = 19;
            this.authorLabel.Text = "Author: ";
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 389);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.authorTxtBox);
            this.Controls.Add(this.bookListBox);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.Controls.SetChildIndex(this.itemTitleLbl, 0);
            this.Controls.SetChildIndex(this.itemTitleTxt, 0);
            this.Controls.SetChildIndex(this.itemPublisherLbl, 0);
            this.Controls.SetChildIndex(this.itemPublisherTxt, 0);
            this.Controls.SetChildIndex(this.itemCopyrightLbl, 0);
            this.Controls.SetChildIndex(this.itemCopyrightTxt, 0);
            this.Controls.SetChildIndex(this.itemLoanPeriodLbl, 0);
            this.Controls.SetChildIndex(this.itemLoanPeriodTxt, 0);
            this.Controls.SetChildIndex(this.itemCallNumberLbl, 0);
            this.Controls.SetChildIndex(this.itemCallNumberTxt, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.cancelBtn, 0);
            this.Controls.SetChildIndex(this.bookListBox, 0);
            this.Controls.SetChildIndex(this.authorTxtBox, 0);
            this.Controls.SetChildIndex(this.authorLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookListBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorTxtBox;
    }
}