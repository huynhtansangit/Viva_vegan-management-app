using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viva_vegan.FormDashboard.GoiMonChild
{
    class SoTienGocKhiThanhToan
    {
        private string tongtien;
        private string thueVat;

        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string ThueVat { get => thueVat; set => thueVat = value; }

        public SoTienGocKhiThanhToan(string tongtien, string thueVat)
        {
            this.tongtien = tongtien;
            this.thueVat = thueVat;
        }
        public SoTienGocKhiThanhToan()
        {
          
        }

    }
}
