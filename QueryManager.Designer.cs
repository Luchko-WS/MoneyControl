namespace MoneyControl
{
    partial class QueryManager
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
            this.checkBoxUsingDateTime = new System.Windows.Forms.CheckBox();
            this.checkBoxUsingObjectDescrible = new System.Windows.Forms.CheckBox();
            this.checkBoxUsingExpenses = new System.Windows.Forms.CheckBox();
            this.dateTimePickerMinDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMaxDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.comboBoxOperators = new System.Windows.Forms.ComboBox();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxFromDate = new System.Windows.Forms.CheckBox();
            this.checkBoxToDate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxQueryText = new System.Windows.Forms.RichTextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxUsingDateTime
            // 
            this.checkBoxUsingDateTime.AutoSize = true;
            this.checkBoxUsingDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUsingDateTime.Location = new System.Drawing.Point(31, 22);
            this.checkBoxUsingDateTime.Name = "checkBoxUsingDateTime";
            this.checkBoxUsingDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxUsingDateTime.Size = new System.Drawing.Size(267, 24);
            this.checkBoxUsingDateTime.TabIndex = 0;
            this.checkBoxUsingDateTime.Text = "Використовувати дату і час";
            this.checkBoxUsingDateTime.UseVisualStyleBackColor = true;
            this.checkBoxUsingDateTime.CheckedChanged += new System.EventHandler(this.checkBoxUsingDateTime_CheckedChanged);
            // 
            // checkBoxUsingObjectDescrible
            // 
            this.checkBoxUsingObjectDescrible.AutoSize = true;
            this.checkBoxUsingObjectDescrible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUsingObjectDescrible.Location = new System.Drawing.Point(31, 94);
            this.checkBoxUsingObjectDescrible.Name = "checkBoxUsingObjectDescrible";
            this.checkBoxUsingObjectDescrible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxUsingObjectDescrible.Size = new System.Drawing.Size(355, 24);
            this.checkBoxUsingObjectDescrible.TabIndex = 1;
            this.checkBoxUsingObjectDescrible.Text = "Використовувати текст опису об\'єктів";
            this.checkBoxUsingObjectDescrible.UseVisualStyleBackColor = true;
            this.checkBoxUsingObjectDescrible.CheckedChanged += new System.EventHandler(this.checkBoxUsingObjectDescrible_CheckedChanged);
            // 
            // checkBoxUsingExpenses
            // 
            this.checkBoxUsingExpenses.AutoSize = true;
            this.checkBoxUsingExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUsingExpenses.Location = new System.Drawing.Point(31, 167);
            this.checkBoxUsingExpenses.Name = "checkBoxUsingExpenses";
            this.checkBoxUsingExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxUsingExpenses.Size = new System.Drawing.Size(254, 24);
            this.checkBoxUsingExpenses.TabIndex = 2;
            this.checkBoxUsingExpenses.Text = "Використовувати витрати";
            this.checkBoxUsingExpenses.UseVisualStyleBackColor = true;
            this.checkBoxUsingExpenses.CheckedChanged += new System.EventHandler(this.checkBoxUsingExpenses_CheckedChanged);
            // 
            // dateTimePickerMinDate
            // 
            this.dateTimePickerMinDate.Enabled = false;
            this.dateTimePickerMinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMinDate.Location = new System.Drawing.Point(67, 53);
            this.dateTimePickerMinDate.Name = "dateTimePickerMinDate";
            this.dateTimePickerMinDate.Size = new System.Drawing.Size(170, 22);
            this.dateTimePickerMinDate.TabIndex = 3;
            this.dateTimePickerMinDate.ValueChanged += new System.EventHandler(this.dateTimePickerMinDate_ValueChanged);
            // 
            // dateTimePickerMaxDate
            // 
            this.dateTimePickerMaxDate.Enabled = false;
            this.dateTimePickerMaxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMaxDate.Location = new System.Drawing.Point(295, 52);
            this.dateTimePickerMaxDate.Name = "dateTimePickerMaxDate";
            this.dateTimePickerMaxDate.Size = new System.Drawing.Size(170, 22);
            this.dateTimePickerMaxDate.TabIndex = 3;
            this.dateTimePickerMaxDate.ValueChanged += new System.EventHandler(this.dateTimePickerMaxDate_ValueChanged);
            // 
            // textBoxToken
            // 
            this.textBoxToken.Enabled = false;
            this.textBoxToken.Location = new System.Drawing.Point(31, 124);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(434, 22);
            this.textBoxToken.TabIndex = 4;
            this.textBoxToken.TextChanged += new System.EventHandler(this.textBoxToken_TextChanged);
            // 
            // comboBoxOperators
            // 
            this.comboBoxOperators.Enabled = false;
            this.comboBoxOperators.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<=",
            "=",
            "<>",
            "BETWEEN",
            "NOT BETWEEN"});
            this.comboBoxOperators.Location = new System.Drawing.Point(121, 194);
            this.comboBoxOperators.Name = "comboBoxOperators";
            this.comboBoxOperators.Size = new System.Drawing.Size(113, 24);
            this.comboBoxOperators.TabIndex = 5;
            this.comboBoxOperators.Text = "=";
            this.comboBoxOperators.TextChanged += new System.EventHandler(this.comboBoxOperators_TextChanged);
            this.comboBoxOperators.Leave += new System.EventHandler(this.comboBoxOperators_Leave);
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Enabled = false;
            this.textBoxValue1.Location = new System.Drawing.Point(341, 194);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(100, 22);
            this.textBoxValue1.TabIndex = 6;
            this.textBoxValue1.Text = "0";
            this.textBoxValue1.Leave += new System.EventHandler(this.textBoxValue1_Leave);
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Enabled = false;
            this.textBoxValue2.Location = new System.Drawing.Point(341, 219);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(100, 22);
            this.textBoxValue2.TabIndex = 6;
            this.textBoxValue2.Text = "0";
            this.textBoxValue2.Visible = false;
            this.textBoxValue2.Leave += new System.EventHandler(this.textBoxValue2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оператор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Значення 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Значення 2:";
            this.label3.Visible = false;
            // 
            // checkBoxFromDate
            // 
            this.checkBoxFromDate.AutoSize = true;
            this.checkBoxFromDate.Enabled = false;
            this.checkBoxFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFromDate.Location = new System.Drawing.Point(24, 53);
            this.checkBoxFromDate.Name = "checkBoxFromDate";
            this.checkBoxFromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxFromDate.Size = new System.Drawing.Size(37, 21);
            this.checkBoxFromDate.TabIndex = 8;
            this.checkBoxFromDate.Text = "з";
            this.checkBoxFromDate.UseVisualStyleBackColor = true;
            this.checkBoxFromDate.CheckedChanged += new System.EventHandler(this.checkBoxFromDate_CheckedChanged);
            // 
            // checkBoxToDate
            // 
            this.checkBoxToDate.AutoSize = true;
            this.checkBoxToDate.Enabled = false;
            this.checkBoxToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxToDate.Location = new System.Drawing.Point(243, 53);
            this.checkBoxToDate.Name = "checkBoxToDate";
            this.checkBoxToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxToDate.Size = new System.Drawing.Size(46, 21);
            this.checkBoxToDate.TabIndex = 9;
            this.checkBoxToDate.Text = "по";
            this.checkBoxToDate.UseVisualStyleBackColor = true;
            this.checkBoxToDate.CheckedChanged += new System.EventHandler(this.checkBoxToDate_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результуючий SQL-запит:";
            // 
            // richTextBoxQueryText
            // 
            this.richTextBoxQueryText.Location = new System.Drawing.Point(31, 276);
            this.richTextBoxQueryText.Name = "richTextBoxQueryText";
            this.richTextBoxQueryText.ReadOnly = true;
            this.richTextBoxQueryText.Size = new System.Drawing.Size(434, 70);
            this.richTextBoxQueryText.TabIndex = 11;
            this.richTextBoxQueryText.Text = "SELECT * FROM [Money]";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(143, 363);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(103, 30);
            this.buttonAccept.TabIndex = 12;
            this.buttonAccept.Text = "Прийняти";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(252, 364);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 30);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // QueryManager
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(509, 423);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.richTextBoxQueryText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxToDate);
            this.Controls.Add(this.checkBoxFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValue2);
            this.Controls.Add(this.textBoxValue1);
            this.Controls.Add(this.comboBoxOperators);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.dateTimePickerMaxDate);
            this.Controls.Add(this.dateTimePickerMinDate);
            this.Controls.Add(this.checkBoxUsingExpenses);
            this.Controls.Add(this.checkBoxUsingObjectDescrible);
            this.Controls.Add(this.checkBoxUsingDateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(515, 455);
            this.Name = "QueryManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер запитів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxUsingDateTime;
        private System.Windows.Forms.CheckBox checkBoxUsingObjectDescrible;
        private System.Windows.Forms.CheckBox checkBoxUsingExpenses;
        private System.Windows.Forms.DateTimePicker dateTimePickerMinDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaxDate;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.ComboBox comboBoxOperators;
        private System.Windows.Forms.TextBox textBoxValue1;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxFromDate;
        private System.Windows.Forms.CheckBox checkBoxToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxQueryText;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}