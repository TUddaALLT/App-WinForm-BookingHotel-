using BookingAppWinForm.Models;
using BookingAppWinForm.Repository.RepRoom;
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
    public partial class UpdateRoom : Form
    {
        Room roomUp;
        public UpdateRoom(Room room)
        {
            roomUp = room;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Room r = new Room()
            {
                Id = roomUp.Id,
                Name = txtName.Text,
                Bed = txtBed.Text,
                Capacity = txtCapacity.Text,
                Description = txtDescribe.Text,
                Price = int.Parse(txtPrice.Text),
                Size = int.Parse(txtSize.Text),
                Services = txtServices.Text,
                Image = roomUp.Image,
            };
          
            IRoomRepository roomRepository = new RoomRepository();
            roomRepository.UpdateRoom(r);
            MessageBox.Show("Update Successfully");
            this.Hide();
            Admin admin = new Admin();
            admin.Show();

        }

        private void UpdateRoom_Load(object sender, EventArgs e)
        {
            txtBed.Text = roomUp.Bed;
            txtCapacity.Text = roomUp.Capacity;
            txtName.Text = roomUp.Name;
            txtPrice.Text = roomUp.Price + "";
            txtServices.Text = roomUp.Services;
            txtSize.Text = roomUp.Size + "";
            txtDescribe.Text = roomUp.Description;
        }
        private void UpdateRoom_FormClosing(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
