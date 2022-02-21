using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viva_vegan.ClassCSharp.ChuongTrinhKM
{
    public partial class FormTangDiemKhuyenMai : Form
    {
        public FormTangDiemKhuyenMai()
        {
            InitializeComponent();
        }

        private void Btnthemdieukien_Click(object sender, EventArgs e)
        {
            if (dgvdieukientangdiem.Rows.Count <= 4)
            {
                CTKMFunction.AddNewRowInDataGridView(dgvdieukientangdiem, new string[] {
                    dgvdieukientangdiem.Rows.Count.ToString(), "Từ",null,null,"Điểm"
                });
            }
            else
            {
                MessageBox.Show("Chỉ được thêm tối đa 4 điều kiện");
            }
        }

        private void TangDiemKhuyenMai_Load(object sender, EventArgs e)
        {
            dgvdieukientangdiem.EditingControlShowing += CTKMFunction.Dgv_EditingControlShowing;
        }

        private void Btnxoadieukien_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvdieukientangdiem.SelectedRows)
            {
                if (row.Index >= 0 && row.Index < dgvdieukientangdiem.Rows.Count && row.Cells[0].Value != null)
                {
                    dgvdieukientangdiem.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}
