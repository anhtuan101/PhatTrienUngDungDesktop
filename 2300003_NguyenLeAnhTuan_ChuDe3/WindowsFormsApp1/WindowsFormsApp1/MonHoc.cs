using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MonHoc : Form
    {
        private Form1 f;
        public string NewSubjectName { get; private set; }
        public MonHoc()
        {
            InitializeComponent();
        }
        
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbTenMH.Text))
            {
                NewSubjectName = tbTenMH.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
