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
using XanderUI;
using FontAwesome.Sharp;
using Viva_vegan.FormDashboard.GoiMonChild;
using System.IO;
using Viva_vegan.ClassCSharp.ChuongTrinhKM;
namespace Viva_vegan.FormDashboard
{
    public partial class GoiMon : Form
    {
        private List<ThucUong> GetThucUongs = new List<ThucUong>();
        private List<MonAn> GetMonAns = new List<MonAn>();
        public List<BanDangHoatDong> banDangHoatDongs = new List<BanDangHoatDong>();
        private List<BaoCheBien> listBaoCheBien = new List<BaoCheBien>();
        private Boolean chonBan = false;
        private SoTienGocKhiThanhToan tienGocKhiThanhToan = new SoTienGocKhiThanhToan();
        public KHACHHANG kh = new KHACHHANG();
        private bool isCheckOut = false;
        private Form currentChildForm;
        public bool ChonBan { get => chonBan; set => chonBan = value; }

        public GoiMon()
        {
            InitializeComponent();
            resizeDgvHoadon();
            txbtienkhachdua.Enabled = false;
        }

        public string btnText
        {
            get
            {
                return this.btnChonban.Text;
            }
            set
            {
                this.btnChonban.Text = value;
            }
        }

        internal List<BaoCheBien> ListBaoCheBien { get => listBaoCheBien; set => listBaoCheBien = value; }
        internal SoTienGocKhiThanhToan TienGocKhiThanhToan { get => tienGocKhiThanhToan; set => tienGocKhiThanhToan = value; }
        public bool IsCheckOut { get => isCheckOut; set => isCheckOut = value; }

