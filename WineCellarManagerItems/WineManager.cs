using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WineCellarManager
{
    public class WineManager
    {
        private readonly List<WineBottle> wineBottles = new List<WineBottle>();
        private DatabaseManager databaseManager = new DatabaseManager();
        private string connectionString => databaseManager.ConnString;

        public readonly Dictionary<string, string> propertyMap = new Dictionary<string, string>()
        {
            {"Name", "Nome"},
            {"Vineyard", "Vigneto"},
            {"Location", "Origine"},
            {"Year", "Anno"},
            {"Style", "Stile"},
            {"CellarLocation", "Posizione in magazzino"},
            {"Stock", "Quantità"},
            {"SellingPrice", "Prezzo di Vendita"},
            {"BuyingPrice", "Prezzo di acquisto"},
            {"TastingNotes", "Annotazioni"}
        };
        private WineBottle? selectedBottle = null;

        public WineBottle SelectedBottle
        {
            get => selectedBottle;
            set => selectedBottle = value;
        }

        public WineManager(string connectionString)
        {
            LoadWineBottlesFromDatabase();
        }

        private void LoadWineBottlesFromDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.CommandText = "SELECT * FROM WineBottles";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WineBottle wineBottle = MapToWineBottle(reader);
                            wineBottles.Add(wineBottle);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante il caricamento del DB: " + ex.Message);
            }
        }

        private WineBottle MapToWineBottle(SqlDataReader reader)
        {
            return new WineBottle(
                reader["Name"].ToString(),
                reader["Vineyard"].ToString(),
                reader["Location"].ToString(),
                Convert.ToInt32(reader["Year"]),
                reader["Style"].ToString(),
                reader["CellarLocation"].ToString(),
                Convert.ToInt32(reader["Stock"]),
                Convert.ToDecimal(reader["SellingPrice"]),
                Convert.ToDecimal(reader["BuyingPrice"]),
                reader["TastingNotes"].ToString()
            );
        }

        public List<WineBottle> GetWineBottles() => wineBottles;

        public void CheckStockAndRemoveIfNeeded()
        {
            foreach (var bottle in wineBottles.Where(b => b.Stock < 1).ToList())
            {
                RemoveWineBottle(bottle);
                Console.WriteLine($"La bottiglia {bottle.Name} {bottle.Year} è stata rimossa perché il numero in magazzino era inferiore a 1.");
            }
        }

        public void AddWineBottle(WineBottle bottle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.CommandText = @"INSERT INTO WineBottles (Name, Vineyard, Location, Year, Style, CellarLocation, Stock, SellingPrice, BuyingPrice, TastingNotes)
                                            VALUES (@Name, @Vineyard, @Location, @Year, @Style, @CellarLocation, @Stock, @SellingPrice, @BuyingPrice, @TastingNotes)";
                    AddWineBottleParameters(command.Parameters, bottle);
                    command.ExecuteNonQuery();
                }
                wineBottles.Add(bottle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante l'aggiunta della bottiglia: " + ex.Message);
            }
        }

        private void AddWineBottleParameters(SqlParameterCollection parameters, WineBottle bottle)
        {
            parameters.AddWithValue("@Name", bottle.Name);
            parameters.AddWithValue("@Vineyard", bottle.Vineyard);
            parameters.AddWithValue("@Location", bottle.Location);
            parameters.AddWithValue("@Year", bottle.Year);
            parameters.AddWithValue("@Style", bottle.Style);
            parameters.AddWithValue("@CellarLocation", bottle.CellarLocation);
            parameters.AddWithValue("@Stock", bottle.Stock);
            parameters.AddWithValue("@SellingPrice", bottle.SellingPrice);
            parameters.AddWithValue("@BuyingPrice", bottle.BuyingPrice);
            parameters.AddWithValue("@TastingNotes", bottle.TastingNotes);
        }

        public void RemoveWineBottle(WineBottle bottle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.CommandText = @"DELETE FROM WineBottles WHERE Name = @Name AND Year = @Year";
                    command.Parameters.AddWithValue("@Name", bottle.Name);
                    command.Parameters.AddWithValue("@Year", bottle.Year);
                    command.ExecuteNonQuery();
                }
                wineBottles.Remove(bottle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante la rimozione della bottiglia: " + ex.Message);
            }
        }

        public void UpdateWineBottleAttribute(WineBottle bottle, string attributeName, object newValue)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    string query = $"UPDATE WineBottles SET {attributeName} = @NewValue WHERE Name = @Name AND Year = @Year";
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@Name", bottle.Name);
                    command.Parameters.AddWithValue("@Year", bottle.Year);
                    command.ExecuteNonQuery();
                }
                UpdateLocalBottleAttribute(bottle, attributeName, newValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante l'aggiornamento dell'attributo: " + ex.Message);
            }
        }

        private void UpdateLocalBottleAttribute(WineBottle bottle, string attributeName, object newValue)
        {
            int index = wineBottles.FindIndex(b => b.Name == bottle.Name && b.Year == bottle.Year);
            if (index != -1 && newValue is IComparable comparable)
            {
                var property = typeof(WineBottle).GetProperty(attributeName);
                property?.SetValue(wineBottles[index], newValue);
            }
        }

        public void AddQuantity(WineBottle bottle, int newValue) => UpdateWineBottleAttribute(bottle, "Stock", newValue);

        public void RemoveQuantity(WineBottle bottle, int newValue) => UpdateWineBottleAttribute(bottle, "Stock", newValue);

        public void SortWineBottles(string attributeName, SortOrder sortOrder)
        {
            string actualAttributeName = propertyMap.FirstOrDefault(x => x.Value == attributeName).Key;
            if (actualAttributeName == null)
            {
                Console.WriteLine("Attributo non trovato.");
                return;
            }
            var property = typeof(WineBottle).GetProperty(actualAttributeName);
            if (property != null)
            {
                wineBottles.Sort((x, y) => sortOrder == SortOrder.Ascending ?
                    Comparer<object>.Default.Compare(property.GetValue(x), property.GetValue(y)) :
                    Comparer<object>.Default.Compare(property.GetValue(y), property.GetValue(x)));
            }
            else if (actualAttributeName != "CellarLocation" && actualAttributeName != "TastingNotes")
            {
                wineBottles.Sort((x, y) => sortOrder == SortOrder.Ascending ?
                    string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase) :
                    string.Compare(y.Name, x.Name, StringComparison.OrdinalIgnoreCase));
            }
        }

        public List<WineBottle> FilterWineBottles(string propertyName, string searchTerm)
        {
            if (propertyName == null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }
            string actualPropertyName = propertyMap.FirstOrDefault(x => x.Value == propertyName).Key;
            if (string.IsNullOrWhiteSpace(actualPropertyName) || !propertyMap.ContainsKey(actualPropertyName))
            {
                propertyName = "Name";
            }
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return wineBottles;
            }
            var property = typeof(WineBottle).GetProperty(actualPropertyName);
            if (property != null)
            {
                return wineBottles.Where(bottle => property.GetValue(bottle)?.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false).ToList();
            }
            else
            {
                return wineBottles;
            }
        }
    }
}
