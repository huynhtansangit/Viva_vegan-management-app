using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viva_vegan.ClassCSharp;

namespace Viva_vegan.FormDashboard.GoiMonChild
{
    public partial class ChiTietHoaDonBaoCao : Form
    {
        private string mahoadon;
        Entities1 db = new Entities1();
        HOADON hd = new HOADON();
        private List<ChiTietHoaDonBill> list = new List<ChiTietHoaDonBill>();
        public ChiTietHoaDonBaoCao(String mahoadon)
        {
            InitializeComponent();
            Mahoadon = mahoadon;
        }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }

        private  void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
             initData(Mahoadon);
        }

        private  void initData(string mahd)
        {
            list =  new ChiTietHoaDonBill().GetChiTietHoaDonBillsFromMaHoaDon(Mahoadon);
            List<HOADON> hOADONs = db.HOADONs.Where(x => x.MAHD == mahd).ToList();
            if(hOADONs.Count>=1)
            {
                hd = hOADONs[0];
            }
            string tienkhachdua = OptimizedPerformance.formatCurrency(decimal.Parse(hd.TIENNHANKH.ToString()));
            string tienthua = OptimizedPerformance.formatCurrency(decimal.Parse(hd.TIENTRALAIKH.ToString()));
            string giamgiathanhvien = OptimizedPerformance.formatCurrency(decimal.Parse((hd.TIENNHANKH - hd.TIENSAUTHUE - hd.TIENTRALAIKH).ToString()));
            string vat = OptimizedPerformance.formatCurrency(decimal.Parse(hd.VAT.ToString()));
            string tongtienphaitra = OptimizedPerformance.formatCurrency(decimal.Parse(hd.TIENSAUTHUE.ToString()));
            string manv = hd.MANV;
            string ngaylap = hd.NGAYLAP.ToString();
            string makh = hd.MAKH;
            if (makh.Contains("KH000"))
            {
                makh = hd.MAKH + "-Vãng lai";
            }
            hoaDonReport1.SetDataSource(list); // này là cái list món ăn thức uống trong hóa đơn
            hoaDonReport1.SetParameterValue("pKhachhang", makh);
            hoaDonReport1.SetParameterValue("pMahoadon", Mahoadon);
            hoaDonReport1.SetParameterValue("pNgaylap", ngaylap);
            hoaDonReport1.SetParameterValue("pNhanvien", manv);
            hoaDonReport1.SetParameterValue("pVat", vat);
            hoaDonReport1.SetParameterValue("pGiamgiathanhvien", giamgiathanhvien);
            hoaDonReport1.SetParameterValue("pTongtienphaitra", tongtienphaitra);
            hoaDonReport1.SetParameterValue("pTienkhachdua", tienkhachdua);
            hoaDonReport1.SetParameterValue("pTienthua", tienthua);
            crystalReportViewer1.ReportSource = hoaDonReport1;
        }
    }
}
