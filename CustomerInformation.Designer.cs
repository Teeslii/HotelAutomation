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
            this.listShowdata = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtExitDate = new System.Windows.Forms.DateTimePicker();
            this.txtLoginDate = new System.Windows.Forms.DateTimePicker();
            this.LblExitDate = new System.Windows.Forms.Label();
            this.LblLoginDate = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblTelephone = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtResearchID = new System.Windows.Forms.TextBox();
            this.btnhomeback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listShowdata
            // 
            this.listShowdata.BackColor = System.Drawing.Color.Gainsboro;
            this.listShowdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listShowdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.firstName,
            this.lastName,
            this.telephone,
            this.mail,
            this.TC,
            this.price,
            this.loginDate,
            this.exitDate});
            this.listShowdata.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.listShowdata.HideSelection = false;
            this.listShowdata.Location = new System.Drawing.Point(49, 373);
            this.listShowdata.Name = "listShowdata";
            this.listShowdata.Size = new System.Drawing.Size(1121, 170);
            this.listShowdata.TabIndex = 0;
            this.listShowdata.UseCompatibleStateImageBehavior = false;
            this.listShowdata.View = System.Windows.Forms.View.Details;
            this.listShowdata.DoubleClick += new System.EventHandler(this.listShowdata_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 35;
            // 
            // firstName
            // 
            this.firstName.Text = " firstName";
            this.firstName.Width = 115;
            // 
            // lastName
            // 
            this.lastName.Text = "lastName";
            this.lastName.Width = 102;
            // 
            // telephone
            // 
            this.telephone.Text = "telephone";
            this.telephone.Width = 149;
            // 
            // mail
            // 
            this.mail.Text = "mail";
            this.mail.Width = 180;
            // 
            // TC
            // 
            this.TC.Text = "TC";
            this.TC.Width = 142;
            // 
            // price
            // 
            this.price.Text = "price";
            this.price.Width = 58;
            // 
            // loginDate
            // 
            this.loginDate.Text = "loginDate";
            this.loginDate.Width = 153;
            // 
            // exitDate
            // 
            this.exitDate.Text = "exitDate";
            this.exitDate.Width = 186;
            // 
            // btnShowData
            // 
            this.btnShowData.BackColor = System.Drawing.Color.Transparent;
            this.btnShowData.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnShowData.Location = new System.Drawing.Point(1063, 309);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(140, 40);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "Show Data ";
            this.btnShowData.UseVisualStyleBackColor = false;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.BackColor = System.Drawing.Color.Transparent;
            this.btnResearch.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnResearch.Location = new System.Drawing.Point(1053, 36);
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
            this.btnUpdate.Location = new System.Drawing.Point(366, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 51);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnDelete.Location = new System.Drawing.Point(867, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.lblPrice.Location = new System.Drawing.Point(9, 225);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 22);
            this.lblPrice.TabIndex = 38;
            this.lblPrice.Text = "Price :";
            // 
            // txtExitDate
            // 
            this.txtExitDate.CustomFormat = "yyyy-MM-dd";
            this.txtExitDate.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExitDate.Location = new System.Drawing.Point(121, 317);
            this.txtExitDate.Name = "txtExitDate";
            this.txtExitDate.Size = new System.Drawing.Size(200, 30);
            this.txtExitDate.TabIndex = 37;
            this.txtExitDate.Value = new System.DateTime(2020, 7, 16, 0, 0, 0, 0);
            // 
            // txtLoginDate
            // 
            this.txtLoginDate.CustomFormat = "yyyy-MM-dd";
            this.txtLoginDate.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtLoginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtLoginDate.Location = new System.Drawing.Point(121, 276);
            this.txtLoginDate.Name = "txtLoginDate";
            this.txtLoginDate.Size = new System.Drawing.Size(200, 30);
            this.txtLoginDate.TabIndex = 36;
            this.txtLoginDate.Value = new System.DateTime(2020, 7, 16, 0, 0, 0, 0);
            // 
            // LblExitDate
            // 
            this.LblExitDate.AutoSize = true;
            this.LblExitDate.BackColor = System.Drawing.Color.Transparent;
            this.LblExitDate.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblExitDate.Location = new System.Drawing.Point(9, 315);
            this.LblExitDate.Name = "LblExitDate";
            this.LblExitDate.Size = new System.Drawing.Size(101, 22);
            this.LblExitDate.TabIndex = 30;
            this.LblExitDate.Text = "Exit Date:";
            // 
            // LblLoginDate
            // 
            this.LblLoginDate.AutoSize = true;
            this.LblLoginDate.BackColor = System.Drawing.Color.Transparent;
            this.LblLoginDate.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblLoginDate.Location = new System.Drawing.Point(9, 274);
            this.LblLoginDate.Name = "LblLoginDate";
            this.LblLoginDate.Size = new System.Drawing.Size(116, 22);
            this.LblLoginDate.TabIndex = 29;
            this.LblLoginDate.Text = "Login Date:";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.BackColor = System.Drawing.Color.Transparent;
            this.LblLastName.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblLastName.Location = new System.Drawing.Point(9, 48);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(107, 22);
            this.LblLastName.TabIndex = 28;
            this.LblLastName.Text = "LastName:";
            // 
            // LblTelephone
            // 
            this.LblTelephone.AutoSize = true;
            this.LblTelephone.BackColor = System.Drawing.Color.Transparent;
            this.LblTelephone.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.LblTelephone.Location = new System.Drawing.Point(9, 93);
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
            this.LblMail.Location = new System.Drawing.Point(9, 136);
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
            this.LblID.Location = new System.Drawing.Point(9, 179);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(36, 22);
            this.LblID.TabIndex = 25;
            this.LblID.Text = "ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.lblFirstName.Location = new System.Drawing.Point(9, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 22);
            this.lblFirstName.TabIndex = 24;
            this.lblFirstName.Text = "FirstName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.label1.Location = new System.Drawing.Point(763, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnClear.Location = new System.Drawing.Point(366, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 33);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtPrice.Location = new System.Drawing.Point(121, 230);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 30);
            this.txtPrice.TabIndex = 50;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtID.Location = new System.Drawing.Point(121, 184);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 30);
            this.txtID.TabIndex = 49;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtMail.Location = new System.Drawing.Point(121, 140);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 30);
            this.txtMail.TabIndex = 48;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtTelephone.Location = new System.Drawing.Point(121, 95);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(200, 30);
            this.txtTelephone.TabIndex = 47;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtLastName.Location = new System.Drawing.Point(121, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 30);
            this.txtLastName.TabIndex = 46;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtFirstName.Location = new System.Drawing.Point(121, 10);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 30);
            this.txtFirstName.TabIndex = 45;
            // 
            // txtResearchID
            // 
            this.txtResearchID.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.txtResearchID.Location = new System.Drawing.Point(807, 46);
            this.txtResearchID.Name = "txtResearchID";
            this.txtResearchID.Size = new System.Drawing.Size(200, 30);
            this.txtResearchID.TabIndex = 51;
            // 
            // btnhomeback
            // 
            this.btnhomeback.BackColor = System.Drawing.Color.Transparent;
            this.btnhomeback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhomeback.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.btnhomeback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhomeback.Location = new System.Drawing.Point(1053, 578);
            this.btnhomeback.Name = "btnhomeback";
            this.btnhomeback.Size = new System.Drawing.Size(132, 52);
            this.btnhomeback.TabIndex = 53;
            this.btnhomeback.Text = "Home Back";
            this.btnhomeback.UseVisualStyleBackColor = false;
            this.btnhomeback.Click += new System.EventHandler(this.btnhomeback_Click);
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 633);
            this.Controls.Add(this.btnhomeback);
            this.Controls.Add(this.txtResearchID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtExitDate);
            this.Controls.Add(this.txtLoginDate);
            this.Controls.Add(this.LblExitDate);
            this.Controls.Add(this.LblLoginDate);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblTelephone);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.listShowdata);
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

        private System.Windows.Forms.ListView listShowdata;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader telephone;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.ColumnHeader TC;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader loginDate;
        private System.Windows.Forms.ColumnHeader exitDate;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DateTimePicker txtExitDate;
        private System.Windows.Forms.DateTimePicker txtLoginDate;
        private System.Windows.Forms.Label LblExitDate;
        private System.Windows.Forms.Label LblLoginDate;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtResearchID;
        private System.Windows.Forms.Button btnhomeback;
    }
}