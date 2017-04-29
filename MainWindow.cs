using System;
using System.Data;
using System.Windows.Forms;

namespace MoneyControl
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var passwordWindow = new PasswordWindow();
            passwordWindow.ShowDialog();

            if (passwordWindow.DialogResult == DialogResult.Cancel)
                Application.Exit();

            this.dataGridView.AllowUserToAddRows = Options.allowAddRows;
            this.dataGridView.AllowUserToDeleteRows = Options.allowDeleteRows;
            this.moneyTableAdapter.Fill(this.dBMCDataSet.Money);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (Options.saveMode)
            {
                case 1:
                    this.moneyTableAdapter.Update(dBMCDataSet);
                    break;
                case 2:
                    var dialogResult = MessageBox.Show("Зберегти зміни в даних?", "Збереження даних", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            this.moneyTableAdapter.Update(dBMCDataSet);
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            return;
                        case DialogResult.No:
                            break;
                    }
                    break;
                case 3:
                    break;
            }

        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            var options = new OptionsWindow();
            options.ShowDialog();

            this.dataGridView.AllowUserToAddRows = Options.allowAddRows;
            this.dataGridView.AllowUserToDeleteRows = Options.allowDeleteRows;
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.moneyTableAdapter.Update(dBMCDataSet);
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void опціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new OptionsWindow();
            options.ShowDialog();

            this.dataGridView.AllowUserToAddRows = Options.allowAddRows;
            this.dataGridView.AllowUserToDeleteRows = Options.allowDeleteRows;
        }

        private void зберегтиЯкЗвітToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel.Text = "Збереження...";

            try
            {
                MoneyData.Save(this.dataGridView);
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка при збереженні звіту!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.toolStripStatusLabel.Text = "Дані не збережено!";
            }
            this.toolStripStatusLabel.Text = "Дані успішно збережено!";
        }

        private void конструкторЗапитівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryManager = new QueryManager();

            if (queryManager.ShowDialog() == DialogResult.OK)
            {
                var sqlQuery = Query.queryText;

                using (var command = moneyTableAdapter.Connection.CreateCommand())
                {
                    this.moneyTableAdapter.Connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sqlQuery;

                    var showQueryResult = new ShowQueryResult();

                    using (var r = command.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            showQueryResult.dataGridView.Rows.Add(Convert.ToDateTime(r[0]), r[1].ToString(), Convert.ToDecimal(r[2]));
                        }
                    }

                    this.moneyTableAdapter.Connection.Close();
                    showQueryResult.Text = "Запит №" + Options.windowNumber;
                    Options.windowNumber++;
                    showQueryResult.textBoxQueryText.Text = sqlQuery;
                    showQueryResult.Show();
                }
            }
        }

        private void розрахуватиЗалишокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (DataGridViewRow item in this.dataGridView.Rows)
            {
                sum += Convert.ToDouble(item.Cells[2].Value);
            }
            MessageBox.Show(sum.ToString(), "Залишок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void додатиРядокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.moneyTableAdapter.Update(dBMCDataSet);
            this.moneyTableAdapter.Insert(DateTime.Now, "", 0);
            this.moneyTableAdapter.Fill(this.dBMCDataSet.Money);
            this.dataGridView.CurrentCell = dataGridView[0, dataGridView.Rows.Count - 2];
        }

        private void видалитиРядокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView.Rows.RemoveAt(this.dataGridView.CurrentRow.Index);
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.dataGridView.Rows.Count > 1)
            {
                this.dataGridView.Rows.RemoveAt(0);
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.moneyTableAdapter.Update(dBMCDataSet);
                this.moneyTableAdapter.Insert(DateTime.Now, "", 0);
                this.moneyTableAdapter.Fill(this.dBMCDataSet.Money);
                this.dataGridView.CurrentCell = dataGridView[0, dataGridView.Rows.Count - 2];
            }
        }

        private void додатиДоТаблиціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoneyData.Load(this.dataGridView);
        }

        private void відкритиВНовійТаблиціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            очиститиToolStripMenuItem_Click(sender, e);
            MoneyData.Load(this.dataGridView);
        }
    }
}
