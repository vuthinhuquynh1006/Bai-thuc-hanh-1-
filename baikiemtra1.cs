using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("========== BAI TAP THUC HANH BUOI 1 ==========");
            Console.WriteLine("1.1 - Tinh chi so BMI");
            Console.WriteLine("1.2 - Tinh tien dien");
            Console.WriteLine("1.3 - Quy doi ngoai te");
            Console.WriteLine("1.4 - Chuan hoa ho ten");
            Console.WriteLine("1.5 - Tinh thue TNCN");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("==============================================");

            Console.Write("Nhap lua chon: ");
            string luaChon = Console.ReadLine();

            Console.Clear();

            switch (luaChon)
            {
                case "1":
                    Bai11();
                    break;

                case "2":
                    Bai12();
                    break;

                case "3":
                    Bai13();
                    break;

                case "4":
                    Bai14();
                    break;

                case "5":
                    Bai15();
                    break;

                case "0":
                    Console.WriteLine("Da thoat chuong trinh!");
                    return;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Nhan Enter de quay lai menu...");
            Console.ReadLine();
        }
    }

    // ================= BAI 1.1 =================
    static void Bai11()
    {
        Console.WriteLine("===== BAI 1.1: TINH BMI =====");

        Console.Write("Nhap can nang (kg): ");
        double canNang = double.Parse(Console.ReadLine());

        Console.Write("Nhap chieu cao (m): ");
        double chieuCao = double.Parse(Console.ReadLine());

        double bmi = canNang / (chieuCao * chieuCao);

        Console.WriteLine($"BMI = {bmi:F2}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Phan loai: Thieu can");
        }
        else if (bmi < 25)
        {
            Console.WriteLine("Phan loai: Binh thuong");
        }
        else if (bmi < 30)
        {
            Console.WriteLine("Phan loai: Thua can");
        }
        else
        {
            Console.WriteLine("Phan loai: Beo phi");
        }
    }

    // ================= BAI 1.2 =================
    static void Bai12()
    {
        Console.WriteLine("===== BAI 1.2: TINH TIEN DIEN =====");

        Console.Write("Nhap so dien tieu thu (kWh): ");
        double soDien = double.Parse(Console.ReadLine());

        double tienDien;

        if (soDien <= 50)
        {
            tienDien = soDien * 1678;
        }
        else if (soDien <= 100)
        {
            tienDien = 50 * 1678
                      + (soDien - 50) * 1734;
        }
        else
        {
            tienDien = 50 * 1678
                      + 50 * 1734
                      + (soDien - 100) * 2014;
        }

        double vat = tienDien * 0.08;
        double tongTien = tienDien + vat;

        Console.WriteLine($"Tien dien: {tienDien:N0} VND");
        Console.WriteLine($"VAT 8%: {vat:N0} VND");
        Console.WriteLine($"Tong tien: {tongTien:N0} VND");
    }

    // ================= BAI 1.3 =================
    static void Bai13()
    {
        Console.WriteLine("===== BAI 1.3: QUY DOI NGOAI TE =====");

        Console.WriteLine("1. USD");
        Console.WriteLine("2. EUR");
        Console.WriteLine("3. JPY");

        Console.Write("Chon loai tien: ");
        int luaChon = int.Parse(Console.ReadLine());

        Console.Write("Nhap so tien: ");
        double soTien = double.Parse(Console.ReadLine());

        double tyGia;
        string loaiTien;

        switch (luaChon)
        {
            case 1:
                tyGia = 25000;
                loaiTien = "USD";
                break;

            case 2:
                tyGia = 28000;
                loaiTien = "EUR";
                break;

            case 3:
                tyGia = 170;
                loaiTien = "JPY";
                break;

            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        double tienVND = soTien * tyGia;

        Console.WriteLine(
            $"{soTien:N0} {loaiTien} = {tienVND:N0} VND"
        );
    }

    // ================= BAI 1.4 =================
    static void Bai14()
    {
        Console.WriteLine("===== BAI 1.4: CHUAN HOA HO TEN =====");

        Console.Write("Nhap ho ten: ");
        string hoTen = Console.ReadLine();

        hoTen = hoTen.Trim();

        string[] cacTu = hoTen.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        for (int i = 0; i < cacTu.Length; i++)
        {
            cacTu[i] = char.ToUpper(cacTu[i][0])
                     + cacTu[i].Substring(1).ToLower();
        }

        string ketQua = string.Join(" ", cacTu);

        Console.WriteLine("Ho ten sau khi chuan hoa: " + ketQua);
    }

    // ================= BAI 1.5 =================
    static void Bai15()
    {
        Console.WriteLine("===== BAI 1.5: TINH THUE TNCN =====");

        Console.Write("Nhap luong Gross (VND): ");
        double luongGross = double.Parse(Console.ReadLine());

        Console.Write("Nhap so nguoi phu thuoc: ");
        int nguoiPhuThuoc = int.Parse(Console.ReadLine());

        double giamTruBanThan = 11000000;
        double giamTruPhuThuoc = nguoiPhuThuoc * 4400000;

        double thuNhapTinhThue =
            luongGross
            - giamTruBanThan
            - giamTruPhuThuoc;

        Console.WriteLine(
            $"Thu nhap tinh thue: {thuNhapTinhThue:N0} VND"
        );

        if (thuNhapTinhThue <= 0)
        {
            Console.WriteLine("Khong phai nop thue TNCN.");
            return;
        }

        double thue = 0;

        if (thuNhapTinhThue <= 5000000)
        {
            thue = thuNhapTinhThue * 0.05;
        }
        else if (thuNhapTinhThue <= 10000000)
        {
            thue = 5000000 * 0.05
                 + (thuNhapTinhThue - 5000000) * 0.10;
        }
        else if (thuNhapTinhThue <= 18000000)
        {
            thue = 5000000 * 0.05
                 + 5000000 * 0.10
                 + (thuNhapTinhThue - 10000000) * 0.15;
        }
        else if (thuNhapTinhThue <= 32000000)
        {
            thue = 5000000 * 0.05
                 + 5000000 * 0.10
                 + 8000000 * 0.15
                 + (thuNhapTinhThue - 18000000) * 0.20;
        }
        else if (thuNhapTinhThue <= 52000000)
        {
            thue = 5000000 * 0.05
                 + 5000000 * 0.10
                 + 8000000 * 0.15
                 + 14000000 * 0.20
                 + (thuNhapTinhThue - 32000000) * 0.25;
        }
        else if (thuNhapTinhThue <= 80000000)
        {
            thue = 5000000 * 0.05
                 + 5000000 * 0.10
                 + 8000000 * 0.15
                 + 14000000 * 0.20
                 + 20000000 * 0.25
                 + (thuNhapTinhThue - 52000000) * 0.30;
        }
        else
        {
            thue = 5000000 * 0.05
                 + 5000000 * 0.10
                 + 8000000 * 0.15
                 + 14000000 * 0.20
                 + 20000000 * 0.25
                 + 28000000 * 0.30
                 + (thuNhapTinhThue - 80000000) * 0.35;
        }

        Console.WriteLine(
            $"Thue TNCN phai nop: {thue:N0} VND"
        );
    }
}