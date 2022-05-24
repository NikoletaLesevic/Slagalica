using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Slagalica_79_2018
{
    public class RezultatiDB
    {
        SqliteConnection conn = DbConnection.Connection;

        public void upisiRezultat(string ime, int brPoteza, int vreme)
        {
            conn.Open();
            string upit = "INSERT INTO Rezultati(ime,brPoteza,vreme) values(@ime,@brPoteza,@vreme)";
            SqliteCommand cmd = new SqliteCommand(upit, conn);
            cmd.Parameters.AddWithValue("@ime", ime);
            cmd.Parameters.AddWithValue("@brPoteza", brPoteza);
            cmd.Parameters.AddWithValue("@vreme", vreme);

            SqliteDataReader reader = cmd.ExecuteReader();

            conn.Close();
        }

        public List<Rezultat> dajRezultate()
        {
            List<Rezultat> rezultati = new List<Rezultat>();
            conn.Open();
            string upit = "SELECT * FROM Rezultati ORDER BY brPoteza ASC LIMIT 10";
            SqliteCommand cmd = new SqliteCommand(upit, conn);

            SqliteDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                rezultati.Add(new Rezultat(reader["ime"].ToString(), int.Parse(reader["brPoteza"].ToString()),int.Parse(reader["vreme"].ToString())));
            }

            conn.Close();

            return rezultati;
        }

        public List<Rezultat> dajRezultate2()
        {
            List<Rezultat> rezultati = new List<Rezultat>();
            conn.Open();
            string upit = "SELECT * FROM Rezultati ORDER BY vreme ASC LIMIT 10";
            SqliteCommand cmd = new SqliteCommand(upit, conn);

            SqliteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rezultati.Add(new Rezultat(reader["ime"].ToString(), int.Parse(reader["brPoteza"].ToString()), int.Parse(reader["vreme"].ToString())));
            }

            conn.Close();

            return rezultati;
        }

        internal void sacuvajSlike(byte[] bytes)
        {
            conn.Open();
            string upit = "insert into Stanje(slike) values(@bytes)";
            SqliteCommand cmd = new SqliteCommand(upit, conn);
            cmd.Parameters.AddWithValue("@bytes", bytes);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        internal byte[] dajSlicice()
        {
            byte[] bytes = null;
            conn.Open();
            string upit = "select * from Stanje where id=1";
            SqliteCommand cmd = new SqliteCommand(upit, conn);
            SqliteDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                bytes = (byte[])(reader["slike"]);
            }

            conn.Close();
            return bytes;
        }
    }
}
