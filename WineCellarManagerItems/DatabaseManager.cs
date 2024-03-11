using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Data.SqlClient;

public class DatabaseManager
{
    private readonly string _connectionString;
    private readonly string _databaseFolder;

    public string ConnString => _connectionString;

    public DatabaseManager()
    {
        // Carica la configurazione da appsettings.xml
        var xmlDoc = new XmlDocument();
        xmlDoc.Load("appsettings.xml");

        _connectionString = xmlDoc.SelectSingleNode("/configuration/ConnectionStrings/DefaultConnection").InnerText;

        // Modifica per rendere generico il percorso del database
        string databaseFolder = xmlDoc.SelectSingleNode("/configuration/DatabaseFolder").InnerText;
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        _databaseFolder = Path.Combine(baseDirectory, databaseFolder);

        if (CheckDatabaseExists())
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
            }
        }
        else
        {
            CreateDatabase();
        }
    }

    public bool CheckDatabaseExists()
    {
        try
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return true;
            }
        }
        catch (SqlException)
        {
            return false;
        }
    }

    public void CreateDatabase()
    {
        try
        {
            // Crea il database se non esiste
            string databaseFilePath = Path.Combine(_databaseFolder, "WineBottlesDb.mdf");
            string logFilePath = Path.Combine(_databaseFolder, "WineBottlesDb_log.ldf");

            string createDatabaseQuery = $@"
            CREATE DATABASE WineBottlesDb
            ON PRIMARY (
                NAME = WineBottlesDb,
                FILENAME = '{databaseFilePath}'
            )
            LOG ON (
                NAME = WineBottlesDb_log,
                FILENAME = '{logFilePath}'
            )";

            using (var connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Integrated security=SSPI;database=master"))
            {
                using (var command = new SqlCommand(createDatabaseQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            // Crea la tabella WineBottle se non esiste
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'WineBottle')
            BEGIN
                CREATE TABLE WineBottle (
                    Id INT PRIMARY KEY IDENTITY,
                    Name NVARCHAR(100),
                    Vineyard NVARCHAR(100),
                    Location NVARCHAR(100),
                    Year INT,
                    Style NVARCHAR(100),
                    CellarLocation NVARCHAR(100),
                    Stock INT,
                    SellingPrice DECIMAL(18,2),
                    BuyingPrice DECIMAL(18,2),
                    TastingNotes NVARCHAR(MAX)
                )
            END";

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(createTableQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating database: {ex.Message}");
        }
    }

}