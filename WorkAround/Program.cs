using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();

            List<string> sehirler = new List<string> { "Ankara", "İstanbul", "İzmir" };
            sehirler.Add("Isparta");

            foreach (string sehir in sehirler)
            {
                //Console.WriteLine(sehir);
            }
            Person person1 = new Person();
            person1.FirstName = "SAMİ";
            person1.LastName = "KÖSE";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 37018039180;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.giveMask(person1);

        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }


    }

    

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
