using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLMAMNON.DTO
{
    class DangnhapDTO
    {
        public string user { get; set; }
        public string pass { get; set; }
        public int quyen { get; set; }

        public DangnhapDTO(DataRow row)
        {
            user = row["username"].ToString();
            pass = row["password"].ToString();
            quyen = int.Parse(row["quyen"].ToString());
        }
    }
}
