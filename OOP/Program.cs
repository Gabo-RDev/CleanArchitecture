Beer presidente = new Beer("Presidente", 3, -2);

Console.WriteLine(presidente.Name);
Console.WriteLine(presidente.SAlcohol);


public class Beer
{
	private decimal _alcohol; // campo
	public string Name { get; set; }

	public decimal Price { get; set; } // Propiedad automatica

	public decimal Alcohol // Propiedad
	{
		get { return _alcohol; }
		set
		{
			if (value < 0)
			{
				value = 0;
			}
		}
	}

	public string SAlcohol
	{
		get
		{
			return "Alcohol: " + _alcohol.ToString();
		}
	}

	public Beer(string name, decimal price, decimal alcohol)
	{
		Name = name;
		Price = price;
		Alcohol = alcohol;
	}

	public string GetInfo()
	{
		return "Nombre: " + Name + ", Precio: $" + Price + ", Alcohol " + Alcohol;
	}
}
