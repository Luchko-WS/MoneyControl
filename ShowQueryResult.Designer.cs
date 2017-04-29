namespace MoneyControl
{
    partial class ShowQueryResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowQueryResult));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.датаІЧасDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обєктиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.потраченоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxQueryText = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаІЧасDataGridViewTextBoxColumn,
            this.обєктиDataGridViewTextBoxColumn,
            this.потраченоDataGridViewTextBoxColumn});
            this.dataGridView.Location = new System.Drawing.Point(-1, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(685, 375);
            this.dataGridView.TabIndex = 0;
            // 
            // датаІЧасDataGridViewTextBoxColumn
            // 
            this.датаІЧасDataGridViewTextBoxColumn.DataPropertyName = "Дата і час";
            this.датаІЧасDataGridViewTextBoxColumn.HeaderText = "Дата і час";
            this.датаІЧасDataGridViewTextBoxColumn.Name = "датаІЧасDataGridViewTextBoxColumn";
            this.датаІЧасDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // обєктиDataGridViewTextBoxColumn
            // 
            this.обєктиDataGridViewTextBoxColumn.DataPropertyName = "Об\'єкт(и)";
            this.обєктиDataGridViewTextBoxColumn.HeaderText = "Об\'єкт(и)";
            this.обєктиDataGridViewTextBoxColumn.Name = "обєктиDataGridViewTextBoxColumn";
            this.обєктиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // потраченоDataGridViewTextBoxColumn
            // 
            this.потраченоDataGridViewTextBoxColumn.DataPropertyName = "Потрачено";
            this.потраченоDataGridViewTextBoxColumn.HeaderText = "Потрачено";
            this.потраченоDataGridViewTextBoxColumn.Name = "потраченоDataGridViewTextBoxColumn";
            this.потраченоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(380, 406);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 29);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Зберегти як звіт...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxQueryText
            // 
            this.textBoxQueryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQueryText.Location = new System.Drawing.Point(-1, 2);
            this.textBoxQueryText.Name = "textBoxQueryText";
            this.textBoxQueryText.ReadOnly = true;
            this.textBoxQueryText.Size = new System.Drawing.Size(685, 22);
            this.textBoxQueryText.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(61, 20);
            this.toolStripStatusLabel.Text = "Готово!";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.Location = new System.Drawing.Point(535, 406);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(144, 29);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // ShowQueryResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 464);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxQueryText);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowQueryResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запит №1";
            this.Load += new System.EventHandler(this.ShowQueryResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаІЧасDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обєктиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn потраченоDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.TextBox textBoxQueryText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonCalculate;
    }
}