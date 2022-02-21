namespace Viva_vegan.FormDashboard
{
    partial class ChuongTrinhKm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuongTrinhKm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGenMaCtkm = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearText = new System.Windows.Forms.Button();
            this.btnThemKm = new System.Windows.Forms.Button();
            this.btnsua = new FontAwesome.Sharp.IconButton();
            this.pnControlContainer = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLoaiCTKM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbtenctkm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmactkm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pngroubbutton = new System.Windows.Forms.Panel();
            this.rbChuaApDung = new System.Windows.Forms.RadioButton();
            this.rbKichhoat = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDkkm = new System.Windows.Forms.DataGridView();
            this.dIEUKIENKMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cHUONGTRINHKMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCtkm = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pngroubbutton.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDkkm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEUKIENKMBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUONGTRINHKMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtkm)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 847);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1103, 815);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm chương trình KM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGenMaCtkm);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnClearText);
            this.panel4.Controls.Add(this.btnThemKm);
            this.panel4.Controls.Add(this.btnsua);
            this.panel4.Controls.Add(this.pnControlContainer);
            this.panel4.Controls.Add(this.lblTo);
            this.panel4.Controls.Add(this.lblFrom);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dtpTo);
            this.panel4.Controls.Add(this.dtpFrom);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbbLoaiCTKM);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.rtbGhiChu);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txbtenctkm);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txbmactkm);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pngroubbutton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 809);
            this.panel4.TabIndex = 10;
            // 
            // btnGenMaCtkm
            // 
            this.btnGenMaCtkm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnGenMaCtkm.FlatAppearance.BorderSize = 0;
            this.btnGenMaCtkm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenMaCtkm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGenMaCtkm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenMaCtkm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenMaCtkm.IconColor = System.Drawing.Color.Black;
            this.btnGenMaCtkm.IconSize = 28;
            this.btnGenMaCtkm.Location = new System.Drawing.Point(607, 11);
            this.btnGenMaCtkm.Name = "btnGenMaCtkm";
            this.btnGenMaCtkm.Rotation = 0D;
            this.btnGenMaCtkm.Size = new System.Drawing.Size(57, 27);
            this.btnGenMaCtkm.TabIndex = 33;
            this.btnGenMaCtkm.Text = "Tạo mã";
            this.btnGenMaCtkm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenMaCtkm.UseVisualStyleBackColor = false;
            this.btnGenMaCtkm.Click += new System.EventHandler(this.BtnGenMaCtkm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(672, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 22);
            this.label10.TabIndex = 32;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(670, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(670, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "*";
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(885, 139);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(180, 42);
            this.btnClearText.TabIndex = 31;
            this.btnClearText.Text = "Clear Text";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.BtnClearText_Click);
            // 
            // btnThemKm
            // 
            this.btnThemKm.Location = new System.Drawing.Point(705, 139);
            this.btnThemKm.Name = "btnThemKm";
            this.btnThemKm.Size = new System.Drawing.Size(180, 42);
            this.btnThemKm.TabIndex = 30;
            this.btnThemKm.Text = "Thêm KM";
            this.btnThemKm.UseVisualStyleBackColor = true;
            this.btnThemKm.Click += new System.EventHandler(this.BtnThemKm_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.White;
            this.btnsua.Enabled = false;
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnsua.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnsua.IconColor = System.Drawing.Color.Black;
            this.btnsua.IconSize = 28;
            this.btnsua.Location = new System.Drawing.Point(705, 0);
            this.btnsua.Name = "btnsua";
            this.btnsua.Rotation = 0D;
            this.btnsua.Size = new System.Drawing.Size(40, 31);
            this.btnsua.TabIndex = 29;
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = false;
            // 
            // pnControlContainer
            // 
            this.pnControlContainer.BackColor = System.Drawing.Color.White;
            this.pnControlContainer.Location = new System.Drawing.Point(9, 333);
            this.pnControlContainer.Name = "pnControlContainer";
            this.pnControlContainer.Size = new System.Drawing.Size(690, 500);
            this.pnControlContainer.TabIndex = 28;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(436, 304);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(0, 19);
            this.lblTo.TabIndex = 27;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(87, 304);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(0, 19);
            this.lblFrom.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(195, 237);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(472, 2);
            this.panel5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Đến ngày";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(440, 261);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(230, 26);
            this.dtpTo.TabIndex = 24;
            this.dtpTo.ValueChanged += new System.EventHandler(this.DtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(91, 261);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(230, 26);
            this.dtpFrom.TabIndex = 24;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Thời gian áp dụng";
            // 
            // cbbLoaiCTKM
            // 
            this.cbbLoaiCTKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiCTKM.FormattingEnabled = true;
            this.cbbLoaiCTKM.Location = new System.Drawing.Point(111, 182);
            this.cbbLoaiCTKM.Name = "cbbLoaiCTKM";
            this.cbbLoaiCTKM.Size = new System.Drawing.Size(556, 30);
            this.cbbLoaiCTKM.TabIndex = 22;
            this.cbbLoaiCTKM.SelectedIndexChanged += new System.EventHandler(this.CbbLoaiCTKM_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hình thức";
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbGhiChu.Location = new System.Drawing.Point(757, 5);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(393, 128);
            this.rtbGhiChu.TabIndex = 20;
            this.rtbGhiChu.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Trạng thái";
            // 
            // txbtenctkm
            // 
            this.txbtenctkm.Location = new System.Drawing.Point(239, 54);
            this.txbtenctkm.Name = "txbtenctkm";
            this.txbtenctkm.Size = new System.Drawing.Size(428, 30);
            this.txbtenctkm.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên chương trình KM";
            // 
            // txbmactkm
            // 
            this.txbmactkm.Location = new System.Drawing.Point(239, 9);
            this.txbmactkm.Name = "txbmactkm";
            this.txbmactkm.ReadOnly = true;
            this.txbmactkm.Size = new System.Drawing.Size(428, 30);
            this.txbmactkm.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã chương trình KM";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(696, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 120);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(9, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 4);
            this.panel2.TabIndex = 16;
            // 
            // pngroubbutton
            // 
            this.pngroubbutton.Controls.Add(this.rbChuaApDung);
            this.pngroubbutton.Controls.Add(this.rbKichhoat);
            this.pngroubbutton.Location = new System.Drawing.Point(239, 96);
            this.pngroubbutton.Name = "pngroubbutton";
            this.pngroubbutton.Size = new System.Drawing.Size(428, 37);
            this.pngroubbutton.TabIndex = 15;
            // 
            // rbChuaApDung
            // 
            this.rbChuaApDung.AutoSize = true;
            this.rbChuaApDung.Location = new System.Drawing.Point(276, 3);
            this.rbChuaApDung.Name = "rbChuaApDung";
            this.rbChuaApDung.Size = new System.Drawing.Size(148, 26);
            this.rbChuaApDung.TabIndex = 1;
            this.rbChuaApDung.TabStop = true;
            this.rbChuaApDung.Tag = "Not yet apply";
            this.rbChuaApDung.Text = "Chưa áp dụng";
            this.rbChuaApDung.UseVisualStyleBackColor = true;
            // 
            // rbKichhoat
            // 
            this.rbKichhoat.AutoSize = true;
            this.rbKichhoat.Location = new System.Drawing.Point(3, 3);
            this.rbKichhoat.Name = "rbKichhoat";
            this.rbKichhoat.Size = new System.Drawing.Size(118, 26);
            this.rbKichhoat.TabIndex = 0;
            this.rbKichhoat.TabStop = true;
            this.rbKichhoat.Tag = "Active";
            this.rbKichhoat.Text = "Kích hoạt";
            this.rbKichhoat.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1103, 815);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý CTKM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 86);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCtkm);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDkkm);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 726);
            this.splitContainer1.SplitterDistance = 650;
            this.splitContainer1.TabIndex = 31;
            // 
            // dgvDkkm
            // 
            this.dgvDkkm.AutoGenerateColumns = false;
            this.dgvDkkm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDkkm.DataSource = this.dIEUKIENKMBindingSource;
            this.dgvDkkm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDkkm.Location = new System.Drawing.Point(0, 0);
            this.dgvDkkm.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dgvDkkm.Name = "dgvDkkm";
            this.dgvDkkm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDkkm.Size = new System.Drawing.Size(443, 726);
            this.dgvDkkm.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 83);
            this.panel1.TabIndex = 32;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconSize = 28;
            this.btnRefresh.Location = new System.Drawing.Point(9, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Rotation = 0D;
            this.btnRefresh.Size = new System.Drawing.Size(34, 35);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "Trạng thái KM";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kích hoạt",
            "Chưa áp dụng",
            "Còn hạng sử dụng",
            "Hết hạn sử dụng"});
            this.comboBox1.Location = new System.Drawing.Point(151, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 30);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dgvCtkm
            // 
            this.dgvCtkm.AutoGenerateColumns = false;
            this.dgvCtkm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtkm.DataSource = this.dIEUKIENKMBindingSource;
            this.dgvCtkm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCtkm.Location = new System.Drawing.Point(0, 0);
            this.dgvCtkm.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.dgvCtkm.MultiSelect = false;
            this.dgvCtkm.Name = "dgvCtkm";
            this.dgvCtkm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCtkm.Size = new System.Drawing.Size(650, 726);
            this.dgvCtkm.TabIndex = 37;
            this.dgvCtkm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCtkm_CellClick_1);
            this.dgvCtkm.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCtkm_CellEndEdit);
            // 
            // ChuongTrinhKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 847);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChuongTrinhKm";
            this.Text = "HoatDongGanDay";
            this.Load += new System.EventHandler(this.ChuongTrinhKm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pngroubbutton.ResumeLayout(false);
            this.pngroubbutton.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDkkm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEUKIENKMBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUONGTRINHKMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtkm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLoaiCTKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbtenctkm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmactkm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pngroubbutton;
        private System.Windows.Forms.RadioButton rbChuaApDung;
        private System.Windows.Forms.RadioButton rbKichhoat;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel pnControlContainer;
        private FontAwesome.Sharp.IconButton btnsua;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Button btnThemKm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnGenMaCtkm;
        private System.Windows.Forms.BindingSource cHUONGTRINHKMBindingSource;
        private System.Windows.Forms.BindingSource dIEUKIENKMBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDkkm;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADIEUKIENKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATHUCUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMONANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMTANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHANTRAMGIAMGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGTIENMUADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOAIKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYBATDAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYKETTHUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gHICHUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvCtkm;
    }
}