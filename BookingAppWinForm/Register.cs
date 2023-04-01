using BookingAppWinForm.Repository.RepUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingAppWinForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;

            if (username != "" && password != "" && txtRePass.Text != "")
            {
                if (username.Length > 8 && password.Length > 8)
                {
                    if (txtRePass.Text == password)
                    {
                        // register
                        IUserRepository userRepository = new UserRepository();
                        userRepository.Register(new Models.User
                        {
                            Username = username,
                            Password = password,
                            Role = "USER",
                        });

                        Login login = new Login();
                        // Hide Form1 and show Form2
                        this.Hide();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Re-Password must match Password");
                    }
                }
                else
                {
                    MessageBox.Show("All fill must >8 character");
                }

            }
            else
            {
                MessageBox.Show("Must fill in all");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();

            // Hide Form1 and show Form2
            this.Hide();
            login.Show();
        }
    }
}
