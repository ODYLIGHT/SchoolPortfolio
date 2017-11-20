namespace LibraryItems
{
    partial class BookForm
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
            this.addBookBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.copyrightYearLabel = new System.Windows.Forms.Label();
            this.loanPeriodLabel = new System.Windows.Forms.Label();
            this.callNumberLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.copyrightyearTextBox = new System.Windows.Forms.TextBox();
            this.loanPeriodTextBox = new System.Windows.Forms.TextBox();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.errorProviderBookForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBookForm)).BeginInit();
            this.SuspendLayout();
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(75, 319);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(134, 36);
            this.addBookBtn.TabIndex = 0;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(158, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(60, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title: ";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(119, 70);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(99, 25);
            this.publisherLabel.TabIndex = 2;
            this.publisherLabel.Text = "Publisher:";
            // 
            // copyrightYearLabel
            // 
            this.copyrightYearLabel.AutoSize = true;
            this.copyrightYearLabel.Location = new System.Drawing.Point(70, 114);
            this.copyrightYearLabel.Name = "copyrightYearLabel";
            this.copyrightYearLabel.Size = new System.Drawing.Size(148, 25);
            this.copyrightYearLabel.TabIndex = 3;
            this.copyrightYearLabel.Text = "Copyright Year:";
            // 
            // loanPeriodLabel
            // 
            this.loanPeriodLabel.AutoSize = true;
            this.loanPeriodLabel.Location = new System.Drawing.Point(95, 158);
            this.loanPeriodLabel.Name = "loanPeriodLabel";
            this.loanPeriodLabel.Size = new System.Drawing.Size(123, 25);
            this.loanPeriodLabel.TabIndex = 4;
            this.loanPeriodLabel.Text = "Loan Period:";
            // 
            // callNumberLabel
            // 
            this.callNumberLabel.AutoSize = true;
            this.callNumberLabel.Location = new System.Drawing.Point(92, 202);
            this.callNumberLabel.Name = "callNumberLabel";
            this.callNumberLabel.Size = new System.Drawing.Size(126, 25);
            this.callNumberLabel.TabIndex = 5;
            this.callNumberLabel.Text = "Call Number:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(142, 246);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(76, 25);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(224, 26);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(156, 29);
            this.titleTextBox.TabIndex = 7;
            this.titleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.title_Validating);
            this.titleTextBox.Validated += new System.EventHandler(this.title_Validated);
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(224, 70);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(156, 29);
            this.publisherTextBox.TabIndex = 8;
            this.publisherTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.publisher_Validating);
            this.publisherTextBox.Validated += new System.EventHandler(this.publisher_Validated);
            // 
            // copyrightyearTextBox
            // 
            this.copyrightyearTextBox.Location = new System.Drawing.Point(224, 114);
            this.copyrightyearTextBox.Name = "copyrightyearTextBox";
            this.copyrightyearTextBox.Size = new System.Drawing.Size(156, 29);
            this.copyrightyearTextBox.TabIndex = 9;
            this.copyrightyearTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.copyrightyear_Validating);
            this.copyrightyearTextBox.Validated += new System.EventHandler(this.copyrightyear_Validated);
            // 
            // loanPeriodTextBox
            // 
            this.loanPeriodTextBox.Location = new System.Drawing.Point(224, 158);
            this.loanPeriodTextBox.Name = "loanPeriodTextBox";
            this.loanPeriodTextBox.Size = new System.Drawing.Size(156, 29);
            this.loanPeriodTextBox.TabIndex = 10;
            this.loanPeriodTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.loanperiod_Validating);
            this.loanPeriodTextBox.Validated += new System.EventHandler(this.loanperiod_Validated);
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(224, 202);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(156, 29);
            this.callNumberTextBox.TabIndex = 11;
            this.callNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.callnumber_Validating);
            this.callNumberTextBox.Validated += new System.EventHandler(this.callnumber_Validated);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(224, 246);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(156, 29);
            this.authorTextBox.TabIndex = 12;
            this.authorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.author_Validating);
            this.authorTextBox.Validated += new System.EventHandler(this.author_Validated);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(246, 319);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(134, 36);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitBtn_MouseDown);
            // 
            // errorProviderBookForm
            // 
            this.errorProviderBookForm.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 395);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.callNumberTextBox);
            this.Controls.Add(this.loanPeriodTextBox);
            this.Controls.Add(this.copyrightyearTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.callNumberLabel);
            this.Controls.Add(this.loanPeriodLabel);
            this.Controls.Add(this.copyrightYearLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addBookBtn);
            this.Name = "BookForm";
            this.Text = "Book Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBookForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label copyrightYearLabel;
        private System.Windows.Forms.Label loanPeriodLabel;
        private System.Windows.Forms.Label callNumberLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox copyrightyearTextBox;
        private System.Windows.Forms.TextBox loanPeriodTextBox;
        private System.Windows.Forms.TextBox callNumberTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ErrorProvider errorProviderBookForm;
    }
}