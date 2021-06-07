using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QLMAMNON.DTO
{
    class PhicobanDTO
    {
        public string namhoc { get; set; }
        public int luongcoban { get; set; }
        public int hocphicoban { get; set; }

        public PhicobanDTO(DataRow row)
        {
            namhoc = row["namhoc"].ToString();
            luongcoban = int.Parse(row["luongcoban"].ToString());
            hocphicoban = int.Parse(row["hocphicoban"].ToString());
        }
    }
    
}
