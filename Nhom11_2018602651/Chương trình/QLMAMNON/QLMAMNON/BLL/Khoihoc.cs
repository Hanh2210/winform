using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLMAMNON.DAL;
using System.Data.SqlClient;
using System.Data;

namespace QLMAMNON.BLL
{
    class Khoihoc
    {
        Data data = new Data();
        public DataTable showKhoihoc()
        {
            string sql = "select khoi.tenkhoi, namhoc.tennamhoc from khoi inner join namhoc on khoi.namhoc = namhoc.namhoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void Themkhoihoc(string tenkhoi, string namhoc)
        {

            string sql = "insert into khoi values (N'" + tenkhoi + "',N'" + namhoc + "')";
            data.ExcuteNonQuery(sql);
        }
        public void Suakhoihoc(string tenkhoi, string namhoc)
        {
            string sql = "UPDATE khoi SET namhoc =N'" + namhoc + "' WHERE tenkhoi ='" + tenkhoi + "'";
            data.ExcuteNonQuery(sql);
        }
        public void XoaKhoihoc(string tenkhoi)
        {
            string sql = "Delete From khoi Where tenkhoi ='" + tenkhoi + "'";
            data.ExcuteNonQuery(sql);
        }
        public DataTable Timkiem(string timkiem)
        {
            string sql = "SELECT * FROM khoi WHERE tenkhoi  LIKE  '%" + timkiem + "%'";
            DataTable dt = data.GetTable(sql);
            return dt;
        }
    }
}
