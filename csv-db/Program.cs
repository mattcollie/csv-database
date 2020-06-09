using System;
using csv_db.tables;
using csv_db.tables.interfaces;

namespace csv_db
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var accountTable = new Account();
            accountTable.Items.Add(new AccountModel{Username = "Joel", Password = "J"});
            accountTable.Items.Add(new AccountModel{Username = "Matt", Password = "x", Balance = 400, CreditCard = "blah blah"});
            accountTable.Store();

            var shareTable = new Shares();
            shareTable.Items.Add(new ShareModel{Name="NZX", Price = 500, Value=4});
            shareTable.Store();
        }
    }
}