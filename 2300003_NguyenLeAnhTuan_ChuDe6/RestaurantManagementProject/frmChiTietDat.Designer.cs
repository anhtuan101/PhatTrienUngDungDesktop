namespace RestaurantManagementProject
{
    partial class frmChiTietDat
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
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDSMatHang = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(131, 38);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(21, 20);
            this.lblOrderID.TabIndex = 5;
            this.lblOrderID.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã đặt: ";
            // 
            // lvDSMatHang
            // 
            this.lvDSMatHang.HideSelection = false;
            this.lvDSMatHang.Location = new System.Drawing.Point(47, 86);
            this.lvDSMatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvDSMatHang.Name = "lvDSMatHang";
            this.lvDSMatHang.Size = new System.Drawing.Size(559, 402);
            this.lvDSMatHang.TabIndex = 3;
            this.lvDSMatHang.UseCompatibleStateImageBehavior = false;
            // 
            // frmChiTietDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 515);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDSMatHang);
            this.Name = "frmChiTietDat";
            this.Text = "frmChiTietDat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDSMatHang;
    }
}