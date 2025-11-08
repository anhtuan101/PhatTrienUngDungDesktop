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

namespace Lab_Advanced_Command
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }
        //Name, TableID, Status, CheckoutDate, Account, Amount
        public void LoadOrder()
        {
            SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT ID, Name, TableID, CASE WHEN Status = 1 THEN N'Đã thanh toán' ELSE N'Chưa thanh toán' END AS Status,CheckoutDate, Account, Amount FROM Bills"; 

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet table = new DataSet();
            con.Open();
            adapter.Fill(table);
            dgvDanhSach.DataSource = table.Tables[0];
            con.Close();
            con.Dispose();

        }

        private void TongDoanhThu()
        {
            Decimal tong = 0;
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select sum(Amount + (Amount*Tax/100)) from Bills";

                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    tong = Convert.ToDecimal(result);
                con.Close();
                con.Dispose();
            }   
            lblChuaGiam.Text =tong.ToString();
        }

        private void TongDaGiam()
        {
            Decimal tong = 0;
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select sum(Amount * Discount / 100) from Bills";

                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    tong = Convert.ToDecimal(result);
                con.Close();
                con.Dispose();
            }
            lblGiam.Text = tong.ToString();
        }

        private void TongDTNgay()
        {
            Decimal tong = 0;
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select sum(Amount + (Amount*Tax/100) - (Amount * Discount / 100)) from Bills where CheckoutDate = @ngay";
                cmd.Parameters.AddWithValue("@ngay", dtpThongKe.Value.Date);

                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    tong = Convert.ToDecimal(result);
                con.Close();
                con.Dispose();
            }
            lblDoanhThu.Text = tong.ToString();
        }

        private void TongHoaDon()
        {
            Decimal tong = 0;
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select count(ID) from Bills where CheckoutDate = @ngay";
                cmd.Parameters.AddWithValue("@ngay", dtpThongKe.Value.Date);

                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    tong = Convert.ToDecimal(result);
                con.Close();
                con.Dispose();
            }
            lblCount.Text = tong.ToString();
        }


        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrder();
            TongDoanhThu();
            TongDaGiam();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT ID, Name, TableID, CASE WHEN Status = 1 THEN N'Đã thanh toán' ELSE N'Chưa thanh toán' END AS Status,CheckoutDate, Account, Amount FROM Bills WHERE CheckoutDate BETWEEN @nMin AND @nMax";
            cmd.Parameters.AddWithValue("@nMin", dtpNgayMin.Value);
            cmd.Parameters.AddWithValue("@nMax", dtpNgayMax.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet table = new DataSet();
            con.Open();
            adapter.Fill(table);
            con.Close();
            con.Dispose();
            dgvDanhSach.DataSource = table.Tables[0];
        }

        private void dtpThongKe_ValueChanged(object sender, EventArgs e)
        {
            TongDTNgay();
            TongHoaDon();
        }

        private void dgvDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int billID = Convert.ToInt32(dgvDanhSach.Rows[0].Cells[0].Value);
            //int foodid = Convert.ToInt32(dgvFood.Rows[0].Cells[0].Value);
            // Mở form chi tiết và truyền ID sang
            OrderDetailsForm form = new OrderDetailsForm(billID);
            form.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
