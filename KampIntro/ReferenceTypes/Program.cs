using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Eyüp";
            person2=person1;

            person1.FirstName = "Buğra";

            Console.WriteLine(person2.FirstName);

            
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "2123123";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();

            personManager.Add(employee);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class : Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}