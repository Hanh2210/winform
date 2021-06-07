using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLMAMNON.DAL;
using System.Data.SqlClient;
using System.Data;
using QLMAMNON.DTO;

namespace QLMAMNON.BLL
{
    class Phicoban
    {
        Data data = new Data();
        public DataTable showPhicb()
        {
            string sql = "select namhoc.namhoc, phicoban.luongcoban, phicoban.hocphicoban from phicoban inner join namhoc on phicoban.namhoc = namhoc.namhoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void Themphi(string namhoc, int luongcoban, int hocphicoban)
        {

            string sql = "insert into phicoban values (N'" + namhoc + "','" + luongcoban + "','" + hocphicoban + "')";
            data.ExcuteNonQuery(sql);
        }
        public void Suaphi(string namhoc, int luongcoban, int hocphicoban)
        {
            string sql = "UPDATE phicoban SET luongcoban ='" + luongcoban + "',hocphicoban ='" + hocphicoban + "' WHERE namhoc =N'" + namhoc + "'";
            data.ExcuteNonQuery(sql);
        }
        public void Xoaphi(string namhoc)
        {
            string sql = "Delete From phicoban Where namhoc =N'" + namhoc + "'";
            data.ExcuteNonQuery(sql);
        }

        public string Nganquy(int nganquy)
        {
            nganquy = 0;
            return nganquy.ToString();
        }
    }
}
