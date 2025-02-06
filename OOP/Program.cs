Beer presidente = new Beer("Presidente", 3);

var coronaBeer = new Beer("Republica", 1.2m);
coronaBeer.Name = "Corona";
coronaBeer.Price = 1.5m;


Console.WriteLine(presidente.Name);
Console.WriteLine(coronaBeer.Name + " $ " + coronaBeer.Price);
Console.WriteLine(presidente.GetInfo());


public class Beer
{
	public string Name { get; set; }

	public decimal Price {  get; set; }	

	public Beer(string name, decimal price)
	{
		Name = name; 
		Price = price;
	}

	public string GetInfo()
	{
		return "Nombre: "+Name + ", Precio: $" + Price;
	}
}
