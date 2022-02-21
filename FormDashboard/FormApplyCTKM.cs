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
    public partial class FormApplyCTKM : Form
    {
        private decimal tongtienmua;
        Entities1 qlnh = new Entities1();
        private List<string> makms = new List<string>();
        private GoiMon parent = new GoiMon();
        private string makh;
        public FormApplyCTKM(decimal tongtienmua,string makh, GoiMon goimon)
        {
            InitializeComponent();
            Tongtienmua = tongtienmua;
            parent = goimon;
            Makh = makh;
            DataTable table = ConnectDataBase.SessionConnect.executeQuery("SELECT MAKM, MIN(tongtienmua) AS 'So tien it nhat' FROM DIEUKIENKM GROUP BY MAKM; ");
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (decimal.Parse(row[1].ToString()) > tongtienmua)
                    {
                        makms.Add(row["MAKM"].ToString());
                    }
                }
            }
        }
        public decimal Tongtienmua { get => tongtienmua; set => tongtienmua = value; }
        public string Makh { get => makh; set => makh = value; }

        public async void loadCTKM()
        {
            dgvctkm.DataSource = qlnh.CHUONGTRINHKMs.Where(x => x.NGAYKETTHUC <= DateTime.Now).ToList();
        }
        public async void loadDKKM(string makm)
        {
            dgvdkkm.DataSource = qlnh.DIEUKIENKMs.Where(x => x.MAKM == makm).Where(x=>x.TONGTIENMUA<=tongtienmua).ToList();
        }
        private void FormApplyCTKM_Load(object sender, EventArgs e)
        {
            OptimizedPerformance.log(tongtienmua);
            loadCTKM();
        }

        private void Dgvctkm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string makm = dgvctkm[0, e.RowIndex].Value.ToString();
            loadDKKM(makm);
        }

        private async void Dgvdkkm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal diemtang = decimal.Parse(dgvdkkm[4, e.RowIndex].Value.ToString());
            decimal phantramgiamgia = decimal.Parse(dgvdkkm[5, e.RowIndex].Value.ToString());
            decimal dagiam = 0;
            if (phantramgiamgia <= 100)
            {
                dagiam = phantramgiamgia * Tongtienmua / 100;
            }
            else if (phantramgiamgia>100)
            {
                dagiam = phantramgiamgia;
            }
            string query = "update khachhang set diem=diem+" + diemtang + " where makh='" + Makh + "'";
            int res =await ConnectDataBase.SessionConnect.executeNonQueryAsync(query);
            if(res>0)
            {
                DialogResult dia = MessageBox.Show("Áp dụng KM thành công");
                if (dia==DialogResult.OK)
                {
                    parent.btnkhuyenmai.ButtonText = OptimizedPerformance.formatCurrency(dagiam);
                    parent.btnkhuyenmai.Tag = dagiam;
                    parent.btntiensaukhigiamm.ButtonText = OptimizedPerformance.formatCurrency(decimal.Parse(parent.btntiensaukhigiamm.Tag.ToString()) - dagiam);
                    parent.btntiensaukhigiamm.Tag = decimal.Parse(parent.btntiensaukhigiamm.Tag.ToString()) - dagiam;
                    this.Close();
                }
            }
            else
            {
                OptimizedPerformance.alertError("Lỗi");
            }
        }
    }
}
