using System;
namespace Address_Book_System_Problem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tutorial of address book includation part");
            

            AddressBook address = new AddressBook();
            Person person = new();

            string input;
            do
            {
                UserMenu();
                input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                        Console.WriteLine("\nEnter Details to Add New Contact-");
                        person.AddingPerson();
                        address.AddRecords(person);
                        break;
                    case "E":
                        Console.WriteLine("\nEnter Name of the person to edit-");
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        address.EditRecords(firstName, lastName);
                        break;
                    case "D":
                        Console.WriteLine("\nEnter Name of the person to delete-");
                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        lastName = Console.ReadLine();
                        address.DeleteRecords(firstName, lastName);
                        break;
                    case "P":
                        address.DisplayRecords();
                        break;
                    case "X":
                        Console.WriteLine("\nProgram Exited Successfully.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input.");
                        break;
                }
            }
            while (input != "X");

        }

        public static void UserMenu()
        {
            Console.WriteLine("\n--------User Menu--------");
            Console.WriteLine("Enter 'A' to add new contact.");
            Console.WriteLine("Enter 'E' to edit existing contact.");
            Console.WriteLine("Enter 'D' to delete the existing contact");
            Console.WriteLine("Enter 'P' to display all address book contacts");
            Console.WriteLine("Enter 'X' to exit.");
            Console.Write("Input: ");
        }
    }
}
