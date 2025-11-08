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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        string conn = "server=TUNN\\ANHTUAN; database=Restaurant_Management; Integrated Security = True";

        public bool check()
        {
            if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtType.Text))
                return false;
            else
                return true;
        }
        private void Display(SqlDataReader reader)
        {
            lvCategory.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
                lvCategory.Items.Add(item);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                reset();
                string query = "SELECT * FROM Category";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                this.Display(reader);
                sqlConnection.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                SqlCommand cmd = sqlConnection.CreateCommand();
                if(check() == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }    

                cmd.CommandText = "insert into Category (Name, Type) values (@name, @type)";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@type", txtType.Text == "Thức uống" ? 0 : 1);

                sqlConnection.Open();
                int numOfRows = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (numOfRows == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    btnLoad.PerformClick();

                    txtName.Text = "";
                    txtType.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];

            txtID.Text = item.SubItems[0].Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        public void reset()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            check();

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "UPDATE Category SET Name = @name, Type = @type where ID = @id";

            sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@type", txtType.Text == "Thức uống" ? 0 : 1);
            sqlCommand.Parameters.AddWithValue("@id", txtID.Text);

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            if (numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;

                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
            sqlConnection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "DELETE FROM Category WHERE ID = @id";
            sqlCommand.Parameters.AddWithValue("@id", txtID.Text);

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);

                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Xóa nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                string query = "SELECT * FROM Category";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                this.Display(reader);
                sqlConnection.Close();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if(lvCategory.SelectedItems.Count > 0)
            {
                btnDelete.PerformClick();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhóm món ăn để xóa!");
            }
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                FoodForm foodForm = new FoodForm();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtID.Text));
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
