namespace MoneyControl
{
    partial class ChangePasswordWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonShowNewPasswordText = new System.Windows.Forms.Button();
            this.buttonShowNewPasswordRepeatText = new System.Windows.Forms.Button();
            this.buttonShowOldPasswordText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Повторіть новий пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введіть новий пароль:";
            // 
            // textBoxRepeatNewPassword
            // 
            this.textBoxRepeatNewPassword.Location = new System.Drawing.Point(35, 88);
            this.textBoxRepeatNewPassword.Name = "textBoxRepeatNewPassword";
            this.textBoxRepeatNewPassword.PasswordChar = '•';
            this.textBoxRepeatNewPassword.Size = new System.Drawing.Size(216, 22);
            this.textBoxRepeatNewPassword.TabIndex = 2;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(35, 39);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '•';
            this.textBoxNewPassword.Size = new System.Drawing.Size(216, 22);
            this.textBoxNewPassword.TabIndex = 1;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(35, 136);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '•';
            this.textBoxOldPassword.Size = new System.Drawing.Size(216, 22);
            this.textBoxOldPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Введіть старий пароль:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(158, 169);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 27);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(50, 169);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(102, 27);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Прийняти";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonShowNewPasswordText
            // 
            this.buttonShowNewPasswordText.Location = new System.Drawing.Point(251, 38);
            this.buttonShowNewPasswordText.Name = "buttonShowNewPasswordText";
            this.buttonShowNewPasswordText.Size = new System.Drawing.Size(24, 24);
            this.buttonShowNewPasswordText.TabIndex = 13;
            this.buttonShowNewPasswordText.TabStop = false;
            this.buttonShowNewPasswordText.Text = "*";
            this.buttonShowNewPasswordText.UseVisualStyleBackColor = true;
            this.buttonShowNewPasswordText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShowNewPasswordText_MouseDown);
            this.buttonShowNewPasswordText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShowNewPasswordText_MouseUp);
            // 
            // buttonShowNewPasswordRepeatText
            // 
            this.buttonShowNewPasswordRepeatText.Location = new System.Drawing.Point(251, 87);
            this.buttonShowNewPasswordRepeatText.Name = "buttonShowNewPasswordRepeatText";
            this.buttonShowNewPasswordRepeatText.Size = new System.Drawing.Size(24, 24);
            this.buttonShowNewPasswordRepeatText.TabIndex = 13;
            this.buttonShowNewPasswordRepeatText.TabStop = false;
            this.buttonShowNewPasswordRepeatText.Text = "*";
            this.buttonShowNewPasswordRepeatText.UseVisualStyleBackColor = true;
            this.buttonShowNewPasswordRepeatText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShowNewPasswordRepeatText_MouseDown);
            this.buttonShowNewPasswordRepeatText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShowNewPasswordRepeatText_MouseUp);
            // 
            // buttonShowOldPasswordText
            // 
            this.buttonShowOldPasswordText.Location = new System.Drawing.Point(251, 135);
            this.buttonShowOldPasswordText.Name = "buttonShowOldPasswordText";
            this.buttonShowOldPasswordText.Size = new System.Drawing.Size(24, 24);
            this.buttonShowOldPasswordText.TabIndex = 13;
            this.buttonShowOldPasswordText.TabStop = false;
            this.buttonShowOldPasswordText.Text = "*";
            this.buttonShowOldPasswordText.UseVisualStyleBackColor = true;
            this.buttonShowOldPasswordText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShowOldPasswordText_MouseDown);
            this.buttonShowOldPasswordText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShowOldPasswordText_MouseUp);
            // 
            // ChangePasswordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(315, 208);
            this.ControlBox = false;
            this.Controls.Add(this.buttonShowOldPasswordText);
            this.Controls.Add(this.buttonShowNewPasswordRepeatText);
            this.Controls.Add(this.buttonShowNewPasswordText);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.textBoxRepeatNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(333, 255);
            this.Name = "ChangePasswordWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зміна паролю";
            this.Load += new System.EventHandler(this.ChangePasswordWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRepeatNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonShowNewPasswordText;
        private System.Windows.Forms.Button buttonShowNewPasswordRepeatText;
        private System.Windows.Forms.Button buttonShowOldPasswordText;
    }
}