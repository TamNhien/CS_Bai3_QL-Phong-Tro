using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai3_QL_Phong_Tro
{
    internal class KhachSan
    {
        public Nguoi KhachHang {  get; set; }
        public int SoNgayTro { get; set; }
        public string LoaiPhong {  get; set; }
        public double GiaPhong { get; set; }

        public KhachSan(Nguoi khachHang, int soNgayTro, string loaiPhong, double giaPhong)
        {
            KhachHang = khachHang;
            SoNgayTro = soNgayTro;
            LoaiPhong = loaiPhong;
            GiaPhong = giaPhong;
        }

        public double TinhTien()
        {
            return SoNgayTro * GiaPhong;
        }

        public override string ToString()
        {
            return $"{KhachHang}, Số Ngày Trọ: {SoNgayTro}, Loại Phòng: {LoaiPhong}, Giá Phòng: {GiaPhong:C}, Tiền Cần Trả: {TinhTien():C}";
        }
    }
}