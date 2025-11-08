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
using System.Diagnostics;

namespace Lab_Advanced_Command
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAccount()
        {
            using (SqlConnection con = new SqlConnection("Server = TUNN\\ANHTUAN ; database = Restaurant_Management ; Integrated security=true;"))
            {
                    SqlCommand cmd = con.CreateCommand();
    
                    cmd.CommandText = "select AccountName, FullName, Email, Tell, DateCreated from Account";
    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
    
                    con.Open();
    
                    adapter.Fill(table);
    
                    con.Close();
                    con.Dispose();
    
                    dgvAccount.DataSource = table;
            }    
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dgvAccount.SelectedRows[0];
                DataRowView rowview = selectedrow.DataBoundItem as DataRowView;

                AddAccount accountForm = new AddAccount();
                accountForm.Show(this);
                accountForm.DisplayAccount(rowview);
            }
        }

        private void stmDanhSach_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAccount.SelectedRows[0];
                DataRowView rowview = selectedRow.DataBoundItem as DataRowView;

                ListRole listrole = new ListRole();
                listrole.Show(this);
                //Lấy dữ liệu từ dòng được chọn
                listrole.DisplayRole(rowview);
            }
        }

        private void tsmNhatKy_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dgvAccount.SelectedRows[0];
                DataRowView rowview = selectedrow.DataBoundItem as DataRowView;

                BillForm billForm = new BillForm();
                billForm.Show(this);
                billForm.DisplayBill(rowview);
            }
        }
    }
}
