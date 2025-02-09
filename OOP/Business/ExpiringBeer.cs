
namespace OOP.Business
{
	public class ExpiringBeer : Beer
	{
		public DateTime Expiration { get; set; }
		public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expiration)
			: base(name, price, alcohol)
		{
			Expiration = expiration;
			var p = Price;
		}

		public override string GetInfo()
		{
			return "Cerverza con caducidad: " + Name + ", " + "Precio: $ " + Price + ", Alcohol: "
				+ Alcohol + ", caducidad: " + Expiration.Date.ToString();
		}
	}
}
