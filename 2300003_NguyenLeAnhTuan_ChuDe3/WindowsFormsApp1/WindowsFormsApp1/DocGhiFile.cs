using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class DocGhiFile : Form
    {
        public DocGhiFile()
        {
            InitializeComponent();
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            string Str = "";
            string path = "D:\\2300003\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Students.json";
            List<Student> List = LoadJSON(path);
            for (int i = 1;i<List.Count;i++)
            {
                Student student = List[i];
                Str += string.Format("Sinh viên {0} có mssv: {1}, lớp: {2}\n", i, student.mssv, student.Lop);
            }
            MessageBox.Show(Str);
        }

        private List<Student> LoadJSON(string path)
        {
            // Khai báo danh sách lưu trữ
            List<Student> list = new List<Student>();

            // Đọc tệp JSON
            StreamReader r = new StreamReader(path);
            string json = r.ReadToEnd(); // Đọc hết

            // Chuyển về dạng mảng các đối tượng
            var array = (JObject)JsonConvert.DeserializeObject(json);

            // Lấy đối tượng sinh viên
            var students = array["sinhvien"].Children();

            foreach (var item in students)
            {
                // Lấy các thành phần
                int mssv = item["MSSV"].Value<int>();
                string ho = item["ho"].Value<string>();
                string ten = item["ten"].Value<string>();
                string gioitinh = item["gioitinh"].Value<string>();
                DateTime ngaysinh = item["ngaysinh"].Value<DateTime>();
                string lop = item["lop"].Value<string>();
                string cmnd = item["CMND"].Value<string>();
                string sdt = item["SDT"].Value<string>();
                string diachi = item["DiaChi"].Value<string>();

                // Tạo đối tượng Student
                Student student = new Student(mssv, ho, ten, gioitinh, ngaysinh,lop, cmnd, sdt, diachi);

                // Thêm vào danh sách
                list.Add(student);
            }

            return list;
        }

        private void btnTXT_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            string Str = "";
            var xmlDOC = new XmlDocument();
            xmlDOC.Load("D:\\2300003\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Students.xml");

            var nodelist = xmlDOC.DocumentElement.SelectNodes("/SinhVienList/SinhVien");

            foreach (XmlNode node in nodelist)
            {
                var id = node.SelectSingleNode("MSSV").InnerText;
                var firstName = node.SelectSingleNode("Ho").InnerText;
                var lastName = node.SelectSingleNode("Ten").InnerText;
                var gender = node.SelectSingleNode("GioiTinh").InnerText;
                var ngay = node.SelectSingleNode("NgaySinh").InnerText;
                var lop = node.SelectSingleNode("Lop").InnerText;
                var cmnd = node.SelectSingleNode("CMND").InnerText;
                var sdt = node.SelectSingleNode("SDT").InnerText;
                var address = node.SelectSingleNode("DiaChi").InnerText;

                Str += string.Format("{0,-10}{1,-20}{2,-10}{3,-12}{4,-10}{5,-15}{6,-15}{7,-30}\n\n",
            id, firstName + " " + lastName, gender, ngay, lop, cmnd, sdt, address);
            }
            MessageBox.Show(Str);
        }
    }
}
