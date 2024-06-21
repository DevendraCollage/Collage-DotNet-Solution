using System;
using System.Runtime.CompilerServices;

namespace Pro_8
{
	public class Distance
	{
		// Data members of the class
		public double dist1;
		public double dist2;
		public double dist3 = 0;

		public Distance(double dist1, double dist2)
		{
			this.dist1 = dist1;
			this.dist2 = dist2;
		}

		// Perform the addition of this two in the third variable
		public void Add()
		{
			this.dist3 = this.dist1 + this.dist2;
		}

		public void Disp()
		{
			Add();
			Console.WriteLine(this.dist3);
		}
	}
}
