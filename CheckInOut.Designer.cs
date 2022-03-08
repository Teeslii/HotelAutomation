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
            this.roomControlCheck = new hotel.RoomControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarCheckOut = new System.Windows.Forms.MonthCalendar();
            this.CalendarCheckIn = new System.Windows.Forms.MonthCalendar();
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
            this.roomControlCheck.Location = new System.Drawing.Point(585, 12);
            this.roomControlCheck.Name = "roomControlCheck";
            this.roomControlCheck.Size = new System.Drawing.Size(580, 514);
            this.roomControlCheck.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Check-Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Check-In";
            // 
            // CalendarCheckOut
            // 
            this.CalendarCheckOut.Location = new System.Drawing.Point(229, 323);
            this.CalendarCheckOut.Name = "CalendarCheckOut";
            this.CalendarCheckOut.TabIndex = 89;
            this.CalendarCheckOut.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarCheckOut_DateSelected);
            // 
            // CalendarCheckIn
            // 
            this.CalendarCheckIn.Location = new System.Drawing.Point(229, 93);
            this.CalendarCheckIn.Margin = new System.Windows.Forms.Padding(15);
            this.CalendarCheckIn.Name = "CalendarCheckIn";
            this.CalendarCheckIn.TabIndex = 88;
            // 
            // CheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalendarCheckOut);
            this.Controls.Add(this.CalendarCheckIn);
            this.Controls.Add(this.roomControlCheck);
            this.Controls.Add(this.btnhomeback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.CheckInOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button btnhomeback;
        private RoomControl roomControlCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar CalendarCheckOut;
        private System.Windows.Forms.MonthCalendar CalendarCheckIn;
    }
}