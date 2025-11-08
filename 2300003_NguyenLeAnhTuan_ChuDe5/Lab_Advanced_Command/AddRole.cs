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
    public partial class AddRole : Form
    {
        public AddRole()
        {
            InitializeComponent();
        }

        public void EnabledbtnAdd()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        public void EnabledbtnUpdate()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into Rolee (RoleName, Path, Notes) values (@name, @path, @note)";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@path", txtPath.Text);
                cmd.Parameters.AddWithValue("@note", rtbNote.Text);

                int num = cmd.ExecuteNonQuery();
                if (num == 1)
                {
                    DialogResult kq = MessageBox.Show("Thêm vai trò thành công. Bạn có muốn thêm tiếp?", "Thông báo", MessageBoxButtons.YesNo);
                    if (kq == DialogResult.Yes)
                    {
                        txtName.ResetText();
                        txtPath.ResetText();
                        rtbNote.ResetText();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Thêm vai trò thất bại!");
                }
                con.Close();
                con.Dispose();
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisplayRole(DataRowView rowview)
        {
            try
            {
                txtName.Text = rowview["RoleName"].ToString();
                txtPath.Text = rowview["Path"].ToString();
                rtbNote.Text = rowview["Notes"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị thông tin vai trò: " + ex.Message, "Lỗi");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "update Rolee set RoleName = @name, Path = @path, Notes = @note where RoleName = @name";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@path", txtPath.Text);
                cmd.Parameters.AddWithValue("@note", rtbNote.Text);

                int num = cmd.ExecuteNonQuery();
                if (num == 1)
                {
                    DialogResult kq = MessageBox.Show("Cập nhật vai trò thành công. Bạn có muốn thêm tiếp?", "Thông báo", MessageBoxButtons.YesNo);
                    if (kq == DialogResult.Yes)
                    {
                        txtName.ResetText();
                        txtPath.ResetText();
                        rtbNote.ResetText();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật vai trò thất bại!");
                }
                con.Close();
                con.Dispose();
            }
        }

        
    }
}
