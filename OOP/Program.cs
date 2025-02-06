﻿Beer presidente = new Beer()
{
	Name = "Presidente",
	Price = 3
};

var coronaBeer = new Beer();
coronaBeer.Name = "Corona";
coronaBeer.Price = 1.5m;


Console.WriteLine(presidente.Name);
Console.WriteLine(coronaBeer.Name + " $ " + coronaBeer.Price);
Console.WriteLine(presidente.GetInfo());


public class Beer
{
	public string Name { get; set; }

	public decimal Price {  get; set; }	

	public string GetInfo()
	{
		return "Nombre: "+Name + ", Precio: $" + Price;
	}
}
