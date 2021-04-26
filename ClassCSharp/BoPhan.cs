﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viva_vegan.ClassCSharp
{
    public class BoPhan
    {
        private String mabp;
        private String tenbp;

        #region Getter and Setter
        public BoPhan(string mabp, string tenbp)
        {
            this.mabp = mabp;
            this.tenbp = tenbp;
        }
        public BoPhan()
        {
           
        }
        public String Mabp { set => mabp = value; get => mabp; }
        public String Tenbp { set => tenbp = value; get => tenbp; }
        #endregion
        #region Methods

        public async Task<List <BoPhan>> loadListBoPhan ()
        {
            List<BoPhan> list = new List<BoPhan>();
            String query = "select * from bophan";
            DataTable table =await ConnectDataBase.SessionConnect.executeQueryAsync(query);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new BoPhan(row["mabp"].ToString(), row["tenbp"].ToString()));
            }
            return list;
        }
        public String getTenBpFromMaBp (String mabp)
        {
            String query = "select tenbp from bophan where mabp='" + mabp +
                "'";
            String tenbp = "";
            DataTable table = ConnectDataBase.SessionConnect.executeQuery(query);
            foreach (DataRow row in table.Rows)
            {
                tenbp = row["tenbp"].ToString();
            }
            return tenbp;
        }
        #endregion
    }
}
