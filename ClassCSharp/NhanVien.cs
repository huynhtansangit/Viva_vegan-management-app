﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viva_vegan.ClassCSharp
{
    class NhanVien
    {
        private String manv;
        private String macv;
        private String mabp;
        private String tennv;
        private String dienthoai;
        private String email;
        private String diachi;
        private String sotk;
        private String tendangnhap;
        private String matkhau;
        private DateTime ngayvaolam;

        #region Getter and Setter
        public NhanVien(string manv, string macv, string mabp, string tennv, string dienthoai, string email, string diachi, string sotk, string tendangnhap, string matkhau, DateTime ngayvaolam)
        {
            this.manv = manv;
            this.macv = macv;
            this.mabp = mabp;
            this.tennv = tennv;
            this.dienthoai = dienthoai;
            this.email = email;
            this.diachi = diachi;
            this.sotk = sotk;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.ngayvaolam = ngayvaolam;
        }
        public NhanVien(DataRow row)
        {
            this.manv       = row[0].ToString();
            this.macv       = row[1].ToString();
            this.mabp       = row[2].ToString();
            this.tennv      = row[3].ToString();
            this.dienthoai  = row[4].ToString();
            this.email      = row[5].ToString();
            this.diachi     = row[6].ToString();
            this.sotk       = row[7].ToString();
            this.tendangnhap= row[8].ToString();
            this.matkhau    = row[9].ToString();
            this.ngayvaolam = Convert.ToDateTime(row[10]);
        }
        public NhanVien()
        {
        }
        //Method 
        public String Manv { get => manv; set => manv = value; }
        public String Mabp { get => mabp; set => mabp = value; }
        public String Macv { get => macv; set => macv = value; }
        public String Tennv { get => tennv; set => tennv = value; }
        public String Dienthoai { get => dienthoai; set => dienthoai = value; }
        public String Email { get => email; set => email = value; }
        public String Diachi { get => diachi; set => diachi = value; }
        public String Sotk { get => sotk; set => sotk = value; }
        public String Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public String Matkhau { get => matkhau; set => matkhau = value; }
        public DateTime Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        #endregion
        #region Methods
        public async Task<string> taoManv()
        {
            // lỗi -> solution lấy cột mã nhân viên -> tách 2 số cuối
            //-> tìm số lớn nhất -> cộng 1 tạo thành mã nv
            string query = "select manv from nhanvien";
            string result = "";
            int max= 0;
            DataTable table =await ConnectDataBase.SessionConnect.executeQueryAsync(query);
            foreach(DataRow row in table.Rows)
            {
                string manv = row["MANV"].ToString();
                int i=int.Parse(manv.Substring(2, manv.Length - 2));
                if (max<=i)
                {
                    max = i;
                }
            }
            return "NV" + (max+1).ToString();
        }
        public async Task<DataTable> loadTableNhanVien (String input,String timtheo=null)
        {
            String query = "select * from nhanvien";
            if (String.IsNullOrWhiteSpace(input))
            {
                query = "select * from nhanvien";
                DataTable table =await ConnectDataBase.SessionConnect.executeQueryAsync(query);
                return table;
            }
            else
            {
                
                if (timtheo.Contains("Tên"))
                {
                    query = "select * from nhanvien where tennv like N'%" +
                    input.Trim() + "%'";
                }
                else if (timtheo.Contains("Mã"))
                {
                    query = "select * from nhanvien where manv like '%" +
                    input.Trim() + "%'";
                }
                DataTable table = await ConnectDataBase.SessionConnect.executeQueryAsync(query);
                return table;
            }
        }
        public List<NhanVien> getListNhanVien()
        {
            List<NhanVien> nvs = new List<NhanVien>();
;            String query = "select * from nhanvien";
            DataTable table = ConnectDataBase.SessionConnect.executeQuery(query);
            if (table.Rows.Count>0)
            {
                foreach (DataRow row in table.Rows)
                {
                    nvs.Add(new NhanVien(row));
                }

            }
            return nvs;
        }
        #endregion
      
    }
}
