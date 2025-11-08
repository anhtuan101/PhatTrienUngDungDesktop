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
    public partial class BillDetailsForm : Form
    {
        private int _billID;
        public BillDetailsForm(int billID)
        {
            InitializeComponent();
            _billID = billID;
        }

        string conn = "server=TUNN\\ANHTUAN; database=Restaurant_Management; Integrated Security = True";

        private void BillDetailsForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);
            string query = "Select * from BillDetails WHERE InvoiceID = @InvoiceID";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@InvoiceID", _billID);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBillDetails.DataSource = dt;
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
