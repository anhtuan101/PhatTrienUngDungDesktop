using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2300003_NguyenLeAnhTuan_ChuDe4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string conn = "server=TUNN\\ANHTUAN; database=Restaurant_Management; Integrated Security = True";

        private void LoadBan()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "SELECT * FROM Ban";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                connection.Open();
                da.Fill(dt);
                connection.Close();
                connection.Dispose();
                dgvBan.DataSource = dt;
            }
        }

        public void ThemBan(int id, string name, int status, int capacity)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("Ban_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Capacity", capacity);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Cập nhật bàn
        public void CapNhatBan(int id, string name, int status, int capacity)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("Ban_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Capacity", capacity);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Xóa bàn
        public void XoaBan(int id)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("Ban_Delete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn để lưu!");
                return;
            }

            DataGridViewRow row = dgvBan.SelectedRows[0];

            // Lấy dữ liệu từ dòng được chọn
            int maBan = Convert.ToInt32(row.Cells[0].Value);
            string tenBan = row.Cells[1].Value?.ToString() ?? "";
            int trangThai = Convert.ToInt32(row.Cells[2].Value);
            int soGhe = Convert.ToInt32(row.Cells[3].Value);

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(tenBan))
            {
                MessageBox.Show("Tên bàn không được để trống!");
                return;
            }

            // Nếu ID = 0 => thêm mới, ngược lại => cập nhật
            if (maBan == 0)
            {
                ThemBan(maBan, tenBan, trangThai, soGhe);
                MessageBox.Show("Thêm bàn thành công!");
            }
            else
            {
                CapNhatBan(maBan, tenBan, trangThai, soGhe);
                MessageBox.Show("Cập nhật bàn thành công!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void tsmXoa_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvBan.SelectedRows[0].Cells[0].Value);
                XoaBan(id);
                LoadBan();
            }
        }

        private void tsmDanhMuc_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvBan.SelectedRows[0].Cells[0].Value);
                // Hiển thị form danh mục hóa đơn cho bàn này
                BillsForm billsForm = new BillsForm(id);
                billsForm.ShowDialog();
            }
        }

        private void tsmNhatKy_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvBan.SelectedRows[0].Cells[0].Value);
                // Hiển thị form nhật ký hóa đơn cho bàn này
                BillDetailsForm logForm = new BillDetailsForm(id);
                logForm.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
