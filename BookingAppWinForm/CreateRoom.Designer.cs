namespace BookingAppWinForm
{
    partial class CreateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoom));
            btnImage = new Button();
            pictureUpload = new PictureBox();
            btnCreateRoom = new Button();
            txtPrice = new TextBox();
            txtDescribe = new TextBox();
            txtName = new TextBox();
            txtServices = new TextBox();
            txtSize = new TextBox();
            txtCapacity = new TextBox();
            txtBed = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureUpload).BeginInit();
            SuspendLayout();
            // 
            // btnImage
            // 
            btnImage.BackColor = SystemColors.ActiveBorder;
            btnImage.BackgroundImageLayout = ImageLayout.Stretch;
            btnImage.FlatStyle = FlatStyle.Popup;
            btnImage.Location = new Point(34, 293);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(264, 29);
            btnImage.TabIndex = 4;
            btnImage.Text = "Upload Image";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // pictureUpload
            // 
            pictureUpload.Image = (Image)resources.GetObject("pictureUpload.Image");
            pictureUpload.InitialImage = null;
            pictureUpload.Location = new Point(34, 32);
            pictureUpload.Name = "pictureUpload";
            pictureUpload.Size = new Size(264, 190);
            pictureUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUpload.TabIndex = 3;
            pictureUpload.TabStop = false;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.BackColor = SystemColors.ActiveBorder;
            btnCreateRoom.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreateRoom.FlatStyle = FlatStyle.Popup;
            btnCreateRoom.ImageAlign = ContentAlignment.TopLeft;
            btnCreateRoom.Location = new Point(34, 396);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(264, 29);
            btnCreateRoom.TabIndex = 5;
            btnCreateRoom.Text = "Create Room";
            btnCreateRoom.UseVisualStyleBackColor = false;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(478, 91);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(279, 27);
            txtPrice.TabIndex = 6;
            // 
            // txtDescribe
            // 
            txtDescribe.Location = new Point(478, 152);
            txtDescribe.Name = "txtDescribe";
            txtDescribe.Size = new Size(279, 27);
            txtDescribe.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(478, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 27);
            txtName.TabIndex = 8;
            // 
            // txtServices
            // 
            txtServices.Location = new Point(478, 398);
            txtServices.Name = "txtServices";
            txtServices.Size = new Size(279, 27);
            txtServices.TabIndex = 9;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(478, 212);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(279, 27);
            txtSize.TabIndex = 10;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(478, 275);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(279, 27);
            txtCapacity.TabIndex = 11;
            // 
            // txtBed
            // 
            txtBed.Location = new Point(478, 336);
            txtBed.Name = "txtBed";
            txtBed.Size = new Size(279, 27);
            txtBed.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 98);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 14;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 159);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 15;
            label3.Text = "Describe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 219);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 16;
            label4.Text = "Size";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 282);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 17;
            label5.Text = "Capatity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 343);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 18;
            label6.Text = "Bed";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 405);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 19;
            label7.Text = "Services";
            // 
            // CreateRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBed);
            Controls.Add(txtCapacity);
            Controls.Add(txtSize);
            Controls.Add(txtServices);
            Controls.Add(txtName);
            Controls.Add(txtDescribe);
            Controls.Add(txtPrice);
            Controls.Add(btnCreateRoom);
            Controls.Add(btnImage);
            Controls.Add(pictureUpload);
            Name = "CreateRoom";
            Text = "CreateRoom";
            Closing += CreateRoom_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureUpload).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImage;
        private PictureBox pictureUpload;
        private Button btnCreateRoom;
        private TextBox txtPrice;
        private TextBox txtDescribe;
        private TextBox txtName;
        private TextBox txtServices;
        private TextBox txtSize;
        private TextBox txtCapacity;
        private TextBox txtBed;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}