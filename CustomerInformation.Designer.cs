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
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblTelephone = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
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
            this.lastName,
            this.telephone,
            this.mail,
            this.TC});
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
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblTelephone);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblID);
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
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader telephone;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.ColumnHeader TC;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblTelephone;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtResearchID;
        private System.Windows.Forms.Button btnhomeback;
    }
}