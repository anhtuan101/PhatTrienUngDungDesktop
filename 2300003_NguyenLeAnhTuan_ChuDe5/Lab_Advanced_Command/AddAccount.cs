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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void InitValues()
        {
            string connectionString = "server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;";
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "select ID, RoleName from Rolee";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet table = new DataSet();

            con.Open();

            adapter.Fill(table, "Rolee");

            cbbRoleName.DataSource = table.Tables[0];

            cbbRoleName.DisplayMember = "RoleName";

            cbbRoleName.ValueMember = "ID";

            con.Close();
            con.Dispose();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddRole addRole = new AddRole();
            addRole.EnabledbtnUpdate();
            if (addRole.ShowDialog() == DialogResult.OK)
            {
                this.InitValues();
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "exec Insert_Account @name = @Name, @pass = null, @full = @Full, @role = @Role, @email = @mail, @tell = @sdt, @ngay = @Ngay, @note = @Note";

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Full", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Role", cbbRoleName.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@sdt", txtTell.Text);
                cmd.Parameters.AddWithValue("@Ngay", dtpNgayTao.Value);
                cmd.Parameters.AddWithValue("@Note", rtbNote.Text);
                con.Open();
                int num = cmd.ExecuteNonQuery();
                DialogResult kq = MessageBox.Show("Thêm tài khoản thành công. Bạn có muốn thêm tiếp?", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    txtName.ResetText();
                    txtFullName.ResetText();
                    txtEmail.ResetText();
                    txtTell.ResetText();
                    rtbNote.ResetText();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                //if (num == 1)
                //{
                //    DialogResult kq = MessageBox.Show("Thêm tài khoản thành công. Bạn có muốn thêm tiếp?", "Thông báo", MessageBoxButtons.YesNo);
                //    if (kq == DialogResult.Yes)
                //    {
                //        txtName.ResetText();
                //        txtFullName.ResetText();
                //        txtEmail.ResetText();
                //        txtTell.ResetText();
                //        rtbNote.ResetText();
                //    }
                //    else
                //    {
                //        this.DialogResult = DialogResult.OK;
                //        this.Close();
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Thêm tài khoản thất bại!");
                //}
                con.Close();
                con.Dispose();
            }    
        }

        public void DisplayAccount(DataRowView rowview)
        {
            try
            {
                txtName.Text = rowview["AccountName"].ToString();
                txtFullName.Text = rowview["FullName"].ToString();
                txtEmail.Text = rowview["Email"].ToString();
                txtTell.Text = rowview["Tell"].ToString();
                dtpNgayTao.Value = Convert.ToDateTime(rowview["DateCreated"].ToString());

               
                using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select l.RoleName, l.Notes from RoleAccount r, Rolee l where r.RoleID = l.ID and r.AccountName = @accName";
                    cmd.Parameters.AddWithValue("@accName", rowview["AccountName"].ToString());
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string roleName = reader["RoleName"].ToString();
                        cbbRoleName.SelectedIndex = cbbRoleName.FindStringExact(roleName);
                        string note = reader["Notes"].ToString();
                        rtbNote.Text = note;
                    }
                    con.Close();
                    con.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "exec Update_Account @name = @Name, @full = @Full, @role = @Role, @email = @mail, @tell = @sdt, @note = @Note";
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Full", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Role", cbbRoleName.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@sdt", txtTell.Text);
                cmd.Parameters.AddWithValue("@Note", rtbNote.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo");
                con.Close();
                con.Dispose();
            }
        }

        private void btnMK_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "update Account set Password = N'NhaHang123' where AccountName = @Name";
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reset mật khẩu thành công!", "Thông báo");
                con.Close();
                con.Dispose();
            }
            btnMK.Enabled = false;
        }
    }
}
