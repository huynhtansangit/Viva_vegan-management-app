namespace Viva_vegan.FormDashboard
{
    partial class FormKiemTraThongTinKH
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
            this.txbsodienthoaixacnhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmakh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbtenkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbngaysinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbtrangthai = new System.Windows.Forms.TextBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbsodienthoaixacnhan
            // 
            this.txbsodienthoaixacnhan.Location = new System.Drawing.Point(17, 32);
            this.txbsodienthoaixacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.txbsodienthoaixacnhan.Name = "txbsodienthoaixacnhan";
            this.txbsodienthoaixacnhan.Size = new System.Drawing.Size(316, 26);
            this.txbsodienthoaixacnhan.TabIndex = 0;
            this.txbsodienthoaixacnhan.TextChanged += new System.EventHandler(this.Txbsodienthoai_TextChanged);
            this.txbsodienthoaixacnhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txbsodienthoai_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiểm tra thông tin";
            // 
            // txbmakh
            // 
            this.txbmakh.Location = new System.Drawing.Point(115, 129);
            this.txbmakh.Margin = new System.Windows.Forms.Padding(4);
            this.txbmakh.Name = "txbmakh";
            this.txbmakh.ReadOnly = true;
            this.txbmakh.Size = new System.Drawing.Size(218, 26);
            this.txbmakh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên KH";
            // 
            // txbtenkh
            // 
            this.txbtenkh.Location = new System.Drawing.Point(115, 163);
            this.txbtenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txbtenkh.Name = "txbtenkh";
            this.txbtenkh.ReadOnly = true;
            this.txbtenkh.Size = new System.Drawing.Size(218, 26);
            this.txbtenkh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày sinh";
            // 
            // txbngaysinh
            // 
            this.txbngaysinh.Location = new System.Drawing.Point(115, 197);
            this.txbngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.txbngaysinh.Name = "txbngaysinh";
            this.txbngaysinh.ReadOnly = true;
            this.txbngaysinh.Size = new System.Drawing.Size(218, 26);
            this.txbngaysinh.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trạng thái";
            // 
            // txbtrangthai
            // 
            this.txbtrangthai.Location = new System.Drawing.Point(115, 231);
            this.txbtrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.txbtrangthai.Name = "txbtrangthai";
            this.txbtrangthai.ReadOnly = true;
            this.txbtrangthai.Size = new System.Drawing.Size(218, 26);
            this.txbtrangthai.TabIndex = 9;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(104, 264);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(135, 41);
            this.btnxacnhan.TabIndex = 11;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.Btnxacnhan_Click);
            // 
            // FormKiemTraThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 318);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbtrangthai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbngaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbtenkh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbmakh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbsodienthoaixacnhan);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKiemTraThongTinKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKiemTraThongTinKH";
            this.Load += new System.EventHandler(this.FormKiemTraThongTinKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbsodienthoaixacnhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmakh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbtenkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbtrangthai;
        private System.Windows.Forms.Button btnxacnhan;
    }
}