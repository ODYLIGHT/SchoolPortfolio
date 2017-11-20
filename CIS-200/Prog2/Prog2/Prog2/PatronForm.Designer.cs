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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.patronNameInput = new System.Windows.Forms.TextBox();
            this.patronIDInput = new System.Windows.Forms.TextBox();
            this.patronNameLabel = new System.Windows.Forms.Label();
            this.patronIDLabel = new System.Windows.Forms.Label();
            this.errorProviderforName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderforID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforID)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(230, 235);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 45);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(92, 235);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(87, 45);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // patronNameInput
            // 
            this.patronNameInput.Location = new System.Drawing.Point(171, 94);
            this.patronNameInput.Name = "patronNameInput";
            this.patronNameInput.Size = new System.Drawing.Size(161, 29);
            this.patronNameInput.TabIndex = 2;
            this.patronNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.patronNameInput_Validating);
            this.patronNameInput.Validated += new System.EventHandler(this.patronNameInput_Validated);
            // 
            // patronIDInput
            // 
            this.patronIDInput.Location = new System.Drawing.Point(171, 163);
            this.patronIDInput.Name = "patronIDInput";
            this.patronIDInput.Size = new System.Drawing.Size(161, 29);
            this.patronIDInput.TabIndex = 3;
            this.patronIDInput.Validating += new System.ComponentModel.CancelEventHandler(this.patronIDInput_Validating);
            this.patronIDInput.Validated += new System.EventHandler(this.patronIDInput_Validated);
            // 
            // patronNameLabel
            // 
            this.patronNameLabel.AutoSize = true;
            this.patronNameLabel.Location = new System.Drawing.Point(88, 94);
            this.patronNameLabel.Name = "patronNameLabel";
            this.patronNameLabel.Size = new System.Drawing.Size(70, 25);
            this.patronNameLabel.TabIndex = 4;
            this.patronNameLabel.Text = "Name:";
            // 
            // patronIDLabel
            // 
            this.patronIDLabel.AutoSize = true;
            this.patronIDLabel.Location = new System.Drawing.Point(116, 163);
            this.patronIDLabel.Name = "patronIDLabel";
            this.patronIDLabel.Size = new System.Drawing.Size(42, 25);
            this.patronIDLabel.TabIndex = 5;
            this.patronIDLabel.Text = "ID: ";
            // 
            // errorProviderforName
            // 
            this.errorProviderforName.ContainerControl = this;
            // 
            // errorProviderforID
            // 
            this.errorProviderforID.ContainerControl = this;
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 361);
            this.Controls.Add(this.patronIDLabel);
            this.Controls.Add(this.patronNameLabel);
            this.Controls.Add(this.patronIDInput);
            this.Controls.Add(this.patronNameInput);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "PatronForm";
            this.Text = "PatronForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox patronNameInput;
        private System.Windows.Forms.TextBox patronIDInput;
        private System.Windows.Forms.Label patronNameLabel;
        private System.Windows.Forms.Label patronIDLabel;
        private System.Windows.Forms.ErrorProvider errorProviderforName;
        private System.Windows.Forms.ErrorProvider errorProviderforID;
    }
}