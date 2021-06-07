using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLMAMNON.DTO
{
    class LophocDTO
    {
        public string mahs { get; set; }
        public string malop { get; set; }
        public LophocDTO(DataRow row)
        {
            mahs = row["mahs"].ToString();
            malop = row["malop"].ToString();

        }
    }
}
