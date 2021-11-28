
namespace Storage_System
{
    partial class UsersCRUD
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
            this.gbSearchUser = new System.Windows.Forms.GroupBox();
            this.txtSearchBat = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.txtUserAddress = new System.Windows.Forms.TextBox();
            this.cbUserActive = new System.Windows.Forms.CheckBox();
            this.cbUserInactive = new System.Windows.Forms.CheckBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.gbSearchUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchUser
            // 
            this.gbSearchUser.Controls.Add(this.btnSearchUser);
            this.gbSearchUser.Controls.Add(this.txtSearchBat);
            this.gbSearchUser.Location = new System.Drawing.Point(67, 13);
            this.gbSearchUser.Name = "gbSearchUser";
            this.gbSearchUser.Size = new System.Drawing.Size(391, 70);
            this.gbSearchUser.TabIndex = 0;
            this.gbSearchUser.TabStop = false;
            this.gbSearchUser.Text = "SEARCH USER";
            // 
            // txtSearchBat
            // 
            this.txtSearchBat.Location = new System.Drawing.Point(15, 27);
            this.txtSearchBat.Name = "txtSearchBat";
            this.txtSearchBat.Size = new System.Drawing.Size(250, 27);
            this.txtSearchBat.TabIndex = 0;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(300, 25);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(66, 29);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "GO";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(52, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(52, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(52, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(52, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(52, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(408, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(408, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(408, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Address:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(110, 123);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(164, 27);
            this.txtUserName.TabIndex = 9;
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(140, 178);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(164, 27);
            this.txtUserLastName.TabIndex = 10;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(127, 235);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(164, 27);
            this.txtUserPassword.TabIndex = 11;
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(467, 123);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(164, 27);
            this.txtUserPhone.TabIndex = 12;
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(452, 178);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(164, 27);
            this.txtUserMail.TabIndex = 13;
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.Location = new System.Drawing.Point(479, 235);
            this.txtUserAddress.Multiline = true;
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.Size = new System.Drawing.Size(164, 82);
            this.txtUserAddress.TabIndex = 14;
            // 
            // cbUserActive
            // 
            this.cbUserActive.AutoSize = true;
            this.cbUserActive.BackColor = System.Drawing.Color.Transparent;
            this.cbUserActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbUserActive.Location = new System.Drawing.Point(109, 364);
            this.cbUserActive.Name = "cbUserActive";
            this.cbUserActive.Size = new System.Drawing.Size(79, 24);
            this.cbUserActive.TabIndex = 15;
            this.cbUserActive.Text = "ACTIVE";
            this.cbUserActive.UseVisualStyleBackColor = false;
            // 
            // cbUserInactive
            // 
            this.cbUserInactive.AutoSize = true;
            this.cbUserInactive.BackColor = System.Drawing.Color.Transparent;
            this.cbUserInactive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbUserInactive.Location = new System.Drawing.Point(109, 394);
            this.cbUserInactive.Name = "cbUserInactive";
            this.cbUserInactive.Size = new System.Drawing.Size(94, 24);
            this.cbUserInactive.TabIndex = 16;
            this.cbUserInactive.Text = "INACTIVE";
            this.cbUserInactive.UseVisualStyleBackColor = false;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Items.AddRange(new object[] {
            "STANDAR",
            "ADMIN"});
            this.cmbUserRole.Location = new System.Drawing.Point(100, 294);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(151, 28);
            this.cmbUserRole.TabIndex = 17;
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUserCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserCreate.Location = new System.Drawing.Point(97, 429);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Size = new System.Drawing.Size(126, 54);
            this.btnUserCreate.TabIndex = 18;
            this.btnUserCreate.Text = "CREATE";
            this.btnUserCreate.UseVisualStyleBackColor = false;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserUpdate.Location = new System.Drawing.Point(330, 429);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(126, 54);
            this.btnUserUpdate.TabIndex = 19;
            this.btnUserUpdate.Text = "UPDATE";
            this.btnUserUpdate.UseVisualStyleBackColor = false;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserDelete.Location = new System.Drawing.Point(568, 429);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(126, 54);
            this.btnUserDelete.TabIndex = 20;
            this.btnUserDelete.Text = "DELETE";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            // 
            // UsersCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Storage_System.Properties.Resources.warehouse_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.btnUserUpdate);
            this.Controls.Add(this.btnUserCreate);
            this.Controls.Add(this.cmbUserRole);
            this.Controls.Add(this.cbUserInactive);
            this.Controls.Add(this.cbUserActive);
            this.Controls.Add(this.txtUserAddress);
            this.Controls.Add(this.txtUserMail);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserLastName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSearchUser);
            this.Name = "UsersCRUD";
            this.Text = "UsersCRUD";
            this.gbSearchUser.ResumeLayout(false);
            this.gbSearchUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearchBat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserLastName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.TextBox txtUserAddress;
        private System.Windows.Forms.CheckBox cbUserActive;
        private System.Windows.Forms.CheckBox cbUserInactive;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Button btnUserCreate;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserDelete;
    }
}