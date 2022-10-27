using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Авторизация
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passwordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheck.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "admin" && PasswordTextBox.Text == "1234567890")
            {
                Form Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
            else
            {
                bool isFalseEnter = true;
                foreach (accounts acc in Accounts.getInstance().GetAccounts())
                {
                    if (acc.login == LoginTextBox.Text && acc.password == PasswordTextBox.Text)
                    {
                        Form Form2 = new Form2();
                        Form2.Show();
                        this.Hide();
                        isFalseEnter = false;
                        break;
                    }
                }
                if(isFalseEnter)
                    MessageBox.Show("Неправильно введен логин или пароль!!!!!!!!!!!!!!!!! \n Вас обнаружили...");
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }
    }
}
