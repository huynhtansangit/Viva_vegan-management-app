namespace Viva_vegan.ClassCSharp.ChuongTrinhKM
{
    partial class FormGiamGiaHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDieuKien = new System.Windows.Forms.DataGridView();
            this.btnthemdk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnxoadieukien = new System.Windows.Forms.Button();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuKien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDieuKien
            // 
            this.dgvDieuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDieuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.from,
            this.tongtienmua,
            this.giamgia,
            this.dvt});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDieuKien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDieuKien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDieuKien.Location = new System.Drawing.Point(0, 0);
            this.dgvDieuKien.Name = "dgvDieuKien";
            this.dgvDieuKien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDieuKien.Size = new System.Drawing.Size(416, 222);
            this.dgvDieuKien.TabIndex = 0;
            this.dgvDieuKien.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDieuKien_EditingControlShowing);
            // 
            // btnthemdk
            // 
            this.btnthemdk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnthemdk.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemdk.Location = new System.Drawing.Point(0, 0);
            this.btnthemdk.Name = "btnthemdk";
            this.btnthemdk.Size = new System.Drawing.Size(197, 41);
            this.btnthemdk.TabIndex = 1;
            this.btnthemdk.Text = "+ Thêm điều kiện";
            this.btnthemdk.UseVisualStyleBackColor = true;
            this.btnthemdk.Click += new System.EventHandler(this.Btnthemdk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnxoadieukien);
            this.panel1.Controls.Add(this.btnthemdk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 41);
            this.panel1.TabIndex = 2;
            // 
            // btnxoadieukien
            // 
            this.btnxoadieukien.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnxoadieukien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoadieukien.Location = new System.Drawing.Point(197, 0);
            this.btnxoadieukien.Name = "btnxoadieukien";
            this.btnxoadieukien.Size = new System.Drawing.Size(219, 41);
            this.btnxoadieukien.TabIndex = 2;
            this.btnxoadieukien.Text = "- Xóa điều kiện";
            this.btnxoadieukien.UseVisualStyleBackColor = true;
            this.btnxoadieukien.Click += new System.EventHandler(this.Btnxoadieukien_Click);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 53;
            // 
            // from
            // 
            this.from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.from.HeaderText = "";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Width = 21;
            // 
            // tongtienmua
            // 
            this.tongtienmua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongtienmua.HeaderText = "Tổng tiền hàng";
            this.tongtienmua.Name = "tongtienmua";
            // 
            // giamgia
            // 
            this.giamgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giamgia.HeaderText = "Giảm giá";
            this.giamgia.Name = "giamgia";
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dvt.HeaderText = "";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 21;
            // 
            // FormGiamGiaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 263);
            this.Controls.Add(this.dgvDieuKien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiamGiaHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiamGiaHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDieuKien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDieuKien;
        private System.Windows.Forms.Button btnthemdk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnxoadieukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienmua;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
    }
}