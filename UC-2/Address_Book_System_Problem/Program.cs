using System;
namespace Address_Book_System_Problem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tutorial of address book includation part");

           AddressBook address= new AddressBook();

            Person person= new Person();
            person.AddingPerson();
            address.AddRecords(person);
            address.DisplayRecords();

        }
    }
}