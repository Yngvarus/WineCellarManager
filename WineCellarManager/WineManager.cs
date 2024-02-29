using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace WineCellarManager
{
    public class WineManager
    {
        #region Fields
        // Attributi
        private List<WineBottle> wineBottles = new List<WineBottle>();
        private readonly string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=M:\\desktop\\junk_cartelle\\Documents\\WineBottlesDb.mdf;Integrated Security=True;Connect Timeout=30";
        private WineBottle? selectedBottle = null;
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
        #endregion

        #region Constructor
        // Costruttore
        public WineManager()
        {
            LoadWineBottlesFromDatabase();
        }
        #endregion

        #region Properties
        public WineBottle SelectedBottle
        {
            get => selectedBottle;
            set => selectedBottle = value;
        }
        #endregion

        #region Methods
        // Metodo per caricare i dati da db a List
        private void LoadWineBottlesFromDatabase()
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
                                Convert.ToDecimal(reader["SellingPrice"]),
                                Convert.ToDecimal(reader["BuyingPrice"]),
                                reader["TastingNotes"].ToString()
                            );
                            wineBottles.Add(wineBottle);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Errore durante il caricamento del DB: " + ex.Message);
                }
            }
        }

        // Metodo che restituisce la lista delle bottiglie
        public List<WineBottle> GetWineBottles() => wineBottles;

        // Metodo per controllare il numero di bottiglie in magazzino e rimuovere se minore di 1
        public void CheckStockAndRemoveIfNeeded()
        {
            foreach (var bottle in wineBottles)
            {
                if (bottle.Stock < 1)
                {
                    RemoveWineBottle(bottle);
                    Console.WriteLine($"La bottiglia {bottle.Name} {bottle.Year} è stata rimossa perché il numero in magazzino era inferiore a 1.");
                }
            }
        }

        // Metodo per aggiungere bottiglie al db
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
                }
                // Aggiorna la lista interna dopo l'aggiunta di una nuova bottiglia
                wineBottles.Add(bottle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante l'aggiunta della bottiglia: " + ex.Message);
            }
        }

        // Metodo per rimuovere bottiglie dal db
        public void RemoveWineBottle(WineBottle bottle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    string query = @"DELETE FROM WineBottles WHERE Name = @bottleName AND Year = @bottleYear";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@bottleName", bottle.Name);
                    command.Parameters.AddWithValue("@bottleYear", bottle.Year);
                    command.ExecuteNonQuery();
                }
                // Rimuovi la bottiglia dalla lista interna dopo la rimozione dal database
                wineBottles.Remove(bottle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante la rimozione della bottiglia: " + ex.Message);
            }
        }

        // Metodo per aggiornare un singolo attributo di una bottiglia di vino
        public void UpdateWineBottleAttribute(WineBottle bottle, string attributeName, object newValue)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    string query = $@"UPDATE WineBottles SET {attributeName} = @newValue WHERE Name = @bottleName AND Year = @bottleYear";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@bottleName", bottle.Name);
                    command.Parameters.AddWithValue("@bottleYear", bottle.Year);
                    command.ExecuteNonQuery();
                }
                // Aggiorna la lista interna dopo la modifica dell'attributo
                int index = wineBottles.FindIndex(b => b.Name == bottle.Name && b.Year == bottle.Year);
                if (index != -1 && newValue is IComparable comparable)
                {
                    wineBottles[index].GetType().GetProperty(attributeName)?.SetValue(wineBottles[index], newValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante l'aggiornamento dell'attributo: " + ex.Message);
            }
        }

        // Metodo per aggiungere la quantità a una bottiglia di vino
        public void AddQuantity(WineBottle bottle, int newValue) => UpdateWineBottleAttribute(bottle, "Stock", newValue);

        // Metodo per rimuovere la quantità da una bottiglia di vino
        public void RemoveQuantity(WineBottle bottle, int newValue) => UpdateWineBottleAttribute(bottle, "Stock", newValue);

        // Metodo per ordinare le bottiglie di vino
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
                wineBottles = sortOrder == SortOrder.Ascending ?
                    wineBottles.OrderBy(b => property.GetValue(b) as IComparable).ToList() :
                    wineBottles.OrderByDescending(b => property.GetValue(b) as IComparable).ToList();
            }
            else if (actualAttributeName == "CellarLocation" || actualAttributeName == "TastingNotes")
            {
                // Se l'attributo corrisponde a CellarLocation o TastingNotes, non ordinare
                return;
            }
            else
            {
                // Se l'attributo non corrisponde a nessun caso specifico, ordina per nome di default
                wineBottles = sortOrder == SortOrder.Ascending ?
                    wineBottles.OrderBy(b => b.Name).ToList() :
                    wineBottles.OrderByDescending(b => b.Name).ToList();
            }
        }

        // Metodo per filtrare le bottiglie di vino
        public List<WineBottle> FilterWineBottles(string propertyName, string searchTerm)
        {
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
        #endregion
    }
}
