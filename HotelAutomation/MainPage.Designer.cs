namespace hotel
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnNewUser_Reservation = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAboutUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnAdminLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdminLogin.Location = new System.Drawing.Point(63, 81);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(242, 89);
            this.btnAdminLogin.TabIndex = 13;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnNewUser_Reservation
            // 
            this.btnNewUser_Reservation.BackColor = System.Drawing.Color.Transparent;
            this.btnNewUser_Reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser_Reservation.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnNewUser_Reservation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewUser_Reservation.Location = new System.Drawing.Point(859, 81);
            this.btnNewUser_Reservation.Name = "btnNewUser_Reservation";
            this.btnNewUser_Reservation.Size = new System.Drawing.Size(242, 89);
            this.btnNewUser_Reservation.TabIndex = 14;
            this.btnNewUser_Reservation.Text = "New User / Reservation";
            this.btnNewUser_Reservation.UseVisualStyleBackColor = false;
            this.btnNewUser_Reservation.Click += new System.EventHandler(this.btnNewUser_Reservation_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.Location = new System.Drawing.Point(63, 240);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(242, 89);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Check in / out ";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomers.Location = new System.Drawing.Point(63, 421);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(242, 89);
            this.btnCustomers.TabIndex = 17;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnAboutUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAboutUs.Location = new System.Drawing.Point(859, 421);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(242, 89);
            this.btnAboutUs.TabIndex = 19;
            this.btnAboutUs.Text = "About us";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 633);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnNewUser_Reservation);
            this.Controls.Add(this.btnAdminLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnNewUser_Reservation;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAboutUs;
    }
}