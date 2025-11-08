namespace Lab_Advanced_Command
{
    partial class OrdersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpThongKe = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblGiam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblChuaGiam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbNgay = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayMax = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMin = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbNgay.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpThongKe);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblDoanhThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(950, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 645);
            this.panel1.TabIndex = 9;
            // 
            // dtpThongKe
            // 
            this.dtpThongKe.CustomFormat = "dd/MM/yyyy";
            this.dtpThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThongKe.Location = new System.Drawing.Point(51, 223);
            this.dtpThongKe.Name = "dtpThongKe";
            this.dtpThongKe.Size = new System.Drawing.Size(160, 26);
            this.dtpThongKe.TabIndex = 1;
            this.dtpThongKe.ValueChanged += new System.EventHandler(this.dtpThongKe_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "DOANH THU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chọn ngày";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(48, 437);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 20);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Doanh thu trong ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tổng số hóa đơn";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(48, 342);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(13, 20);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = ".";
            // 
            // lblGiam
            // 
            this.lblGiam.AutoSize = true;
            this.lblGiam.Location = new System.Drawing.Point(688, 131);
            this.lblGiam.Name = "lblGiam";
            this.lblGiam.Size = new System.Drawing.Size(13, 20);
            this.lblGiam.TabIndex = 5;
            this.lblGiam.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiền giảm giá";
            // 
            // lblChuaGiam
            // 
            this.lblChuaGiam.AutoSize = true;
            this.lblChuaGiam.Location = new System.Drawing.Point(688, 89);
            this.lblChuaGiam.Name = "lblChuaGiam";
            this.lblChuaGiam.Size = new System.Drawing.Size(13, 20);
            this.lblChuaGiam.TabIndex = 7;
            this.lblChuaGiam.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng tiền chưa giảm";
            // 
            // gbNgay
            // 
            this.gbNgay.Controls.Add(this.btnLoc);
            this.gbNgay.Controls.Add(this.label2);
            this.gbNgay.Controls.Add(this.label1);
            this.gbNgay.Controls.Add(this.dtpNgayMax);
            this.gbNgay.Controls.Add(this.dtpNgayMin);
            this.gbNgay.Location = new System.Drawing.Point(51, 55);
            this.gbNgay.Name = "gbNgay";
            this.gbNgay.Size = new System.Drawing.Size(352, 194);
            this.gbNgay.TabIndex = 4;
            this.gbNgay.TabStop = false;
            this.gbNgay.Text = "Lọc";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(217, 74);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(109, 54);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Tìm";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // dtpNgayMax
            // 
            this.dtpNgayMax.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMax.Location = new System.Drawing.Point(23, 148);
            this.dtpNgayMax.Name = "dtpNgayMax";
            this.dtpNgayMax.Size = new System.Drawing.Size(160, 26);
            this.dtpNgayMax.TabIndex = 1;
            // 
            // dtpNgayMin
            // 
            this.dtpNgayMin.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMin.Location = new System.Drawing.Point(23, 71);
            this.dtpNgayMin.Name = "dtpNgayMin";
            this.dtpNgayMin.Size = new System.Drawing.Size(160, 26);
            this.dtpNgayMin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 351);
            this.panel2.TabIndex = 10;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(950, 351);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellDoubleClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(531, 199);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 38);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Mặc định";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(658, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 38);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 645);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGiam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblChuaGiam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbNgay);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbNgay.ResumeLayout(false);
            this.gbNgay.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpThongKe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblGiam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblChuaGiam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbNgay;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayMax;
        private System.Windows.Forms.DateTimePicker dtpNgayMin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
    }
}