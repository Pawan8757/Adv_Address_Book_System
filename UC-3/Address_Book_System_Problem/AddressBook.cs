﻿using System;
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
            if (this.CheckEmpty())
                return;

            Console.WriteLine("\nThe Contact Details Available in Address Book are:\n");
            foreach (Person p in AddedPerson)
                Console.WriteLine(p.DisplaySavedRecords());
        }

        public void EditRecords(string firstName, string lastName)
        {
            if (this.CheckEmpty())
                return;

            foreach (var person in AddedPerson)
            {
                if (firstName == person.FirstName && lastName == person.LastName)
                {
                    string option;
                    do
                    {
                        Console.WriteLine("\nChoose field you want to update : ");
                        Console.WriteLine("1.First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Email\n" +
                            "7.Zip Code\n8.PhoneNumber");
                        Console.Write("Enter your Choice: ");
                        int choice = Convert.ToInt32(Console.ReadLine()); // Store the user choice which want to update 
                        switch (choice)
                        {
                            case 1:
                                Console.Write("\nEnter new first name : ");
                                string newFirstName = Console.ReadLine();
                                person.FirstName = newFirstName; // Update the first name of record in address book
                                Console.WriteLine("\nFirst Name Updated Successfully");
                                break;
                            case 2:
                                Console.Write("\nEnter new last name: ");
                                string newLastName = Console.ReadLine();
                                person.LastName = newLastName; // Update the last name of record in address book
                                Console.WriteLine("\nLast Name Updated Successfully");
                                break;
                            case 3:
                                Console.Write("\nEnter new address: ");
                                string newAddress = Console.ReadLine();
                                person.Address = newAddress; // Update the address of record in address book
                                Console.WriteLine("\nAddress Updated Successfully");
                                break;
                            case 4:
                                Console.WriteLine("\nEnter new city name: ");
                                string newCity = Console.ReadLine();
                                person.City = newCity; // Update the city name of record in address book
                                Console.WriteLine("\nCity Name Updated Successfully");
                                break;
                            case 5:
                                Console.WriteLine("\nEnter new state : ");
                                string newState = Console.ReadLine();
                                person.State = newState; // Update the state name of record in address book
                                Console.WriteLine("\nState Name Updated Successfully");
                                break;
                            case 6:
                                Console.WriteLine("\nEnter new email : ");
                                string newEmail = Console.ReadLine();
                                person.EmailId = newEmail; // Update the email name of record in address book
                                Console.WriteLine("\nEmail Updated Successfully");
                                break;
                            case 7:
                                Console.WriteLine("\nEnter new Zip Code : ");
                                int newZip = Convert.ToInt32(Console.ReadLine());
                                person.ZipCode = newZip; // Update the zipcode of record in address book
                                Console.WriteLine("\nZip Code Updated Successfully");
                                break;
                            case 8:
                                Console.WriteLine("\nEnter new Phone Number : ");
                                long newPhone = long.Parse(Console.ReadLine());
                                person.PhoneNumber = newPhone; // Update the phone number of record in address book
                                Console.WriteLine("\nPhone Number Updated Successfully");
                                break;
                            default:
                                Console.WriteLine("\nInvalid Choice Entered.");
                                break;
                        }
                        Console.WriteLine("\nPress 'u' to update new fields.");
                        Console.WriteLine("Press 'r' to return to the User Menu");
                        Console.Write("Enter Choice: ");
                        option = Console.ReadLine();
                    }
                    while (option != "r");

                    return;
                }
            }
            Console.WriteLine("\nYour entered details does not match with any records");
        }

        public bool CheckEmpty()
        {
            if (AddedPerson.Count == 0)
            {
                Console.WriteLine("\nThe Address Book is empty");
                return true;
            }
            return false;
        }
    }
}
    
