using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EsDnevnik
{
    class Connect
    {
        public static SqlConnection connect()
        {
            SqlConnection veza = new SqlConnection("Data Source = DESKTOP-RF245O9\\SQLEXPRESS; Initial Catalog = ednevnik2022; Integrated Security = true");
            return veza;
        }
    }
}
