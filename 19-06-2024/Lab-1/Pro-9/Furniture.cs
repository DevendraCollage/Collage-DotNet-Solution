using System;
using Pro_9;

namespace Pro_9
{
	public class Furniture
	{
        // Data members
        public string Material;
		public double Price;

		// Setter method to set the value
		public void Set(string mat, double price)
		{
			this.Material = mat;
			this.Price = price;
		}

		// Getter method to get the value
		public void Get()
		{
			Console.WriteLine("Material : {0}", this.Material);
			Console.WriteLine("Price : {0}", this.Price);
		}
	}
}
