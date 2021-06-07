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
    class Namhoc
    {
        Data data = new Data();
        public DataTable showNamhoc()
        {
            string sql = "select * from namhoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt; 
        }

        public void Themnamhoc(string namhoc, string tennamhoc, string ngaybatdau, string ngayketthuc)
        {

            string sql = "insert into namhoc values (N'" + namhoc + "',N'" + tennamhoc + "',N'" + ngaybatdau + "',N'" + ngayketthuc + "')";
            data.ExcuteNonQuery(sql);
        }
        public void Suanamhoc(string namhoc, string tennamhoc, string ngaybatdau, string ngayketthuc)
        {
            string sql = "UPDATE namhoc SET tennamhoc =N'" + tennamhoc + "', ngaybatdau = N'" + ngaybatdau + "',ngayketthuc = N'" + ngayketthuc + "' WHERE namhoc =N'" + namhoc + "'";
            data.ExcuteNonQuery(sql);
        }
        public void Xoanamhoc(string namhoc)
        {
            string sql = "Delete From namhoc Where namhoc =N'" + namhoc + "'";
            data.ExcuteNonQuery(sql);
        }
        public DataTable Timkiem(string timkiem)
        {
            string sql = "SELECT * FROM namhoc WHERE tennamhoc  LIKE  '%" + timkiem + "%' or namhoc LIKE  '%" + timkiem + "%' ";
            DataTable dt = data.GetTable(sql);
            return dt;
        }
    }
}
