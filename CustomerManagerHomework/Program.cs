using System;

namespace CustomerManagerHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Nursebil";
            customer1.Surname = "Canbolat";
            customer1.IdNo = 1000000000;
            customer1.Bank = "Ziraat Bankası";

            Customer customer2 = new Customer();
            customer2.Name = "İpek";
            customer2.Surname = "Albayrak";
            customer2.IdNo = 1111111111;
            customer2.Bank = "VakıfBank";

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (Customer customer in customers)
            {
                Console.Write(customer.Name + " "+ customer.Surname +" " );
                Console.WriteLine(customer.IdNo + " "+ customer.Bank);
            }

            Console.WriteLine("---------------------------------------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1.Name,customer1.Surname,customer1.IdNo);
            customerManager.Add(customer2.Name,customer2.Surname,customer2.IdNo);

            Console.WriteLine("---------------------------------------------------");
            customerManager.List(customer1.Name,customer1.Surname);
            customerManager.List(customer2.Name,customer2.Surname);
            Console.WriteLine("---------------------------------------------------");

            customerManager.Cancel(customer1.Name,customer1.Surname);
            customerManager.Cancel(customer2.Name, customer2.Surname);
            Console.WriteLine("---------------------------------------------------");



            Console.ReadLine();

            
        }
    }
}
