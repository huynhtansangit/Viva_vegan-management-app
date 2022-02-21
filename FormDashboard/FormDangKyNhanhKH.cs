using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viva_vegan.ClassCSharp.ChuongTrinhKM;
using Viva_vegan.ClassCSharp;
namespace Viva_vegan.FormDashboard
{
    public partial class FormDangKyNhanhKH : Form
    {
        public FormDangKyNhanhKH()
        {
            InitializeComponent();
            txbmakh.Text = CTKMFunction.generateCode(5);
        }

        private void BtnThemkh_Click(object sender, EventArgs e)
        {
            string makh = txbmakh.Text;
            string tenkh = txbtenkh.Text;
            string dienthoai = txbdienthoaikh.Text;
            string diachi = txbdiachikh.Text;
            string email = txbemailkh.Text;
            DateTime ngaysinh = dpngaysinhkh.Value;

            if (string.IsNullOrWhiteSpace(tenkh) ||
                string.IsNullOrWhiteSpace(dienthoai) ||
                string.IsNullOrWhiteSpace(diachi) ||
                string.IsNullOrWhiteSpace(email))
            {
                OptimizedPerformance.alertError("Không bỏ trống trường có *");
            }
            else
            {
                try
                {
                    String query = "thaotackhachhang @makh @tenkh @dienthoaikh @diachikh @ngaysinhkh @emailkh @maloaikh @ngaydangky @matrangthai @REQUEST";
                    int res = ConnectDataBase.SessionConnect.executeNonQuery(query, new object[]
                    {
                     makh,tenkh, dienthoai,diachi,ngaysinh,email,"GREEN",DateTime.Now,"activ","insert"
                        //manv,macv,mabp,tennv,dienthoai,email,diachi,sotk, tendangnhap,matkhau,ngayvaolam,"insert"
                    });
                    if (res > 0)
                    {
                        OptimizedPerformance.alertSuccess("Thành công");
                        this.Close();
                    }
                }
               catch(Exception x)
                {
                    OptimizedPerformance.alertError(x.Message);
                }
            }
        }

        private void Txbmakh_Click(object sender, EventArgs e)
        {
            txbmakh.Text = CTKMFunction.generateCode(5);
        }
    }
}
