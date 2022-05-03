using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System_Problem
{
    internal class AddressBook
    {
        private List<Person> AddedPerson = new List<Person>();

        public void AddRecords(Person p)
        {
            AddedPerson.Add(p);
            Console.WriteLine("\nRecord successfully Added in Address Book");
        }

        public void DisplayRecords()
        {
            Console.WriteLine("\nThe Contact Details Available in Address Book are:\n");
            foreach (Person p in AddedPerson)
                Console.WriteLine(p.DisplaySavedRecords());
        }
    }
}
