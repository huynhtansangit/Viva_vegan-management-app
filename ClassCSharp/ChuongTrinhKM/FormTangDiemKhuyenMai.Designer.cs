namespace Viva_vegan.ClassCSharp.ChuongTrinhKM
{
    partial class FormTangDiemKhuyenMai
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
            this.dgvdieukientangdiem = new System.Windows.Forms.DataGridView();
            this.btnthemdieukien = new System.Windows.Forms.Button();
            this.btnxoadieukien = new System.Windows.Forms.Button();
            this.sothutu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodiemtang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdieukientangdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdieukientangdiem
            // 
            this.dgvdieukientangdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdieukientangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdieukientangdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sothutu,
            this.tu,
            this.tongtienmua,
            this.sodiemtang,
            this.diem});
            this.dgvdieukientangdiem.Location = new System.Drawing.Point(12, 12);
            this.dgvdieukientangdiem.Name = "dgvdieukientangdiem";
            this.dgvdieukientangdiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdieukientangdiem.Size = new System.Drawing.Size(550, 288);
            this.dgvdieukientangdiem.TabIndex = 0;
            // 
            // btnthemdieukien
            // 
            this.btnthemdieukien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthemdieukien.Location = new System.Drawing.Point(12, 306);
            this.btnthemdieukien.Name = "btnthemdieukien";
            this.btnthemdieukien.Size = new System.Drawing.Size(275, 35);
            this.btnthemdieukien.TabIndex = 1;
            this.btnthemdieukien.Text = "+ Thêm điều kiện";
            this.btnthemdieukien.UseVisualStyleBackColor = true;
            this.btnthemdieukien.Click += new System.EventHandler(this.Btnthemdieukien_Click);
            // 
            // btnxoadieukien
            // 
            this.btnxoadieukien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnxoadieukien.Location = new System.Drawing.Point(287, 306);
            this.btnxoadieukien.Name = "btnxoadieukien";
            this.btnxoadieukien.Size = new System.Drawing.Size(275, 35);
            this.btnxoadieukien.TabIndex = 2;
            this.btnxoadieukien.Text = "- Xóa điều kiện";
            this.btnxoadieukien.UseVisualStyleBackColor = true;
            this.btnxoadieukien.Click += new System.EventHandler(this.Btnxoadieukien_Click_1);
            // 
            // sothutu
            // 
            this.sothutu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sothutu.HeaderText = "STT";
            this.sothutu.Name = "sothutu";
            this.sothutu.ReadOnly = true;
            this.sothutu.Width = 61;
            // 
            // tu
            // 
            this.tu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tu.HeaderText = "";
            this.tu.Name = "tu";
            this.tu.ReadOnly = true;
            this.tu.Width = 21;
            // 
            // tongtienmua
            // 
            this.tongtienmua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongtienmua.HeaderText = "Tổng tiền mua";
            this.tongtienmua.Name = "tongtienmua";
            // 
            // sodiemtang
            // 
            this.sodiemtang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sodiemtang.HeaderText = "Số điểm tặng";
            this.sodiemtang.Name = "sodiemtang";
            // 
            // diem
            // 
            this.diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diem.HeaderText = "";
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            this.diem.Width = 21;
            // 
            // FormTangDiemKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 353);
            this.Controls.Add(this.btnxoadieukien);
            this.Controls.Add(this.btnthemdieukien);
            this.Controls.Add(this.dgvdieukientangdiem);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTangDiemKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TangDiemKhuyenMai";
            this.Load += new System.EventHandler(this.TangDiemKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdieukientangdiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdieukientangdiem;
        private System.Windows.Forms.Button btnthemdieukien;
        private System.Windows.Forms.Button btnxoadieukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothutu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienmua;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodiemtang;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
    }
}