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
    public partial class ListRole : Form
    {
        public ListRole()
        {
            InitializeComponent();
        }
        public void DisplayRole(DataRowView rowview)
        {
            try
            {
                txtName.Text = rowview["AccountName"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị thông tin vai trò: " + ex.Message, "Lỗi");
            }
        }
        public void LoadRole()
        {
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select RoleName, Path, Notes from Rolee";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                con.Open();
                adapter.Fill(table);
                dgvListRole.DataSource = table;
                con.Close();
                con.Dispose();
            }
        }

        private void ListRole_Load(object sender, EventArgs e)
        {
            LoadRole();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRole addRole = new AddRole();
            addRole.EnabledbtnUpdate();
            addRole.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddRole roleForm = new AddRole();
            roleForm.EnabledbtnAdd();
            if (dgvListRole.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvListRole.SelectedRows[0];
                DataRowView rowview = selectedRow.DataBoundItem as DataRowView;

                
                roleForm.Show();
                //Lấy dữ liệu từ dòng được chọn
                roleForm.DisplayRole(rowview);
            }
        }

        private void CheckAssignedRoles()
        {
            if (string.IsNullOrEmpty(txtName.Text)) return;

            // Get assigned roles for this account
            List<string> assignedRoles = new List<string>();
            using (var conn = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                string query = "SELECT RoleName FROM Rolee, RoleAccount WHERE RoleID = ID and AccountName = @AccountName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", txtName.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    assignedRoles.Add(reader["RoleName"].ToString());
                }
                conn.Close();
            }

            // Set checkbox to true if role is assigned
            foreach (DataGridViewRow row in dgvListRole.Rows)
            {
                if (row.Cells["RoleName"].Value != null)
                {
                    string roleName = row.Cells["RoleName"].Value.ToString();
                    row.Cells["Check"].Value = assignedRoles.Contains(roleName);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CheckAssignedRoles();
        }
    }
}
