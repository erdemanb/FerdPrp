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
            DataBaseOlustur();

        }

        public void DataBaseOlustur()
        {
            connection = baglanti.GetConnection();
            connection.Open();
            string createTable1SQL = "CREATE TABLE IF NOT EXISTS Tbl_Isler (\r\n    IsID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    YapilacakIs VARCHAR(90)\r\n);\r\n" +
                "CREATE TABLE IF NOT EXISTS Tbl_Login (\r\n    KullaniciID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    KullaniciAdi VARCHAR(15),\r\n    Sifre VARCHAR(12)\r\n);\r\n" +
                "CREATE TABLE IF NOT EXISTS Tbl_Bakiye (\r\n    KarZararID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    Gelir INT,\r\n    Gider INT,\r\n    KarZarar INT\r\n);\r\n " +
                "CREATE TABLE IF NOT EXISTS Tbl_Kitaplar (\r\n    KitapID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    KitapAd VARCHAR(50),\r\n    Yazar VARCHAR(50)\r\n);\r\n\r\n" +
                "CREATE TABLE IF NOT EXISTS Tbl_Filmler (\r\n    FilmID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    FilmAd VARCHAR(50),\r\n    FilmTur VARCHAR(50),\r\n    FilmYonetmen VARCHAR(50)\r\n);";


            SQLiteCommand command1 = new SQLiteCommand(createTable1SQL, connection);
            command1.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable VeriListele()
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
                return veriTablosu;
            }
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
                connection.Close ();


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
        public void TumVerileriSilTblIsler()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string deleteSQL = "DELETE FROM Tbl_Isler"; // WHERE koşulu olmadan tüm verileri siler

            using (SQLiteCommand command = new SQLiteCommand(deleteSQL, connection))
            {
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
            connection.Close ();
        }
    }
}
