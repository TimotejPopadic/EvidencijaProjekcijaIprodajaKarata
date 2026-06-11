using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba_3_evid_projekcijaIprodajaKarata
{
    public class Film
    {
        public string connectionString = "server=localhost;database=evidencija_projekcija_i_prodaja_karata;user=root;password=";
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Zanr { get; set; }
        public int Trajanje { get; set; }
        public string Opis { get; set; }

        public Film(int id, string naziv, string zanr, int trajanje, string opis)
        {
            Id = id;
            Naziv = naziv;
            Zanr = zanr;
            Trajanje = trajanje;
            Opis = opis;
        }

        public void DodajFilm() 
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO film (naziv, zanr, trajanje, opis) VALUES (@naziv, @zanr, @trajanje, @opis)";

                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        mycommand.Parameters.AddWithValue("@naziv", Naziv);
                        mycommand.Parameters.AddWithValue("@zanr", Zanr);
                        mycommand.Parameters.AddWithValue("@trajanje", Trajanje);
                        mycommand.Parameters.AddWithValue("@opis", Opis);

                        mycommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom dodavanja filma: " + ex.Message);
            }
        }

        public void UpdateFilm()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE film SET naziv = @naziv, zanr = @zanr, trajanje = @trajanje, opis = @opis WHERE id = @id";

                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        mycommand.Parameters.AddWithValue("@id", Id);
                        mycommand.Parameters.AddWithValue("@naziv", Naziv);
                        mycommand.Parameters.AddWithValue("@zanr", Zanr);
                        mycommand.Parameters.AddWithValue("@trajanje", Trajanje);
                        mycommand.Parameters.AddWithValue("@opis", Opis);

                        mycommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom dodavanja filma: " + ex.Message);
            }
        }
        public void DeleteFilm()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM film WHERE id = @id";

                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        mycommand.Parameters.AddWithValue("@id", Id);
                        mycommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom brisanja filma: " + ex.Message);
            }
        }
        public void PrikaziFilmove()
        {
            try { 
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM film";

                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = mycommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string naziv = reader.GetString("naziv");
                                string zanr = reader.GetString("zanr");
                                int trajanje = reader.GetInt32("trajanje");
                                string opis = reader.GetString("opis");
                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom prikaza filmova: " + ex.Message);
            }
        }

        public void PretragaPoNazivu() 
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM film WHERE naziv = @naziv";

                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        mycommand.Parameters.AddWithValue("@naziv", Naziv);
                        using (MySqlDataReader reader = mycommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string naziv = reader.GetString("naziv");
                                string zanr = reader.GetString("zanr");
                                int trajanje = reader.GetInt32("trajanje");
                                string opis = reader.GetString("opis");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom prikaza filmova: " + ex.Message);
            }
        }
        public void PretragaPoZanru()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM film WHERE zanr = @zanr";

                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        mycommand.Parameters.AddWithValue("@zanr", Zanr);
                        using (MySqlDataReader reader = mycommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string naziv = reader.GetString("naziv");
                                string zanr = reader.GetString("zanr");
                                int trajanje = reader.GetInt32("trajanje");
                                string opis = reader.GetString("opis");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom prikaza filmova: " + ex.Message);
            }
        }


    }
}
