using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WineCellarManager
{

    public class WineManager
    {
        private List<WineBottle> wineBottles = new List<WineBottle>();
        String conString = "aggiungere la stringa di connessione";

        public WineManager() 
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM WineBottles";
                    SqlCommand command = new SqlCommand(query, conn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WineBottle wineBottle = new WineBottle(
                                reader["Name"].ToString(),
                                reader["Vineyard"].ToString(),
                                reader["Location"].ToString(),
                                Convert.ToInt32(reader["Year"]),
                                reader["Style"].ToString(),
                                reader["CellarLocation"].ToString(),
                                Convert.ToInt32(reader["Stock"]),
                                double.Parse(reader["SellingPrice"].ToString()),
                                double.Parse(reader["BuyingPrice"].ToString()),
                                reader["TastingNotes"].ToString()
                            );

                            wineBottles.Add(wineBottle);
                        };
                    }

                    conn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Errore durante il caricamento del DB: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public List<WineBottle> GetWineBottles() 
        { 
            return wineBottles;
        }
        public void AddWineBottle(WineBottle bottle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();

                    string query = @"INSERT INTO WineBottles (Name, Vineyard, Location, Year, Style, CellarLocation, Stock, SellingPrice, BuyingPrice, TastingNotes)
                                    VALUES (@Name, @Vineyard, @Location, @Year, @Style, @CellarLocation, @Stock, @SellingPrice, @BuyingPrice, @TastingNotes)";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Name", bottle.Name);
                    command.Parameters.AddWithValue("@Vineyard", bottle.Vineyard);
                    command.Parameters.AddWithValue("@Location", bottle.Location);
                    command.Parameters.AddWithValue("@Year", bottle.Year);
                    command.Parameters.AddWithValue("@Style", bottle.Style);
                    command.Parameters.AddWithValue("@CellarLocation", bottle.CellarLocation);
                    command.Parameters.AddWithValue("@Stock", bottle.Stock);
                    command.Parameters.AddWithValue("@SellingPrice", bottle.SellingPrice);
                    command.Parameters.AddWithValue("@BuyingPrice", bottle.BuyingPrice);
                    command.Parameters.AddWithValue("@TastingNotes", bottle.TastingNotes);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante l'aggiunta della bottiglia: " + ex.Message);
            }
        }

        public void RemoveWineBottle(WineBottle bottle)
        {
            String bottleName = bottle.Name;
            int bottleYear = bottle.Year;
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();

                    string query = @"DELETE FROM WineBottles WHERE Name = @bottleName AND Year = @bottleYear";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@bottleName", bottleName);
                    command.Parameters.AddWithValue("@bottleYear", bottleYear);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante la rimozione della bottiglia: " + ex.Message);
            }
        }
    }

    // un metodo per aggiornare la lista interna
    // un metodo per aggiornare i cambiamenti tra lista e db
    // metodi per modificare singolarmente i valori delle wineBottle
    // metodo per controllare il numero in stock quindi if(<1) messageBox con richiesta di rimozione
}
