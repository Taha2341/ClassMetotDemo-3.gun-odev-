using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        private IEnumerable<object> musteri;

        public void Add(musteri customer)
        {
            Console.WriteLine("Müşteri İD " + customer.musteriId + " ---Müşteri adı:" + customer.musteriName + " ---Müşteri soyadı: " + customer.musteriSurname + " ---Müşteri kredi puanı: " + customer.musteriCreditPoint +""+ customer.musteriBalance + " <Müşteri Ekleme  Başarılı.>");
        }



        public void Delete(musteri customer)
        {
            Console.WriteLine("Müşteri İD "+customer.musteriId + " ---Müşteri adı :" + customer.musteriName + " ---Müşteri soyadı:" + customer.musteriSurname + " ---Müşteri kredi puanı: " + customer.musteriCreditPoint + ""+  customer.musteriBalance +  " <Müşteri Silme  Başarılı.>");
        }

        public void List(musteri[] customers)
        {
            foreach (musteri customer in customers)
            {
                Console.WriteLine(customer.musteriId + " - " + customer.musteriName + " " + customer.musteriSurname + " " + customer.musteriCreditPoint + " " + customer.musteriBalance);
            }
        }
    }
}
