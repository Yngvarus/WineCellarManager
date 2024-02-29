using System;

namespace WineCellarManager
{
    // Rappresenta una bottiglia di vino.
    public class WineBottle
    {
        #region Fields
        // Campi privati della WineBottle
        private string name = "";
        private string vineyard = "";
        private string location = "";
        private int year = 0;
        private string style = "";
        private string cellarLocation = "";
        private int stock = 0;
        private decimal sellingPrice = 0.00m;
        private decimal buyingPrice = 0.00m;
        private string tastingNotes = "";
        #endregion

        #region Properties
        // Nome della bottiglia di vino.
        public string Name { get; set; }

        // Vigneto di provenienza del vino.
        public string Vineyard { get; set; }

        // Luogo d'origine del vino.
        public string Location { get; set; }

        // Anno di produzione del vino.
        public int Year { get; set; }

        // Stile del vino.
        public string Style { get; set; }

        // Posizione della bottiglia nella cantina.
        public string CellarLocation { get; set; }

        // Quantità di bottiglie in magazzino.
        public int Stock { get; set; }

        // Prezzo di vendita della bottiglia.
        public decimal SellingPrice { get; set; }

        // Prezzo di acquisto della bottiglia.
        public decimal BuyingPrice { get; set; }

        // Note di degustazione del vino.
        public string TastingNotes { get; set; }
        #endregion

        #region Constructor
        // Costruisce un'istanza di WineBottle con le informazioni specificate.
        // Solleva un'eccezione ArgumentException se uno dei parametri stringa è vuoto o nullo.
        // Solleva un'eccezione ArgumentException se uno dei parametri numerici è negativo o zero.
        public WineBottle(string name, string vineyard, string location, int year, string style, string cellarLocation, int stock, decimal sellingPrice, decimal buyingPrice, string tastingNotes)
        {
            // Controllo dei parametri
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Il nome non può essere vuoto.", nameof(name));

            if (string.IsNullOrWhiteSpace(vineyard))
                throw new ArgumentException("Il vigneto non può essere vuoto.", nameof(vineyard));

            if (string.IsNullOrWhiteSpace(location))
                throw new ArgumentException("Il luogo d'origine non può essere vuoto.", nameof(location));

            if (string.IsNullOrWhiteSpace(style))
                throw new ArgumentException("Lo stile non può essere vuoto.", nameof(style));

            if (string.IsNullOrWhiteSpace(cellarLocation))
                throw new ArgumentException("La posizione in cantina non può essere vuota.", nameof(cellarLocation));

            if (string.IsNullOrWhiteSpace(tastingNotes))
                throw new ArgumentException("Le note di degustazione non possono essere vuote.", nameof(tastingNotes));

            if (year <= 0)
                throw new ArgumentException("L'anno deve essere maggiore di zero.", nameof(year));

            if (stock < 0)
                throw new ArgumentException("La quantità in magazzino non può essere negativa.", nameof(stock));

            if (sellingPrice <= 0)
                throw new ArgumentException("Il prezzo di vendita deve essere maggiore di zero.", nameof(sellingPrice));

            if (buyingPrice <= 0)
                throw new ArgumentException("Il prezzo di acquisto deve essere maggiore di zero.", nameof(buyingPrice));


            // Assegnamento dei valori ai campi
            Name = name;
            Vineyard = vineyard;
            Location = location;
            Year = year;
            Style = style;
            CellarLocation = cellarLocation;
            Stock = stock;
            SellingPrice = sellingPrice;
            BuyingPrice = buyingPrice;
            TastingNotes = tastingNotes;

            Console.WriteLine("Oggetto bottiglia di vino creato");
        }
        #endregion

        #region Methods
        // Determina se l'oggetto specificato è uguale all'oggetto corrente.
        public override bool Equals(object? obj)
        {
            return obj is WineBottle bottle &&
                   Name == bottle.Name &&
                   Vineyard == bottle.Vineyard &&
                   Year == bottle.Year &&
                   Style == bottle.Style &&
                   CellarLocation == bottle.CellarLocation;
        }

        // Restituisce il codice hash per l'oggetto corrente.
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();

            hash.Add(Name);
            hash.Add(Vineyard);
            hash.Add(Year);
            hash.Add(Style);
            hash.Add(CellarLocation);

            return hash.ToHashCode();
        }
        #endregion
    }
}