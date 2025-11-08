namespace RestaurantManagementProject
{
    partial class frmBan
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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHieuChinh = new System.Windows.Forms.Button();
            this.dgvDSMonAn = new System.Windows.Forms.DataGridView();
            this.lvMonAnTheoBan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.flpDSBan = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblSoBan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetCBB = new System.Windows.Forms.Button();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(351, 839);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 35);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Location = new System.Drawing.Point(351, 790);
            this.btnHieuChinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.Size = new System.Drawing.Size(147, 35);
            this.btnHieuChinh.TabIndex = 25;
            this.btnHieuChinh.Text = "Hiệu chỉnh";
            this.btnHieuChinh.UseVisualStyleBackColor = true;
            this.btnHieuChinh.Click += new System.EventHandler(this.btnHieuChinh_Click);
            // 
            // dgvDSMonAn
            // 
            this.dgvDSMonAn.AllowUserToResizeRows = false;
            this.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonAn.Location = new System.Drawing.Point(857, 148);
            this.dgvDSMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDSMonAn.Name = "dgvDSMonAn";
            this.dgvDSMonAn.RowHeadersWidth = 62;
            this.dgvDSMonAn.Size = new System.Drawing.Size(896, 608);
            this.dgvDSMonAn.TabIndex = 24;
            // 
            // lvMonAnTheoBan
            // 
            this.lvMonAnTheoBan.CheckBoxes = true;
            this.lvMonAnTheoBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader8});
            this.lvMonAnTheoBan.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMonAnTheoBan.HideSelection = false;
            this.lvMonAnTheoBan.Location = new System.Drawing.Point(32, 86);
            this.lvMonAnTheoBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvMonAnTheoBan.Name = "lvMonAnTheoBan";
            this.lvMonAnTheoBan.Size = new System.Drawing.Size(820, 348);
            this.lvMonAnTheoBan.TabIndex = 23;
            this.lvMonAnTheoBan.UseCompatibleStateImageBehavior = false;
            this.lvMonAnTheoBan.View = System.Windows.Forms.View.Details;
            this.lvMonAnTheoBan.DoubleClick += new System.EventHandler(this.lvMonAnTheoBan_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DVT";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 36);
            // 
            // tsmXoa
            // 
            this.tsmXoa.Name = "tsmXoa";
            this.tsmXoa.Size = new System.Drawing.Size(115, 32);
            this.tsmXoa.Text = "Xóa";
            this.tsmXoa.Click += new System.EventHandler(this.tsmXoa_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(29, 839);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(112, 35);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(180, 839);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(147, 35);
            this.btnThemMon.TabIndex = 21;
            this.btnThemMon.Text = "Thêm vào bàn";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 797);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(152, 794);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(166, 26);
            this.txtTongTien.TabIndex = 19;
            // 
            // flpDSBan
            // 
            this.flpDSBan.Location = new System.Drawing.Point(35, 444);
            this.flpDSBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpDSBan.Name = "flpDSBan";
            this.flpDSBan.Size = new System.Drawing.Size(814, 312);
            this.flpDSBan.TabIndex = 18;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(28, 9);
            this.lblTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(157, 37);
            this.lblTenNhanVien.TabIndex = 29;
            this.lblTenNhanVien.Text = "Nhân viên";
            // 
            // lblSoBan
            // 
            this.lblSoBan.AutoSize = true;
            this.lblSoBan.Location = new System.Drawing.Point(102, 57);
            this.lblSoBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoBan.Name = "lblSoBan";
            this.lblSoBan.Size = new System.Drawing.Size(21, 20);
            this.lblSoBan.TabIndex = 28;
            this.lblSoBan.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Bàn số:";
            // 
            // btnResetCBB
            // 
            this.btnResetCBB.Location = new System.Drawing.Point(1084, 82);
            this.btnResetCBB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetCBB.Name = "btnResetCBB";
            this.btnResetCBB.Size = new System.Drawing.Size(112, 35);
            this.btnResetCBB.TabIndex = 31;
            this.btnResetCBB.Text = "None";
            this.btnResetCBB.UseVisualStyleBackColor = true;
            this.btnResetCBB.Click += new System.EventHandler(this.btnResetCBB_Click);
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(884, 86);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(180, 28);
            this.cbbCategory.TabIndex = 30;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 914);
            this.Controls.Add(this.btnResetCBB);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblSoBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHieuChinh);
            this.Controls.Add(this.dgvDSMonAn);
            this.Controls.Add(this.lvMonAnTheoBan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.flpDSBan);
            this.Name = "frmBan";
            this.Text = "frmBan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonAn)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHieuChinh;
        private System.Windows.Forms.DataGridView dgvDSMonAn;
        private System.Windows.Forms.ListView lvMonAnTheoBan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.FlowLayoutPanel flpDSBan;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblSoBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmXoa;
        private System.Windows.Forms.Button btnResetCBB;
        private System.Windows.Forms.ComboBox cbbCategory;
    }
}