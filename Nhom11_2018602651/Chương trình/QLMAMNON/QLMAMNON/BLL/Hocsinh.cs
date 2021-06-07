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
    public class Hocsinh
    {
        Data data = new Data();
        string strCon = @"Data Source=DESKTOP-MF2OIJQ\SQLEXPRESS;Initial Catalog=truongmamnon;Integrated Security=True";
        public static dbDataContext db;
        public Hocsinh()
        {
            db = new dbDataContext(strCon);
        }
        public DataTable showHocsinh()
        {

            string sql = "select * from hocsinh";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public static List<hocsinh> Gethocsinh()
        {
            List<hocsinh> nv = new List<hocsinh>();
            var ht = from p in db.hocsinhs select p;
            foreach (var row in ht)
            {
                hocsinh lst = new hocsinh();
                lst.mahs = row.mahs;
                lst.hotenhs = row.hotenhs;
                lst.gioitinh = row.gioitinh;
                lst.ngaysinh = row.ngaysinh;
                lst.dantoc = row.dantoc;
                lst.hotenbo = row.hotenbo;
                lst.sdtbo = row.sdtbo;
                lst.hotenme = row.hotenme;
                lst.sdtme = row.sdtme;
                nv.Add(lst);
            }
            return nv;
        }

        public void Themhocsinh(string mahs, string hotenhs, string gioitinh, DateTime ngaysinh,
            string dantoc, string hotenbo, string sdtbo, string hotenme, string sdtme)
        {
            //dbDataContext db = new dbDataContext();
            hocsinh nv = new hocsinh();
            nv.mahs = mahs;
            nv.hotenhs = hotenhs;
            nv.gioitinh = gioitinh;
            nv.ngaysinh = ngaysinh;
            nv.dantoc = dantoc;
            nv.hotenbo = hotenbo;
            nv.sdtbo = sdtbo;
            nv.hotenme = hotenme;
            nv.sdtme = sdtme;
            db.hocsinhs.InsertOnSubmit(nv);
            db.SubmitChanges();
        }

        public void Suahocsinh(string mahs, string hotenhs, string gioitinh, DateTime ngaysinh,
            string dantoc, string hotenbo, string sdtbo, string hotenme, string sdtme)
        {
            //dbDataContext db = new dbDataContext();
            var nv = db.hocsinhs.Single(sp => sp.mahs == mahs);
            nv.hotenhs = hotenhs;
            nv.gioitinh = gioitinh;
            nv.ngaysinh = ngaysinh;
            nv.dantoc = dantoc;
            nv.hotenbo = hotenbo;
            nv.sdtbo = sdtbo;
            nv.hotenme = hotenme;
            nv.sdtme = sdtme;
            db.SubmitChanges();
        }

        public void Xoahocsinh(string mahs)
        {
            //dbDataContext db = new dbDataContext();
            var xoa = from nv in db.hocsinhs where nv.mahs == mahs select nv;
            foreach (var i in xoa)
            {
                db.hocsinhs.DeleteOnSubmit(i);
                db.SubmitChanges();
            }
        }

        public static List<hocsinh> Timkiemhocsinh(string timkiem)
        {
            //dbDataContext db = new dbDataContext();
            List<hocsinh> nv = new List<hocsinh>();
            var tk = from sp in db.hocsinhs where (sp.hotenhs.Contains(timkiem) || sp.hotenbo.Contains(timkiem)) select sp;
            foreach (var row in tk)
            {
                hocsinh lst = new hocsinh();
                lst.mahs = row.mahs;
                lst.hotenhs = row.hotenhs;
                lst.gioitinh = row.gioitinh;
                lst.ngaysinh = row.ngaysinh;
                lst.dantoc = row.dantoc;
                lst.hotenbo = row.hotenbo;
                lst.sdtbo = row.sdtbo;
                lst.hotenme = row.hotenme;
                lst.sdtme = row.sdtme;
                nv.Add(lst);
            }
            return nv;
        }
    }
}
