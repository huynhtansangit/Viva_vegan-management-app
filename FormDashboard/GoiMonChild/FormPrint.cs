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
using Viva_vegan.ClassCSharp.ChuongTrinhKM;

namespace Viva_vegan.FormDashboard.GoiMonChild
{
    public partial class FormPrint : Form
    {
        public GoiMon GetGoiMon;
        private List<ChiTietHoaDonBill> list = new List<ChiTietHoaDonBill>();
        private List<HOADON> GetHOADONs = new List<HOADON>();
        private List<CHUONGTRINHKM> GetHUONGTRINHKMs = new List<CHUONGTRINHKM>();
        private List<KHACHHANG> GetHACHHANGs = new List<KHACHHANG>();
        Entities1 entities = new Entities1();
        private string mahoadon;
        private bool isBaoCao;
        public FormPrint(GoiMon goimon, String mahoadon, bool tuFormBaoCao = false)
        {
            InitializeComponent();
            GetGoiMon = goimon;
            IsBaoCao = tuFormBaoCao;
            Mahoadon = mahoadon;
            list = new ChiTietHoaDonBill().GetChiTietHoaDonBillsFromMaHoaDon(mahoadon);
        }

        public bool IsBaoCao { get => isBaoCao; set => isBaoCao = value; }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            hoaDonReport1.SetDataSource(list); // này là cái list món ăn thức uống trong hóa đơn
            try
            {
                if(IsBaoCao)
                {
                    GetHOADONs = entities.HOADONs.Where(x => x.MAHD == Mahoadon).ToList();
                    HOADON hd = GetHOADONs[0];
                    GetHACHHANGs = entities.KHACHHANGs.Where(x => x.MAKH == hd.MAKH).ToList();
                    KHACHHANG kh = GetHACHHANGs[0];
                    hoaDonReport1.SetParameterValue("pKhachhang",hd.MAKH);
                    hoaDonReport1.SetParameterValue("pMahoadon", Mahoadon);
                    hoaDonReport1.SetParameterValue("pNgaylap", hd.NGAYLAP.ToString());
                    hoaDonReport1.SetParameterValue("pNhanvien", hd.MANV);
                    hoaDonReport1.SetParameterValue("pVat", hd.VAT);
                    hoaDonReport1.SetParameterValue("pTongtienphaitra", hd.TIENNHANKH - hd.TIENTRALAIKH);
                    if (kh.MAKH.Contains("KH000"))
                    {
                        hoaDonReport1.SetParameterValue("pGiamgiathanhvien", 0);
                    }
                    else
                    {
                        hoaDonReport1.SetParameterValue("pGiamgiathanhvien", CTKMFunction.solveDiscount(kh.MALOAIKH, hd.TIENNHANKH - hd.TIENTRALAIKH));
                    }
                    hoaDonReport1.SetParameterValue("pTienkhachdua", hd.TIENNHANKH);
                    hoaDonReport1.SetParameterValue("pKhuyenmai", 0);
                    hoaDonReport1.SetParameterValue("pTienthua", hd.TIENTRALAIKH);
                }
                else
                {
                    decimal tienkhachdua = decimal.Parse(GetGoiMon.txbtienkhachdua.Text);
                    decimal tienkhuyenmai = decimal.Parse(GetGoiMon.btnkhuyenmai.Tag.ToString());
                    decimal tienthua = decimal.Parse(GetGoiMon.btntienthua.Tag.ToString());
                    decimal giamgiathanhvien = decimal.Parse(GetGoiMon.txbsotiendagiam.Tag.ToString());
                    decimal tongtienphaitra = decimal.Parse(GetGoiMon.btntiensaukhigiamm.Tag.ToString());
                    decimal svat = decimal.Parse(GetGoiMon.btnvat.Tag.ToString());
                    hoaDonReport1.SetParameterValue("pKhachhang", this.Tag.ToString());
                    hoaDonReport1.SetParameterValue("pMahoadon", Mahoadon);
                    hoaDonReport1.SetParameterValue("pNgaylap", DateTime.Now.ToLongDateString());
                    hoaDonReport1.SetParameterValue("pNhanvien", User.Manv);
                    hoaDonReport1.SetParameterValue("pVat", svat);
                    hoaDonReport1.SetParameterValue("pGiamgiathanhvien", giamgiathanhvien);
                    hoaDonReport1.SetParameterValue("pTongtienphaitra", tongtienphaitra);
                    hoaDonReport1.SetParameterValue("pTienkhachdua", tienkhachdua);
                    hoaDonReport1.SetParameterValue("pKhuyenmai", tienkhuyenmai);
                    hoaDonReport1.SetParameterValue("pTienthua", tienthua);
                }
                crystalReportViewer1.ReportSource = hoaDonReport1;
            }
            catch (Exception x)
            {
                OptimizedPerformance.alertError(x.Message);
            }
        }
    }
}
