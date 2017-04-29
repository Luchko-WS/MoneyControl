using System;
using System.Windows.Forms;

namespace MoneyControl
{
    public partial class ShowQueryResult : Form
    {
        public ShowQueryResult()
        {
            InitializeComponent();
        }

        private void ShowQueryResult_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Збереження...";

            try
            {
                MoneyData.Save(dataGridView);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                toolStripStatusLabel.Text = "Дані не збережено!";
            }
            toolStripStatusLabel.Text = "Дані успішно збережено!";

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                sum += Convert.ToDouble(item.Cells[2].Value);
            }
            MessageBox.Show(sum.ToString(), "Залишок", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
