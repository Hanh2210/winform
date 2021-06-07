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
    class Login
    {
        Data data = new Data();
        public DataTable showLoginNhanvien(string user, string password)
        {
            string sql = "select * from users where username = '" + user + "' and pass='" + password + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable showTaiKhoan()
        {
            string sql = "select * from users";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public void Themtaikhoan(string username, string pass, int quyen)
        {

            string sql = "insert into users values ('" + username + "',N'" + pass + "','" + quyen + "')";
            data.ExcuteNonQuery(sql);
        }
        public void Suataikhoan(string username, string pass, int quyen)
        {
            string sql = "UPDATE users SET pass =N'" + pass + "', quyen = '" + quyen + "' WHERE username ='" + username + "'";
            data.ExcuteNonQuery(sql);
        }
        public void XoaTaiKhoan(string username)
        {
            string sql = "Delete From users Where username ='" + username + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
