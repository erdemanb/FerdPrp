using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferd_DAL;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;

namespace FerdBussiness
{

    public class Bussiness
    {
        ConnectionCl baglanti = new ConnectionCl();
        SQLiteConnection connection;


        public Bussiness()
        {
            connection = baglanti.GetConnection();
            connection.Open();
            string createTableSQL = "CREATE TABLE IF NOT EXISTS Tbl_Isler (" +
                                     "IsID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                     "YapilacakIs VARCHAR(50)" +
                                     ");" +
                                     "CREATE TABLE IF NOT EXISTS Tbl_Tamamlananlar (" +
                                     "YapilanIsID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                     "TamamlananIs VARCHAR(50)" +
                                     ");" +
                                     "CREATE TABLE IF NOT EXISTS Tbl_Kitaplar (" +
                                     "KitapID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                     "KitapAd VARCHAR(50)," +
                                     "Yazar VARCHAR(50)" +
                                     ");" +
                                     "CREATE TABLE IF NOT EXISTS Tbl_GelirGider (" +
                                     "GelirGiderID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                     "Ay VARCHAR(10)," +
                                     "Miktar INTEGER," +
                                     "GelirGiderTur VARCHAR(25)," +
                                     "GelirGiderAciklama VARCHAR(50)" +
                                     ");" +
                                     "CREATE TABLE IF NOT EXISTS Tbl_Filmler (" +
                                     "FilmID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                     "FilmAd VARCHAR(50)," +
                                     "FilmTur VARCHAR(50)," +
                                     "FilmYonetmen VARCHAR(50)" +
                                     ");";

            SQLiteCommand command1 = new SQLiteCommand(createTableSQL, connection);
            command1.ExecuteNonQuery();
            connection.Close();
        }


