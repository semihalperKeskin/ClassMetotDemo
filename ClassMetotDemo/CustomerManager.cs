using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer musteri)
        {
            Console.WriteLine(musteri.CustomerId + "." + "Müşteri Adı : " + musteri.CustomerName + " " + "Müşteri Soyadı : " + musteri.CustomerSurname);
        }
        public void List(Customer liste)
        {
            Console.WriteLine(liste.CustomerId + " " + "Müşteri Adı : " + liste.CustomerName + " " + "Müşteri Soyadı : " + liste.CustomerSurname);
        }
        public void Delete(Customer sil)
        {
            Console.WriteLine(sil.CustomerId + "." + "Müşteri Adı : " + sil.CustomerName + " " + "Müşteri Soyadı : " + sil.CustomerSurname);
        }
    }
}
