using System;

namespace Task3
{
    class Customer
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;

        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public void PrintInfo()
        {
            Console.WriteLine($"account = {account} | customer = {customer} | provider = {provider}");
        }

        public Customer(int account , string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CalcNds(int price)
        {
            int withoutnds = price * quantity;
            double withnds = withoutnds * 0.2 + withoutnds; // если НДС 20%

            Console.WriteLine($"Price with NDS : {withnds} || Price without NDS {withoutnds}");
        }

    }
}