        public DataTable YapilacaklarVeriListele()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string selectSQL = "SELECT * FROM Tbl_Isler";

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectSQL, connection))
            {
                DataTable veriTablosu = new DataTable();
                adapter.Fill(veriTablosu);
                connection.Close();
                return veriTablosu;
            }

        }
        public void IDyeGoreListeleTblGelirGider(int id)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "SELECT FROM Tbl_GelirGider WHERE GelirGiderID = @id";

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public DataTable GelirlerVeriListele()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string SelectSQLBakiye = "SELECT * FROM Tbl_GelirGider";
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(SelectSQLBakiye, connection))
            {
                DataTable veriTablosu = new DataTable();
                adapter.Fill(veriTablosu);
                connection.Close();
                return veriTablosu;
            }
        }
        public DataTable TamamlananlarVeriListele()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string selectSQL = "SELECT * FROM Tbl_Tamamlananlar";

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectSQL, connection))
            {
                DataTable veriTablosu = new DataTable();
                adapter.Fill(veriTablosu);
                connection.Close();
                return veriTablosu;
            }

        }
        public DataTable AyaGoreListele(string seciliAy)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string selectSQL = "SELECT * FROM Tbl_GelirGider WHERE Ay = @Ay";
            using (SQLiteCommand command = new SQLiteCommand(selectSQL, connection))
            {
                command.Parameters.AddWithValue("@Ay", seciliAy);

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable veriTablosu2 = new DataTable();
                    adapter.Fill(veriTablosu2);
                    connection.Close();
                    return veriTablosu2;
                }
            }
        }
        public DataTable GiderTureGoreGetir()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string selectSQL = "SELECT GelirGiderTur, SUM(CASE WHEN Miktar < 0 THEN Miktar ELSE 0 END) AS Giderler \r\nFROM Tbl_GelirGider \r\nWHERE Miktar < 0 \r\nGROUP BY GelirGiderTur";

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectSQL, connection);

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            connection.Close();

            return dataTable;
        }
        public DataTable GiderTureGoreGetirAy(string ay)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string selectSQL = "SELECT GelirGiderTur, SUM(CASE WHEN Miktar < 0 THEN Miktar ELSE 0 END) AS Giderler \r\n" +
                               "FROM Tbl_GelirGider \r\n" +
                               "WHERE Miktar < 0 \r\n" +
                               "AND Ay = @Ay \r\n" +
                               "GROUP BY GelirGiderTur";

            SQLiteCommand cmd = new SQLiteCommand(selectSQL, connection);
            cmd.Parameters.AddWithValue("@Ay", ay);

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            connection.Close();

            return dataTable;
        }
        public DataTable GelirTureGoreGetirAy(string ay)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string selectSQL = "SELECT GelirGiderTur, SUM(CASE WHEN Miktar > 0 THEN Miktar ELSE 0 END) AS Gelirler \r\n" +
                               "FROM Tbl_GelirGider \r\n" +
                               "WHERE Miktar < 0 \r\n" +
                               "AND Ay = @Ay \r\n" +
                               "GROUP BY GelirGiderTur";

            SQLiteCommand cmd = new SQLiteCommand(selectSQL, connection);
            cmd.Parameters.AddWithValue("@Ay", ay);

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            connection.Close();

            return dataTable;
        }
        public DataTable GelirTureGoreGetir()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string selectSQL = "SELECT GelirGiderTur, SUM(Miktar) AS Gelirler \r\nFROM Tbl_GelirGider \r\nWHERE Miktar > 0 \r\nGROUP BY GelirGiderTur";

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectSQL, connection);

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            connection.Close();

            return dataTable;
        }
        public DataTable MiktarlarToplamiGetir()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string selectSQL = "SELECT\r\n    Ay,\r\n    SUM(CASE WHEN Miktar < 0 THEN Miktar ELSE 0 END) AS NegatifMiktar,\r\n    SUM(CASE WHEN Miktar >= 0 THEN Miktar ELSE 0 END) AS PozitifMiktar,\r\n    SUM(Miktar) AS ToplamMiktar\r\nFROM\r\n    Tbl_GelirGider\r\nGROUP BY\r\n    Ay";

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectSQL, connection);

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            connection.Close();

            return dataTable;
        }
        public DataTable PozitifMiktarlarToplamiGetir()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string selectSQL = "SELECT Ay, SUM(Miktar) AS NegatifMiktar FROM Tbl_GelirGider WHERE Miktar >= 0 GROUP BY Ay";

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectSQL, connection);

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            connection.Close();

            return dataTable;
        }

        public void VeriEkleTblIsler(string yapilacakIs)
        {

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string insertSQL = "INSERT INTO Tbl_Isler (YapilacakIs) VALUES (@yapilacakIs)";

            using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
            {
                command.Parameters.AddWithValue("@yapilacakIs", yapilacakIs);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void VeriEkleTblGelirGider(int Miktar, string Ay, string Aciklama, string Tur)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string insertSQL = "INSERT INTO Tbl_GelirGider (Miktar, Ay, GelirGiderAciklama, GelirGiderTur) VALUES (@Miktar, @Ay, @Aciklama, @Tur)";

            using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
            {
                command.Parameters.AddWithValue("@Miktar", Miktar);
                command.Parameters.AddWithValue("@Ay", Ay);
                command.Parameters.AddWithValue("@Aciklama", Aciklama);
                command.Parameters.AddWithValue("@Tur", Tur);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void VeriGuncelleTblGelirGider(string guncelAy, string guncelAciklama, int guncelMiktar, int id, string guncelTur)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string updateSQL = "UPDATE Tbl_GelirGider SET GelirGiderAciklama = @guncelAciklama, Ay = @guncelAy, Miktar = @guncelMiktar, GelirGiderTur= @guncelTur WHERE GelirGiderID = @id";

            using (SQLiteCommand command = new SQLiteCommand(updateSQL, connection))
            {
                command.Parameters.AddWithValue("@guncelAciklama", guncelAciklama);
                command.Parameters.AddWithValue("@guncelTur", guncelTur);
                command.Parameters.AddWithValue("@guncelAy", guncelAy);
                command.Parameters.AddWithValue("@guncelMiktar", guncelMiktar);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }

            connection.Close();
        }
        public void VeriEkleTblTamamlananlar(string yapilanIs)
        {

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string insertSQL = "INSERT INTO Tbl_Tamamlananlar (TamamlananIs) VALUES (@P1)";

            using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
            {
                command.Parameters.AddWithValue("@P1", yapilanIs);
                command.ExecuteNonQuery();
            }
            connection.Close();


        }
        public void SatirSilTblIsler(int id)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "DELETE FROM Tbl_Isler WHERE IsID = @id";

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void SatirSilTblTamamlananlar(int id)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "DELETE FROM Tbl_Tamamlananlar WHERE YapilanIsId = @id";

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void SatirSilTblGelirGider(int id)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "DELETE FROM Tbl_GelirGider WHERE GelirGiderID = @id";

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void TumVerileriSilTblIsler()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "DELETE FROM Tbl_Isler";

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void TumVerileriSilTblTamamlananlar()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "DELETE FROM Tbl_Tamamlananlar";

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void TumVerileriSilTblGelirGider()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "DELETE FROM Tbl_GelirGider";

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void AyaGoreVeriSilTblGelirGider(string seciliay)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "DELETE FROM Tbl_GelirGider WHERE Ay = @p1";

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
                command.Parameters.AddWithValue("@p1", seciliay);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void SatirGuncelleTblIsler(int id, string yeniYapilacakIs)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string updateSQL = "UPDATE Tbl_Isler SET YapilacakIs = @yeniYapilacakIs WHERE IsID = @id";

            using (SQLiteCommand command = new SQLiteCommand(updateSQL, connection))
            {
                command.Parameters.AddWithValue("@yeniYapilacakIs", yeniYapilacakIs);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void VeriEkleTblLogin(string kullaniciAdi, string sifre)
        {

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string insertSQL = "INSERT INTO Tbl_Login (KullaniciAdi, Sifre) VALUES (@kullaniciAdi, @sifre)";

            using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
            {
                command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@sifre", sifre);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
