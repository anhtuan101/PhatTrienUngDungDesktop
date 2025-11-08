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
using System.Xml.Linq;

namespace _2300003_NguyenLeAnhTuan_ChuDe4
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        string query = "server=TUNN\\ANHTUAN; database=Restaurant_Management; Integrated Security = True";
        public void LoadFood(int categoryID)
        {
            SqlConnection con = new SqlConnection(query);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = con.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "SELECT Name FROM Category where ID = " + categoryID;

            // Mở kết nối tới cơ sở dữ liệu
            con.Open();

            // Gán tên nhóm sản phẩm cho tiêu đề
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

            // Tạo đối tượng DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            // Tạo DataTable để chứa dữ liệu
            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            // Hiển thị danh sách món ăn lên Form
            dgvFood.DataSource = dt;

            // Đóng kết nối và giải phóng bộ nhớ
            con.Close();
            con.Dispose();
            da.Dispose();
        }

        public void ThemMoi()
        {
            SqlConnection connection = new SqlConnection(query);

            foreach (DataGridViewRow row in dgvFood.SelectedRows)
            {

                int id = Convert.ToInt32(row.Cells[0].Value);
                string name = row.Cells[1].Value.ToString();
                string unit = row.Cells[2].Value.ToString();
                int foodCategoryID = Convert.ToInt32(row.Cells[3].Value);
                int price = row.Cells[4].Value == DBNull.Value ? 0 : int.Parse(row.Cells[4].Value.ToString());
                string notes = row.Cells[5].Value.ToString();

                SqlCommand sqlCommand = connection.CreateCommand();

                sqlCommand.CommandText = "exec InsertFood " + id + ", N'" + name + "', N'" + unit + "', " + foodCategoryID + ", " + price + ", N'" + notes + "'";

                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                DataTable dt = new DataTable("InsertFood");
                da.Fill(dt);

                dgvFood.DataSource = dt;

                connection.Close();
                connection.Dispose();
                da.Dispose();

                LoadFood(foodCategoryID);
            }
        }
        public void CapNhat()
        {
            SqlConnection connection = new SqlConnection(query);

            foreach (DataGridViewRow row in dgvFood.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                string name = row.Cells[1].Value.ToString();
                string unit = row.Cells[2].Value.ToString();
                float price = float.Parse(row.Cells[4].Value.ToString());
                int foodCategoryID = Convert.ToInt32(row.Cells[3].Value);
                string notes = row.Cells[5].Value.ToString();

                SqlCommand sqlCommand = connection.CreateCommand();

                sqlCommand.CommandText = "exec Food_Update " + id + ", N'" + name + "', N'" + unit + "', " + foodCategoryID + ", " + price + ", N'" + notes + "'";

                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                DataTable dt = new DataTable("Food_Update");
                da.Fill(dt);

                dgvFood.DataSource = dt;

                connection.Close();
                connection.Dispose();
                da.Dispose();

                LoadFood(foodCategoryID);


            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFood.SelectedRows)
            {
                if (row.Cells[0].Value == "0")
                {
                    MessageBox.Show("Vui lòng chọn món ăn để lưu!");
                    return;
                }
                int id = Convert.ToInt32(row.Cells[0].Value);
                if (id == 0)
                {
                    ThemMoi();
                    MessageBox.Show("Thêm món thành công!");
                }
                else
                {
                    CapNhat();
                    MessageBox.Show("Cập nhật món thành công!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(query);

            string kq = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (kq == "Yes")
            {
                if (dgvFood.SelectedRows.Count > 0)
                {
                    int foodid = Convert.ToInt32(dgvFood.Rows[0].Cells[0].Value);

                    SqlCommand cmdCN = con.CreateCommand();
                    con.Open();
                    cmdCN.CommandText = "update BillDetails set FoodID = null where FoodID = @id";
                    cmdCN.Parameters.AddWithValue("@id", foodid);
                    cmdCN.ExecuteNonQuery();

                    SqlCommand cmdXoa = con.CreateCommand();
                    cmdXoa.CommandText = "DELETE FROM Food WHERE ID = @id";
                    cmdXoa.Parameters.AddWithValue("@id", foodid);


                    int num = cmdXoa.ExecuteNonQuery();

                    if (num == 1)
                    {
                        MessageBox.Show("Xóa món ăn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
                    }
                    con.Close();
                    con.Dispose();
                }    
                else
                {
                    MessageBox.Show("Vui lòng chọn món ăn!");
                }    
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            LoadFood(1);
        }
    }
}
