using System;

namespace Pro_7
{
	public class Salary
	{
		// Data member of the class
		public double Basic; // Basic Salary
		public double TA; // Travelling Allowance
		public double DA; // Dearness Allowance
		public double HRA; // House Rent Allowance

        // Create the constructor
        public Salary(double basic, double ta, double hra = 0, double da = 0)
		{
			this.Basic = basic;
			this.TA = ta;
			this.DA = da == 0 ? (10*Basic)/100 : da; // This line will define if the value of the da will become 0 then calculate the da otherwise set the value
			this.HRA = hra == 0 ? (20*Basic)/100 : hra; // This line will define if the value of the hra will become 0 then calculate the hra otherwise set the value
        }

		// Calculate the basic salary
		public double BasicSal()
		{
			double bsal = this.Basic - (this.TA + this.DA + this.HRA);
			return bsal;
		}
	}
}
