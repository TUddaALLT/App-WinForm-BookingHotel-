using BookingAppWinForm.Models;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();

            // Hide Form1 and show Form2
            this.Hide();
            reg.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            User userLogined = userRepository.Login(new Models.User
            {
                Username = txtLoginU.Text,
                Password = txtLoginPass.Text,
            });
            if (userLogined != null && userLogined.Username == "admin@gmail.com")
            {
                Admin ad = new Admin();
                // Hide Form1 and show Form2
                this.Hide();
                ad.Show();
            }
            else if (userLogined != null)
            {
                FrmRoom room = new FrmRoom(userLogined.Id, userLogined.Username);
                // Hide Form1 and show Form2
                this.Hide();
                room.Show();
            }
        }
    }
}
