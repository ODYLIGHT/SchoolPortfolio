namespace LibraryItems
{
    partial class PatronForm
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.patronNameLbl = new System.Windows.Forms.Label();
            this.patronNameTxt = new System.Windows.Forms.TextBox();
            this.patronIdLbl = new System.Windows.Forms.Label();
            this.patronIdTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // patronNameLbl
            // 
            this.patronNameLbl.AutoSize = true;
            this.patronNameLbl.Location = new System.Drawing.Point(22, 28);
            this.patronNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.patronNameLbl.Name = "patronNameLbl";
            this.patronNameLbl.Size = new System.Drawing.Size(70, 25);
            this.patronNameLbl.TabIndex = 0;
            this.patronNameLbl.Text = "Name:";
            // 
            // patronNameTxt
            // 
            this.patronNameTxt.Location = new System.Drawing.Point(127, 22);
            this.patronNameTxt.Margin = new System.Windows.Forms.Padding(6);
            this.patronNameTxt.Name = "patronNameTxt";
            this.patronNameTxt.Size = new System.Drawing.Size(180, 29);
            this.patronNameTxt.TabIndex = 1;
            this.patronNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameTxt_Validating);
            this.patronNameTxt.Validated += new System.EventHandler(this.patronNameTxt_Validated);
            // 
            // patronIdLbl
            // 
            this.patronIdLbl.AutoSize = true;
            this.patronIdLbl.Location = new System.Drawing.Point(53, 78);
            this.patronIdLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.patronIdLbl.Name = "patronIdLbl";
            this.patronIdLbl.Size = new System.Drawing.Size(37, 25);
            this.patronIdLbl.TabIndex = 2;
            this.patronIdLbl.Text = "ID:";
            // 
            // patronIdTxt
            // 
            this.patronIdTxt.Location = new System.Drawing.Point(127, 72);
            this.patronIdTxt.Margin = new System.Windows.Forms.Padding(6);
            this.patronIdTxt.Name = "patronIdTxt";
            this.patronIdTxt.Size = new System.Drawing.Size(180, 29);
            this.patronIdTxt.TabIndex = 3;
            this.patronIdTxt.Validating += new System.ComponentModel.CancelEventHandler(this.patronIdTxt_Validating);
            this.patronIdTxt.Validated += new System.EventHandler(this.patronIdTxt_Validated);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(172, 148);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(138, 42);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(22, 148);
            this.okBtn.Margin = new System.Windows.Forms.Padding(6);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(138, 42);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 207);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronIdTxt);
            this.Controls.Add(this.patronIdLbl);
            this.Controls.Add(this.patronNameTxt);
            this.Controls.Add(this.patronNameLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PatronForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        protected internal System.Windows.Forms.TextBox patronIdTxt;
        protected internal System.Windows.Forms.Label patronIdLbl;
        protected internal System.Windows.Forms.Label patronNameLbl;
        protected internal System.Windows.Forms.Button cancelBtn;
        protected internal System.Windows.Forms.Button okBtn;
        protected internal System.Windows.Forms.TextBox patronNameTxt;
    }
}