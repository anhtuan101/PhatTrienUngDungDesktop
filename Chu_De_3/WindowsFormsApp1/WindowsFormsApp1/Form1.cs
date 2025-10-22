using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void WriteReadText(string filename)
        {
            lvDanhSach.Items.Clear();
            foreach (var item in File.ReadAllLines(filename))
            {
                var s = item.Split('\t');

                if (s.Length >= 9)
                {
                    ListViewItem lvi = new ListViewItem(s[0]);
                    lvi.SubItems.Add(s[1]);
                    lvi.SubItems.Add(s[2]);
                    lvi.SubItems.Add(s[3]);
                    lvi.SubItems.Add(s[4]);
                    lvi.SubItems.Add(s[5]);
                    lvi.SubItems.Add(s[6]);
                    lvi.SubItems.Add(s[7]);
                    lvi.Tag = s[8];
                    lvDanhSach.Items.Add(lvi);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WriteReadText("Students.txt");
        }

        public void SaveFile(string filename)
        {
            using (StreamWriter raeder = new StreamWriter(filename, false))
            {
                foreach (ListViewItem item in lvDanhSach.Items)
                {
                    string masv = item.SubItems[0].Text;
                    string ho = item.SubItems[1].Text;
                    string ten = item.SubItems[2].Text;
                    string ngaysinh = item.SubItems[3].Text;
                    string lop = item.SubItems[4].Text;
                    string cmnd = item.SubItems[5].Text;
                    string sdt = item.SubItems[6].Text;
                    string diachi = item.SubItems[7].Text;
                    string gioitinh = item.Tag.ToString();

                    string line = string.Join("\t", masv, ho, ten, ngaysinh, lop, cmnd, sdt, diachi, gioitinh);
                    raeder.WriteLine(line);
                }
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraSL())
                return;
            string masv = mtbMSSV.Text;
            string ten = tbTen.Text;
            string ho = tbHoTen.Text;
            DateTime ngaysinh = dtpNSinh.Value;
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string lop = cbLop.Text;
            string cmnd = mtbCMND.Text;
            string sdt = mtbSDT.Text;
            string diachi = tbDiaChi.Text;

            ListViewItem lv = new ListViewItem(masv);

            lv.SubItems.Add(ho);
            lv.SubItems.Add(ten);
            lv.SubItems.Add(ngaysinh.ToShortDateString());
            lv.SubItems.Add(lop);
            lv.SubItems.Add(cmnd);
            lv.SubItems.Add(sdt);
            lv.SubItems.Add(diachi);
            lv.Tag = gioitinh;

            lvDanhSach.Items.Add(lv);

            SaveFile("Students.txt");
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSach.SelectedItems[0];
                mtbMSSV.Text = item.SubItems[0].Text;
                tbHoTen.Text = item.SubItems[1].Text;
                tbTen.Text = item.SubItems[2].Text;
                dtpNSinh.Value = DateTime.Parse(item.SubItems[3].Text);
                cbLop.Text = item.SubItems[4].Text;
                mtbCMND.Text = item.SubItems[5].Text;
                mtbSDT.Text = item.SubItems[6].Text;
                tbDiaChi.Text = item.SubItems[7].Text;
                if (item.Tag.ToString() == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                btnThem.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!KiemTraSL())
                    return;
                ListViewItem item = lvDanhSach.SelectedItems[0];
                item.SubItems[0].Text = mtbMSSV.Text;
                item.SubItems[1].Text = tbHoTen.Text;
                item.SubItems[2].Text = tbTen.Text;
                item.SubItems[3].Text = dtpNSinh.Value.ToShortDateString();
                item.SubItems[4].Text = cbLop.Text;
                item.SubItems[5].Text = mtbCMND.Text;
                item.SubItems[6].Text = mtbSDT.Text;
                item.SubItems[7].Text = tbDiaChi.Text;
                item.Tag = rdNam.Checked ? "Nam" : "Nữ";

                SaveFile("Students.txt");
                reset();
            }

        }

        public bool KiemTraSL()
        {
            if (!mtbMSSV.MaskCompleted)
            {
                MessageBox.Show("MSSV phải đủ 7 số và không được bỏ trống");
                return false;
            }
            if (!mtbCMND.MaskCompleted)
            {
                MessageBox.Show("CMND phải đủ 9 số và không được bỏ trống");
                return false;
            }
            if (!mtbSDT.MaskCompleted)
            {
                MessageBox.Show("SDT phải đủ 10 số và không được bỏ trống");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbHoTen.Text) || string.IsNullOrWhiteSpace(tbTen.Text) || string.IsNullOrWhiteSpace(cbLop.Text) || string.IsNullOrWhiteSpace(tbDiaChi.Text) )
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
                return false;
            }
            return true;
        }

        public void reset()
        {
            mtbMSSV.Clear();
            tbHoTen.Clear();
            tbTen.Clear();
            dtpNSinh.Value = DateTime.Now;
            cbLop.SelectedIndex = -1;
            mtbCMND.Clear();
            mtbSDT.Clear();
            tbDiaChi.Clear();
            rdNam.Checked = true;
            btnThem.Enabled = true;
            WriteReadText("Students.txt");
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void thêmMônToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new MonHoc();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                clbMonhoc.Items.Add(frm.NewSubjectName);
            }
        }

        private void xóaMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clbMonhoc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất 1 môn học để xóa");
                return;
            }
            else
            {
                while (clbMonhoc.SelectedItems.Count > 0)
                {
                    clbMonhoc.Items.Remove(clbMonhoc.SelectedItems[0]);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            using (DieukienChon f = new DieukienChon())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string loai = f.TimTheo;
                    string giatri = f.DuLieu.ToLower();

                    List<ListViewItem> ketQua = new List<ListViewItem>();

                    foreach (ListViewItem item in lvDanhSach.Items)
                    {
                        bool match = false;

                        if (loai == "MSSV" && item.SubItems[0].Text.ToLower().Contains(giatri))
                            match = true;
                        else if (loai == "Tên" && item.SubItems[2].Text.ToLower().Contains(giatri))
                            match = true;
                        else if (loai == "Lớp" && item.SubItems[4].Text.ToLower().Contains(giatri))
                            match = true;

                        if (match)
                        {

                            ketQua.Add((ListViewItem)item.Clone());
                        }
                    }

                    if (ketQua.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên nào phù hợp!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lvDanhSach.Items.Clear();
                        lvDanhSach.Items.AddRange(ketQua.ToArray());
                    }
                }
            }
        }

        private void xoaSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất 1 môn học để xóa");
                return;
            }
            else
            {
                while (lvDanhSach.SelectedItems.Count > 0)
                {
                    lvDanhSach.Items.Remove(lvDanhSach.SelectedItems[0]);
                    SaveFile("Students.txt");
                    reset();
                }
            }
        }

        

    }
}
