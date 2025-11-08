using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Student
    {
        public int mssv {  get; set; }

        public string Ho { get; set; }

        public string Ten { get; set; }

        public string GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string Lop {  get; set; }

        public string CMND { get; set; }

        public string  SDT { get; set; }

        public string DiaChi { get; set; }

        public Student()
        {

        }

        public Student(int ms, string ho, string ten, string gtinh, DateTime nsinh, string lop, string cmnd, string sdt, string diachi)
        {
            mssv = ms;
            Ho = ho;
            Ten = ten;
            GioiTinh = gtinh;
            NgaySinh = nsinh;
            Lop = lop;
            CMND = cmnd;
            SDT = sdt;
            DiaChi = diachi;
        }
    }

    
}
