namespace BookingAppWinForm
{
    partial class UpdateRoom
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBed = new TextBox();
            txtCapacity = new TextBox();
            txtSize = new TextBox();
            txtServices = new TextBox();
            txtName = new TextBox();
            txtDescribe = new TextBox();
            txtPrice = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(174, 413);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 33;
            label7.Text = "Services";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 351);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 32;
            label6.Text = "Bed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 290);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 31;
            label5.Text = "Capatity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 227);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 30;
            label4.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 167);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 29;
            label3.Text = "Describe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 106);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 28;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 27;
            label1.Text = "Name";
            // 
            // txtBed
            // 
            txtBed.Location = new Point(308, 344);
            txtBed.Name = "txtBed";
            txtBed.Size = new Size(279, 27);
            txtBed.TabIndex = 26;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(308, 283);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(279, 27);
            txtCapacity.TabIndex = 25;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(308, 220);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(279, 27);
            txtSize.TabIndex = 24;
            // 
            // txtServices
            // 
            txtServices.Location = new Point(308, 406);
            txtServices.Name = "txtServices";
            txtServices.Size = new Size(279, 27);
            txtServices.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Location = new Point(308, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 27);
            txtName.TabIndex = 22;
            // 
            // txtDescribe
            // 
            txtDescribe.Location = new Point(308, 160);
            txtDescribe.Name = "txtDescribe";
            txtDescribe.Size = new Size(279, 27);
            txtDescribe.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(308, 99);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(279, 27);
            txtPrice.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(174, 478);
            button1.Name = "button1";
            button1.Size = new Size(413, 29);
            button1.TabIndex = 34;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 545);
            Controls.Add(button1);
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
            Name = "UpdateRoom";
            Text = "UpdateRoom";
            Load += UpdateRoom_Load;
            Closing += UpdateRoom_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBed;
        private TextBox txtCapacity;
        private TextBox txtSize;
        private TextBox txtServices;
        private TextBox txtName;
        private TextBox txtDescribe;
        private TextBox txtPrice;
        private Button button1;
    }
}