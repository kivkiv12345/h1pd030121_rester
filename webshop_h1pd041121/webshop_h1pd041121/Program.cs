using System;
using TECHCOOL;

namespace webshop_h1pd041121
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLet.ConnectSQLite(@"C:\Users\Kevin\webshopdb.db");

            Console.Write("Indtast kundens fornavn: ");
            string firstName = Console.ReadLine();

            Console.Write("Indtast kundens efternavn: ");
            string lastName = Console.ReadLine();

            Console.Write("Indtast kundens postnummer: ");
            string zipCode = Console.ReadLine();

            Console.Write("Indtast kundens telefonnummer: ");
            string phone = Console.ReadLine();

            string sqltpl = "INSERT INTO {0} (firstName, lastName, zipCode, phone) VALUES ('{1}', '{2}', {3}, {4})";
            string sql = string.Format(sqltpl, "customers", firstName, lastName, zipCode, phone);
            Console.WriteLine(sql);

            SQLet.Execute(sql);

            Console.ReadLine();
        }
    }
}
