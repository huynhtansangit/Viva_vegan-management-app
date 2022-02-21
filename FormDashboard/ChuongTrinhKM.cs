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
namespace Viva_vegan.FormDashboard
{
    public partial class ChuongTrinhKm : Form
    {
        private DataTable LoaiCTKM = new DataTable();
        private List<CHUONGTRINHKM> cHUONGTRINHKMs = new List<CHUONGTRINHKM>();
        private List<DIEUKIENKM> dIEUKIENKMs = new List<DIEUKIENKM>();
        private bool themChuongTrinhKmIsCalled = false;
        private bool quanLiChuongTrinhKmIsCalled = false;
        
        public ChuongTrinhKm()
        {
            InitializeComponent();
            rbChuaApDung.Checked = true;
            OptimizedPerformance.formatCurrency(dgvDkkm);
        }

        private async void ChuongTrinhKm_Load(object sender, EventArgs e)
        {
            LoaiCTKM = await new LoaiCTKM().getAllLoaiCtkmTable();
            new LoaiCTKM().fromDataTableToCbb(LoaiCTKM, cbbLoaiCTKM);
            btnGenMaCtkm.PerformClick();
            string value = dtpTo.Value.ToLongDateString() + " " + dtpTo.Value.ToLongTimeString();
            lblTo.Text = lblFrom.Text = value;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker From = sender as DateTimePicker;
            string value = From.Value.ToLongDateString() + " " + From.Value.ToLongTimeString();
            lblFrom.Text = value;
        }

