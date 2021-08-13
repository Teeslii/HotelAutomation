namespace hotel
{
    partial class NewUserBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserBooking));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblTelephone = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnhomeback = new System.Windows.Forms.Button();
            this.roomControlBooking = new hotel.roomControl();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.lblFirstName.Location = new System.Drawing.Point(25, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 22);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FirstName:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.Transparent;
            this.LblID.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblID.Location = new System.Drawing.Point(25, 211);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(36, 22);
            this.LblID.TabIndex = 3;
            this.LblID.Text = "ID:";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.BackColor = System.Drawing.Color.Transparent;
            this.LblMail.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblMail.Location = new System.Drawing.Point(25, 168);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(55, 22);
            this.LblMail.TabIndex = 4;
            this.LblMail.Text = "Mail:";
            // 
            // LblTelephone
            // 
            this.LblTelephone.AutoSize = true;
            this.LblTelephone.BackColor = System.Drawing.Color.Transparent;
            this.LblTelephone.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblTelephone.Location = new System.Drawing.Point(25, 125);
            this.LblTelephone.Name = "LblTelephone";
            this.LblTelephone.Size = new System.Drawing.Size(112, 22);
            this.LblTelephone.TabIndex = 5;
            this.LblTelephone.Text = "Telephone:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(153, 19);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(221, 30);
            this.txtFirstName.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(235, 506);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 56);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtTelephone.ForeColor = System.Drawing.Color.Black;
            this.txtTelephone.Location = new System.Drawing.Point(153, 114);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(221, 30);
            this.txtTelephone.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtMail.ForeColor = System.Drawing.Color.Black;
            this.txtMail.Location = new System.Drawing.Point(153, 157);
            this.txtMail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(221, 30);
            this.txtMail.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(153, 200);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(221, 30);
            this.txtID.TabIndex = 18;
            // 
            // btnhomeback
            // 
            this.btnhomeback.BackColor = System.Drawing.Color.Transparent;
            this.btnhomeback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhomeback.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnhomeback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhomeback.Location = new System.Drawing.Point(1060, 580);
            this.btnhomeback.Name = "btnhomeback";
            this.btnhomeback.Size = new System.Drawing.Size(132, 52);
            this.btnhomeback.TabIndex = 30;
            this.btnhomeback.Text = "Home Back";
            this.btnhomeback.UseVisualStyleBackColor = false;
            this.btnhomeback.Click += new System.EventHandler(this.btnhomeback_Click);
            // 
            // roomControlBooking
            // 
            this.roomControlBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomControlBooking.BackgroundImage")));
            this.roomControlBooking.Location = new System.Drawing.Point(501, 12);
            this.roomControlBooking.Name = "roomControlBooking";
            this.roomControlBooking.RoomNo = 0;
            this.roomControlBooking.Size = new System.Drawing.Size(580, 514);
            this.roomControlBooking.TabIndex = 31;
            // 
            // NewUserBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 633);
            this.Controls.Add(this.roomControlBooking);
            this.Controls.Add(this.btnhomeback);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.LblTelephone);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.lblFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Booking";
            this.Load += new System.EventHandler(this.newUserBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtID;
        
        private System.Windows.Forms.Button btnhomeback;
        private roomControl roomControlBooking;
    }
}