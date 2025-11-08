using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Lab_Advanced_Command
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Server = TUNN\\ANHTUAN ; database = Restaurant_Management ; Integrated security=true;");

        private void LoadCategoy()
        {
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "select ID, Name from Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            con.Open();

            adapter.Fill(table);

            con.Close();
            con.Dispose();

            cbbCategory.DataSource = table;

            cbbCategory.DisplayMember = "Name";

            cbbCategory.ValueMember = "ID";
        }
        private void FoodForm_Load(object sender, EventArgs e)
        {
            LoadCategoy();
        }

        private DataTable foodTable;

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;

            string connectionString = "server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

            // Truyền tham số
            cmd.Parameters.Add("@categoryId", SqlDbType.Int);

            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
            }

            // Tạo bộ điều phối dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable foodTable = new DataTable();

            // Mở kết nối
            conn.Open();

            // Đẩy dữ liệu từ csdl đưa vào DataTable
            adapter.Fill(foodTable);

            // Đóng kết nối và giải phóng bộ nhớ
            conn.Close();

            // Đưa dữ liệu vào điều khiển datagridview
            dgvListFood.DataSource = foodTable;

            // Tính số lượng món ăn
            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = "server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

            // Lấy dòng tin sản phẩm được chọn
            if (dgvListFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListFood.SelectedRows[0];

                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                // Truyền tham số
                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];

                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                // Mở kết nối csdl
                conn.Open();

                // Thực thi truy vấn và lấy dữ liệu từ tham số
                cmd.ExecuteNonQuery();

                string result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);

                // Đóng kết nối csdl
                conn.Close();

                cmd.Dispose();
                conn.Dispose();
            }
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodInfoForm = new FoodInfoForm();
            foodInfoForm.FormClosed += new FormClosedEventHandler(FoodForm_FormClosed);

            foodInfoForm.Show(this);
        }

        void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if(dgvListFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListFood.SelectedRows[0];
                DataRowView rowview = selectedRow.DataBoundItem as DataRowView;

                FoodInfoForm foodForm = new FoodInfoForm();

                foodForm.FormClosed += new FormClosedEventHandler(FoodForm_FormClosed);
                foodForm.Show(this);
                //Lấy dữ liệu từ dòng được chọn
                foodForm.DisplayFoodInfo(rowview);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server = TUNN\\ANHTUAN ; database = Restaurant_Management ; Integrated security=true;");

            string query = "SELECT * FROM Food WHERE Name LIKE '%" + txtSearchByName.Text + "%' ORDER BY Price DESC";

            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            con.Close();
            con.Dispose();

            dgvListFood.DataSource = table;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
        }
    }
}
