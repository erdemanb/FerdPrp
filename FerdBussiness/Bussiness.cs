using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferd_DAL;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace FerdBussiness
{

    public class Bussiness
    {
        ConnectionCl baglanti = new ConnectionCl();
        
        public Bussiness()
        {
            SQLiteConnection connection = baglanti.GetConnection();
            connection.Open();

        }
    }
}
