namespace RestaurantManagementProject
{
    partial class frmIn
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
            this.lblNgayIn = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayIn
            // 
            this.lblNgayIn.AutoSize = true;
            this.lblNgayIn.Location = new System.Drawing.Point(821, 63);
            this.lblNgayIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayIn.Name = "lblNgayIn";
            this.lblNgayIn.Size = new System.Drawing.Size(61, 20);
            this.lblNgayIn.TabIndex = 20;
            this.lblNgayIn.Text = "Ngày in";
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Location = new System.Drawing.Point(674, 63);
            this.lblBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(38, 20);
            this.lblBan.TabIndex = 19;
            this.lblBan.Text = "Bàn";
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Location = new System.Drawing.Point(856, 207);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(112, 35);
            this.btnHoanThanh.TabIndex = 18;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(788, 109);
            this.nudGiamGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(180, 26);
            this.nudGiamGia.TabIndex = 17;
            this.nudGiamGia.ValueChanged += new System.EventHandler(this.nudGiamGia_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(790, 154);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(178, 26);
            this.txtTongTien.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giảm giá";
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(47, 38);
            this.lvHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(597, 467);
            this.lvHoaDon.TabIndex = 13;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // frmIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 548);
            this.Controls.Add(this.lblNgayIn);
            this.Controls.Add(this.lblBan);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.nudGiamGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvHoaDon);
            this.Name = "frmIn";
            this.Text = "frmIn";
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgayIn;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvHoaDon;
    }
}