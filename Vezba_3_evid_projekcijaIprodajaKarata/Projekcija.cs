using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba_3_evid_projekcijaIprodajaKarata
{
    public class Projekcija
    {
        public string connectionString = "server=localhost;database=evidencija_projekcija_i_prodaja_karata;user=root;password=";

        public int Id { get; set; }
        public string Datum { get; set; }
        public int Vreme { get; set; }
        public int Sala { get; set; }
        public int FilmId { get; set; }
        public double CenaKarte { get; set; }
        public int DostupnoMesta { get; set; }

        public Projekcija(int id, string datum, int vreme, int sala, int filmId, double cenaKarte, int dostupnoMesta)
        {
            Id = id;
            Datum = datum;
            Vreme = vreme;
            Sala = sala;
            FilmId = filmId;
            CenaKarte = cenaKarte;
            DostupnoMesta = dostupnoMesta;
        }

        public void ZakaziProjekciju()
        {
            try 
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO projekcija (datum, vreme, sala, film_id, cena_karte, dostupno_mesta) VALUES (@datum, @vreme, @sala, @filmId, @cenaKarte, @dostupnoMesta)";
                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        mycommand.Parameters.AddWithValue("@datum", Datum);
                        mycommand.Parameters.AddWithValue("@vreme", Vreme);
                        mycommand.Parameters.AddWithValue("@sala", Sala);
                        mycommand.Parameters.AddWithValue("@filmId", FilmId);
                        mycommand.Parameters.AddWithValue("@cenaKarte", CenaKarte);
                        mycommand.Parameters.AddWithValue("@dostupnoMesta", DostupnoMesta);
                        mycommand.ExecuteNonQuery();
                    }
                }
            
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom zakazivanja projekcije: " + ex.Message);
            }
        }
        public void UpdateProjekcija()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE projekcija SET datum = @datum, vreme = @vreme, sala = @sala, film_id = @filmId, cena_karte = @cenaKarte, dostupno_mesta = @dostupnoMesta WHERE id = @id";

                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        mycommand.Parameters.AddWithValue("@id", Id);
                        mycommand.Parameters.AddWithValue("@datum", Datum);
                        mycommand.Parameters.AddWithValue("@vreme", Vreme);
                        mycommand.Parameters.AddWithValue("@sala", Sala);
                        mycommand.Parameters.AddWithValue("@filmId", FilmId);
                        mycommand.Parameters.AddWithValue("@cenaKarte", CenaKarte);
                        mycommand.Parameters.AddWithValue("@dostupnoMesta", DostupnoMesta);

                        mycommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom uredjivanja projekcije: " + ex.Message);
            }
        }
        public void IzbrisiProjekciju()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM projekcija WHERE id = @id";
                    using (MySqlCommand mycommand = new MySqlCommand(query, connection))
                    {
                        mycommand.Parameters.AddWithValue("@id", Id);
                        mycommand.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom brisanja projekcije: " + ex.Message);
            }
        }

        public void ProdajKartu()
        {
            if (DostupnoMesta > 0)
            {
                DostupnoMesta--;
                UpdateProjekcija();
            }
            else
            {
                Console.WriteLine("Nema dostupnih mesta za ovu projekciju.");
            }
        }
}
}
