namespace BookingAppWinForm
{
    partial class Register
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
            txtUsername = new TextBox();
            txtPass = new TextBox();
            txtRePass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(303, 109);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(282, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(303, 182);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(282, 27);
            txtPass.TabIndex = 1;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(303, 243);
            txtRePass.Name = "txtRePass";
            txtRePass.PasswordChar = '*';
            txtRePass.Size = new Size(282, 27);
            txtRePass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 109);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 182);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 243);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Re-password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(303, 343);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(282, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 294);
            label4.Name = "label4";
            label4.Size = new Size(205, 20);
            label4.TabIndex = 7;
            label4.Text = "If you do not have an account";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(496, 294);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRePass);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPass;
        private TextBox txtRePass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegister;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}