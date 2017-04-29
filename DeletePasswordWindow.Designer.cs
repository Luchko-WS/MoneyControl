namespace MoneyControl
{
    partial class DeletePasswordWindow
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonShowOldPasswordText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введіть старий пароль:";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(12, 40);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '•';
            this.textBoxOldPassword.Size = new System.Drawing.Size(216, 22);
            this.textBoxOldPassword.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(136, 73);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(28, 73);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(102, 27);
            this.buttonAccept.TabIndex = 2;
            this.buttonAccept.Text = "Прийняти";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonShowOldPasswordText
            // 
            this.buttonShowOldPasswordText.Location = new System.Drawing.Point(228, 39);
            this.buttonShowOldPasswordText.Name = "buttonShowOldPasswordText";
            this.buttonShowOldPasswordText.Size = new System.Drawing.Size(24, 24);
            this.buttonShowOldPasswordText.TabIndex = 14;
            this.buttonShowOldPasswordText.TabStop = false;
            this.buttonShowOldPasswordText.Text = "*";
            this.buttonShowOldPasswordText.UseVisualStyleBackColor = true;
            this.buttonShowOldPasswordText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShowOldPasswordText_MouseDown);
            this.buttonShowOldPasswordText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShowOldPasswordText_MouseUp);
            // 
            // DeletePasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(263, 116);
            this.ControlBox = false;
            this.Controls.Add(this.buttonShowOldPasswordText);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOldPassword);
            this.MinimumSize = new System.Drawing.Size(281, 163);
            this.Name = "DeletePasswordWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletePasswordWindow";
            this.Load += new System.EventHandler(this.DeletePasswordWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonShowOldPasswordText;
    }
}