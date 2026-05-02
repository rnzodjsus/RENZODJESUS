using System;

namespace Accounts
{
    
    public class CircleHelper
    {
        public static double getCircleDiameter(double radius)
        {
            return radius * 2;
        }
    }

    public struct Product
    {
        public string code;
        public string description;
        public double price;

        public Product(string code, string description, double price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
        }
    }

    
    public class Person
    {
        public string full_name;

        public Person()
        {
            full_name = "Isidro Renzo De Jesus";
        }
    }

    
    public class Account
    {
        public string account_number;

        public Account(string account_number)
        {
            this.account_number = account_number;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            double diameter = CircleHelper.getCircleDiameter(5);
            Console.WriteLine("Circle Diameter: " + diameter);

           
            Product p = new Product("P001", "Laptop", 45000.50);
            Console.WriteLine($"Product: {p.code}, {p.description}, {p.price}");

            
            Person person = new Person();
            Console.WriteLine("Person Name: " + person.full_name);

            
            Account acc = new Account("ACC12345");
            Console.WriteLine("Account Number: " + acc.account_number);
        }
    }
}
