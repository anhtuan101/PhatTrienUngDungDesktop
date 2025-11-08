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
    public partial class BillsForm : Form
    {
        public BillsForm(int tableId)
        {
            InitializeComponent();
            LoadBillsByTable(tableId);
        }
        string conn = "server=TUNN\\ANHTUAN; database=Restaurant_Management; Integrated Security = True";

        public void LoadBillsForm()
        {
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Bills";
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Bills");
            da.Fill(dt);
            dgvBills.DataSource = dt;
            connection.Close();
            connection.Dispose();
        }
        public void LoadBillsByTable(int tableId)
        {
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Bills where TableID = @TableID";
            cmd.Parameters.AddWithValue("@TableID", tableId);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Bills");
            da.Fill(dt);
            dgvBills.DataSource = dt;
            connection.Close();
            connection.Dispose();
        }
        public void TimTheoNgay()
        {
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay = dtpDenNgay.Value;
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Bills where CheckoutDate between CAST(N'" + tuNgay + "' AS SmallDateTime) and CAST(N'" + denNgay + "' AS SmallDateTime)";
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Bills");
            da.Fill(dt);
            dgvBills.DataSource = dt;
            connection.Close();
            connection.Dispose();
        }
        private void TongDoanhThu()
        {
            Decimal tong = 0;
            SqlConnection connection = new SqlConnection(conn);
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select sum(Amount + (Amount*Tax/100)) from Bills";

                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    tong = Convert.ToDecimal(result);
                connection.Close();
                connection.Dispose();
            }
            lblChuaGiam.Text = tong.ToString();
        }

        private void TongDaGiam()
        {
            Decimal tong = 0;
            SqlConnection connection = new SqlConnection(conn);
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select sum(Amount * Discount / 100) from Bills";

                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    tong = Convert.ToDecimal(result);
                connection.Close();
                connection.Dispose();
            }
            lblGiam.Text = tong.ToString();
        }

        private void btnTai_Click(object sender, EventArgs e)
        {
            LoadBillsForm();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimTheoNgay();
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID hóa đơn từ dòng được chọn
                int billID = Convert.ToInt32(dgvBills.Rows[e.RowIndex].Cells["ID"].Value);

                // Tạo form chi tiết hóa đơn
                BillDetailsForm frm = new BillDetailsForm(billID);

                // Hiển thị form dưới dạng dialog
                frm.ShowDialog();
            }
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            LoadBillsForm();
            TongDoanhThu();
            TongDaGiam();
        }
    }
}
