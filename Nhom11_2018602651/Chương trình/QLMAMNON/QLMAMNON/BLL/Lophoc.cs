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
    class Lophoc
    {
        Data data = new Data();
        public DataTable showLophoc()
        {
            string sql = "select hocsinh.hotenhs, lop.tenlop, khoi.tenkhoi, namhoc.tennamhoc from hocsinhlop inner join hocsinh on hocsinhlop.mahs = hocsinh.mahs inner join lop on hocsinhlop.malop = lop.malop inner join namhoc on hocsinhlop.namhoc = namhoc.namhoc inner join khoi on hocsinhlop.tenkhoi = khoi.tenkhoi";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void Themlophoc(string mahs, string malop, string tenkhoi, string namhoc)
        {

            string sql = "insert into hocsinhlop values ('" + mahs + "',N'" + malop + "','" + tenkhoi + "',N'" + namhoc + "')";
            data.ExcuteNonQuery(sql);
        }
        public void Sualophoc(string mahs, string malop, string tenkhoi, string namhoc)
        {
            string sql = "UPDATE hocsinhlop SET malop =N'" + malop + "', tenkhoi = '" + tenkhoi + "',namhoc = N'" + namhoc + "' WHERE mahs ='" + mahs + "'";
            data.ExcuteNonQuery(sql);
        }
        public void Xoalophoc(string mahs)
        {
            string sql = "Delete From hocsinhlop Where mahs ='" + mahs + "'";
            data.ExcuteNonQuery(sql);
        }
        public DataTable Timkiem(string timkiem)
        {
            string sql = "select hocsinh.hotenhs, lop.tenlop, khoi.tenkhoi, namhoc.tennamhoc from hocsinhlop inner join hocsinh on hocsinhlop.mahs = hocsinh.mahs inner join lop on hocsinhlop.malop = lop.malop inner join namhoc on hocsinhlop.namhoc = namhoc.namhoc inner join khoi on hocsinhlop.tenkhoi = khoi.tenkhoi" +
                " where hotenhs like '%" + timkiem + "%' or lop.tenlop like '%" + timkiem + "%' or khoi.tenkhoi like '%" + timkiem + "%' or namhoc.tennamhoc like '%" + timkiem + "%'";
            DataTable dt = data.GetTable(sql);
            return dt;
        }
    }
}
