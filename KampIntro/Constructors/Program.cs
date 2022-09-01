using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer1 = new Customer { Id=1,FirstName="Eyup",LastName="Ozturk",City="Antalya"};

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Mesut"; 

            Customer customer2 = new Customer(2, "Ahmet", "Arslan", "Afyon");
        }

        class Customer
        {
            public Customer()
            {

            }
            //default constructor
            public Customer(int id,string fistName,string lastName,string city)
            {
                Id = id;
                FirstName = fistName;
                LastName = lastName;
                City = city;
                Console.WriteLine("Yapıcı Blok Çalıştı (Constructor)");
            }

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}