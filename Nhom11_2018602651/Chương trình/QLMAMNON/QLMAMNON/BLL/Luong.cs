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
    class Luong
    {
        Data data = new Data();
        public DataTable showLuong()
        {
            string sql = "select luongnv.mathanhtoan, luongnv.manv, nhanvien.hotennv, nhanvien.chucvu, phicoban.luongcoban, luongnv.phucap, luongnv.thuong," +
                " luongnv.kyluat, luongnv.tongluong, luongnv.thang, luongnv.namhoc, luongnv.tinhtrang, luongnv.ghichu" +
                "  from  luongnv inner join nhanvien on luongnv.manv = nhanvien.manv inner join phicoban on phicoban.namhoc = luongnv.namhoc ";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void themLuong(string manv, int luongcoban, int phucap, int thuong, int kyluat, int tongluong,
            int thang, string namhoc, int tinhtrang, string ghichu)
        {
            string sql = "insert into luongnv values('" + manv + "', '" + luongcoban + "', '" + phucap + "'," +
                " '" + thuong + "', '" + kyluat + "', '" + tongluong + "', '" + thang + "', '" + namhoc + "', N'" + tinhtrang + "', N'" + ghichu + "'  )";
            data.ExcuteNonQuery(sql);
        }

        public void suaLuong( int mathanhtoan, string manv, int luongcoban, int phucap, int thuong, int kyluat, int tongluong,
            int thang, string namhoc, int tinhtrang, string ghichu)
        {
            string sql = "UPDATE luongnv SET manv = '" + manv + "',luongcoban ='"+luongcoban+"', phucap = '" + phucap + "', thuong ='"+ thuong +"', kyluat='"+ kyluat +"', tongluong ='"+tongluong+"'," +
                "thang ='"+ thang +"', namhoc ='"+ namhoc +"', tinhtrang = N'"+ tinhtrang +"', ghichu = N'"+ ghichu +"' WHERE mathanhtoan ='"+ mathanhtoan +"' ";
            data.ExcuteNonQuery(sql);
        }

        public void xoaLuong(string manv, int thang, string namhoc)
        {
            string sql = "delete from luongnv where manv ='" + manv + "' and thang ='" + thang + "' and namhoc = '" + namhoc + "' ";
            data.ExcuteNonQuery(sql);
        }

        public DataTable LoadcbxLuong(string manv)
        {
            string sql = "select hotennv, chucvu from nhanvien where manv = '" + manv + "'";
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
                string sql = " select luongnv.mathanhtoan, luongnv.manv, nhanvien.hotennv, nhanvien.chucvu, phicoban.luongcoban, luongnv.phucap, luongnv.thuong," +
                    " luongnv.kyluat, luongnv.tongluong, luongnv.thang, luongnv.namhoc, luongnv.tinhtrang, luongnv.ghichu" +
                    "  from  luongnv inner join nhanvien on luongnv.manv = nhanvien.manv inner join phicoban on phicoban.namhoc = luongnv.namhoc" +
                    " WHERE luongnv.manv  LIKE  '%" + timkiem + "%' or hotennv LIKE  '%" + timkiem + "%' or chucvu LIKE  '%" + timkiem + "%' or thang LIKE  '%" + timkiem + "%' ";
                DataTable dt = data.GetTable(sql);
                return dt;
            }
        public string tinhLuong(int lcb, int lpc, int thuong, int tru)
        {
            return (lcb+lpc+thuong-tru).ToString();

        }

        
    }
}
