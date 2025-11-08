using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2300003_NguyenLeAnhTuan_ChuDe4
{
    public partial class Tong : Form
    {
        public Tong()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            AccountManager acc = new AccountManager();
            acc.ShowDialog();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            FoodForm food = new FoodForm(); 
            food.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.ShowDialog();
        }
    }
}
