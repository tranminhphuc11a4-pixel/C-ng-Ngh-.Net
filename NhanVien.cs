using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class NhanVien
    {
        private string maNhanVien;
        private string tenNhanVien;
        private double heSL;
        static public int LuongCoBan = 2340000;

        public double HeSL
        {
            get { return heSL; }
            set { heSL = value; }
        }
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set
            {
                if (value.StartsWith("NV")) maNhanVien = value;
                else maNhanVien = "NV001";
            }
        }

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        public NhanVien()
        {
            MaNhanVien = "NV001";
            TenNhanVien = "Tran Minh Phuc";
            HeSL = 2.34;
        }

         public double TinhThuNhap()
        {
            return HeSL * LuongCoBan;
        }

        public void XuatNV()
        {
            Console.WriteLine("Ma Nhan Vien: {0}", maNhanVien);
            Console.WriteLine("Ten Nhan Vien: {0}", tenNhanVien);
            Console.WriteLine("He So Luong: {0}", heSL);
            Console.WriteLine("Thu Nhap: {0}", TinhThuNhap());
        }
       
    }
}
