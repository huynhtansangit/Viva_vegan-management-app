using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viva_vegan.ClassCSharp
{
    class BaoCheBien
    {
        private string mamon;
        private string tenmon;
        private int soluong;

        public BaoCheBien(string mamon, string tenmon, int soluong)
        {
            this.mamon = mamon;
            this.tenmon = tenmon;
            this.soluong = soluong;
        }
        public BaoCheBien()
        {
            this.mamon = mamon;
            this.tenmon = tenmon;
            this.soluong = soluong;
        }
        public string Mamon { get => mamon; set => mamon = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Soluong { get => soluong; set => soluong = value; }

    }
}
