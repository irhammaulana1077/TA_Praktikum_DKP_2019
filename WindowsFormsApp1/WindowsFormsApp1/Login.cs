using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = System.Convert.ToString(label());
        }

        public string label()
        {
            return "Selamat Datang!!! Silakan Login terlebih dahulu. ";
        }

        private void Tombol_Click_1(object sender, EventArgs e)
        {
            userpass Diijinkan = new userpass();
            Diijinkan.setUser("Irham");
            Diijinkan.setPass("1234");
            Diijinkan.setUser1("Budi");
            Diijinkan.setPass1("abcd");

            if (txtUser.Text == Diijinkan.getUser() && txtPassword.Text == Diijinkan.getPass())
            {
                MessageBox.Show("Login Berhasil! Selamat Datang " + Diijinkan.getUser());
                this.Hide();
                Form1 fm = new Form1();
                fm.Show();
            }
            else if (txtUser.Text == Diijinkan.getUser1() && txtPassword.Text == Diijinkan.getPass1())
            {
                MessageBox.Show("Login Berhasil! Selamat Datang " + Diijinkan.getUser1());
                this.Hide();
                Form1 fm = new Form1();
                fm.Show();
            }

            else if (txtUser.Text == "" || txtPassword.Text == "")
            {
                do
                {
                    MessageBox.Show("Mohon masukkan Username dan Password Anda!");
                    return;

                }
                while (txtUser.Text == "" || txtPassword.Text == "");
            }


            else if (txtUser.Text != Diijinkan.getUser() || txtPassword.Text != Diijinkan.getPass())
            {
                do
                {
                    MessageBox.Show("Login Gagal! Username atau Password Salah!");
                    txtUser.Clear();
                    txtPassword.Clear();
                    return;

                }
                while (txtUser.Text != Diijinkan.getUser() || txtPassword.Text != Diijinkan.getPass());
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

    }
}