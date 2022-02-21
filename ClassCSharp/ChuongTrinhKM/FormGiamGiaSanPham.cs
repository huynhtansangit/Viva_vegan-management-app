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
    public partial class formGiamGiaSp : Form
    {
        Entities1 db = new Entities1();
        public formGiamGiaSp()
        {

            InitializeComponent();
        }
        private void FormGiamGiaSp_Load(object sender, EventArgs e)
        {
            cbbWhichDgvDisplay.SelectedIndex = 0;
            dgvGiamgiathucuong.DataSource =  CTKMFunction.GetThucUongsInUse().ToList();
            dgvGiamgiaMonAn.DataSource = CTKMFunction.GetMonAnsInUse().ToList();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            switch (box.SelectedIndex)
            {
                case 0:
                    {
                        dgvGiamgiaMonAn.BringToFront();
                        break;
                    }
                case 1:
                    {
                        dgvGiamgiathucuong.BringToFront();
                        break;
                    }
            }
        }
        private void TxbByCode_TextChanged(object sender, EventArgs e)
        {
            dgvGiamgiaMonAn.DataSource = CTKMFunction.GetMonAnsInUseByWhat("code",txbByCode.Text).ToList();
            dgvGiamgiathucuong.DataSource = CTKMFunction.GetThucUongsInUseByWhat("code", txbByCode.Text).ToList();

        }
        private void TxbByName_TextChanged(object sender, EventArgs e)
        {
            dgvGiamgiaMonAn.DataSource = CTKMFunction.GetMonAnsInUseByWhat("name", txbByName.Text).ToList();
            dgvGiamgiathucuong.DataSource = CTKMFunction.GetThucUongsInUseByWhat("name", txbByName.Text).ToList();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvGiamgiathucuong.DataSource = CTKMFunction.GetThucUongsInUse().ToList();
            dgvGiamgiaMonAn.DataSource = CTKMFunction.GetMonAnsInUse().ToList();
        }
        private void DgvGiamgiaMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView c = sender as DataGridView;
            if (txbmachon.DataBindings.Count > 0)
                txbmachon.DataBindings.RemoveAt(0);

            // The code binds column index 2 to the TextBox control
            txbmachon.DataBindings.Add(
                new Binding("Text", c["mamonDataGridViewTextBoxColumn", e.RowIndex], "Value", false));
        }
        private void DgvGiamgiathucuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView c = sender as DataGridView;
            if (txbmachon.DataBindings.Count > 0)
                txbmachon.DataBindings.RemoveAt(0);

            // The code binds column index 2 to the TextBox control
            txbmachon.DataBindings.Add(
                new Binding("Text", c["mathucuongDataGridViewTextBoxColumn", e.RowIndex], "Value", false));
        }
    }
}
