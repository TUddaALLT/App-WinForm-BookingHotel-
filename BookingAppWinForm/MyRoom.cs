using BookingAppWinForm.Models;
using BookingAppWinForm.Repository.RepReservation;
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
    public partial class MyRoom : Form
    {
        int Id { get; set; }
        string Username { get; set; }
        public MyRoom(int id, string username)
        {
            Id = id;
            Username = username;
            InitializeComponent();
        }

        private void MyRoom_Load(object sender, EventArgs e)
        {
            var context = new ReservationRepository();
            Render(context.GetMyReservation(Id.ToString()));
        }
        public void Render(List<Reservation> reservations)
        {

            if (reservations.Count == 0)
            {
                Label labelName = new Label();
                labelName.Location = new Point(460, 103);
                labelName.Text = "No room ";
                Controls.Add(labelName);
            }
            var context = new RoomRepository();
            for (int i = 0; i < reservations.Count; i++)
            {
                Room room = context.GetRoomById(reservations[i].IdRoom);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(69, 103 + i * 500);
                pictureBox.Size = new Size(361, 363);
                pictureBox.Image = Image.FromFile("C:\\Users\\84352\\source\\repos\\BookingAppWinForm\\BookingAppWinForm\\Images\\" + room.Image);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


                Label txtName = new Label();
                txtName.Text = reservations[i].CheckIn.ToString();
                txtName.Location = new Point(535, 103 + i * 500);
                txtName.Size = new Size(259, 27);
                Label labelName = new Label();
                labelName.Text = "Check In: ";
                labelName.Location = new Point(460, 103 + i * 500);

                Label txtPrice = new Label();
                txtPrice.Text = reservations[i].CheckOut + "";
                txtPrice.Location = new Point(535, 159 + i * 500);
                txtPrice.Size = new Size(259, 27);
                Label labelPrice = new Label();
                labelPrice.Text = "Check Out: ";
                labelPrice.Location = new Point(460, 159 + i * 500);


                Label txtSize = new Label();
                txtSize.Text = reservations[i].TotalPrice + "";
                txtSize.Location = new Point(535, 213 + i * 500);
                txtSize.Size = new Size(259, 27);
                Label labelSize = new Label();
                labelSize.Text = "Total Price: ";
                labelSize.Location = new Point(460, 213 + i * 500);

                Button buttonCancelBooking = new Button();
                buttonCancelBooking.Location = new Point(460, 300 + i * 500);
                buttonCancelBooking.Size = new Size(163, 29);
                buttonCancelBooking.Text = "Cancel";
                buttonCancelBooking.Tag = reservations[i];
                buttonCancelBooking.Click += new EventHandler(buttonCancelBooking_Click); ;
                Controls.Add(buttonCancelBooking);
                Controls.Add(pictureBox);
                Controls.Add(txtName);
                Controls.Add(txtPrice);
                Controls.Add(txtSize);
                Controls.Add(labelName);
                Controls.Add(labelSize);
                Controls.Add(labelPrice);
            }

        }
        private void buttonCancelBooking_Click(object? sender, EventArgs e)
        {
            Reservation value = (Reservation)((Button)sender).Tag;
            var context = new ReservationRepository();
            context.CancelReservation(value.Id);

            MyRoom m = new MyRoom(Id, Username);
            // Hide Form1 and show Admin
            this.Hide();
            m.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRoom m = new FrmRoom(Id, Username);
            // Hide Form1 and show Admin
            this.Hide();
            m.Show();
        }
    }
}
