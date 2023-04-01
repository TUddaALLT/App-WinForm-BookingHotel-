﻿namespace BookingAppWinForm
{
    partial class BookingRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            checkin = new DateTimePicker();
            checkout = new DateTimePicker();
            booking = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 134);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Check In:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 215);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Check Out: ";
            // 
            // checkin
            // 
            checkin.Location = new Point(325, 134);
            checkin.Name = "checkin";
            checkin.Size = new Size(250, 27);
            checkin.TabIndex = 2;
            checkin.ValueChanged += checkin_ValueChanged;
            // 
            // checkout
            // 
            checkout.Location = new Point(325, 208);
            checkout.Name = "checkout";
            checkout.Size = new Size(250, 27);
            checkout.TabIndex = 3;
            checkout.ValueChanged += checkout_ValueChanged;
            // 
            // booking
            // 
            booking.Location = new Point(325, 287);
            booking.Name = "booking";
            booking.Size = new Size(250, 29);
            booking.TabIndex = 4;
            booking.TabStop = false;
            booking.Text = "Booking";
            booking.UseVisualStyleBackColor = true;
            booking.Click += booking_Click;
            // 
            // BookingRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(booking);
            Controls.Add(checkout);
            Controls.Add(checkin);
            Controls.Add(label2);
            Controls.Add(label1);
            HelpButton = true;
            Name = "BookingRoom";
            Text = "BookingRoom";
            Load += BookingRoom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker checkin;
        private DateTimePicker checkout;
        private Button booking;
    }
}