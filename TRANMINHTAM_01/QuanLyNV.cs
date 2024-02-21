using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANMINHTAM_01
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("Chon loai nhan vien [1:bien che, 2:hop dong]:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv); 
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv); 
                        break;
                    default:
                        Console.WriteLine("Ban chon sai. Vui long chon 1 hoac 2.");
                        break;
                }
                Console.Write("Ban co muon tiep tuc khong? Y/N:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10}  {"Ho Ten",20} {"Luong",20}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.MaSo,-10}  {x.HoTen,20}  {x.tinhLuong(),20:#,##0 vnd}");
            }
        }
        public int tinhTongLuong()
        {
            int sum = 0;
            foreach (NhanVien gv in dsNV)
            {
                sum += gv.tinhLuong();
            }
            return sum;
        }
        public double TinhTrungbinh()
        {
            int dem = dsNV.Count();
            return tinhTongLuong() / dem;
        }
        }
}
