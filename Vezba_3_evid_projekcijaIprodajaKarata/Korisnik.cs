using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba_3_evid_projekcijaIprodajaKarata
{
    public class Korisnik
    {
        public string connectionString = "server=localhost;database=evidencija_projekcija_i_prodaja_karata;user=root;password=";
        public string Ime { get; set; }
        public string Sifra { get; set; }

        public Korisnik(string ime, string sifra)
        {
            Ime = ime;
            Sifra = sifra;
        }

        public bool LoginKorisnika()
        {
            try 
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM korisnici WHERE ime = @ime AND sifra = @sifra";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ime", Ime);
                        cmd.Parameters.AddWithValue("@sifra", Sifra);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                            else
                            {  return false; }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom provere korisnika: " + ex.Message);
                return false;
            }
        }

        public void DodajKorisnika()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO korisnici (ime, sifra) VALUES (@ime, @sifra)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ime", Ime);
                        cmd.Parameters.AddWithValue("@sifra", Sifra);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom dodavanja korisnika: " + ex.Message);
            }
        }
}
}
