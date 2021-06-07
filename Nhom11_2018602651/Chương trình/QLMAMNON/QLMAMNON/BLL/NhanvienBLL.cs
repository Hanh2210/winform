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
    public class NhanvienBLL
    {
        Data data = new Data();
        string strCon = @"Data Source=DESKTOP-MF2OIJQ\SQLEXPRESS;Initial Catalog=truongmamnon;Integrated Security=True";
        public static dbDataContext db;
        public NhanvienBLL()
        {
            db = new dbDataContext(strCon);
        }
        public DataTable shownhanvien()
        {
            string sql = "select * from nhanvien";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }


        public static List<nhanvien> Getnhanvien() 
        {
            List<nhanvien> nv = new List<nhanvien>();           
            var ht = from p in db.nhanviens select p;
            foreach(var row in ht)
            {
                nhanvien lst = new nhanvien();
                lst.manv = row.manv;
                lst.hotennv = row.hotennv;
                lst.gioitinh = row.gioitinh;
                lst.ngaysinh = row.ngaysinh;
                lst.chucvu = row.chucvu;
                lst.chungminhthu = row.chungminhthu;
                lst.dantoc = row.dantoc;
                lst.sodienthoai = row.sodienthoai;
                lst.diachi = row.diachi;
                nv.Add(lst);
            }
            return nv;
        }

        public  void ThemNhanvien(string manv, string hotennv, string gioitinh, DateTime ngaysinh,
            string chucvu, string chungminhthu, string dantoc, string sodienthoai, string diachi)
        {
            //dbDataContext db = new dbDataContext();
            nhanvien nv = new nhanvien();
            nv.manv = manv;
            nv.hotennv = hotennv;
            nv.gioitinh = gioitinh;
            nv.ngaysinh = ngaysinh;
            nv.chucvu = chucvu;
            nv.chungminhthu = chungminhthu;
            nv.dantoc = dantoc;
            nv.sodienthoai = sodienthoai;
            nv.diachi = diachi;
            db.nhanviens.InsertOnSubmit(nv);
            db.SubmitChanges();
        }

        public void SuaNhanvien(string manv, string hotennv, string gioitinh, DateTime ngaysinh,
            string chucvu, string chungminhthu, string dantoc, string sodienthoai, string diachi)
        {
            //dbDataContext db = new dbDataContext();
            var nv = db.nhanviens.Single(sp => sp.manv == manv);
            nv.hotennv = hotennv;
            nv.gioitinh = gioitinh;
            nv.ngaysinh = ngaysinh;
            nv.chucvu = chucvu;
            nv.chungminhthu = chungminhthu;
            nv.dantoc = dantoc;
            nv.sodienthoai = sodienthoai;
            nv.diachi = diachi;
            db.SubmitChanges();
        }

        public void XoaNhanvien(string manv)
        {
            //dbDataContext db = new dbDataContext();
            try
            {
                var xoa = from nv in db.nhanviens where nv.manv == manv select nv;
                foreach (var i in xoa)
                {
                    db.nhanviens.DeleteOnSubmit(i);
                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<nhanvien> Timkiemnhanvien(string timkiem)
        {
            //dbDataContext db = new dbDataContext();
            List<nhanvien> nv = new List<nhanvien>();
            var tk = from sp in db.nhanviens where (sp.hotennv.Contains(timkiem) || sp.chucvu.Contains(timkiem)) select sp;
            foreach (var row in tk)
            {
                nhanvien lst = new nhanvien();
                lst.manv = row.manv;
                lst.hotennv = row.hotennv;
                lst.gioitinh = row.gioitinh;
                lst.ngaysinh = row.ngaysinh;
                lst.chucvu = row.chucvu;
                lst.chungminhthu = row.chungminhthu;
                lst.dantoc = row.dantoc;
                lst.sodienthoai = row.sodienthoai;
                lst.diachi = row.diachi;
                nv.Add(lst);
            }
            return nv;
        }

        //public DataTable Timkiem(string timkiem)
        //{
        //    //dbDataContext db = new dbDataContext();
        //    //DataTable dt = new DataTable();
        //    //var tk = from nv in db.nhanviens where (nv.hotennv.Contains(timkiem) || nv.chucvu.Contains(timkiem)) select nv;
        //    //foreach(var i in tk)
        //    //{
        //    //    dt.Rows[]
        //    //}
        //    //return dt;
        //}
    }
}
