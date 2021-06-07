using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;




namespace QLMAMNON.DTO
{
    class NhanvienDTO
    {
        public string manv { get; set; }
        public string hotennv { get; set; }
        public string gioitinh { get; set; }
        public DateTime ngaysinh { get; set; }
        public string chucvu { get; set; }
        public string chungminhthu { get; set; }
        public string dantoc { get; set; }
        public string sodienthoai { get; set; }
        public string diachi { get; set; }

        public NhanvienDTO(DataRow row)
        {
            manv = row["manv"].ToString();
            hotennv = row["hotennv"].ToString();
            chucvu = row["chucvu"].ToString();
        }

    }
}
