using System;

namespace Pro_3
{
    internal class Bank_Account
    {
        // Data members of this class
        public int Account_No;
        public string Email;
        public string User_Name;
        public string Account_Type;
        public double Account_Balance;

        // Member function to get details
        public void GetAccountDetails(int acno, string email, string uname, string actype, double acbal)
        {
            this.Account_No = acno;
            this.Email = email;
            this.User_Name = uname;
            this.Account_Type = actype;
            this.Account_Balance = acbal;
        }

        // Member function to disply details
        public void DisplayAccountDetails()
        {
            Console.WriteLine("-- Your Bank Details --");
            Console.WriteLine("Your Ac No Is : {0}", Account_No);
            Console.WriteLine("Your Emain Is : {0}", Email);
            Console.WriteLine("Your Username Is : {0}", User_Name);
            Console.WriteLine("Your Account Type Is : {0}", Account_Type);
            Console.WriteLine("Your Account Balance Is : {0}", Account_Balance);
        }
    }
}
