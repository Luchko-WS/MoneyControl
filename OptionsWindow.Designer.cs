namespace MoneyControl
{
    partial class OptionsWindow
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
            this.radioButtonAutoSave = new System.Windows.Forms.RadioButton();
            this.radioButtonAsk = new System.Windows.Forms.RadioButton();
            this.radioButtonNoSave = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonDeletePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAllowAddRows = new System.Windows.Forms.CheckBox();
            this.checkBoxAllowDeleteRows = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // radioButtonAutoSave
            // 
            this.radioButtonAutoSave.AutoSize = true;
            this.radioButtonAutoSave.Location = new System.Drawing.Point(75, 45);
            this.radioButtonAutoSave.Name = "radioButtonAutoSave";
            this.radioButtonAutoSave.Size = new System.Drawing.Size(212, 21);
            this.radioButtonAutoSave.TabIndex = 1;
            this.radioButtonAutoSave.Text = "зберігати дані автоматично";
            this.radioButtonAutoSave.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsk
            // 
            this.radioButtonAsk.AutoSize = true;
            this.radioButtonAsk.Location = new System.Drawing.Point(75, 72);
            this.radioButtonAsk.Name = "radioButtonAsk";
            this.radioButtonAsk.Size = new System.Drawing.Size(216, 21);
            this.radioButtonAsk.TabIndex = 2;
            this.radioButtonAsk.Text = "запитувати про збереження";
            this.radioButtonAsk.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoSave
            // 
            this.radioButtonNoSave.AutoSize = true;
            this.radioButtonNoSave.Location = new System.Drawing.Point(75, 98);
            this.radioButtonNoSave.Name = "radioButtonNoSave";
            this.radioButtonNoSave.Size = new System.Drawing.Size(157, 21);
            this.radioButtonNoSave.TabIndex = 3;
            this.radioButtonNoSave.Text = "ніколи не зберігати";
            this.radioButtonNoSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дії з даними при закритті програми:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Встановлення паролю:";
            // 
            // buttonAccept
            // 
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(74, 319);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(102, 27);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Прийняти";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(182, 319);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 27);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(60, 166);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(116, 27);
            this.buttonChangePassword.TabIndex = 4;
            this.buttonChangePassword.Text = "Змінити пароль";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonDeletePassword
            // 
            this.buttonDeletePassword.Location = new System.Drawing.Point(182, 166);
            this.buttonDeletePassword.Name = "buttonDeletePassword";
            this.buttonDeletePassword.Size = new System.Drawing.Size(116, 27);
            this.buttonDeletePassword.TabIndex = 5;
            this.buttonDeletePassword.Text = "Видалити";
            this.buttonDeletePassword.UseVisualStyleBackColor = true;
            this.buttonDeletePassword.Click += new System.EventHandler(this.buttonDeletePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Властивості таблиці:";
            // 
            // checkBoxAllowAddRows
            // 
            this.checkBoxAllowAddRows.AutoSize = true;
            this.checkBoxAllowAddRows.Location = new System.Drawing.Point(64, 243);
            this.checkBoxAllowAddRows.Name = "checkBoxAllowAddRows";
            this.checkBoxAllowAddRows.Size = new System.Drawing.Size(238, 21);
            this.checkBoxAllowAddRows.TabIndex = 6;
            this.checkBoxAllowAddRows.Text = "дозволити додавати нові рядки";
            this.checkBoxAllowAddRows.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllowDeleteRows
            // 
            this.checkBoxAllowDeleteRows.AutoSize = true;
            this.checkBoxAllowDeleteRows.Location = new System.Drawing.Point(64, 273);
            this.checkBoxAllowDeleteRows.Name = "checkBoxAllowDeleteRows";
            this.checkBoxAllowDeleteRows.Size = new System.Drawing.Size(208, 21);
            this.checkBoxAllowDeleteRows.TabIndex = 7;
            this.checkBoxAllowDeleteRows.Text = "дозволити видаляти рядки";
            this.checkBoxAllowDeleteRows.UseVisualStyleBackColor = true;
            // 
            // OptionsWindow
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(352, 358);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxAllowDeleteRows);
            this.Controls.Add(this.checkBoxAllowAddRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeletePassword);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonNoSave);
            this.Controls.Add(this.radioButtonAsk);
            this.Controls.Add(this.radioButtonAutoSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(370, 405);
            this.Name = "OptionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опції";
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAutoSave;
        private System.Windows.Forms.RadioButton radioButtonAsk;
        private System.Windows.Forms.RadioButton radioButtonNoSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonDeletePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAllowAddRows;
        private System.Windows.Forms.CheckBox checkBoxAllowDeleteRows;
    }
}