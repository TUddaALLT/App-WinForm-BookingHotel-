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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }
        Boolean isImageCaptuerd = false;
        string uniqueFileName = "";
        string fileName = "";
        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                isImageCaptuerd = false;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    isImageCaptuerd = true;
                    fileName = openFileDialog.FileName;
                    uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);

                    // Display the image in the PictureBox control
                    pictureUpload.Image = Image.FromFile(openFileDialog.FileName);

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
          int price = 0; int size = 0;
            try
            {
                price = Convert.ToInt32(txtPrice.Text);
                size = Convert.ToInt32(txtSize.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Price and size must be number");
            }
            if (txtBed.Text == ""
                || txtCapacity.Text == ""
                || txtDescribe.Text == ""
                || txtName.Text == ""
                || txtServices.Text == ""
                || txtBed.Text == ""
                )
            {
                MessageBox.Show("Must fill all");
            }
            else
            {
                IRoomRepository roomRepository = new RoomRepository();
                roomRepository.Create(new Models.Room
                {
                    Name = txtName.Text,
                    Bed = txtBed.Text,
                    Capacity = txtCapacity.Text,
                    Description = txtDescribe.Text,
                    Services = txtServices.Text,
                    Price = price,
                    Size = size,
                    Image = uniqueFileName
                });
                string folderPath = "C:\\Users\\84352\\source\\repos\\BookingAppWinForm\\BookingAppWinForm\\Images";
                // Change this to the folder where you want to save the images
                string fullPath = Path.Combine(folderPath, uniqueFileName);

                File.Copy(fileName, fullPath);
            }

            this.Hide();
            Admin admin = new Admin();
            admin.Show();

        }



        private void CreateRoom_FormClosing(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
