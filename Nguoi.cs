using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai3_QL_Phong_Tro
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string SoCMND { get; set; }

        public Nguoi(string hoTen, string ngaySinh, string soCMND)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            SoCMND = soCMND;
        }

        public override string ToString()
        {
            return $"Ho và Ten: {HoTen}, Ngay Sinh: {NgaySinh}, So CMND: {SoCMND}";
        }
    }
}