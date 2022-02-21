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
namespace Viva_vegan.FormDashboard.GoiMonChild
{
    public partial class FormBaoCheBien : Form
    {
        private List<BaoCheBien> list = new List<BaoCheBien>();
        private string maban = "";
        private string tenban = "";
        public FormBaoCheBien(GoiMon parent, string maban ="",string tenban="")
        {
            InitializeComponent();
            GoiMon goiMon = parent;
            Maban = maban;
            Tenban = tenban;

            list = parent.ListBaoCheBien;
        }

        public string Maban { get => maban; set => maban = value; }
        public string Tenban { get => tenban; set => tenban = value; }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

            try
            {
                if (list is null)
                {
                    this.Close();
                }
                else
                {
                    baoCheBien1.SetDataSource(list);
                    if (string.IsNullOrWhiteSpace(Maban) || string.IsNullOrWhiteSpace(tenban))
                    {

                    }
                    else
                    {
                        baoCheBien1.SetParameterValue("pMaBan", Maban + " - " + Tenban);
                    }
                    crystalReportViewer1.ReportSource = baoCheBien1;
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
