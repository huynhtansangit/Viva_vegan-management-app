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
    public partial class FormGiamGiaHoaDon : Form
    {
        public FormGiamGiaHoaDon()
        {
            InitializeComponent();
        }
        private void dgvDieuKien_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void AddNewRowInDataGridView (DataGridView dgv, string [] value=null)
        {
            if (dgv.ColumnCount!=value.Length)
            {
                Console.WriteLine("Dữ liệu truyền vào sai");
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)dgvDieuKien.Rows[0].Clone();
                for (int i=0;i<value.Length;i++)
                {
                    row.Cells[i].Value = value[i];
                }
                dgv.Rows.Add(row);
            }
        }
        private void Btnthemdk_Click(object sender, EventArgs e)
        {
            if (dgvDieuKien.Rows.Count<=4)
            {
                AddNewRowInDataGridView(dgvDieuKien, new string[] {
                    dgvDieuKien.Rows.Count.ToString(), "Từ",null,null,"VNĐ|%"
                });
            }
            else
            {
                MessageBox.Show("Chỉ được thêm tối đa 4 điều kiện");
            }
        }

        private void Btnxoadieukien_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDieuKien.SelectedRows)
            {
                if(row.Index>=0 && row.Index<dgvDieuKien.Rows.Count && row.Cells[0].Value!=null)
                {
                    dgvDieuKien.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}
