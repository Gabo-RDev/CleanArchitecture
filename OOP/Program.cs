using OOP.Business;

Beer presidente = new Beer("Presidente", 3, -2, 1);
var delirium = new ExpiringBeer("Delirium", 4, 8, 4,  new DateTime(2025,12,01));
Drinks drink = new Beer("La Republica", 5, 5, 999);


Console.WriteLine(presidente.Name);
Console.WriteLine(delirium.GetInfo());
Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
Console.WriteLine(delirium.GetInfo(5));
