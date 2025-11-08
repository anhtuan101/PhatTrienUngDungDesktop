namespace WindowsFormsApp1
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoaSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbMSSV = new System.Windows.Forms.MaskedTextBox();
            this.mtbCMND = new System.Windows.Forms.MaskedTextBox();
            this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.dtpNSinh = new System.Windows.Forms.DateTimePicker();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.clbMonhoc = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMônToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvDanhSach = new System.Windows.Forms.ListView();
            this.cMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaSVToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // xoaSVToolStripMenuItem
            // 
            this.xoaSVToolStripMenuItem.Name = "xoaSVToolStripMenuItem";
            this.xoaSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xoaSVToolStripMenuItem.Text = "Xóa";
            this.xoaSVToolStripMenuItem.Click += new System.EventHandler(this.xoaSVToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên lót:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lớp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số ĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ liên lạc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Môn học đăng ký:";
            // 
            // mtbMSSV
            // 
            this.mtbMSSV.Location = new System.Drawing.Point(173, 37);
            this.mtbMSSV.Mask = "0000000";
            this.mtbMSSV.Name = "mtbMSSV";
            this.mtbMSSV.Size = new System.Drawing.Size(269, 23);
            this.mtbMSSV.TabIndex = 1;
            // 
            // mtbCMND
            // 
            this.mtbCMND.Location = new System.Drawing.Point(173, 157);
            this.mtbCMND.Mask = "000000000";
            this.mtbCMND.Name = "mtbCMND";
            this.mtbCMND.Size = new System.Drawing.Size(269, 23);
            this.mtbCMND.TabIndex = 2;
            // 
            // mtbSDT
            // 
            this.mtbSDT.Location = new System.Drawing.Point(554, 157);
            this.mtbSDT.Mask = "0000.000.000";
            this.mtbSDT.Name = "mtbSDT";
            this.mtbSDT.Size = new System.Drawing.Size(277, 23);
            this.mtbSDT.TabIndex = 3;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(173, 77);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(269, 23);
            this.tbHoTen.TabIndex = 4;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(554, 77);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(277, 23);
            this.tbTen.TabIndex = 5;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(173, 193);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(658, 23);
            this.tbDiaChi.TabIndex = 6;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(554, 39);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(55, 21);
            this.rdNam.TabIndex = 7;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(633, 38);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(44, 21);
            this.rdNu.TabIndex = 7;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // dtpNSinh
            // 
            this.dtpNSinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNSinh.Location = new System.Drawing.Point(173, 116);
            this.dtpNSinh.Name = "dtpNSinh";
            this.dtpNSinh.Size = new System.Drawing.Size(269, 23);
            this.dtpNSinh.TabIndex = 8;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "CNTT1",
            "CNTT2",
            "CNTT3"});
            this.cbLop.Location = new System.Drawing.Point(554, 118);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(277, 24);
            this.cbLop.TabIndex = 9;
            // 
            // clbMonhoc
            // 
            this.clbMonhoc.CheckOnClick = true;
            this.clbMonhoc.ColumnWidth = 300;
            this.clbMonhoc.ContextMenuStrip = this.contextMenuStrip2;
            this.clbMonhoc.FormattingEnabled = true;
            this.clbMonhoc.Items.AddRange(new object[] {
            "Mạng máy tính",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình trên thiết bị di động",
            "An toàn và bảo mật hệ thống"});
            this.clbMonhoc.Location = new System.Drawing.Point(173, 234);
            this.clbMonhoc.MultiColumn = true;
            this.clbMonhoc.Name = "clbMonhoc";
            this.clbMonhoc.Size = new System.Drawing.Size(658, 76);
            this.clbMonhoc.TabIndex = 10;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMônToolStripMenuItem1,
            this.xóaMônToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(133, 48);
            // 
            // thêmMônToolStripMenuItem1
            // 
            this.thêmMônToolStripMenuItem1.Name = "thêmMônToolStripMenuItem1";
            this.thêmMônToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.thêmMônToolStripMenuItem1.Text = "Thêm môn";
            this.thêmMônToolStripMenuItem1.Click += new System.EventHandler(this.thêmMônToolStripMenuItem1_Click);
            // 
            // xóaMônToolStripMenuItem
            // 
            this.xóaMônToolStripMenuItem.Name = "xóaMônToolStripMenuItem";
            this.xóaMônToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.xóaMônToolStripMenuItem.Text = "Xóa môn";
            this.xóaMônToolStripMenuItem.Click += new System.EventHandler(this.xóaMônToolStripMenuItem_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(334, 339);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 35);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(453, 339);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(578, 339);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(109, 35);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(719, 339);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 35);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lvDanhSach
            // 
            this.lvDanhSach.CheckBoxes = true;
            this.lvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cMSSV,
            this.cHo,
            this.cTen,
            this.cSinh,
            this.cLop,
            this.cCM,
            this.cSDT,
            this.cDiaChi});
            this.lvDanhSach.ContextMenuStrip = this.contextMenuStrip1;
            this.lvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSach.FullRowSelect = true;
            this.lvDanhSach.GridLines = true;
            this.lvDanhSach.HideSelection = false;
            this.lvDanhSach.Location = new System.Drawing.Point(3, 19);
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new System.Drawing.Size(916, 247);
            this.lvDanhSach.TabIndex = 0;
            this.lvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lvDanhSach.View = System.Windows.Forms.View.Details;
            this.lvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lvDanhSach_SelectedIndexChanged);
            // 
            // cMSSV
            // 
            this.cMSSV.Text = "MSSV";
            // 
            // cHo
            // 
            this.cHo.Text = "Họ và tên lót";
            this.cHo.Width = 100;
            // 
            // cTen
            // 
            this.cTen.Text = "Tên";
            // 
            // cSinh
            // 
            this.cSinh.Text = "Ngày sinh";
            this.cSinh.Width = 100;
            // 
            // cLop
            // 
            this.cLop.Text = "Lớp";
            // 
            // cCM
            // 
            this.cCM.Text = "Số CMND";
            this.cCM.Width = 120;
            // 
            // cSDT
            // 
            this.cSDT.Text = "Số điện thoại";
            this.cSDT.Width = 100;
            // 
            // cDiaChi
            // 
            this.cDiaChi.Text = "Địa chỉ liên lạc";
            this.cDiaChi.Width = 150;
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Controls.Add(this.lvDanhSach);
            this.gbDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDanhSach.Location = new System.Drawing.Point(0, 454);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(922, 269);
            this.gbDanhSach.TabIndex = 12;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách sinh viên";
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(719, 37);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(112, 28);
            this.btnMacDinh.TabIndex = 13;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 723);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.clbMonhoc);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.dtpNSinh);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.mtbSDT);
            this.Controls.Add(this.mtbCMND);
            this.Controls.Add(this.mtbMSSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.gbDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xoaSVToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbMSSV;
        private System.Windows.Forms.MaskedTextBox mtbCMND;
        private System.Windows.Forms.MaskedTextBox mtbSDT;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.DateTimePicker dtpNSinh;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.CheckedListBox clbMonhoc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvDanhSach;
        private System.Windows.Forms.ColumnHeader cMSSV;
        private System.Windows.Forms.ColumnHeader cHo;
        private System.Windows.Forms.ColumnHeader cTen;
        private System.Windows.Forms.ColumnHeader cSinh;
        private System.Windows.Forms.ColumnHeader cLop;
        private System.Windows.Forms.ColumnHeader cCM;
        private System.Windows.Forms.ColumnHeader cSDT;
        private System.Windows.Forms.ColumnHeader cDiaChi;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmMônToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xóaMônToolStripMenuItem;
    }
}

