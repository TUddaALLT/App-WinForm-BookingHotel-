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
    public partial class BookingRoom : Form
    {
        Reservation Reservation { get; set; }
        public BookingRoom(Reservation reservation)
        {
            Reservation = reservation;
            InitializeComponent();
        }

        private void BookingRoom_Load(object sender, EventArgs e)
        {

            checkin.Format = DateTimePickerFormat.Custom;
            checkin.CustomFormat = "dd/MM/yyyy";
            checkin.MinDate = DateTime.Now;
            checkout.Format = DateTimePickerFormat.Custom;
            checkout.CustomFormat = "dd/MM/yyyy";
            checkout.MinDate = checkin.Value;
        }

        private void checkin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkout_ValueChanged(object sender, EventArgs e)
        {

        }

        private void booking_Click(object sender, EventArgs e)
        {

            Reservation.CheckIn = new DateTime(checkin.Value.Year, checkin.Value.Month, checkin.Value.Day);
            Reservation.CheckOut = new DateTime(checkout.Value.Year, checkout.Value.Month, checkout.Value.Day);
            IReservationRepository Repository = new ReservationRepository();

            if (Reservation.CheckIn == Reservation.CheckOut)
            {
                MessageBox.Show("Checkin, Checkout is invalid");
            }
            else
            {
                try
                {

                    Reservation x = Repository.CreateReservation(Reservation);
                    if (x != null)
                    {
                        MessageBox.Show("Booking Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Room is booking");
                    }
                }
                catch
                {
                    MessageBox.Show("You have booked recently");
                }


            }

        }
    }
}
