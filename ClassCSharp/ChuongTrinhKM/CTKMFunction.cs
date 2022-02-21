using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viva_vegan.ClassCSharp.ChuongTrinhKM
{
    static class CTKMFunction
    {
        static Entities1 db = new Entities1();
        public static void log(string s)
        {
            Console.WriteLine(s);
        }
        public static IQueryable<MONAN> GetMonAnsInUse()
        {
            IQueryable<MONAN> mons = db.MONANs.Where(x => x.matrangthai != "elimi");
            return mons;
        }
        public static IQueryable<THUCUONG> GetThucUongsInUse()
        {
            IQueryable<THUCUONG> tu = db.THUCUONGs.Where(x => x.matrangthai != "elimi");
            return tu;
        }
        public static IQueryable<THUCUONG> GetThucUongsInUseByWhat(string bywhat, string input = null)
        {
            IQueryable<THUCUONG> tu = null;
            if (bywhat == "name")
            {
                tu = GetThucUongsInUse().Where(x => x.TENTHUCUONG.Contains(input));
            }
            else
            {
                tu = GetThucUongsInUse().Where(x => x.MATHUCUONG.Contains(input));

            }
            return tu;
        }
        public static IQueryable<MONAN> GetMonAnsInUseByWhat(string bywhat, string input = null)
        {

            IQueryable<MONAN> ma = null;
            if (bywhat == "name")
            {
                ma = GetMonAnsInUse().Where(x => x.TENMON.Contains(input));
            }
            else
            {
                ma = GetMonAnsInUse().Where(x => x.MAMON.Contains(input));

            }
            return ma;
        }
        public static void Dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            DataGridView dgvFocusing = sender as DataGridView;
            //if(dgvFocusing.CurrentCell.ColumnIndex ==0) // setting desired column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        public static void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void AddNewRowInDataGridView(DataGridView dgv, string[] value = null)
        {
            if (dgv.ColumnCount != value.Length)
            {
                Console.WriteLine("Dữ liệu truyền vào sai");
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                for (int i = 0; i < value.Length; i++)
                {
                    row.Cells[i].Value = value[i];
                }
                dgv.Rows.Add(row);
            }
        }
        public static void RemoveText(object sender, EventArgs e)
        {
            RichTextBox rich = sender as RichTextBox;
            if (rich.Text.Contains("Ghi chú"))
            {
                rich.Text = "";
            }
        }

        public static void AddText(object sender, EventArgs e)
        {
            RichTextBox rich = sender as RichTextBox;
            if (string.IsNullOrWhiteSpace(rich.Text))
                rich.Text = "Ghi chú";
        }
        public static string generateCode(int length = 5)
        {
            return Guid.NewGuid().ToString("N").Substring(10, length);
        }
        public static object solveTotalAfterDiscount(string maloakh, object tongthanhtien)
        {
            double result = double.Parse(tongthanhtien.ToString());
            switch (maloakh)
            {
                case "GREEN":
                    {
                        if (result * 2 / 100 > 400000)
                            return result - 400000;
                        else result -= result * 2 / 100;
                        break;
                    }
                case "SILVE":
                    {
                        if (result * 6 / 100 > 400000)
                            return result - 400000;
                        else
                            result -= result * 6 / 100;
                        break;
                    }
                case "GOLD":
                    {
                        if (result * 10 / 100 > 400000)
                            return result - 400000;
                        else
                            result -= result * 1 / 10;
                        break;
                    }
                case "RUBY":
                    {
                        if (result * 14 / 100 > 400000)
                            return result - 400000;
                        else
                            result -= result * 14 / 100;
                        break;
                    }
                case "DIAMO":
                    {
                        if (result * 18 / 100 > 400000)
                            return result - 400000;
                        else
                            result -= result * 18 / 100;
                        break;
                    }
            }
            double roundingMoney = Math.Round(double.Parse(result.ToString()), 0);
            return roundingMoney;
        }
        public static object solveDiscount(string maloakh, object tongthanhtien)
        {
            double result = double.Parse(tongthanhtien.ToString());
            switch (maloakh)
            {
                case "GREEN":
                    {
                        if (result * 2 / 100 > 400000)
                            return 400000;
                        else
                            result=0.02 * result;
                        break;
                    }
                case "SILVE":
                    {
                        if (result * 6 / 100 > 400000)
                            return  400000;
                        else
                            result=0.06 * result;
                        break;
                    }
                case "GOLD":
                    {
                        if (result * 10 / 100 > 400000)
                            return  400000;
                        else
                            result=0.1*result;
                        break;
                    }
                case "RUBY":
                    {
                        if (result * 14 / 100 > 400000)
                            return 400000;
                        else
                            result=0.14*result;
                        break;
                    }
                case "DIAMO":
                    {
                        if (result * 18 / 100 > 400000)
                            return 400000;
                        else
                            result=0.18*result;
                        break;
                    }
            }
            double roundingMoney = Math.Round(double.Parse(result.ToString()), 0);
            return roundingMoney;
        }
    }
}
