using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class CBLanhDao:NhanVien
    {
        private string chucVu;
        private float thamNienQL;

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public float ThamNienQL
        {
            get { return thamNienQL; }
            set { thamNienQL = value; }
        }

        public CBLanhDao()
        {
            MaNhanVien = "NV009";
            TenNhanVien = "Dieu Hien";
            HeSL = 4.67;
            ChucVu = "Giam Doc";
            ThamNienQL = 10;
        }
        public double HeSoLanhDao()
        {
            if (ChucVu == "Giam Doc") return 7.0;
            else if (ChucVu == "Truong Phong") return 6.0;
            else if (ChucVu == "Pho Phong") return 4.5;
            else return 1.0;
        }

        public double PhuCapLanhDao()
        {
            return 1500000 * HeSoLanhDao();
        }

        public double TinhThuNhapCB()
        {
            return TinhThuNhap() + PhuCapLanhDao();
        }

        public void XuatCBLD()
        {
            Console.WriteLine("Ma so nhan vien: {0}", MaNhanVien);
            Console.WriteLine("Ten can bo: {0}", TenNhanVien);
            Console.WriteLine("He so luong: {0}", HeSL);
            Console.WriteLine("Thu Nhap: {0}", TinhThuNhapCB());
            Console.WriteLine("Chuc vu: {0}", ChucVu);
        }
    }
}
