using CS_Bai3_QL_Phong_Tro;

class Program
{
    static List<KhachSan> khachSans = new List<KhachSan>();

    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong khach tro: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            NhapKhachTro();
        }

        while (true)
        {
            Console.WriteLine("\nChon chuc nang:");
            Console.WriteLine("1. Hien thi thong tin khach tro");
            Console.WriteLine("2. Xoa thong tin khach tro");
            Console.WriteLine("3. Tinh tien tra phong");
            Console.WriteLine("4. Thoat");

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    HienThiKhachTro();
                    break;
                case 2:
                    XoaKhachTro();
                    break;
                case 3:
                    TinhTienTraPhong();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Chọn chuc nang khong hop le. Vui long thu lai.");
                    break;
            }
        }
    }

    static void NhapKhachTro()
    {
        Console.WriteLine("Nhap ho va ten:");
        string hoTen = Console.ReadLine();

        Console.WriteLine("Nhap ngay sinh:");
        string ngaySinh = Console.ReadLine();

        Console.WriteLine("Nhap so CMND:");
        string soCMND = Console.ReadLine();

        Nguoi khachHang = new Nguoi(hoTen, ngaySinh, soCMND);

        Console.WriteLine("Nhap so ngay tro:");
        int soNgayTro = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap loai phong:");
        string loaiPhong = Console.ReadLine();

        Console.WriteLine("Nhap gia phong:");
        double giaPhong = double.Parse(Console.ReadLine());

        KhachSan khachSan = new KhachSan(khachHang, soNgayTro, loaiPhong, giaPhong);
        khachSans.Add(khachSan);
        Console.WriteLine("Da them khach tro thanh cong.");
    }

    static void HienThiKhachTro()
    {
        foreach (var khachSan in khachSans)
        {
            Console.WriteLine(khachSan);
        }
    }

    static void XoaKhachTro()
    {
        Console.WriteLine("Nhap so CMND cua khach tro can xoa: ");
        string soCMND = Console.ReadLine();

        var khachSan = khachSans.Find(k => k.KhachHang.SoCMND == soCMND);
        if (khachSan != null)
        {
            khachSans.Remove(khachSan);
            Console.WriteLine("Da xoa thong tin khach tro thanh cong");
        }
        else
        {
            Console.WriteLine("Khong tim thay khach tro voi so CMND da nhap.");
        }
    }

    static void TinhTienTraPhong()
    {
        Console.WriteLine("Nhap so CMND cua khach tro:");
        string soCMND = Console.ReadLine();

        var khachSan = khachSans.Find(k => k.KhachHang.SoCMND == soCMND);
        if (khachSan != null)
        {
            Console.WriteLine($"Tien can tra: {khachSan.TinhTien():C}");
        }
        else
        {
            Console.WriteLine("Khong tim thay khach tro voi so CMND da nhap.");
        }
    }
}