using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri customer1 = new musteri();
            customer1.musteriId = 1001122001;
            customer1.musteriName = "serdar";
            customer1.musteriSurname = "demir";
            customer1.musteriCreditPoint = 1435;
            customer1.musteriBalance = 2204000;

            musteri customer2 = new musteri();
            customer2.musteriId = 1001100222;
            customer2.musteriName = "ali";
            customer2.musteriSurname = "yılmaz";
            customer2.musteriCreditPoint = 1735;
            customer2.musteriBalance = 350040;

            musteri customer3 = new musteri();
            customer3.musteriId = 102011003;
            customer3.musteriName = "emre";
            customer3.musteriSurname = "oktay";
            customer3.musteriCreditPoint = 1435;
            customer3.musteriBalance = 13040;

            MusteriManager customerManager = new MusteriManager() ;
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);



            musteri[] customers = new musteri[] { customer1, customer2, customer3 };

            customerManager.List(customers);
        }
    }
}
