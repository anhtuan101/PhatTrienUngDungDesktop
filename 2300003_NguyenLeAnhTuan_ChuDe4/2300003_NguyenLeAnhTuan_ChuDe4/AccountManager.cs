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
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }
        string conn = "server=TUNN\\ANHTUAN; database=Restaurant_Management; Integrated Security = True";

        public void LoadAccountData()
        {

            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Select A.*, B.Actived from Account A, RoleAccount B where A.AccountName = B.AccountName";
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dgvAccount.DataSource = ds;
            connection.Close();
            connection.Dispose();
        }

        public void LoadNhom()
        {
            cbNhom.Items.Clear();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Select ID, RoleName from Rolee";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            connection.Open();
            da.Fill(dt);
            connection.Close();
            connection.Dispose();
            cbNhom.DataSource = dt;
            cbNhom.DisplayMember = "RoleName";
            cbNhom.ValueMember = "ID";
        }
        private void AccountManager_Load(object sender, EventArgs e)
        {
            LoadNhom();
            LoadAccountData();
        }

        public void TimTheoTrangThai()
        {
            var tt = "";
            SqlConnection sqlConnection = new SqlConnection(conn);
            SqlCommand cmd = sqlConnection.CreateCommand();
            if (rdActive.Checked)
            {
                tt = "1";
            }
            else if (rdInactive.Checked)
            {
                tt = "0";
            }
            cmd.CommandText = "Select Account.AccountName, Password, FullName, Email, Tell, DateCreated, Actived from Account, RoleAccount where Account.AccountName = RoleAccount.AccountName and Actived = " + tt;
            DataTable dt = new DataTable("Account");
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            sqlConnection.Open();
            da.Fill(dt);

            sqlConnection.Close();
            sqlConnection.Dispose();

            dgvAccount.DataSource = dt;

        }
        public void TimTheoNhom()
        {
            string timNhom = cbNhom.Text;
            SqlConnection connection = new SqlConnection(conn);
            string query = "select c.AccountName, c.Password, c.FullName, c.Email, c.Tell, c.DateCreated, a.Actived from RoleAccount a, Rolee b, Account c  where a.RoleID = b.ID and a.AccountName = c.AccountName and b.RoleName = @Notes";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Notes", timNhom);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAccount.DataSource = dt;
                connection.Close();
                connection.Dispose();
            }
        }

        private void btnTai_Click(object sender, EventArgs e)
        {
            LoadAccountData();
            rdActive.Checked = false;
            rdInactive.Checked = false;
            cbNhom.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdActive.Checked || rdInactive.Checked)
            {
                TimTheoTrangThai();
            }
            else
            {
                TimTheoNhom();
            }
        }
        private void SetAccountInactive(string accountName)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "UPDATE RoleAccount SET Actived = 0 WHERE AccountName = @AccountName";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AccountName", accountName);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void ShowAccountRoles(string accountName)
        {
            // You can implement a new form to show roles, for now just show a MessageBox
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "select a.* from Rolee a, RoleAccount b where a.ID = b.RoleID and b.AccountName = @AccountName";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AccountName", accountName);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();
                while (reader.Read())
                {
                    sb.AppendLine(reader["RoleName"].ToString());
                }
                connection.Close();
                MessageBox.Show(sb.Length > 0 ? sb.ToString() : "Không có vai trò nào.", "Danh sách vai trò");
            }
        }

        public void InsertAccount(string accName, string password, string fullName, string email, string tell, DateTime dateCreated)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("Account_Insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", accName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@fullname", fullName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@tell", tell);
                cmd.Parameters.AddWithValue("@datecreated", dateCreated);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateAccount(string accName, string password, string fullName, string email, string tell, DateTime dateCreated)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("Account_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountName", accName);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Tell", tell);
                cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void ResetPassword(string accName, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("Account_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountName", accName);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@FullName", DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                cmd.Parameters.AddWithValue("@Tell", DBNull.Value);
                cmd.Parameters.AddWithValue("@DateCreated", DBNull.Value);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAccount.SelectedRows)
            {
                string accName = row.Cells[0].ToString();
                string pass = row.Cells[1].ToString();
                string hoTen = row.Cells[2].ToString();
                string email = row.Cells[3].ToString();
                string sdt = row.Cells[4].Value.ToString();
                object dateValue = row.Cells[5].Value;
                DateTime mgayTao;
                if (dateValue == null || !DateTime.TryParse(dateValue.ToString(), out mgayTao))
                {
                    // Handle invalid date (set default, skip, or show error)
                    mgayTao = DateTime.Now; // or continue;
                }
                //int maVaiTro = Convert.ToInt32(row.Cells[6].Value.ToString());
                //int tt = Convert.ToInt32(row.Cells[7].Value.ToString());
                //string ghiChu = row.Cells[8].Value.ToString();
                if (row.Cells[0].Selected)
                {
                    MessageBox.Show("Vui lòng chọn món ăn để lưu!");
                    return;
                }
                if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    UpdateAccount(accName, pass, hoTen, email, sdt, mgayTao);

                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    InsertAccount(accName, pass, hoTen, email, sdt, mgayTao);

                    MessageBox.Show("Thêm món thành công!");
                }
            }
        }

        private void tsmXoaAcc_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                var accName = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
                SetAccountInactive(accName);
                LoadAccountData();
            }
        }

        private void tsmXem_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                var accName = dgvAccount.SelectedRows[0].Cells[0].Value.ToString();
                ShowAccountRoles(accName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
