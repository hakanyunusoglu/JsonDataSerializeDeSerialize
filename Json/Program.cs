using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Personel> perList = new List<Personel>();
            //int sayac = 1;
            for(int i = 1; i<=100;i++)
            { 
            Personel p = new Personel();
            p.ID = Guid.NewGuid();
            p.Name = FakeData.NameData.GetFirstName();
            p.Surname = FakeData.NameData.GetSurname();
            p.Email = String.Concat((p.Name+"."+p.Surname).ToLower() +"@"+ FakeData.NetworkData.GetDomain());
            p.City = FakeData.PlaceData.GetCity();
            p.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
            perList.Add(p);
            }

            Console.WriteLine("Bilgileriniz JSON formatında C:\\JsonIslemleri\\Personeller.json olarak kayıt edilecektir.");
            if(Directory.Exists("C:\\JsonIslemleri\\Personeller.json"))
            {

            }
            else
            {
                Directory.CreateDirectory("C:\\JsonIslemleri\\");
            }
            string jsonPersoneller = Newtonsoft.Json.JsonConvert.SerializeObject(perList);
            File.WriteAllText("C:\\JsonIslemleri\\Personeller.json", jsonPersoneller);
            Console.WriteLine("JSON Export işlemi tamamlandır!");

            //foreach(var item in perList)
            //{
                
            //    Console.WriteLine($"---- {sayac}. Kayıt----");
            //    Console.WriteLine(item.ID);
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Surname);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.PhoneNumber);
            //    Console.WriteLine(item.City);
            //    Console.WriteLine();
            //    sayac++;
            //}
            Console.ReadLine();
        }
    }
}
