using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANMINHTAM_01
{
    class NhanVienBC : NhanVien
    {
        {
        private double mucxeploai;

        public NhanVienBC() : base()
        {
        }
        public NhanVienBC(string maso, string hoten, int luongcung, string mucxeploai) : base(maso, hoten,luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public double MucXepLoai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong:");
            this.mucxeploai = double.Parse(Console.ReadLine());
        }
        public override int tinhLuong()
        {
            double luong = mucxeploai * 1800000;
            return (int)luong;
        }
    }
}
