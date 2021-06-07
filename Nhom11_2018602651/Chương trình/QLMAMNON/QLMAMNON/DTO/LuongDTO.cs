using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLMAMNON.DTO
{
    class LuongDTO
    {
        public int mathanhtoan { get; set; }
        public string manv { get; set; }
        public string hotennv { get; set; }
        public string chucvu { get; set; }
        public int luongcoban { get; set; }
        public int phucap { get; set; }
        public int thuong { get; set; }
        public int kyluat { get; set; }
        public int tong { get; set; }
        public int thang { get; set; }
        public string namhoc { get; set; }
        public int tinhtrang { get; set; }
        public string ghichu { get; set; }
        
    }
}
