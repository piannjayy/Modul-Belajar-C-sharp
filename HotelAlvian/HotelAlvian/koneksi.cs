using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data;

namespace HotelAlvian
{
    internal class koneksi
    {
        public static string connStr = @"Data Source=LAPTOP-UH3ULTU9;Initial Catalog=upk_hotel;Integrated Security=True;";

        public SqlConnection conn = new SqlConnection(connStr);

        public void bukaKoneksi()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void tutupKoneksi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static class Model
        {
            private static string _name;
            public static string name
            {
                get { return _name; }
                set { _name = value; }
            }
        }
    }
}
