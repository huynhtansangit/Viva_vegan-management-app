using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viva_vegan.ClassCSharp.ChuongTrinhKM
{
    class LoaiCTKM
    {
        private string maloaiCTKM;
        private string tenloaiCTKM;

        public LoaiCTKM(string maloaiCTKM, string tenloaiCTKM)
        {
            this.maloaiCTKM = maloaiCTKM;
            this.tenloaiCTKM = tenloaiCTKM;
        }
        public LoaiCTKM()
        {
        }
        public string MaloaiCTKM { get => maloaiCTKM; set => maloaiCTKM = value; }
        public string TenloaiCTKM { get => tenloaiCTKM; set => tenloaiCTKM = value; }

        public async Task<DataTable> getAllLoaiCtkmTable ()
        {
            string query = "select * from LoaiCTKM";
            DataTable res=await ConnectDataBase.SessionConnect.executeQueryAsync(query);
            return res;
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Tag { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public void fromDataTableToCbb (DataTable table, ComboBox cbb)
        {
            foreach(DataRow row in table.Rows)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Tag = row["MALOAIKM"].ToString();
                item.Text = row["TENLOAIKM"].ToString();
                cbb.Items.Add(item);

            }
            cbb.SelectedIndex = 0;
        }
    }
}
