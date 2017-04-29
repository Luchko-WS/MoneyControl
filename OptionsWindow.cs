using System;
using System.Windows.Forms;

namespace MoneyControl
{
    public partial class OptionsWindow : Form
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            var changePassworWindow = new ChangePasswordWindow();
            changePassworWindow.ShowDialog();

            if (Options.password != null)
                buttonDeletePassword.Enabled = true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (radioButtonAutoSave.Checked)
                Options.saveMode = 1;
            else if (radioButtonAsk.Checked)
                Options.saveMode = 2;
            else if (radioButtonNoSave.Checked)
                Options.saveMode = 3;

            if (checkBoxAllowAddRows.Checked)
                Options.allowAddRows = true;
            else
                Options.allowAddRows = false;

            if (checkBoxAllowDeleteRows.Checked)
                Options.allowDeleteRows = true;
            else
                Options.allowDeleteRows = false;

            Options.SaveOptions();
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            switch (Options.saveMode)
            {
                case 1:
                    radioButtonAutoSave.Checked = true;
                    break;
                case 2:
                    radioButtonAsk.Checked = true;
                    break;
                case 3:
                    radioButtonNoSave.Checked = true;
                    break;
            }

            if (Options.allowAddRows)
                checkBoxAllowAddRows.Checked = true;
            else
                checkBoxAllowAddRows.Checked = false;

            if (Options.allowDeleteRows)
                checkBoxAllowDeleteRows.Checked = true;
            else
                checkBoxAllowDeleteRows.Checked = false;

            if (Options.password == null)
                buttonDeletePassword.Enabled = false;

        }

        private void buttonDeletePassword_Click(object sender, EventArgs e)
        {
            var deletePassworWindow = new DeletePasswordWindow();
            deletePassworWindow.ShowDialog();

            if (Options.password == null)
                buttonDeletePassword.Enabled = false;
        }
    }
}
