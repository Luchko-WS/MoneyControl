using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MoneyControl
{
    public partial class PasswordWindow : Form
    {
        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void PasswordWindow_Load(object sender, EventArgs e)
        {
            if (!File.Exists("config.bin"))
            {
                MessageBox.Show("Відсутній файл config.bin! Роботу програми припинено!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (!File.Exists("DBMC.mdb"))
            {
                MessageBox.Show("Відсутній файл DBMC.mdb! Роботу програми припинено!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                try
                {
                    Options.LoadOptions();
                }
                catch (Exception)
                {
                    Options.password = null;
                    Options.saveMode = 1;
                    Options.allowAddRows = true;
                    Options.allowDeleteRows = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            if (Options.password == "" || Options.password == null)
            {
                Options.password = null;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == Options.password)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Невiрний пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PasswordWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (this.DialogResult != DialogResult.OK)
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOK_Click(sender, e);
        }

        private void buttonShowPasswordText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBoxPassword.PasswordChar = '\0';
        }

        private void buttonShowPasswordText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBoxPassword.PasswordChar = '•';
        }
    }
}
