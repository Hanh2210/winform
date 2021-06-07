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
    class Giaovien
    {
        Data data = new Data();
        public DataTable showGiaovien()
        {
            string sql = "select nhanvien.hotennv, lop.tenlop, khoi.tenkhoi, namhoc.tennamhoc from gvlop inner join nhanvien on gvlop.manv = nhanvien.manv inner join lop on gvlop.malop = lop.malop inner join namhoc on gvlop.namhoc = namhoc.namhoc inner join khoi on gvlop.tenkhoi = khoi.tenkhoi";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void Themgiaovien(string manv, string malop, string tenkhoi, string namhoc)
        {

            string sql = "insert into gvlop values ('" + manv + "',N'" + malop + "','" + tenkhoi + "',N'" + namhoc + "')";
            data.ExcuteNonQuery(sql);
        }
        public void Suagiaovien(string manv, string malop, string tenkhoi, string namhoc)
        {
            string sql = "UPDATE gvlop SET malop =N'" + malop + "', tenkhoi = '" + tenkhoi + "',namhoc = N'" + namhoc + "' WHERE manv ='" + manv + "'";
            data.ExcuteNonQuery(sql);
        }
        public void Xoagiaovien(string manv)
        {
            string sql = "Delete From gvlop Where manv ='" + manv + "'";
            data.ExcuteNonQuery(sql);
        }
        public DataTable Timkiem(string timkiem)
        {
            string sql = "select nhanvien.hotennv, lop.tenlop, khoi.tenkhoi, namhoc.tennamhoc from gvlop inner join nhanvien on gvlop.manv = nhanvien.manv inner join lop on gvlop.malop = lop.malop inner join namhoc on gvlop.namhoc = namhoc.namhoc inner join khoi on gvlop.tenkhoi = khoi.tenkhoi" +
                " where hotennv like '%" + timkiem + "%' or tenlop like '%" + timkiem + "%'";
            DataTable dt = data.GetTable(sql);
            return dt;
        }
    }
}
