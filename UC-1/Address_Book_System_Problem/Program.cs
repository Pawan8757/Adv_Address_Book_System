using System;
namespace Address_Book_System_Problem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tutorial of address book includation part");

            Person person = new Person();
            person.AddingPerson();
            Console.WriteLine("\n------------Here is the detailed form of person----------- ");

            Console.WriteLine("Person's Detail=" + person.DisplaySavedRecords());

        }
    }
}