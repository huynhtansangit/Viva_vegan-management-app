using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viva_vegan.ClassCSharp;

namespace Viva_vegan
{
    public partial class Login : Form
    {
        private ClassCSharp.ConnectDataBase conDB;
        public Login()
        {
            InitializeComponent();
            txtusername.Focus();
            this.AcceptButton = btndangnhap;
            conDB = new ClassCSharp.ConnectDataBase("");
        }

        private void IBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndangnhap.PerformClick();
            }
        }

        private async Task<bool> kiemTraDangNhap()
        {
            try
            {
                string name = txtusername.Text;
                string pass = txtpassword.Text;
                Console.WriteLine(pass);

                if (string.IsNullOrWhiteSpace(name) | string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Vui lòng không bỏ trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    pass = OptimizedPerformance.encryptor(pass);
                    string querylogin = "dangkydangnhap @MANV @TENDANGNHAP @MATKHAU @Request";
                    DataTable dataTable = await ClassCSharp.ConnectDataBase.SessionConnect.executeQueryAsync(querylogin,
                        new object[] { " ", name.Trim(), pass.Trim(), "login" });
                    if (dataTable.Rows.Count != 0)
                    {
                        ClassCSharp.User.Manv = dataTable.Rows[0].Field<string>(0);
                        ClassCSharp.User.Macv = dataTable.Rows[0].Field<string>(1);
                        ClassCSharp.User.Mabp = dataTable.Rows[0].Field<string>(2);
                        ClassCSharp.User.Tennv = dataTable.Rows[0].Field<string>(3);
                        ClassCSharp.User.Dienthoai = dataTable.Rows[0].Field<string>(4);
                        ClassCSharp.User.Email = dataTable.Rows[0].Field<string>(5);
                        ClassCSharp.User.Diachi = dataTable.Rows[0].Field<string>(6);
                        ClassCSharp.User.Sotk = dataTable.Rows[0].Field<string>(7);
                        ClassCSharp.User.Tendangnhap = dataTable.Rows[0].Field<string>(8);
                        ClassCSharp.User.Matkhau = dataTable.Rows[0].Field<string>("matkhau");
                        ClassCSharp.User.Ngayvaolam = Convert.ToDateTime(dataTable.Rows[0]["ngayvaolam"]);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
                return false;
            }
        }

        private async void Btndangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var GreetingForm = new Greeting();
                GreetingForm.Show();
                await Task.Delay(1000);
                if (await kiemTraDangNhap())
                {
                    GreetingForm.Close();
                    new Dashboard().Show();
                }
                else
                {
                    GreetingForm.Close();
                    new Login().Show();
                }
            }
            catch (Exception ex)
            {
                OptimizedPerformance.showSomeThingWentWrong();
                OptimizedPerformance.log(ex);
            }
        }

        private void LblChuyensangdky_MouseHover(object sender, EventArgs e)
        {
            lblChuyensangdky.ForeColor = Color.DodgerBlue;
        }

        private void LblChuyensangdky_MouseLeave(object sender, EventArgs e)
        {
            lblChuyensangdky.ForeColor = Color.Black;
        }

        private void XuiCheckBox1_CheckedStateChanged(object sender, EventArgs e)
        {
            if (cbshowpass.Checked)
                txtpassword.PasswordChar = '\0';
            else
                txtpassword.PasswordChar = '*';
        }

        private void LblChuyensangdky_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
