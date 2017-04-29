using System;
using System.Windows.Forms;

namespace MoneyControl
{
    public partial class ChangePasswordWindow : Form
    {
        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (Options.password == null)
            {
                if (String.IsNullOrWhiteSpace(textBoxNewPassword.Text) || String.IsNullOrWhiteSpace(textBoxRepeatNewPassword.Text))
                {
                    MessageBox.Show("Усі поля повинні бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(textBoxNewPassword.Text) || String.IsNullOrWhiteSpace(textBoxRepeatNewPassword.Text) ||
                    String.IsNullOrWhiteSpace(textBoxOldPassword.Text))
                {
                    MessageBox.Show("Усі поля повинні бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (textBoxNewPassword.Text == textBoxOldPassword.Text)
                {
                    MessageBox.Show("Новий і старий паролі не повинні збігатися!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if ((Options.password != null && textBoxOldPassword.Text == Options.password &&
                textBoxNewPassword.Text == textBoxRepeatNewPassword.Text) ||
                Options.password == null && textBoxNewPassword.Text == textBoxRepeatNewPassword.Text)
            {
                Options.password = textBoxNewPassword.Text;
                MessageBox.Show("Пароль змінено!", "Зміна паролю", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Options.SaveOptions();

                this.Close();
            }
            else
            {
                if (textBoxNewPassword.Text != textBoxRepeatNewPassword.Text)
                {
                    MessageBox.Show("Невідповідність паролів! Уважно перевірте поля з введенням нового паролю!",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxRepeatNewPassword.Clear();
                }
                else if (Options.password != null && Options.password != textBoxOldPassword.Text)
                {
                    MessageBox.Show("Невірний старий пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxOldPassword.Clear();
                }
            }
        }

        private void ChangePasswordWindow_Load(object sender, EventArgs e)
        {
            if (Options.password == null)
            {
                this.label3.Visible = false;
                this.textBoxOldPassword.Visible = false;
                this.buttonShowOldPasswordText.Visible = false;
            }
        }

        private void buttonShowNewPasswordText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBoxNewPassword.PasswordChar = '\0';
        }

        private void buttonShowNewPasswordText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBoxNewPassword.PasswordChar = '•';
        }

        private void buttonShowNewPasswordRepeatText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBoxRepeatNewPassword.PasswordChar = '\0';
        }

        private void buttonShowNewPasswordRepeatText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBoxRepeatNewPassword.PasswordChar = '•';
        }

        private void buttonShowOldPasswordText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBoxOldPassword.PasswordChar = '\0';
        }

        private void buttonShowOldPasswordText_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBoxOldPassword.PasswordChar = '•';
        }
    }
}
