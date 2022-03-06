using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_userName.Text == "admin" && textBox_password.Text == "admin")
            {
                MainForm main = new MainForm();
                this.Hide();

                main.Show();
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort exestieren nicht", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
            }
        }
    }
}
