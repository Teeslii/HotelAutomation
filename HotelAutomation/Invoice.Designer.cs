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
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.cbFeePayable = new System.Windows.Forms.ComboBox();
            this.btnCashPayment = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.txtYYNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCardPart1 = new System.Windows.Forms.TextBox();
            this.txtCardPart2 = new System.Windows.Forms.TextBox();
            this.txtCardPart3 = new System.Windows.Forms.TextBox();
            this.txtCardPart4 = new System.Windows.Forms.TextBox();
            this.btnhomeback = new System.Windows.Forms.Button();
            this.btnCardPayment = new System.Windows.Forms.Button();
            this.txtCVCNumber = new System.Windows.Forms.TextBox();
            this.txtMMNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameOfCard = new System.Windows.Forms.TextBox();
            this.lblPaymentAmountText = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.lblPaymentAmount.Location = new System.Drawing.Point(50, 77);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(176, 22);
            this.lblPaymentAmount.TabIndex = 81;
            this.lblPaymentAmount.Text = "Payment Amount:";
            // 
            // cbFeePayable
            // 
            this.cbFeePayable.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.cbFeePayable.FormattingEnabled = true;
            this.cbFeePayable.Items.AddRange(new object[] {
            "cash",
            "credit card"});
            this.cbFeePayable.Location = new System.Drawing.Point(89, 163);
            this.cbFeePayable.Name = "cbFeePayable";
            this.cbFeePayable.Size = new System.Drawing.Size(317, 30);
            this.cbFeePayable.TabIndex = 83;
            this.cbFeePayable.Text = "choose payment option..";
            this.cbFeePayable.SelectedIndexChanged += new System.EventHandler(this.cbFeePayable_SelectedIndexChanged);
            // 
            // btnCashPayment
            // 
            this.btnCashPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnCashPayment.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnCashPayment.Location = new System.Drawing.Point(321, 365);
            this.btnCashPayment.Name = "btnCashPayment";
            this.btnCashPayment.Size = new System.Drawing.Size(233, 106);
            this.btnCashPayment.TabIndex = 84;
            this.btnCashPayment.Text = "Pay";
            this.btnCashPayment.UseVisualStyleBackColor = false;
            this.btnCashPayment.Visible = false;
            this.btnCashPayment.Click += new System.EventHandler(this.btnCashPayment_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.Controls.Add(this.txtYYNumber);
            this.pnlCard.Controls.Add(this.label7);
            this.pnlCard.Controls.Add(this.txtCardPart1);
            this.pnlCard.Controls.Add(this.txtCardPart2);
            this.pnlCard.Controls.Add(this.txtCardPart3);
            this.pnlCard.Controls.Add(this.txtCardPart4);
            this.pnlCard.Controls.Add(this.btnhomeback);
            this.pnlCard.Controls.Add(this.btnCardPayment);
            this.pnlCard.Controls.Add(this.txtCVCNumber);
            this.pnlCard.Controls.Add(this.txtMMNumber);
            this.pnlCard.Controls.Add(this.label6);
            this.pnlCard.Controls.Add(this.label5);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.txtNameOfCard);
            this.pnlCard.Location = new System.Drawing.Point(607, 39);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(596, 582);
            this.pnlCard.TabIndex = 85;
            this.pnlCard.Visible = false;
            // 
            // txtYYNumber
            // 
            this.txtYYNumber.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYYNumber.Location = new System.Drawing.Point(389, 103);
            this.txtYYNumber.Name = "txtYYNumber";
            this.txtYYNumber.Size = new System.Drawing.Size(57, 25);
            this.txtYYNumber.TabIndex = 91;
            this.txtYYNumber.Text = "YY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label7.Location = new System.Drawing.Point(364, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 22);
            this.label7.TabIndex = 90;
            this.label7.Text = "/";
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
            this.btnCardPayment.Text = "Pay";
            this.btnCardPayment.UseVisualStyleBackColor = false;
            this.btnCardPayment.Click += new System.EventHandler(this.btnCardPayment_Click);
            // 
            // txtCVCNumber
            // 
            this.txtCVCNumber.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtCVCNumber.Location = new System.Drawing.Point(301, 153);
            this.txtCVCNumber.Name = "txtCVCNumber";
            this.txtCVCNumber.Size = new System.Drawing.Size(102, 30);
            this.txtCVCNumber.TabIndex = 89;
            // 
            // txtMMNumber
            // 
            this.txtMMNumber.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMNumber.Location = new System.Drawing.Point(301, 103);
            this.txtMMNumber.Name = "txtMMNumber";
            this.txtMMNumber.Size = new System.Drawing.Size(57, 25);
            this.txtMMNumber.TabIndex = 88;
            this.txtMMNumber.Text = "MM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label6.Location = new System.Drawing.Point(18, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 87;
            this.label6.Text = "CVC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 86;
            this.label5.Text = "Valid Thru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 85;
            this.label2.Text = "Number Of Card:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 83;
            this.label3.Text = "Holder Of Card:";
            // 
            // txtNameOfCard
            // 
            this.txtNameOfCard.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtNameOfCard.Location = new System.Drawing.Point(301, 17);
            this.txtNameOfCard.Name = "txtNameOfCard";
            this.txtNameOfCard.Size = new System.Drawing.Size(211, 30);
            this.txtNameOfCard.TabIndex = 82;
            // 
            // lblPaymentAmountText
            // 
            this.lblPaymentAmountText.AutoSize = true;
            this.lblPaymentAmountText.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentAmountText.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.lblPaymentAmountText.Location = new System.Drawing.Point(232, 77);
            this.lblPaymentAmountText.Name = "lblPaymentAmountText";
            this.lblPaymentAmountText.Size = new System.Drawing.Size(0, 22);
            this.lblPaymentAmountText.TabIndex = 86;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 633);
            this.Controls.Add(this.lblPaymentAmountText);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnCashPayment);
            this.Controls.Add(this.cbFeePayable);
            this.Controls.Add(this.lblPaymentAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.ComboBox cbFeePayable;
        private System.Windows.Forms.Button btnCashPayment;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button btnCardPayment;
        private System.Windows.Forms.TextBox txtCVCNumber;
        private System.Windows.Forms.TextBox txtMMNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameOfCard;
        private System.Windows.Forms.Button btnhomeback;
        private System.Windows.Forms.TextBox txtCardPart1;
        private System.Windows.Forms.TextBox txtCardPart2;
        private System.Windows.Forms.TextBox txtCardPart3;
        private System.Windows.Forms.TextBox txtCardPart4;
        private System.Windows.Forms.TextBox txtYYNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPaymentAmountText;
    }
}