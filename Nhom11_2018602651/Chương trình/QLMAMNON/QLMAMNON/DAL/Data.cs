using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLMAMNON.DAL
{
    class Data
    {

        //kết nối csdl
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-MF2OIJQ\SQLEXPRESS;Initial Catalog=truongmamnon;Integrated Security=True");
        }

        //lấy dl về bảng
        public DataTable GetTable(string sql)
        {
            
                SqlConnection conn = getConnect();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            
            
        }


        //xử lí truy vấn
        public void ExcuteNonQuery(string sql)
        {
            try
            {
                SqlConnection conn = getConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Clone();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Vi phạm khóa chính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    MessageBox.Show("Xóa không thành công, liên quan đến khóa phụ");
                }
            }
        }
            
                

            
        }
    }

