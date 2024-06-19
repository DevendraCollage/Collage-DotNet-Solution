using System;
using Pro_3;

/*
 * Author :  Devendra Parmar
 * Question : Write a pogram to Create a class Bank_Account with Account_No, Email, User_Name,
 * Account_Type and Account_Balance as data members. Also create a Member function GetAccountDetails()
 * & DisplayAccountDetails().
 */

namespace Pro_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the Class
            Bank_Account account = new Bank_Account();

            // Read the detail from the user
            Console.WriteLine("-- Enter your bank details here --");
            Console.Write("Enter your Account No : ");
            account.Account_No = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Email : ");
            account.Email = Console.ReadLine();
            Console.Write("Enter your Name : ");
            account.User_Name = Console.ReadLine();
            Console.Write("Enter your Account Type : ");
            account.Account_Type = Console.ReadLine();
            Console.Write("Enter your Account Balance : ");
            account.Account_Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // Call the method and pass the details
            account.GetAccountDetails(account.Account_No, account.Email, account.User_Name, account.Account_Type, account.Account_Balance);

            // Call the method and print the details
            account.DisplayAccountDetails();
        }
    }
}
