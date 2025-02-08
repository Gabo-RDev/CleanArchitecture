using OOP.Business;

Beer presidente = new Beer("Presidente", 3, -2);
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2025,12,01));


Console.WriteLine(presidente.Name);
Console.WriteLine(delirium.GetInfo());
Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
Console.WriteLine(delirium.GetInfo(5));
