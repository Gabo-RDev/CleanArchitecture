namespace OOP.Business
{
	public class Beer : Drinks
	{
		private const string Category = "Cerveza";
		private decimal _alcohol; // campo
		public string Name { get; set; }

		protected decimal Price { get; set; } // Propiedad automatica

		public decimal Alcohol // Propiedad
		{
			get { return _alcohol; }
			set
			{
				if (value < 0)
				{
					_alcohol = 0;
				}
				else
				{
					_alcohol = value;
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

		public Beer(string name, decimal price, decimal alcohol, int quantity) : base(quantity)
		{
			Name = name;
			Price = price;
			Alcohol = alcohol;
			Quantity = quantity;
		}

		public virtual string GetInfo()
		{
			return "Nombre: " + Name + ", Precio: $" + Price + ", Alcohol " + Alcohol;
		}

		public string GetInfo(string message)
		{
			return message + " " + GetInfo();
		}

		public string GetInfo(int number) { return number + ".- " + GetInfo(); }

		public override string GetCategory()
		{
			return Category;
		}
	}
}

