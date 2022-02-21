using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viva_vegan.ClassCSharp.ChuongTrinhKM
{
    class DieuKienKM
    {
        private string makm;
        private string madieukienKM;
        private string mathucuong;
        private string mamonan;
        private decimal diemtang;
        private decimal giamgia;
        private decimal tongtienmua;

        public DieuKienKM()
        {

        }
        public DieuKienKM(string makm,
            string madieukienKM,
            string mathucuong,
            string mamonan,
            decimal diemtang,
            decimal giamgia,
            decimal tongtienmua)
        {
            this.makm = makm;
            this.madieukienKM = madieukienKM;
            this.mathucuong = mathucuong;
            this.mamonan = mamonan;
            this.diemtang = diemtang;
            this.giamgia = giamgia;
            this.tongtienmua = tongtienmua;
        }
        public string Makm { get => makm; set => makm = value; }
        public string MadieukienKM { get => madieukienKM; set => madieukienKM = value; }
        public string Mathucuong { get => mathucuong; set => mathucuong = value; }
        public string Mamonan { get => mamonan; set => mamonan = value; }
        public decimal Diemtang { get => diemtang; set => diemtang = value; }
        public decimal Giamgia { get => giamgia; set => giamgia = value; }
        public decimal Tongtienmua { get => tongtienmua; set => tongtienmua = value; }

        public async Task<DataTable> getAllDataTableDieuKienKM ()
        {
            string query = "select * from dieukienkm ";
            DataTable table =await ConnectDataBase.SessionConnect.executeQueryAsync(query);
            return table;
        }
    }
}
