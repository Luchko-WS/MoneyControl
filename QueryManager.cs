using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyControl
{
    public partial class QueryManager : Form
    {
        public QueryManager()
        {
            InitializeComponent();
        }

        private void checkBoxUsingDateTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUsingDateTime.Checked)
            {
                checkBoxFromDate.Checked = true;
                checkBoxToDate.Checked = true;

                checkBoxFromDate.Enabled = true;
                checkBoxToDate.Enabled = true;

                dateTimePickerMinDate.Enabled = true;
                dateTimePickerMaxDate.Enabled = true;
            }
            else
            {
                checkBoxFromDate.Checked = false;
                checkBoxToDate.Checked = false;

                checkBoxFromDate.Enabled = false;
                checkBoxToDate.Enabled = false;

                dateTimePickerMinDate.Enabled = false;
                dateTimePickerMaxDate.Enabled = false;

            }

            formatSQLQuery();
        }

        private void checkBoxUsingObjectDescrible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUsingObjectDescrible.Checked)
                textBoxToken.Enabled = true;
            else
                textBoxToken.Enabled = false;

            formatSQLQuery();
        }

        private void checkBoxUsingExpenses_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUsingExpenses.Checked)
            {
                comboBoxOperators.Enabled = true;
                textBoxValue1.Enabled = true;
                textBoxValue2.Enabled = true;
            }
            else
            {
                comboBoxOperators.Enabled = false;
                textBoxValue1.Enabled = false;
                textBoxValue2.Enabled = false;
            }

            formatSQLQuery();
        }

        private void checkBoxFromDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFromDate.Checked)
                dateTimePickerMinDate.Enabled = true;
            else
                dateTimePickerMinDate.Enabled = false;

            formatSQLQuery();
        }

        private void checkBoxToDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxToDate.Checked)
                dateTimePickerMaxDate.Enabled = true;
            else
                dateTimePickerMaxDate.Enabled = false;

            formatSQLQuery();
        }

        private void comboBoxOperators_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxOperators.Text == "BETWEEN" || comboBoxOperators.Text == "NOT BETWEEN")
            {
                label3.Visible = true;
                textBoxValue2.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBoxValue2.Visible = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatSQLQuery()
        {
            string dateCondition = "", textCondition = "", expensesCondition = "";

            if (checkBoxFromDate.Checked)
            {
                dateCondition = "[Дата і час] >= #" + dateTimePickerMinDate.Value.Month + "/" + dateTimePickerMinDate.Value.Day +
                    "/" + dateTimePickerMinDate.Value.Year + "#";
            }

            if (checkBoxToDate.Checked)
            {
                if (checkBoxFromDate.Checked)
                    dateCondition += " AND ";

                dateCondition += "[Дата і час] <= #" + dateTimePickerMaxDate.Value.AddDays(1).Month + "/" + dateTimePickerMaxDate.Value.AddDays(1).Day +
                    "/" + dateTimePickerMaxDate.Value.AddDays(1).Year + "#";
            }

            if (checkBoxUsingObjectDescrible.Checked)
            {
                if (!String.IsNullOrWhiteSpace(textBoxToken.Text))
                    textCondition = "[Об\'єкт(и)] LIKE '%" + textBoxToken.Text + "%'";
            }

            if (checkBoxUsingExpenses.Checked)
            {
                if (comboBoxOperators.Text != ">" && comboBoxOperators.Text != ">=" &&
                    comboBoxOperators.Text != "<" && comboBoxOperators.Text != "<=" &&
                    comboBoxOperators.Text != "=" && comboBoxOperators.Text != "<>" &&
                    comboBoxOperators.Text != "BETWEEN" && comboBoxOperators.Text != "NOT BETWEEN")
                {
                    MessageBox.Show("Error");
                    return;
                }

                try
                {
                    if (textBoxValue2.Visible == false)
                        expensesCondition = "[Потрачено] " + comboBoxOperators.Text + " " + Convert.ToDouble(textBoxValue1.Text);
                    else
                        expensesCondition = "[Потрачено] " + comboBoxOperators.Text + " " +
                            Convert.ToDouble(textBoxValue1.Text) + " AND " + Convert.ToDouble(textBoxValue2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }

            richTextBoxQueryText.Text = @"SELECT * FROM [Money]";

            if (dateCondition != "" || textCondition != "" || expensesCondition != "") richTextBoxQueryText.Text += " WHERE";

            if (dateCondition != "") richTextBoxQueryText.Text += " " + dateCondition;

            if (textCondition != "")
            {
                if (dateCondition != "") richTextBoxQueryText.Text += " AND";
                richTextBoxQueryText.Text += " " + textCondition;
            }

            if (expensesCondition != "")
            {
                if (dateCondition != "" && textCondition == "") richTextBoxQueryText.Text += " AND";
                if (textCondition != "") richTextBoxQueryText.Text += " AND";
                richTextBoxQueryText.Text += " " + expensesCondition;
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            formatSQLQuery();
            Query.queryText = richTextBoxQueryText.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dateTimePickerMinDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerMaxDate.MinDate = dateTimePickerMinDate.Value;
            formatSQLQuery();
        }

        private void dateTimePickerMaxDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerMinDate.MaxDate = dateTimePickerMaxDate.Value;
            formatSQLQuery();
        }

        private void comboBoxOperators_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatSQLQuery();
        }

        private void textBoxValue1_TextChanged(object sender, EventArgs e)
        {
            formatSQLQuery();
        }

        private void textBoxValue2_TextChanged(object sender, EventArgs e)
        {
            formatSQLQuery();
        }

        private void textBoxToken_TextChanged(object sender, EventArgs e)
        {
            formatSQLQuery();
        }

        private void textBoxValue1_Leave(object sender, EventArgs e)
        {
            formatSQLQuery();
        }

        private void textBoxValue2_Leave(object sender, EventArgs e)
        {
            formatSQLQuery();
        }

        private void comboBoxOperators_Leave(object sender, EventArgs e)
        {
            formatSQLQuery();
        }
    }
}
