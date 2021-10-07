namespace hotel
{
    partial class CustomerInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInformation));
            this.listCustomerInformation = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowInformation = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.LblTelephone = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtResearchID = new System.Windows.Forms.TextBox();
            this.btnHomeBack = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listCustomerInformation
            // 
            this.listCustomerInformation.BackColor = System.Drawing.Color.Gainsboro;
            this.listCustomerInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCustomerInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NameSurname,
            this.Telephone,
            this.Mail,
            this.Country,
            this.Tc,
            this.Address});
            this.listCustomerInformation.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.listCustomerInformation.HideSelection = false;
            this.listCustomerInformation.Location = new System.Drawing.Point(50, 93);
            this.listCustomerInformation.Name = "listCustomerInformation";
            this.listCustomerInformation.Size = new System.Drawing.Size(1119, 212);
            this.listCustomerInformation.TabIndex = 0;
            this.listCustomerInformation.UseCompatibleStateImageBehavior = false;
            this.listCustomerInformation.View = System.Windows.Forms.View.Details;
            this.listCustomerInformation.DoubleClick += new System.EventHandler(this.listCustomerInformation_DoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 44;
            // 
            // NameSurname
            // 
            this.NameSurname.Text = "Name Surname";
            this.NameSurname.Width = 169;
            // 
            // Telephone
            // 
            this.Telephone.Text = "Telephone";
            this.Telephone.Width = 166;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 180;
            // 
            // btnShowInformation
            // 
            this.btnShowInformation.BackColor = System.Drawing.Color.Transparent;
            this.btnShowInformation.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnShowInformation.Location = new System.Drawing.Point(962, 27);
            this.btnShowInformation.Name = "btnShowInformation";
            this.btnShowInformation.Size = new System.Drawing.Size(207, 47);
            this.btnShowInformation.TabIndex = 1;
            this.btnShowInformation.Text = "Show Information";
            this.btnShowInformation.UseVisualStyleBackColor = false;
            this.btnShowInformation.Click += new System.EventHandler(this.btnShowInformation_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.BackColor = System.Drawing.Color.Transparent;
            this.btnResearch.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnResearch.Location = new System.Drawing.Point(336, 26);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(140, 47);
            this.btnResearch.TabIndex = 2;
            this.btnResearch.Text = "Research";
            this.btnResearch.UseVisualStyleBackColor = false;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnUpdate.Location = new System.Drawing.Point(1034, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 51);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.BackColor = System.Drawing.Color.Transparent;
            this.LblNameSurname.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblNameSurname.Location = new System.Drawing.Point(46, 344);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(155, 22);
            this.LblNameSurname.TabIndex = 28;
            this.LblNameSurname.Text = "Name Surname:";
            // 
            // LblTelephone
            // 
            this.LblTelephone.AutoSize = true;
            this.LblTelephone.BackColor = System.Drawing.Color.Transparent;
            this.LblTelephone.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblTelephone.Location = new System.Drawing.Point(46, 402);
            this.LblTelephone.Name = "LblTelephone";
            this.LblTelephone.Size = new System.Drawing.Size(112, 22);
            this.LblTelephone.TabIndex = 27;
            this.LblTelephone.Text = "Telephone:";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.BackColor = System.Drawing.Color.Transparent;
            this.LblMail.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblMail.Location = new System.Drawing.Point(46, 459);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(55, 22);
            this.LblMail.TabIndex = 26;
            this.LblMail.Text = "Mail:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.Transparent;
            this.LblID.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblID.Location = new System.Drawing.Point(543, 344);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(41, 22);
            this.LblID.TabIndex = 25;
            this.LblID.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnClear.Location = new System.Drawing.Point(1034, 413);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 51);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtTc.Location = new System.Drawing.Point(746, 336);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(200, 30);
            this.txtTc.TabIndex = 49;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtMail.Location = new System.Drawing.Point(269, 449);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 30);
            this.txtMail.TabIndex = 48;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtTelephone.Location = new System.Drawing.Point(269, 394);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(200, 30);
            this.txtTelephone.TabIndex = 47;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtNameSurname.Location = new System.Drawing.Point(269, 336);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(200, 30);
            this.txtNameSurname.TabIndex = 46;
            // 
            // txtResearchID
            // 
            this.txtResearchID.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtResearchID.Location = new System.Drawing.Point(90, 36);
            this.txtResearchID.Name = "txtResearchID";
            this.txtResearchID.Size = new System.Drawing.Size(200, 30);
            this.txtResearchID.TabIndex = 51;
            // 
            // btnHomeBack
            // 
            this.btnHomeBack.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeBack.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnHomeBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHomeBack.Location = new System.Drawing.Point(1037, 559);
            this.btnHomeBack.Name = "btnHomeBack";
            this.btnHomeBack.Size = new System.Drawing.Size(132, 52);
            this.btnHomeBack.TabIndex = 53;
            this.btnHomeBack.Text = "Home Back";
            this.btnHomeBack.UseVisualStyleBackColor = false;
            this.btnHomeBack.Click += new System.EventHandler(this.btnHomeBack_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(746, 399);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(221, 117);
            this.txtAddress.TabIndex = 55;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.lblAddress.Location = new System.Drawing.Point(543, 402);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 22);
            this.lblAddress.TabIndex = 54;
            this.lblAddress.Text = "Address:";
            // 
            // txtCountry
            // 
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(269, 505);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 30);
            this.txtCountry.TabIndex = 57;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.lblCountry.Location = new System.Drawing.Point(45, 513);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(92, 22);
            this.lblCountry.TabIndex = 56;
            this.lblCountry.Text = "Country:";
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 113;
            // 
            // Tc
            // 
            this.Tc.Text = "TC";
            this.Tc.Width = 180;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 266;
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 633);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnHomeBack);
            this.Controls.Add(this.txtResearchID);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblNameSurname);
            this.Controls.Add(this.LblTelephone);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnShowInformation);
            this.Controls.Add(this.listCustomerInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCustomerInformation;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NameSurname;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.Button btnShowInformation;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.TextBox txtResearchID;
        private System.Windows.Forms.Button btnHomeBack;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader Tc;
        private System.Windows.Forms.ColumnHeader Address;
    }
}