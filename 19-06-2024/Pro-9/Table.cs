using System;
using Pro_9;

namespace Pro_9
{
	public class Table : Furniture
	{
		// Data members of the class
		public double Height;
		public double Surface_area;

		// Setter method to set the value
		public void Set(double h, double surf_area)
		{
			this.Height = h;
			this.Surface_area = surf_area;
		}

		// Getter method to get the value
		public void Get()
		{
			Console.WriteLine("Height : {0}", this.Height);
			Console.WriteLine("Surface-Area : {0}", this.Surface_area);
		}
	}
}
