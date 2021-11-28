
namespace Storage_System
{
    partial class MainView
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
            this.msControls = new System.Windows.Forms.MenuStrip();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msControls
            // 
            this.msControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msControls.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.tsmiProducts});
            this.msControls.Location = new System.Drawing.Point(0, 0);
            this.msControls.Name = "msControls";
            this.msControls.Size = new System.Drawing.Size(800, 28);
            this.msControls.TabIndex = 1;
            this.msControls.Text = "Controls";
            // 
            // tsmiUser
            // 
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(66, 24);
            this.tsmiUser.Text = "USERS";
            // 
            // tsmiProducts
            // 
            this.tsmiProducts.Name = "tsmiProducts";
            this.tsmiProducts.Size = new System.Drawing.Size(97, 24);
            this.tsmiProducts.Text = "PRODUCTS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Storage_System.Properties.Resources.warehouse_background_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 566);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msControls);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msControls;
            this.Name = "MainView";
            this.Text = "Form2";
            this.msControls.ResumeLayout(false);
            this.msControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msControls;
        private System.Windows.Forms.MenuStrip msUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}