using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLMAMNON.DTO
{
    class HocsinhDTO
    {
        public string mahs { get; set; }
        public string hotenhs { get; set; }
        public HocsinhDTO(DataRow row)
        {
            mahs = row["mahs"].ToString();
            hotenhs = row["hotenhs"].ToString();
            
        }
    }
}
