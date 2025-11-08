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
    public partial class DieukienChon : Form
    {
        public string TimTheo { get; private set; }

        public string DuLieu { get; private set; }

        public DieukienChon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần tìm!");
                return;
            }

            TimTheo = cbLoc.SelectedItem.ToString();
            DuLieu = tbNhap.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