        private void DtpTo_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker To = sender as DateTimePicker;
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show(this, "Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            string value = To.Value.ToLongDateString() + " " + To.Value.ToLongTimeString();
            lblTo.Text = value;
        }
        private void CbbLoaiCTKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbLoaiCTKM.SelectedIndex)
            {
                //Tang Diem 
                case 0:
                    {
                        FormTangDiemKhuyenMai tangDiemKhuyenMai = new FormTangDiemKhuyenMai();
                        tangDiemKhuyenMai.TopLevel = false;
                        tangDiemKhuyenMai.AutoScroll = true;
                        tangDiemKhuyenMai.Size = new Size(new Point(600, 500));
                        tangDiemKhuyenMai.Dock = DockStyle.Fill;
                        pnControlContainer.Controls.Clear();
                        pnControlContainer.Controls.Add(tangDiemKhuyenMai);
                        tangDiemKhuyenMai.Show();
                        break;
                    }
                //Giam gia hoa don
                case 1:
                    {
                        FormGiamGiaHoaDon fromGiamGiaHD = new FormGiamGiaHoaDon();
                        fromGiamGiaHD.TopLevel = false;
                        fromGiamGiaHD.AutoScroll = true;
                        fromGiamGiaHD.Size = new Size(new Point(600, 500));
                        fromGiamGiaHD.Dock = DockStyle.Fill;
                        pnControlContainer.Controls.Clear();
                        pnControlContainer.Controls.Add(fromGiamGiaHD);
                        fromGiamGiaHD.Show();
                        break;
                    }
            }
            rtbGhiChu.GotFocus += CTKMFunction.RemoveText;
            rtbGhiChu.LostFocus += CTKMFunction.AddText;

        }
        private bool validateInput()
        {
            string ma = txbmactkm.Text;
            string ten = txbtenctkm.Text;
            DateTime from = dtpFrom.Value;
            DateTime To = dtpTo.Value;
            if (
                string.IsNullOrWhiteSpace(ma) ||
                string.IsNullOrWhiteSpace(ten)
                )
            {
                OptimizedPerformance.alertError("Vui lòng không bỏ trống trường có *");
                return false;
            }
            else if (from >= To)
            {
                OptimizedPerformance.alertError("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return false;
            }
            else return true;
        }
        private async void BtnThemKm_Click(object sender, EventArgs e)
        {
            List<DieuKienKM> listDieuKienKm = new List<DieuKienKM>();
            string makm = txbmactkm.Text;
            string ten = txbtenctkm.Text;
            var checkedButton = pngroubbutton.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            string trangthai = (checkedButton as RadioButton).Tag.ToString();
            string maloaikm = (cbbLoaiCTKM.SelectedItem as LoaiCTKM.ComboBoxItem).Tag.ToString();
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            //---------------
            if (maloaikm.Contains("DIEM"))
            {
                listDieuKienKm.Clear();
                FormTangDiemKhuyenMai form = new FormTangDiemKhuyenMai();
                foreach (Control child in pnControlContainer.Controls)
                {
                    if (child is FormTangDiemKhuyenMai)
                    {
                        form = child as FormTangDiemKhuyenMai;
                    }
                }
                DataGridView dgvthemdieukien = form.Controls.Find("dgvdieukientangdiem", true)[0] as DataGridView;
                foreach (DataGridViewRow row in dgvthemdieukien.Rows)
                {
                    if (row.Cells["tongtienmua"].Value != null && row.Cells["sodiemtang"].Value != null)
                    {
                        string madieukienkm = CTKMFunction.generateCode(10);
                        string tongtienmua = row.Cells["tongtienmua"].Value.ToString();
                        string sodiemtang = row.Cells["sodiemtang"].Value.ToString();
                        listDieuKienKm.Add(new DieuKienKM(makm, madieukienkm, "", "", decimal.Parse(sodiemtang), 0, decimal.Parse(tongtienmua)));
                    }
                }
            }
            else if (maloaikm.Contains("GGHD"))
            {
                listDieuKienKm.Clear();
                FormGiamGiaHoaDon form = new FormGiamGiaHoaDon();
                foreach (Control child in pnControlContainer.Controls)
                {
                    if (child is FormGiamGiaHoaDon)
                    {
                        form = child as FormGiamGiaHoaDon;
                    }
                }
                DataGridView dgvthemdieukien = form.Controls.Find("dgvDieuKien", true)[0] as DataGridView;
                foreach (DataGridViewRow row in dgvthemdieukien.Rows)
                {
                    string madieukienkm = CTKMFunction.generateCode(10);
                    if (row.Cells["tongtienmua"].Value != null && row.Cells["giamgia"].Value != null)
                    {
                        string tongtienmua = row.Cells["tongtienmua"].Value.ToString();
                        string giamgia = row.Cells["giamgia"].Value.ToString();
                        listDieuKienKm.Add(new DieuKienKM(makm, madieukienkm, "", "", 0, decimal.Parse(giamgia), decimal.Parse(tongtienmua)));
                    }
                }
            }
            //else if (maloaikm.Contains("GGSP"))
            //{
            //    listDieuKienKm.Clear();
            //    formGiamGiaSp form = new formGiamGiaSp();
            //    foreach (Control child in pnControlContainer.Controls)
            //    {
            //        if (child is formGiamGiaSp)
            //        {
            //            form = child as formGiamGiaSp;
            //        }
            //    }
            //    TextBox txbmachon = form.Controls.Find("txbmachon", true)[0] as TextBox;
            //    TextBox txbgiamgia = form.Controls.Find("txbgiamgia", true)[0] as TextBox;
            //    ComboBox cbbWhichDgvDisplay = form.Controls.Find("cbbWhichDgvDisplay", true)[0] as ComboBox;
            //    string madieukienkm = CTKMFunction.generateCode(10);
            //    string machon = txbmachon.Text;
            //    string giamgia = txbgiamgia.Text;
            //    string whichTable = cbbWhichDgvDisplay.Text;
            //    if (!string.IsNullOrWhiteSpace(machon) && !string.IsNullOrWhiteSpace(giamgia))
            //    {
            //        if (cbbWhichDgvDisplay.SelectedIndex == 0)
            //        {
            //            int res = await CTKMFunction.kiemTraCoKMHayChua(machon, "ma");
            //            if (res < 1)
            //            {
            //                Console.WriteLine(res);
            //                listDieuKienKm.Add(new DieuKienKM(makm, madieukienkm, "", machon, 0, decimal.Parse(giamgia), 0));
            //            }
            //            else
            //            {
            //                OptimizedPerformance.alertError("Sản phẩm này đang được KM");
            //                return;
            //            }
            //        }
            //        else if (cbbWhichDgvDisplay.SelectedIndex == 1)
            //        {
            //            if (await CTKMFunction.kiemTraCoKMHayChua(machon, "tu") < 1)
            //            {
            //                listDieuKienKm.Add(new DieuKienKM(makm, madieukienkm, machon, "", 0, decimal.Parse(giamgia), 0));
            //            }
            //            else
            //            {
            //                OptimizedPerformance.alertError("Sản phẩm này đang được KM");
            //                return;
            //            }

            //        }
            //    }
            //    else
            //    {
            //        OptimizedPerformance.alertError("Không bỏ trống điều kiện KM");
            //    }
            //}
            else
            {
                MessageBox.Show("Không được bỏ trống những trường có *");
            }
            if (validateInput() && listDieuKienKm.Any())
            {
                try
                {
                    string queryCTKM = "themchuongtrinhkm @makm @maloaikm @tenkm @ngaybatdau @ngayketthuc @trangthai @ghichu";
                    int resCTKM = await ConnectDataBase.SessionConnect.executeNonQueryAsync(queryCTKM, new object[]
                    {
                    makm, maloaikm, ten,from, to,trangthai,rtbGhiChu.Text
                    });
                    if (resCTKM > 0)
                    {
                        int res = 0;
                        foreach (DieuKienKM item in listDieuKienKm)
                        {
                            string query = "themdieukienkm @madieukienkm @makm @mathucuong @mamonan @diemtang @phantramgiamgia @tongtienmua";
                            int i = await ConnectDataBase.SessionConnect.executeNonQueryAsync(query, new object[] {
                        item.MadieukienKM,item.Makm,item.Mathucuong,item.Mamonan,item.Diemtang,item.Giamgia,item.Tongtienmua
                    });
                            res += i;
                        }
                        if (res == listDieuKienKm.Count)
                        {

                            OptimizedPerformance.alertSuccess("Thêm điều kiện thành công");
                            btnClearText.PerformClick();
                            btnGenMaCtkm.PerformClick();
                        }
                    }
                }
                catch (Exception ex)
                {
                    OptimizedPerformance.showSomeThingWentWrong();
                    OptimizedPerformance.log(ex);
                }
            }
        }

        private void BtnGenMaCtkm_Click(object sender, EventArgs e)
        {
            string ma = CTKMFunction.generateCode();
            if (!string.IsNullOrWhiteSpace(ma))
            {
                txbmactkm.Text = ma;
            }
        }

        private void BtnClearText_Click(object sender, EventArgs e)
        {
            OptimizedPerformance.ClearAllText(panel4);
        }
        #region Tab quản lý KM
        Entities1 qlnh = new Entities1();


        #endregion


        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        if (themChuongTrinhKmIsCalled)
                        {
                            break;
                        }
                        else
                        {
                            themChuongTrinhKmIsCalled = true;
                        }
                        break;
                    }
                case 1:
                    {
                        if (!quanLiChuongTrinhKmIsCalled)
                        {
                            loadCtkm();
                            loadDkkm();
                            quanLiChuongTrinhKmIsCalled = true;
                        }
                        break;
                    }
            }
        }
        
        private async void loadCtkm()
        {
            try
            {
                cHUONGTRINHKMs = qlnh.CHUONGTRINHKMs.ToList();
                dgvCtkm.DataSource = cHUONGTRINHKMs;
                cHUONGTRINHKMs.ForEach(i => Console.WriteLine("{0}\t", i));
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private async void loadDkkm()
        {
            try
            {
                dIEUKIENKMs = qlnh.DIEUKIENKMs.ToList();
                dgvDkkm.DataSource = dIEUKIENKMs;
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            loadDkkm();
            loadCtkm();
        }

        private void DgvCtkm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if(e.RowIndex!=-1)
                {
                    string makm = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
                    OptimizedPerformance.log(makm);
                    dgvDkkm.DataSource = qlnh.DIEUKIENKMs.Where(x => x.MAKM == makm).ToList();
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgvKhuyenMai_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
        }

        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //when i press enter,bellow code never run?
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    OptimizedPerformance.log((sender as TextBox).Text);
                }
                catch (Exception ex)
                {
                    OptimizedPerformance.showSomeThingWentWrong();
                    OptimizedPerformance.log(ex);
                }
            }
        }

        private async void DgvCtkm_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            OptimizedPerformance.log(colIndex);
            OptimizedPerformance.log(rowIndex);
            string makm = dgvCtkm[0, rowIndex].Value.ToString();
            if (e.ColumnIndex == 2)
            {
                if (!(dgvCtkm[colIndex, rowIndex].Value is null))
                {
                    string tenkm = dgvCtkm[colIndex, rowIndex].Value.ToString();
                    OptimizedPerformance.log(tenkm);
                    if (!string.IsNullOrWhiteSpace(tenkm))
                    {
                        string query = "update chuongtrinhkm set tenkm=N'" + tenkm + "' where makm='"+makm+"'";
                        int res = await ConnectDataBase.SessionConnect.executeNonQueryAsync(query);
                        if(res>0)
                        {
                            OptimizedPerformance.alertSuccess("Cập nhật tên KM thành công");
                        }
                        else
                        {
                            OptimizedPerformance.alertError("Thất bại");
                        }
                    }
                    else
                    {
                        OptimizedPerformance.alertError("Tên không hợp lệ");
                        dgvCtkm.SelectedCells[0].Value.ToString();
                    }
                }
                else
                {
                    OptimizedPerformance.alertError("Tên không hợp lệ");
                    dgvCtkm.SelectedCells[0].Value.ToString();
                }
            }
        }
        private void BtnRefresh_Click_1(object sender, EventArgs e)
        {
            loadCtkm();
            loadDkkm();
        }
        private void DgvCtkm_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string makm = dgvCtkm[0, e.RowIndex].Value.ToString();
            dgvDkkm.DataSource = qlnh.DIEUKIENKMs.Where(x => x.MAKM == makm).ToList();
        }
    }
}
