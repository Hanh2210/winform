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
    class Lop
    {
        Data data = new Data();
        public DataTable showLop()
        {
            string sql = "select lop.malop, lop.tenlop, lop.tenkhoi, namhoc.tennamhoc from lop inner join namhoc on namhoc.namhoc = lop.namhoc ";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void Themlop(string malop, string tenlop, string tenkhoi, string namhoc)
        {

            string sql = "insert into lop values ('" + malop + "',N'" + tenlop + "',N'" + tenkhoi + "',N'" + namhoc + "')";
            data.ExcuteNonQuery(sql);
        }
        public void Sualop(string malop, string tenlop, string tenkhoi, string namhoc)
        {
            string sql = "UPDATE lop SET tenlop =N'" + tenlop + "',tenkhoi =N'" + tenkhoi + "',namhoc =N'" + namhoc + "' WHERE malop ='" + malop + "'";
            data.ExcuteNonQuery(sql);
        }
        public void XoaLop(string malop)
        {
            string sql = "Delete From lop Where malop ='" + malop + "'";
            data.ExcuteNonQuery(sql);
        }
        public DataTable Timkiem(string timkiem)
        {
            string sql = "SELECT * FROM lop WHERE malop  LIKE  '%" + timkiem + "%' or tenlop  LIKE  '%" + timkiem + "%' ";
            DataTable dt = data.GetTable(sql);
            return dt;
        }
    }
}
