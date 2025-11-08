using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Advanced_Command
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "exec InsertCategory @name = @Name, @type = @Type";
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Type", txtType.Text == "Thức uống" ? 0 : 1);
            int num = cmd.ExecuteNonQuery();
            if (num == 1)
            {
                DialogResult kq = MessageBox.Show("Thêm nhóm món ăn thành công. Bạn có muốn thêm tiếp?", "Thông báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    txtName.ResetText();
                    txtType.ResetText();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Thêm nhóm món ăn thất bại!");
            }
            con.Close();
            con.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
