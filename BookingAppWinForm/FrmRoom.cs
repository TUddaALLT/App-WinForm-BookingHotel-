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
    public partial class FrmRoom : Form
    {
        int Id { get; set; }
        string Username { get; set; }
        public FrmRoom(int id, string username)
        {
            Id = id;
            Username = username;
            InitializeComponent();
        }
        private static IRoomRepository roomRepository = new RoomRepository();
        List<Room> room = roomRepository.GetAllRoom().ToList();
        private void FrmRoom_Load(object sender, EventArgs e)
        {
            Button myrRoom = new Button();
            myrRoom.Location = new Point(338, 20);
            myrRoom.Size = new Size(100, 29);
            myrRoom.Text = "MyRoom";
            myrRoom.Click += new EventHandler(myrRoom_Click);
            Controls.Add(myrRoom);
            Render(room);
        }
        public void Render(List<Room> room)
        {
            //this.Controls.Clear();
            Button buttonSortDes = new Button();
            buttonSortDes.Location = new Point(65, 20);
            buttonSortDes.Size = new Size(100, 29);
            buttonSortDes.Text = "Descease";
            buttonSortDes.Click += new EventHandler(buttonSortDes_Click);
            Controls.Add(buttonSortDes);

            Button buttonSortInc = new Button();
            buttonSortInc.Location = new Point(65 + 120, 20);
            buttonSortInc.Size = new Size(100, 29);
            buttonSortInc.Text = "Increase";
            buttonSortInc.Click += new EventHandler(buttonSortInc_Click);

            Controls.Add(buttonSortInc);
            if (room.Count == 0)
            {
                Label labelName = new Label();
                labelName.Location = new Point(460, 103);
                labelName.Text = "No room ";
                Controls.Add(labelName);
            }
            for (int i = 0; i < room.Count; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(69, 103 + i * 500);
                pictureBox.Size = new Size(361, 363);
                pictureBox.Image = Image.FromFile("C:\\Users\\84352\\source\\repos\\BookingAppWinForm\\BookingAppWinForm\\Images\\" + room[i].Image);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


                Label txtName = new Label();
                txtName.Text = room[i].Name;
                txtName.Location = new Point(535, 103 + i * 500);
                txtName.Size = new Size(259, 27);
                Label labelName = new Label();
                labelName.Text = "Name: ";
                labelName.Location = new Point(460, 103 + i * 500);

                //Label txtCheckIn = new Label();
                //txtCheckIn.Text = "Check In: ";
                //txtCheckIn.Location = new Point(700, 100 + i * 500);

                //Label txtCheckOut = new Label();
                //txtCheckOut.Text = "Check Out: ";
                //txtCheckOut.Location = new Point(700, 200 + i * 500);

                //DateTimePicker checkIn = new DateTimePicker();
                //checkIn.Location = new Point(800, 100 + i * 500);
                //checkIn.Size = new Size(250, 27);
                //checkIn.MinDate = DateTime.Now;
                //DateTimePicker checkOut = new DateTimePicker();
                //checkOut.Location = new Point(800, 200 + i * 500);
                //checkOut.Size = new Size(250, 27);
                //checkOut.MinDate = DateTime.Now;
                //Controls.Add(checkOut);
                //Controls.Add(checkIn);
                //Controls.Add(txtCheckIn);
                //Controls.Add(txtCheckOut);






                Label txtPrice = new Label();
                txtPrice.Text = room[i].Price + "";
                txtPrice.Location = new Point(535, 159 + i * 500);
                txtPrice.Size = new Size(259, 27);
                Label labelPrice = new Label();
                labelPrice.Text = "Price: ";
                labelPrice.Location = new Point(460, 159 + i * 500);


                Label txtSize = new Label();
                txtSize.Text = room[i].Size + "";
                txtSize.Location = new Point(535, 213 + i * 500);
                txtSize.Size = new Size(259, 27);
                Label labelSize = new Label();
                labelSize.Text = "Size: ";
                labelSize.Location = new Point(460, 213 + i * 500);


                Label txtDes = new Label();
                txtDes.Text = room[i].Description;
                txtDes.Location = new Point(535, 273 + i * 500);
                txtDes.Size = new Size(259, 27);
                Label labelDes = new Label();
                labelDes.Text = "Describe: ";
                labelDes.Location = new Point(460, 273 + i * 500);



                Label txtSer = new Label();
                txtSer.Text = room[i].Services;
                txtSer.Location = new Point(535, 331 + i * 500);
                txtSer.Size = new Size(259, 27);
                Label labelSer = new Label();
                labelSer.Text = "Services: ";
                labelSer.Location = new Point(460, 331 + i * 500);


                Label txtBed = new Label();
                txtBed.Text = room[i].Bed;
                txtBed.Location = new Point(535, 387 + i * 500);
                txtBed.Size = new Size(259, 27);
                Label labelBed = new Label();
                labelBed.Text = "Bed: ";
                labelBed.Location = new Point(460, 387 + i * 500);



                Label txtCap = new Label();
                txtCap.Text = room[i].Capacity;
                txtCap.Location = new Point(535, 436 + i * 500);
                txtCap.Size = new Size(259, 27);
                Label labelCap = new Label();
                labelCap.Text = "Capacity: ";
                labelCap.Location = new Point(460, 436 + i * 500);




                //Button buttonUpdate = new Button();
                //buttonUpdate.Location = new Point(69, 508 + i * 500);
                //buttonUpdate.Size = new Size(163, 29);
                //buttonUpdate.Text = "Update";
                //buttonUpdate.Click += new EventHandler(buttonUpdate_Click);
                //buttonUpdate.Tag = room[i].Id;

                //Button buttonDelete = new Button();
                //buttonDelete.Location = new Point(267, 508 + i * 500);
                //buttonDelete.Size = new Size(163, 29);
                //buttonDelete.Text = "Delete";
                //buttonDelete.Click += new EventHandler(buttonDelete_Click);
                //buttonDelete.Tag = room[i].Id;

                Button buttonBooking = new Button();
                buttonBooking.Location = new Point(69, 508 + i * 500);
                buttonBooking.Size = new Size(163, 29);
                buttonBooking.Text = "Booking Room";
                buttonBooking.Click += new EventHandler(buttonBooking_Click);
                buttonBooking.Tag = new Reservation()
                {
                    IdUser = Id,
                    IdRoom = room[i].Id,
                };
                Controls.Add(buttonBooking);

                Controls.Add(pictureBox);
                //Controls.Add(buttonUpdate);
                //Controls.Add(buttonDelete);
                Controls.Add(txtName);
                Controls.Add(txtCap);
                Controls.Add(txtSer);
                Controls.Add(txtDes);
                Controls.Add(txtPrice);
                Controls.Add(txtSize);
                Controls.Add(txtBed);
                Controls.Add(labelName);
                Controls.Add(labelDes);
                Controls.Add(labelSize);
                Controls.Add(labelPrice);
                Controls.Add(labelCap);
                Controls.Add(labelBed);
                Controls.Add(labelSer);
            }

        }


        private void buttonBooking_Click(object? sender, EventArgs e)
        {
            Reservation value = (Reservation)((Button)sender).Tag;
            BookingRoom createRoom = new BookingRoom(value);
            createRoom.Show();
        }


        private void buttonSortDes_Click(object? sender, EventArgs e)
        {

            room = roomRepository.GetAllRoom().OrderByDescending(product => product.Price).ToList();
            Render(room);
        }

        private void myrRoom_Click(object? sender, EventArgs e)
        {

            MyRoom m = new MyRoom(Id, Username);
            // Hide Form1 and show Admin
            this.Hide();
            m.Show();

        }
        private void buttonSortInc_Click(object? sender, EventArgs e)
        {

            room = roomRepository.GetAllRoom().OrderBy(product => product.Price).ToList();
            Render(room);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("hehe");
        }
    }

}
