namespace OOP.Business
{
	public abstract class Drinks // Clase abstracta, no se puede crear nuevos objectos
	{
		public int Quantity { get; set; }

		public Drinks(int quantity)
		{
			this.Quantity = quantity;
		}

		public string GetQuantity()
		{
			return Quantity + "ml";
		}

		public abstract string GetCategory();
	}
}
