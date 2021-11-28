
namespace Storage_System
{
    partial class ProductsCRUD
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
            this.gbSearchProduct = new System.Windows.Forms.GroupBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.txtCuanityProd = new System.Windows.Forms.TextBox();
            this.cbProdActive = new System.Windows.Forms.CheckBox();
            this.cbProdInactive = new System.Windows.Forms.CheckBox();
            this.btnProdInsert = new System.Windows.Forms.Button();
            this.btnProdUpdate = new System.Windows.Forms.Button();
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.gbSearchProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchProduct
            // 
            this.gbSearchProduct.Controls.Add(this.btnSearchProduct);
            this.gbSearchProduct.Controls.Add(this.txtSearchProduct);
            this.gbSearchProduct.Location = new System.Drawing.Point(57, 13);
            this.gbSearchProduct.Name = "gbSearchProduct";
            this.gbSearchProduct.Size = new System.Drawing.Size(321, 74);
            this.gbSearchProduct.TabIndex = 0;
            this.gbSearchProduct.TabStop = false;
            this.gbSearchProduct.Text = "Search Product";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(264, 27);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(44, 29);
            this.btnSearchProduct.TabIndex = 1;
            this.btnSearchProduct.Text = "GO";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(17, 27);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(223, 27);
            this.txtSearchProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(57, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCT NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(57, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUCT DESCRIPTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(57, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRODUCT PRICE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(57, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CUANTITY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(57, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "PRODUCT STATUS:";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(187, 126);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(191, 27);
            this.txtProdName.TabIndex = 6;
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Location = new System.Drawing.Point(236, 193);
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(191, 81);
            this.txtProdDesc.TabIndex = 7;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(187, 287);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(191, 27);
            this.txtProdPrice.TabIndex = 8;
            // 
            // txtCuanityProd
            // 
            this.txtCuanityProd.Location = new System.Drawing.Point(143, 356);
            this.txtCuanityProd.Name = "txtCuanityProd";
            this.txtCuanityProd.Size = new System.Drawing.Size(191, 27);
            this.txtCuanityProd.TabIndex = 9;
            // 
            // cbProdActive
            // 
            this.cbProdActive.AutoSize = true;
            this.cbProdActive.BackColor = System.Drawing.Color.Transparent;
            this.cbProdActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbProdActive.Location = new System.Drawing.Point(192, 428);
            this.cbProdActive.Name = "cbProdActive";
            this.cbProdActive.Size = new System.Drawing.Size(79, 24);
            this.cbProdActive.TabIndex = 10;
            this.cbProdActive.Text = "ACTIVE";
            this.cbProdActive.UseVisualStyleBackColor = false;
            // 
            // cbProdInactive
            // 
            this.cbProdInactive.AutoSize = true;
            this.cbProdInactive.BackColor = System.Drawing.Color.Transparent;
            this.cbProdInactive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbProdInactive.Location = new System.Drawing.Point(192, 458);
            this.cbProdInactive.Name = "cbProdInactive";
            this.cbProdInactive.Size = new System.Drawing.Size(94, 24);
            this.cbProdInactive.TabIndex = 11;
            this.cbProdInactive.Text = "INACTIVE";
            this.cbProdInactive.UseVisualStyleBackColor = false;
            // 
            // btnProdInsert
            // 
            this.btnProdInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProdInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdInsert.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdInsert.Location = new System.Drawing.Point(568, 52);
            this.btnProdInsert.Name = "btnProdInsert";
            this.btnProdInsert.Size = new System.Drawing.Size(151, 75);
            this.btnProdInsert.TabIndex = 12;
            this.btnProdInsert.Text = "INSERT";
            this.btnProdInsert.UseVisualStyleBackColor = false;
            // 
            // btnProdUpdate
            // 
            this.btnProdUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdUpdate.Location = new System.Drawing.Point(568, 211);
            this.btnProdUpdate.Name = "btnProdUpdate";
            this.btnProdUpdate.Size = new System.Drawing.Size(151, 75);
            this.btnProdUpdate.TabIndex = 13;
            this.btnProdUpdate.Text = "UPDATE";
            this.btnProdUpdate.UseVisualStyleBackColor = false;
            // 
            // btnProdDelete
            // 
            this.btnProdDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProdDelete.Location = new System.Drawing.Point(568, 368);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(151, 75);
            this.btnProdDelete.TabIndex = 14;
            this.btnProdDelete.Text = "DELETE";
            this.btnProdDelete.UseVisualStyleBackColor = false;
            // 
            // ProductsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Storage_System.Properties.Resources.warehouse_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 509);
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnProdUpdate);
            this.Controls.Add(this.btnProdInsert);
            this.Controls.Add(this.cbProdInactive);
            this.Controls.Add(this.cbProdActive);
            this.Controls.Add(this.txtCuanityProd);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.txtProdDesc);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSearchProduct);
            this.Name = "ProductsCRUD";
            this.Text = "ProductsCRUD";
            this.gbSearchProduct.ResumeLayout(false);
            this.gbSearchProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.TextBox txtProdCuantity;
        private System.Windows.Forms.CheckBox cbProdActive;
        private System.Windows.Forms.CheckBox cbProdInactive;
        private System.Windows.Forms.TextBox txtCuanityProd;
        private System.Windows.Forms.Button btnProdInsert;
        private System.Windows.Forms.Button btnProdUpdate;
        private System.Windows.Forms.Button btnProdDelete;
    }
}