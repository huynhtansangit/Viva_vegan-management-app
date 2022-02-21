using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viva_vegan.ClassCSharp.ChuongTrinhKM
{
    class ChuongTrinhKM
    {
        public string mactkm;
        public string maloaikm;
        public string tenkm;
        public string ngaybatdau;
        public string ngayketthuc;
        public string ghichu;
        public string trangthai;
        private string madieukienkm;
        public ChuongTrinhKM(string mactkm, string maloaikm, string tenkm, string ngaybatdau, string ngayketthuc, string ghichu, string trangthai,string madieukienkm)
        {
            this.mactkm = mactkm;
            this.maloaikm = maloaikm;
            this.tenkm = tenkm;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.ghichu = ghichu;
            this.trangthai = trangthai;
            this.madieukienkm = madieukienkm;

        }
        public ChuongTrinhKM()
        {
        }
        public string Mactkm { get => mactkm; set => mactkm = value; }
        public string Maloaikm { get => maloaikm; set => maloaikm = value; }
        public string Tenkm { get => tenkm; set => tenkm = value; }
        public string Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public string Ngayketthuc { get => ngayketthuc; set => ngayketthuc = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Madieukienkm { get => madieukienkm; set => madieukienkm = value; }
    }

}
