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
    public partial class OrderDetailsForm : Form
    {
        private int billID;
        public OrderDetailsForm(int billID)
        {
            InitializeComponent();
            this.billID = billID;
        }

        private void LoadDetails()
        {
            using (SqlConnection con = new SqlConnection("server=TUNN\\ANHTUAN; database = Restaurant_Management; Integrated Security = true;"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select b.Name, b.Price, a.Quantity, (b.Price * a.Quantity) as [Thành tiền] from BillDetails a, Food b where a.FoodID = b.ID and a.InvoiceID = @bill";
                cmd.Parameters.AddWithValue("@bill", billID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                con.Open();
                adapter.Fill(table);
                con.Close();
                con.Dispose();
                dgvDetails.DataSource = table;
            }    
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = billID.ToString();

            LoadDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
