using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Semih Alper";
            customer1.CustomerSurname = "Keskin";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Yasin";
            customer2.CustomerSurname = "Değirmenbaşı";
            Console.WriteLine("-----------------------Müşteriler-------------------");
            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer custumerAll in customers)
            {
                Console.WriteLine(custumerAll.CustomerId + " Müşteri Adı : " + custumerAll.CustomerName + " Müşteri Soyadı : " + custumerAll.CustomerSurname);
            }
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("-----------------------Eklenecek Müşteri------------------------");
            customerManager.Add(customer2);
            Console.WriteLine("-----------------------Müşteri Listesi---------------------");
            customerManager.List(customer1);
            customerManager.List(customer2);
            Console.WriteLine("-----------------------Silinecek Müşteri-----------------------");
            customerManager.Delete(customer1);
        }
    }
}
