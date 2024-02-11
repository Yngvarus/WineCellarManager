using System;
using System.Runtime.InteropServices;

public class WineBottle
{
	//Fiels privati della WineBottle
	private String name = "";
	private String vineyard = "";
    private String location = "";
    private int year = 0;
    private String style = "";
    private String cellarLocation = "";
    private int stock = 0;
    private Double sellingPrice = 0.0f;
    private Double buyingPrice = 0.0f;
    private String tastingNotes = "";

    //Setter e getter per le proprietà
    public string Name { get => name; set => name = value; }
    public string Vineyard { get => vineyard; set => vineyard = value; }
    public string Location { get => location; set => location = value; }
    public int Year { get => year; set => year = value; }
    public string Style { get => style; set => style = value; }
    public string CellarLocation { get => cellarLocation; set => cellarLocation = value; }
    public int Stock { get => stock; set => stock = value; }
    public double SellingPrice { get => sellingPrice; set => sellingPrice = value; }
    public double BuyingPrice { get => buyingPrice; set => buyingPrice = value; }
    public string TastingNotes { get => tastingNotes; set => tastingNotes = value; }

    //Costruttore dell'obj Winebottle 
    public WineBottle(string name, string vineyard, string location, int year, string style, string cellarLocation, int stock, double sellingPrice, double buyingPrice, string tastingNotes)
    {
        this.Name = name;
        this.Vineyard = vineyard;
        this.Location = location;
        this.Year = year;
        this.Style = style;
        this.CellarLocation = cellarLocation;
        this.Stock = stock;
        this.SellingPrice = sellingPrice;
        this.BuyingPrice = buyingPrice;
        this.TastingNotes = tastingNotes;
        Console.WriteLine("Oggetto bottiglia di vino creato");
    }

    public override bool Equals(object? obj)
    {
        return obj is WineBottle bottle &&
               name == bottle.name &&
               vineyard == bottle.vineyard &&
               year == bottle.year &&
               style == bottle.style &&
               cellarLocation == bottle.cellarLocation;
    }

    public override int GetHashCode()
    {
        HashCode hash = new HashCode();
        hash.Add(name);
        hash.Add(vineyard);
        hash.Add(year);
        hash.Add(style);
        hash.Add(cellarLocation);
        return hash.ToHashCode();
    }


}
