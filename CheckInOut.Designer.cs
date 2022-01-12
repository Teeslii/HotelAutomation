namespace hotel
{
    partial class CheckInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInOut));
            this.btnhomeback = new System.Windows.Forms.Button();
            this.roomControlCheck = new hotel.roomControl();
            this.SuspendLayout();
            // 
            // btnhomeback
            // 
            this.btnhomeback.BackColor = System.Drawing.Color.Transparent;
            this.btnhomeback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhomeback.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnhomeback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhomeback.Location = new System.Drawing.Point(1063, 580);
            this.btnhomeback.Name = "btnhomeback";
            this.btnhomeback.Size = new System.Drawing.Size(132, 52);
            this.btnhomeback.TabIndex = 71;
            this.btnhomeback.Text = "Home Back";
            this.btnhomeback.UseVisualStyleBackColor = false;
            this.btnhomeback.Click += new System.EventHandler(this.btnhomeback_Click);
            // 
            // roomControlCheck
            // 
            this.roomControlCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomControlCheck.BackgroundImage")));
            this.roomControlCheck.CustomerId = 0;
            this.roomControlCheck.Location = new System.Drawing.Point(572, 36);
            this.roomControlCheck.Name = "roomControlCheck";
            this.roomControlCheck.RoomNo = 0;
            this.roomControlCheck.Size = new System.Drawing.Size(580, 514);
            this.roomControlCheck.TabIndex = 77;
            // 
            // CheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 633);
            this.Controls.Add(this.roomControlCheck);
            this.Controls.Add(this.btnhomeback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckInOut";
            this.Text = " ";
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button btnhomeback;
        private roomControl roomControlCheck;
    }
}