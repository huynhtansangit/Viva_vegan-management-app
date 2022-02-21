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
namespace Viva_vegan.FormDashboard
{
    public partial class FormKiemTraThongTinKH : Form
    {
        Entities1 data = new Entities1();
        private KHACHHANG kh = new KHACHHANG();

        public KHACHHANG Kh { get => kh; set => kh = value; }
        public GoiMon Parent1 { get => parent; set => parent = value; }

        private GoiMon parent = new GoiMon();
        public FormKiemTraThongTinKH(GoiMon goimon)
        {
            InitializeComponent();
            Parent1 = goimon;
        }

        private void Txbsodienthoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string sdt = txbsodienthoaixacnhan.Text;
                if (string.IsNullOrWhiteSpace(sdt))
                {
                    OptimizedPerformance.alertError("Không được bỏ trống!");
                }
                else
                {

                }
            }
        }

        private void FormKiemTraThongTinKH_Load(object sender, EventArgs e)
        {
            txbsodienthoaixacnhan.KeyPress += OptimizedPerformance.textBox_KeyPress;
        }

        private void Txbsodienthoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<KHACHHANG> khs = data.KHACHHANGs.Where(x => x.DIENTHOAIKH == txbsodienthoaixacnhan.Text && x.matrangthai == "activ").ToList();
                if (khs.Count > 0)
                {
                    Kh = khs[0];
                    this.Tag = Kh;
                    txbmakh.Text = Kh.MAKH;
                    txbtenkh.Text = Kh.TENKH;
                    txbngaysinh.Text = OptimizedPerformance.formatDateTime(Kh.NGAYSINHKH);
                    txbtrangthai.Text = Kh.matrangthai;
                }
                else
                {
                    OptimizedPerformance.ClearAllText(this);
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private void Btnxacnhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Kh.MAKH))
            {
                OptimizedPerformance.alertError("Chưa tìm thấy khách hàng");
            }
            else
            {
                Parent1.kh = Kh;
                this.Close();
            }
        }
    }
}
