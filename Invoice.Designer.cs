namespace hotel
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.label4 = new System.Windows.Forms.Label();
            this.txtResearchRoom = new System.Windows.Forms.TextBox();
            this.btnResearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFeePayable = new System.Windows.Forms.TextBox();
            this.cbFeePayable = new System.Windows.Forms.ComboBox();
            this.btnPaid = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnhomeback = new System.Windows.Forms.Button();
            this.btnCardPayment = new System.Windows.Forms.Button();
            this.txtPullDate = new System.Windows.Forms.TextBox();
            this.txtIcNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCardPart1 = new System.Windows.Forms.TextBox();
            this.txtCardPart2 = new System.Windows.Forms.TextBox();
            this.txtCardPart3 = new System.Windows.Forms.TextBox();
            this.txtCardPart4 = new System.Windows.Forms.TextBox();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 79;
            this.label4.Text = "Room No:";
            // 
            // txtResearchRoom
            // 
            this.txtResearchRoom.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtResearchRoom.Location = new System.Drawing.Point(168, 48);
            this.txtResearchRoom.Name = "txtResearchRoom";
            this.txtResearchRoom.Size = new System.Drawing.Size(200, 30);
            this.txtResearchRoom.TabIndex = 78;
            // 
            // btnResearch
            // 
            this.btnResearch.BackColor = System.Drawing.Color.Transparent;
            this.btnResearch.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnResearch.Location = new System.Drawing.Point(418, 39);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(140, 47);
            this.btnResearch.TabIndex = 77;
            this.btnResearch.Text = "Research";
            this.btnResearch.UseVisualStyleBackColor = false;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label1.Location = new System.Drawing.Point(18, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 81;
            this.label1.Text = "Fee Payable:";
            // 
            // TxtFeePayable
            // 
            this.TxtFeePayable.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.TxtFeePayable.Location = new System.Drawing.Point(168, 150);
            this.TxtFeePayable.Name = "TxtFeePayable";
            this.TxtFeePayable.Size = new System.Drawing.Size(200, 30);
            this.TxtFeePayable.TabIndex = 80;
            // 
            // cbFeePayable
            // 
            this.cbFeePayable.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.cbFeePayable.FormattingEnabled = true;
            this.cbFeePayable.Items.AddRange(new object[] {
            "cash",
            "credit card"});
            this.cbFeePayable.Location = new System.Drawing.Point(51, 241);
            this.cbFeePayable.Name = "cbFeePayable";
            this.cbFeePayable.Size = new System.Drawing.Size(317, 30);
            this.cbFeePayable.TabIndex = 83;
            this.cbFeePayable.Text = "choose payment option..";
            this.cbFeePayable.SelectedIndexChanged += new System.EventHandler(this.cbFeePayable_SelectedIndexChanged);
            // 
            // btnPaid
            // 
            this.btnPaid.BackColor = System.Drawing.Color.Transparent;
            this.btnPaid.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnPaid.Location = new System.Drawing.Point(325, 344);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(233, 127);
            this.btnPaid.TabIndex = 84;
            this.btnPaid.Text = "It has been paid.";
            this.btnPaid.UseVisualStyleBackColor = false;
            this.btnPaid.Visible = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.Controls.Add(this.txtCardPart1);
            this.pnlCard.Controls.Add(this.txtCardPart2);
            this.pnlCard.Controls.Add(this.txtCardPart3);
            this.pnlCard.Controls.Add(this.txtCardPart4);
            this.pnlCard.Controls.Add(this.btnhomeback);
            this.pnlCard.Controls.Add(this.btnCardPayment);
            this.pnlCard.Controls.Add(this.txtPullDate);
            this.pnlCard.Controls.Add(this.txtIcNumber);
            this.pnlCard.Controls.Add(this.label6);
            this.pnlCard.Controls.Add(this.label5);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.txtName);
            this.pnlCard.Location = new System.Drawing.Point(607, 39);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(596, 582);
            this.pnlCard.TabIndex = 85;
            this.pnlCard.Visible = false;
            // 
            // btnhomeback
            // 
            this.btnhomeback.BackColor = System.Drawing.Color.Transparent;
            this.btnhomeback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhomeback.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnhomeback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhomeback.Location = new System.Drawing.Point(464, 541);
            this.btnhomeback.Name = "btnhomeback";
            this.btnhomeback.Size = new System.Drawing.Size(132, 52);
            this.btnhomeback.TabIndex = 86;
            this.btnhomeback.Text = "Home Back";
            this.btnhomeback.UseVisualStyleBackColor = false;
            this.btnhomeback.Click += new System.EventHandler(this.btnhomeback_Click);
            // 
            // btnCardPayment
            // 
            this.btnCardPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnCardPayment.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnCardPayment.Location = new System.Drawing.Point(301, 326);
            this.btnCardPayment.Name = "btnCardPayment";
            this.btnCardPayment.Size = new System.Drawing.Size(211, 106);
            this.btnCardPayment.TabIndex = 86;
            this.btnCardPayment.Text = "It has been paid.";
            this.btnCardPayment.UseVisualStyleBackColor = false;
            this.btnCardPayment.Click += new System.EventHandler(this.btnCardPayment_Click);
            // 
            // txtPullDate
            // 
            this.txtPullDate.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtPullDate.Location = new System.Drawing.Point(301, 153);
            this.txtPullDate.Name = "txtPullDate";
            this.txtPullDate.Size = new System.Drawing.Size(211, 30);
            this.txtPullDate.TabIndex = 89;
            // 
            // txtIcNumber
            // 
            this.txtIcNumber.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtIcNumber.Location = new System.Drawing.Point(301, 103);
            this.txtIcNumber.Name = "txtIcNumber";
            this.txtIcNumber.Size = new System.Drawing.Size(211, 30);
            this.txtIcNumber.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label6.Location = new System.Drawing.Point(18, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 87;
            this.label6.Text = "Pull Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 86;
            this.label5.Text = "IC Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 85;
            this.label2.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 22);
            this.label3.TabIndex = 83;
            this.label3.Text = "Card Firstname /Lastname:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtName.Location = new System.Drawing.Point(301, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 30);
            this.txtName.TabIndex = 82;
            // 
            // txtCardPart1
            // 
            this.txtCardPart1.Location = new System.Drawing.Point(301, 74);
            this.txtCardPart1.Name = "txtCardPart1";
            this.txtCardPart1.Size = new System.Drawing.Size(48, 20);
            this.txtCardPart1.TabIndex = 86;
            // 
            // txtCardPart2
            // 
            this.txtCardPart2.Location = new System.Drawing.Point(355, 74);
            this.txtCardPart2.Name = "txtCardPart2";
            this.txtCardPart2.Size = new System.Drawing.Size(48, 20);
            this.txtCardPart2.TabIndex = 87;
            // 
            // txtCardPart3
            // 
            this.txtCardPart3.Location = new System.Drawing.Point(409, 74);
            this.txtCardPart3.Name = "txtCardPart3";
            this.txtCardPart3.Size = new System.Drawing.Size(48, 20);
            this.txtCardPart3.TabIndex = 88;
            // 
            // txtCardPart4
            // 
            this.txtCardPart4.Location = new System.Drawing.Point(463, 74);
            this.txtCardPart4.Name = "txtCardPart4";
            this.txtCardPart4.Size = new System.Drawing.Size(48, 20);
            this.txtCardPart4.TabIndex = 89;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 633);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.cbFeePayable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFeePayable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResearchRoom);
            this.Controls.Add(this.btnResearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResearchRoom;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFeePayable;
        private System.Windows.Forms.ComboBox cbFeePayable;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button btnCardPayment;
        private System.Windows.Forms.TextBox txtPullDate;
        private System.Windows.Forms.TextBox txtIcNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnhomeback;
        private System.Windows.Forms.TextBox txtCardPart1;
        private System.Windows.Forms.TextBox txtCardPart2;
        private System.Windows.Forms.TextBox txtCardPart3;
        private System.Windows.Forms.TextBox txtCardPart4;
    }
}