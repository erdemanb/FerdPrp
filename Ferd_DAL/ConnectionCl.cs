using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Ferd_DAL
{
    public class ConnectionCl
    {
        private string cncstr = "Data Source=C:\\DbForFerd\\DataBaseFerd.db;Version=3;";

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(cncstr);
        }
    }
}
