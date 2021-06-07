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
    class Hocphi
    {
        Data data = new Data();
        public DataTable showHocphi()
        {
            string sql = "select hocphi.mathanhtoan, hocphi.mahs, hocsinh.hotenhs, hocsinhlop.malop, phicoban.hocphicoban, hocphi.hogiadinh, hocphi.tonghocphi," +
                " hocphi.namhoc, hocphi.tinhtrang from  hocphi inner join hocsinh on hocphi.mahs = hocsinh.mahs inner join hocsinhlop on hocphi.mahs = hocsinhlop.mahs inner join phicoban on phicoban.namhoc = hocphi.namhoc ";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void themHocphi(string mahs, int hocphicoban, string hogiadinh, int tonghocphi, string namhoc, int tinhtrang)
        {
            string sql = "insert into hocphi values('" + mahs + "', '" + hocphicoban + "', N'" + hogiadinh + "'," +
                " '" + tonghocphi + "', '" + namhoc + "', '" + tinhtrang + "')";
            data.ExcuteNonQuery(sql);
        }

        public void suaHocphi(int mathanhtoan, string mahs, int hocphicoban, string hogiadinh, int tonghocphi, string namhoc, int tinhtrang)
        {
            string sql = "UPDATE hocphi SET mahs = '" + mahs + "', hocphicoban = '" + hocphicoban + "', hogiadinh =N'" + hogiadinh + "', tonghocphi ='" + tonghocphi + "'," +
                " namhoc ='" + namhoc + "', tinhtrang = N'" + tinhtrang + "' WHERE mathanhtoan ='" + mathanhtoan + "' ";
            data.ExcuteNonQuery(sql);
        }

        public void xoaHocphi(string mahs, string namhoc)
        {
            string sql = "delete from hocphi where mahs ='" + mahs + "' and namhoc = '" + namhoc + "' ";
            data.ExcuteNonQuery(sql);
        }

        public DataTable Loadcbxhs(string mahs)
        {
            string sql = "select hotenhs  from hocsinh where mahs = '" + mahs + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable Loadlop(string mahs)
        {
            string sql = "select malop  from hocsinhlop where mahs = '" + mahs + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable Loadcbxnam(string namhoc)
        {
            string sql = "select luongcoban, hocphicoban from phicoban where namhoc = '" + namhoc + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable Timkiem(string timkiem)
        {
            string sql = " select hocphi.mathanhtoan, hocphi.mahs, hocsinh.hotenhs, hocsinhlop.malop, phicoban.hocphicoban, hocphi.hogiadinh, hocphi.tonghocphi," +
                " hocphi.namhoc, hocphi.tinhtrang from  hocphi inner join hocsinh on hocphi.mahs = hocsinh.mahs inner join hocsinhlop on hocphi.mahs = hocsinhlop.mahs inner join phicoban on phicoban.namhoc = hocphi.namhoc" +
                " WHERE hocphi.mahs LIKE  '%" + timkiem + "%' or hotenhs LIKE  '%" + timkiem + "%' or hocphi.namhoc LIKE '%" + timkiem + "%' ";
            DataTable dt = data.GetTable(sql);
            return dt;
        }

        //public string tinhHocphi(int hpcb, int giam)
        //{
        //    return (hpcb*giam ).ToString();

        //}
    }
}
