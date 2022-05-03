using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System_Problem
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;
        public long PhoneNumber;
        public string EmailId;

        public void AddingPerson()
        {
            Console.WriteLine("Enter First-Name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last-Name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            City = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            State = Console.ReadLine();
            Console.WriteLine("Enter Zip-Code: ");
            ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ContactNumber: ");
            PhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email-Id: ");
            EmailId = Console.ReadLine();
        }
        public  string DisplaySavedRecords()
        {
            return "\nFirst Name: " + FirstName + "\nLast Name:  " + LastName + "\nAddress: " + Address + "\nCity: " + City
                + "\nState: " + State + "\nZip-Code: " + ZipCode + "\nPhone: " + PhoneNumber + "\nEmail-Id: " + EmailId ;
        }
    }
    }