        #region Methods
        public void ClearThanhToanInfo(Control con)
        {
            //txbsotiendagiam.Text = "";
            //txbtienkhachdua.Text = "";
            //btnthanhtien.ButtonText = "";
            //btnvat.ButtonText = "";
            //btnkhuyenmai.ButtonText = "";
            //btntienthua.ButtonText = "";
            //-- tag
            //txbsotiendagiam.Tag = 0;
            //txbtienkhachdua.Tag = 0;
            //btnthanhtien.Tag = 0;
            //btnvat.Tag = 0;
            //btnkhuyenmai.Tag = 0;
            //btntienthua.Tag = 0;
            foreach (Control c in con.Controls)
            {
                if (c is XUIButton)
                {
                    XUIButton x = c as XUIButton;
                    if (x.Name == "btngoimonthanhtoan" || x.Name == "btnCapnhathoadon" ||x.Name== "btnApplykm")
                    {

                    }
                    else
                    {
                        x.Tag = 0;
                        x.ButtonText = "0đ";
                    }
                }
                else if (c is TextBox)
                {
                    TextBox x = c as TextBox;
                    x.Tag = 0;
                    x.Text = "0đ";
                }
                else ClearThanhToanInfo(c);
            }
        }
        private void activeButton()
        {
            if (chonBan == false)
            {
                chonBan = true;
                btnChonban.IconChar = IconChar.ChevronUp;
                btnChonban.ImageAlign = ContentAlignment.MiddleRight;
                btnChonban.Text = "Thu gọn";

            }
            else
            {
                chonBan = false;
                btnChonban.IconChar = IconChar.ChevronDown;
                btnChonban.ImageAlign = ContentAlignment.MiddleLeft;
                btnChonban.Text = "Chọn bàn";
            }
            openChildForm(new FormBan(this));
        }
        private void openChildForm(Form childForm)
        {
            if (chonBan == false)
            {
                // chỉ mở một form
                currentChildForm.Close();
            }
            else
            {
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnBan.Controls.Add(childForm);
                pnBan.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void loadTheoTuKhoa(string ThucanNuocuong, String tukhoa)
        {
            flpthucdon.Controls.Clear();
            if (ThucanNuocuong.Contains("thucuong"))
            {
                GetThucUongs = new ThucUong().getThucUongTheoTuKhoa(tukhoa, cbbtimtheo.Text);
                foreach (ThucUong item in GetThucUongs)
                {
                    flpthucdon.Controls.Add(groupMonAnThucUong("thucuong", null, item));
                }
            }
            else if (ThucanNuocuong.Contains("monan"))
            {
                GetMonAns = new MonAn().getMonAnTheoTuKhoa(tukhoa, cbbtimtheo.Text);
                foreach (MonAn item in GetMonAns)
                {
                    flpthucdon.Controls.Add(groupMonAnThucUong("monan", item));
                }
            }
        }
        private async void loadMonAnThucUong(string ThucanNuocuong, String order = null)
        {
            flpthucdon.Controls.Clear();
            if (ThucanNuocuong.Contains("thucuong"))
            {
                GetThucUongs = new ThucUong().GetThucUongs();
                if (String.IsNullOrWhiteSpace(order))
                {
                    GetThucUongs = new ThucUong().GetThucUongs();
                    foreach (ThucUong item in GetThucUongs)
                    {
                        flpthucdon.Controls.Add(groupMonAnThucUong("thucuong", null, item));
                    }
                }
                else
                {
                    GetThucUongs = new ThucUong().GetThucUongs(order);
                    foreach (ThucUong item in GetThucUongs)
                    {
                        flpthucdon.Controls.Add(groupMonAnThucUong("thucuong", null, item));
                    }
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(order))
                {
                    GetMonAns = await new MonAn().GetMonAns();
                    foreach (MonAn item in GetMonAns)
                    {
                        flpthucdon.Controls.Add(groupMonAnThucUong("monan", item));
                    }
                }
                else
                {
                    GetMonAns = new MonAn().GetMonAns(order);
                    foreach (MonAn item in GetMonAns)
                    {
                        flpthucdon.Controls.Add(groupMonAnThucUong("monan", item));
                    }
                }
            }
        }

        private XUICustomGroupbox groupMonAnThucUong(String loai, MonAn monan = null, ThucUong thucuong = null)
        {
            XUICustomGroupbox groupbox = new XUICustomGroupbox();
            PictureBox pictureBox = new PictureBox();
            Label lbltenmon = new Label();

            groupbox.BorderWidth = 2;
            groupbox.FlatStyle = FlatStyle.Flat;
            groupbox.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupbox.ShowText = true;
            groupbox.Size = new System.Drawing.Size(159, 227);
            groupbox.Margin = new Padding(30, 0, 0, 0);

            //picture
            pictureBox.MouseEnter += Picture_MouseHover;
            pictureBox.MouseLeave += Picture_MouseLeave;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 18);
            pictureBox.Size = new Size(153, 136);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Click += clickThucDon;
            //label
            lbltenmon.Dock = DockStyle.Bottom;
            lbltenmon.Location = new Point(3, 154);
            lbltenmon.Size = new Size(153, 50);

            lbltenmon.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (loai.Contains("monan"))
            {
                lbltenmon.Text = monan.Tenmon;
                pictureBox.Tag = monan.Mamon;
                groupbox.Text = monan.Giaban.ToString("C0");
                MemoryStream mem = new MemoryStream(monan.Hinh);
                pictureBox.Image = System.Drawing.Image.FromStream(mem);
                groupbox.TextColor = System.Drawing.Color.Maroon;
                groupbox.BorderColor = System.Drawing.Color.Maroon;
                groupbox.Name = "gb" + monan.Mamon;
            }
            else
            {
                lbltenmon.Text = thucuong.Tenthucuong;
                pictureBox.Tag = thucuong.Mathucuong;
                groupbox.Text = thucuong.Giaban.ToString("C0");
                MemoryStream mem = new MemoryStream(thucuong.Hinh);
                pictureBox.Image = System.Drawing.Image.FromStream(mem);
                groupbox.BorderColor = Color.MidnightBlue;
                groupbox.TextColor = Color.MidnightBlue;
            }
            groupbox.Controls.Add(pictureBox);
            groupbox.Controls.Add(lbltenmon);
            return groupbox;
        }
        private void resizeDgvHoadon()
        {
            dgvhoadon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvhoadon.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvhoadon.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvhoadon.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvhoadon.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvhoadon.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvhoadon.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        public Boolean daTonTaiTrongDgv(String mamon)
        {

            if (dgvhoadon.Rows[0].Cells["mamon"].Value != null)
            {
                foreach (DataGridViewRow row in dgvhoadon.Rows)
                {
                    if (row.Cells["MAMON"].Value != null)
                    {
                        if (row.Cells["MAMON"].Value.ToString().Contains(mamon))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        #endregion Methods

        #region Events
        private void Picture_MouseHover(object sender, EventArgs e)
        {
            PictureBox temp = sender as PictureBox;
            XUICustomGroupbox gb = temp.Parent as XUICustomGroupbox;
            gb.BorderColor = Color.Aqua;
            gb.TextColor = Color.Aqua;
        }
        private void Picture_MouseLeave(object sender, EventArgs e)
        {
            PictureBox temp = sender as PictureBox;
            XUICustomGroupbox gb = temp.Parent as XUICustomGroupbox;
            if (temp.Tag.ToString().Contains("MA"))
            {
                gb.BorderColor = Color.Maroon;
                gb.TextColor = Color.Maroon;
                gb.Size = new System.Drawing.Size(159, 227);
            }
            else
            {
                gb.BorderColor = Color.MidnightBlue;
                gb.TextColor = Color.MidnightBlue;
                gb.Size = new System.Drawing.Size(159, 227);
            }
        }
        private void clickThucDon(object sender, EventArgs e)
        {
            try
            {
                String ma = (sender as PictureBox).Tag.ToString();
                DataGridViewRow row = (DataGridViewRow)dgvhoadon.Rows[0].Clone();
                if (ma.Contains("MA") & !daTonTaiTrongDgv(ma))
                {
                    MonAn monAn = new MonAn(ma);
                    row.Cells[0].Value = monAn.Mamon;
                    row.Cells[1].Value = monAn.Tenmon;
                    row.Cells[2].Value = monAn.Dvt;
                    row.Cells[3].Value = OptimizedPerformance.formatCurrency(decimal.Parse(monAn.Giaban.ToString()));
                    row.Cells[4].Value = 1;
                    row.Cells[5].Value = OptimizedPerformance.formatCurrency(decimal.Parse(monAn.Giaban.ToString()));
                    dgvhoadon.Rows.Add(row);
                }
                else if (ma.Contains("TU") & !daTonTaiTrongDgv(ma))
                {
                    ThucUong thucUong = new ThucUong(ma);
                    row.Cells[0].Value = thucUong.Mathucuong;
                    row.Cells[1].Value = thucUong.Tenthucuong;
                    row.Cells[2].Value = thucUong.Dvt;
                    row.Cells[3].Value = OptimizedPerformance.formatCurrency(decimal.Parse(thucUong.Giaban.ToString()));
                    row.Cells[4].Value = 1;
                    row.Cells[5].Value = OptimizedPerformance.formatCurrency(decimal.Parse(thucUong.Giaban.ToString()));
                    dgvhoadon.Rows.Add(row);
                }
                else if (daTonTaiTrongDgv(ma))
                {
                    MessageBox.Show("Món đã tồn tại trong thực đơn", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }

        }
        // xóa row dgv thực đơn.
        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && dgvhoadon.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (senderGrid.Rows[e.RowIndex].Tag == null)
                {
                    dgvhoadon.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    // Cấm hủy những món đã lưu trong hóa đơn.
                    if (e.RowIndex < Convert.ToInt16(senderGrid.Rows[e.RowIndex].Tag))
                        MessageBox.Show("Không cho phép hủy món đã gọi " + e.RowIndex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        dgvhoadon.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
        private void GoiMon_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 1000)
            {
                pnThucDon.Width = this.Width / 2 - 40;
            }
            else
            {
                pnThucDon.Width = this.Width / 2 - 200;
            }
        }
        private void IconButton1_Click(object sender, EventArgs e)
        {
            activeButton();
        }
        private void Btnthucuong_Click(object sender, EventArgs e)
        {
            loadMonAnThucUong("thucuong");
        }
        private void Btnmonan_Click(object sender, EventArgs e)
        {
            loadMonAnThucUong("monan");
        }
        // check chỉ cho phép nhập số
        private void Dgvhoadon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int rowindex = dgvhoadon.CurrentCell.RowIndex;
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvhoadon.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Dgvhoadon_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            try
            {
                dgvhoadon.Tag = Convert.ToDecimal( dgvhoadon[e.ColumnIndex, e.RowIndex].Value);
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private void Dgvhoadon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    int i = Convert.ToInt16(dgvhoadon.Rows[e.RowIndex].Cells[4].Value);
                    if (i != 0)
                    {
                        decimal soluong = Convert.ToDecimal(dgvhoadon.Rows[e.RowIndex].Cells[4].Value);
                        decimal dongia = OptimizedPerformance.ParseDecimalFromCurrency(dgvhoadon.Rows[e.RowIndex].Cells["dongia"].Value.ToString());
                        decimal thanhtien = soluong * dongia;
                        dgvhoadon.Rows[e.RowIndex].Cells[5].Value = OptimizedPerformance.formatCurrency(thanhtien);
                    }
                    else
                    {
                        dgvhoadon.Rows[e.RowIndex].Cells["soluong"].Value = dgvhoadon.Tag;
                        MessageBox.Show("Số lượng không hợp lệ ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        decimal soluong = Convert.ToDecimal(dgvhoadon.Rows[e.RowIndex].Cells[4].Value);
                        decimal dongia = OptimizedPerformance.ParseDecimalFromCurrency(dgvhoadon.Rows[e.RowIndex].Cells["dongia"].Value.ToString());
                        decimal thanhtien = soluong * dongia;
                        dgvhoadon.Rows[e.RowIndex].Cells[5].Value = OptimizedPerformance.formatCurrency(thanhtien);
                    }
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        private void Btntim_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(cbbtimtheo.Text))
                {
                    MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm");
                }
                else
                {
                    if (cbbtimtheo.Text.Contains("thấp"))
                    {
                        if (rbtndoan.Checked)
                        {
                            loadMonAnThucUong("monan", "giam");
                        }
                        else loadMonAnThucUong("thucuong", "giam");
                    }
                    else if (cbbtimtheo.Text.Contains("cao"))
                    {
                        if (rbtndoan.Checked)
                        {
                            loadMonAnThucUong("monan", "cao");
                        }
                        else loadMonAnThucUong("thucuong", "cao");
                    }
                    else if (!String.IsNullOrWhiteSpace(txttimkiem.Text))
                    {
                        if (rbtndoan.Checked)
                        {
                            loadTheoTuKhoa("monan", txttimkiem.Text);      // biến truyền vào hàm này
                                                                           // là tìm theo cái gì, từ khóa.
                        }
                        else loadTheoTuKhoa("thucuong", txttimkiem.Text);

                    }

                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        public void enableGetInfoKH()
        {
            try
            {
                cbkhachvanglai.Enabled = true;
                OptimizedPerformance.enableButton(new Button[] {
                    btnkhachvip,btndangkyvip
                    });
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        public void disableGetInfoKH()
        {
            try
            {
                cbkhachvanglai.Enabled = false;
                OptimizedPerformance.disableButton(new Button[] {
                    btnkhachvip,btndangkyvip
                    });
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private void Btngoimonthanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = btnthongtinban.Tag as Ban;
                if (ban != null)
                {
                    if (ban.Trangthai.Contains("empty")) // đang gọi món
                    {
                        goiMon(ban);
                    }
                    else if (ban.Trangthai.Contains("busy")) // đang gọi món
                    {

                        thanhToan(ban);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bàn cần thao tác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        private async void thanhToan(Ban ban)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txbtienkhachdua.Text) ||
                OptimizedPerformance.ParseDecimalFromCurrency(txbtienkhachdua.Text) < decimal.Parse(btntiensaukhigiamm.Tag.ToString()))
                {
                    MessageBox.Show("Số tiền không hợp lệ !");
                }
                else
                {
                    // set lại bàn trống.
                    string makh = "KH000";
                    string maloaikh = "";
                    Int32 vat = Int32.Parse(btnvat.Tag.ToString());
                    Int32 tongthanhtien = Int32.Parse(OptimizedPerformance.roundingNumberReturnString(btntiensaukhigiamm.Tag.ToString()));
                    Int32 tienkhachdua = Int32.Parse(txbtienkhachdua.Text);
                    Int32 tienthua = Int32.Parse(OptimizedPerformance.roundingNumberReturnString(btntienthua.Tag.ToString()));

                    if (!(kh is null))
                    {
                        makh = kh.MAKH;
                        maloaikh = kh.MALOAIKH;
                        tongthanhtien = Int32.Parse(CTKMFunction.solveTotalAfterDiscount(maloaikh, tongthanhtien).ToString());
                        Console.WriteLine("Tong thanh tien sau km: " + tongthanhtien.ToString());
                    }
                    else
                    {
                        makh = "KH000";
                    }
                    String mahoadon = new BanDangHoatDong().getMaHoaDonFromMaBan(ban.Soban);
                    HoaDon hd = new HoaDon(
                        mahoadon,
                        makh,
                        User.Manv,
                        DateTime.Now,
                        null,
                        "Tien mat",
                        ban.Soban,
                        "Đã thanh toán",
                        vat,
                        tongthanhtien,
                        tienkhachdua,
                        tienthua,
                        "KM000");// makm
                    int res = hd.capNhatHoaDon();
                    if (res < 1)
                    {
                        MessageBox.Show("Lỗi");
                    }
                    else
                    {
                        disableGetInfoKH();
                        try
                        {
                            decimal sodiem = Math.Floor((decimal)((tongthanhtien - vat) / 30000));
                            int updateTien = await ConnectDataBase.SessionConnect.executeNonQueryAsync("updateTien @sotien @makh", new object[]{
                                tongthanhtien-vat,makh
                            });
                            int updateDiem = await ConnectDataBase.SessionConnect.executeNonQueryAsync("updateDiem @sodiem @makh", new object[]{
                                sodiem,makh
                            });
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                        }
                        DialogResult result = MessageBox.Show("Thanh toán thành công. Bắt đầu in hóa đơn");
                        new Ban().setEmpty(ban.Soban);
                        if (result == DialogResult.OK)
                        {
                            using (FormPrint f = new FormPrint(this, mahoadon))
                            {
                                if (string.IsNullOrWhiteSpace(makh))
                                {
                                    f.Tag = "KH000-Vãng lai";
                                }
                                else
                                    f.Tag = makh;
                                f.ShowDialog();
                            }
                        }
                    }
                    btnclear.PerformClick();
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        private void goiMon(Ban ban)
        {
            try
            {
                if (dgvhoadon.Rows[0].Cells["mamon"].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn thực đơn !");
                }
                else
                {
                    String mahoadon = new HoaDon().taoMaHoaDon();
                    // chuyển trạng thái bàn
                    int result = new Ban().setBusy(ban.Soban);
                    if (result == 0)
                    {
                        MessageBox.Show("Lỗi chuyển trạng thái bàn");
                    }
                    // Không được bỏ trống mahd, manv, ngaylap, soban, request -- TẠO HÓA ĐƠN
                    HoaDon hoaDon = new HoaDon(mahoadon,
                        "KH000",
                        User.Manv,
                        DateTime.Now,
                        "",
                        "",
                        ban.Soban,
                        "Chưa thanh toán",
                        (Int32)0.1,
                        0,
                        0,
                        0,
                        "KM000");
                    int resultTaoHoaDon = hoaDon.taoHoaDon(hoaDon);
                    if (resultTaoHoaDon == 0)
                    {
                        MessageBox.Show("Lỗi chuyển Tạo hóa đơn");
                    }
                    // tạo chi tiết hóa đơn.
                    int countError = 0;
                    foreach (DataGridViewRow row in dgvhoadon.Rows)
                    {
                        int res = 0;
                        if (row.Cells["mamon"].Value != null)
                        {
                            ChiTietHoaDon cthd = new ChiTietHoaDon();
                            if (row.Cells["mamon"].Value.ToString().Contains("MA")) // is food
                            {
                                cthd = new ChiTietHoaDon(mahoadon,
                                row.Cells["mamon"].Value.ToString(),
                                Convert.ToInt16(row.Cells["soluong"].Value),
                                "",
                                OptimizedPerformance.ParseIntFromCurrency(row.Cells["dongia"].Value.ToString()), "");
                                res = cthd.insertChiTietHoaDon("monan");
                            }
                            else if (row.Cells["mamon"].Value.ToString().Contains("TU")) // is drink
                            {
                                cthd = new ChiTietHoaDon(mahoadon,
                               row.Cells["mamon"].Value.ToString(),
                                Convert.ToInt16(row.Cells["soluong"].Value),
                                "",
                                OptimizedPerformance.ParseIntFromCurrency(row.Cells["dongia"].Value.ToString()), "");
                                res = cthd.insertChiTietHoaDon("thucuong");
                            }

                            if (res == 0)
                            {
                                countError++;
                            }
                        }
                    }
                    DialogResult d = MessageBox.Show("Thành công ! Số lỗi = " + countError);
                    if (d == DialogResult.OK)
                    {
                        btnbaochebien.PerformClick();
                    }
                    dgvhoadon.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
           
        }
        private void Btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                dgvhoadon.Rows.Clear();
                btnthongtinban.Text = "Thông tin bàn";
                btnthongtinban.Tag = null;
                btntrangthai.Text = "Đang thực hiện";
                ClearThanhToanInfo(xuiCustomGroupbox2);
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private int count = 0;
        private void Txttimkiem_MouseClick(object sender, MouseEventArgs e)
        {
            count++;
            if (count == 1)
            {
                txttimkiem.Clear();
            }
        }
        private void BtnCapnhathoadon_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = btnthongtinban.Tag as Ban;
                if (ban == null) return;
                if (ban.Trangthai.Contains("busy"))
                {
                    String mahoadon = new BanDangHoatDong().getMaHoaDonFromMaBan(ban.Soban);
                    int countError = 0;
                    foreach (DataGridViewRow row in dgvhoadon.Rows)
                    {
                        int res = 0;
                        if (row.Cells["mamon"].Value != null)
                        {
                            ChiTietHoaDon cthd = new ChiTietHoaDon();
                            if (row.Cells["mamon"].Value.ToString().Contains("MA")) // is food
                            {
                                cthd = new ChiTietHoaDon(mahoadon,
                                row.Cells["mamon"].Value.ToString(),
                                Convert.ToInt16(row.Cells["soluong"].Value),
                                "",
                                OptimizedPerformance.ParseIntFromCurrency(row.Cells["dongia"].Value.ToString()),
                                "");
                                res = cthd.insertChiTietHoaDon("monan");
                            }
                            else if (row.Cells["mamon"].Value.ToString().Contains("TU")) // is drink
                            {
                                cthd = new ChiTietHoaDon(mahoadon,
                               row.Cells["mamon"].Value.ToString(),
                                Convert.ToInt16(row.Cells["soluong"].Value),
                                "",
                                OptimizedPerformance.ParseIntFromCurrency(row.Cells["dongia"].Value.ToString()),
                                "");
                                res = cthd.insertChiTietHoaDon("thucuong");
                            }

                            if (res == 0)
                            {
                                countError++;
                            }
                        }
                    }
                    DialogResult d = MessageBox.Show("Cập nhật thành công ! Số lỗi = " + countError);
                    if (d == DialogResult.OK)
                    {
                        btnbaochebien.PerformClick();
                    }
                    dgvhoadon.Rows.Clear();

                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private void Txbtienkhachdua_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && !String.IsNullOrWhiteSpace(txbtienkhachdua.Text))
                {
                    decimal tongtiensaukhigiam = 0;
                    tongtiensaukhigiam = decimal.Parse(btntiensaukhigiamm.Tag.ToString());
                    if (Convert.ToInt64(txbtienkhachdua.Text) < tongtiensaukhigiam)
                    {
                        MessageBox.Show("Số tiền không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbtienkhachdua.Text = "";
                    }
                    else
                    {
                        decimal tienthua = Convert.ToDecimal(txbtienkhachdua.Text) - tongtiensaukhigiam;
                        btntienthua.ButtonText = OptimizedPerformance.formatCurrency(decimal.Parse(tienthua.ToString()));
                        btntienthua.Tag = tienthua;
                    }
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private void Txbchietkhau_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter && !String.IsNullOrWhiteSpace(txbsotiendagiam.Text))
                {
                    long value = Convert.ToInt64(txbsotiendagiam.Text);
                    if (value < 100)
                    {
                        txbsotiendagiam.Text = value.ToString();
                    }
                    else
                    {
                        txbsotiendagiam.Text = value.ToString();
                    }
                    txbsotiendagiam.Tag = value;
                    Txbtienkhachdua_KeyDown(sender, e);
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private void Btnbaochebien_Click(object sender, EventArgs e)
        {
            try
            {
                Ban bandangchon = (btnthongtinban.Tag as Ban);
                if ((bandangchon is null))
                {
                    OptimizedPerformance.alertError("Vui lòng chọn bàn!");
                }
                else
                {
                    if (dgvhoadon.Rows.Count > 1)
                    {
                        listBaoCheBien.Clear();
                        foreach (DataGridViewRow row in dgvhoadon.Rows)
                        {
                            if (row.Index > -1 && row.Index < dgvhoadon.Rows.Count - 1)
                            {
                                listBaoCheBien.Add(new ClassCSharp.BaoCheBien(row.Cells["mamon"].Value.ToString(),
                                row.Cells["tenmon"].Value.ToString(),
                                int.Parse(row.Cells["soluong"].Value.ToString())));
                            }
                        }
                        using (FormBaoCheBien f = new FormBaoCheBien(this, bandangchon.Soban, bandangchon.Tenban))
                        {
                            f.ShowDialog();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        private int isClick = 0;
        private void Txttimkiem_Click(object sender, EventArgs e)
        {
            isClick++;
            if (isClick == 1)
            {
                txttimkiem.Text = "";
            }
            else
            {

            }
        }

        #endregion events

        private void Cbkhachvanglai_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbkhachvanglai.Checked)
                {
                    OptimizedPerformance.disableButton(new Button[]
                    {
                    btnkhachvip, btndangkyvip
                    });
                    SoTienGocKhiThanhToan soTien = cbkhachvanglai.Tag as SoTienGocKhiThanhToan;
                    try
                    {
                        btnthanhtien.Tag = decimal.Parse(soTien.Tongtien) + decimal.Parse(soTien.ThueVat);
                        btnthanhtien.ButtonText = OptimizedPerformance.formatCurrency(decimal.Parse(btnthanhtien.Tag.ToString()));
                        btnvat.Tag = soTien.ThueVat;
                        btnvat.ButtonText = OptimizedPerformance.formatCurrency(decimal.Parse(soTien.ThueVat));
                        txbsotiendagiam.Text = OptimizedPerformance.formatCurrency(decimal.Parse("0"));
                        txbsotiendagiam.Tag = decimal.Parse("0");
                        btntiensaukhigiamm.Tag = decimal.Parse(btnthanhtien.Tag.ToString()) + decimal.Parse(btnvat.Tag.ToString()) - decimal.Parse(btnkhuyenmai.Tag.ToString());
                        btntiensaukhigiamm.ButtonText = OptimizedPerformance.formatCurrency(decimal.Parse(btntiensaukhigiamm.Tag.ToString()));
                        btntienthua.Tag = 0;
                        btntienthua.ButtonText = OptimizedPerformance.formatCurrency(decimal.Parse("0"));
                        txbtienkhachdua.Tag = 0;
                        txbtienkhachdua.Text = "0";
                        //cbkhachvanglai.Enabled = false;
                    }
                    catch (Exception x)
                    {
                        OptimizedPerformance.alertError(x.Message);
                    }

                }
                else
                {
                    OptimizedPerformance.enableButton(new Button[]
                   {
                    btnkhachvip, btndangkyvip
                   });
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        private void Btndangkyvip_Click(object sender, EventArgs e)
        {
            try
            {
                if (!((Application.OpenForms["FormDangKyNhanhKH"] as FormDangKyNhanhKH) != null))
                {
                    FormDangKyNhanhKH form = new FormDangKyNhanhKH();
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        private void Btnkhachvip_Click(object sender, EventArgs e)
        {
            try
            {
                if (!((Application.OpenForms["FormKiemTraThongTinKH"] as FormKiemTraThongTinKH) != null))
                {
                    FormKiemTraThongTinKH form = new FormKiemTraThongTinKH(this);
                    form.Show();
                    form.FormClosed += new FormClosedEventHandler(CheckKiemTraThongTinKhClosed);
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        void CheckKiemTraThongTinKhClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                kh = (sender as FormKiemTraThongTinKH).Tag as KHACHHANG;
                if (!(kh is null))
                {
                    cbkhachvanglai.Checked = false;
                    //cbkhachvanglai.Enabled = true;
                    string tongTienDaGiamVip = CTKMFunction.solveTotalAfterDiscount(kh.MALOAIKH, btnthanhtien.Tag).ToString();  // tổng tiền + vat - giamVip
                    string soTienGiam = CTKMFunction.solveDiscount(kh.MALOAIKH, btnthanhtien.Tag).ToString();
                    string soTienKhuyenMai = btnkhuyenmai.Tag.ToString();
                    txbsotiendagiam.Text = OptimizedPerformance.formatCurrency(decimal.Parse(soTienGiam));
                    txbsotiendagiam.Tag = decimal.Parse(soTienGiam);
                    btntiensaukhigiamm.Tag = decimal.Parse(tongTienDaGiamVip) - decimal.Parse(soTienKhuyenMai);
                    btntiensaukhigiamm.ButtonText = OptimizedPerformance.formatCurrency(decimal.Parse(btntiensaukhigiamm.Tag.ToString()));
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
        public static void RemoveText(object sender, EventArgs e)
        {
            TextBox rich = sender as TextBox;
            if (rich.Text.Contains("0đ"))
            {
                rich.Text = "";
            }
        }

        public static void AddText(object sender, EventArgs e)
        {
            TextBox rich = sender as TextBox;
            if (string.IsNullOrWhiteSpace(rich.Text))
                rich.Text = "0đ";
        }
        private void GoiMon_Load(object sender, EventArgs e)
        {
            try
            {
                cbkhachvanglai.Enabled = false;
                OptimizedPerformance.disableButton(new Button[] {
                btnkhachvip,btndangkyvip
            });
                txbtienkhachdua.GotFocus += RemoveText;
                txbtienkhachdua.LostFocus += AddText;
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        private void Txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btntim.PerformClick();
            }
        }

        private void Btnkhuyenmai_Click(object sender, EventArgs e)
        {

        }

        private void BtnApplykm_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tongthanhtien = OptimizedPerformance.ParseDecimalFromCurrency(btnthanhtien.Tag.ToString());
                if (tongthanhtien > 0)
                {
                    if (kh.MAKH is null)
                    {
                        OptimizedPerformance.alertError("Chỉ được apply khách hàng đã có tài khoản");
                    }
                    else
                    {
                        if (!(kh.MAKH.Contains("KH000")))
                        {
                            OptimizedPerformance.log(kh.MAKH);
                            FormApplyCTKM form = new FormApplyCTKM(tongthanhtien, kh.MAKH, this);
                            form.Show();
                        }
                        else
                        {
                            OptimizedPerformance.alertError("Chỉ được apply khách hàng đã có tài khoản");
                        }
                    }
                }
                else
                {
                    OptimizedPerformance.alertError("Chỉ được apply khi thanh toán");
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }
    }
}
