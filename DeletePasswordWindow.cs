using System;
using System.Windows.Forms;

namespace MoneyControl
{
    public partial class DeletePasswordWindow : Form
    {
        public DeletePasswordWindow()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxOldPassword.Text))
            {
                MessageBox.Show("Поле повинне бути заповненим!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxOldPassword.Text == Options.password)
            {
                MessageBox.Show("Пароль видалено!", "Видалення паролю", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Options.password = null;
                Options.SaveOptions();

                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний старий пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOldPassword.Clear();
            }

        }

        private void DeletePasswordWindow_Load(object sender, EventArgs e)
        {
            if (Options.password == null)
            {
                MessageBox.Show("Пароль не встановлено!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void buttonShowOldPasswordText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBoxOldPassword.PasswordChar = '\0';
            }
        }

        private void buttonShowOldPasswordText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBoxOldPassword.PasswordChar = '•';
            }
        }
    }
}
