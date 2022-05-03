using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the problem of collection using lambda");
            Console.WriteLine();
            List<Person> listPerson = new List<Person>();
            AddRecords(listPerson);

            //FindThePersonByName(listPerson);
            //FindThePersonByAddress(listPerson);
           //CheckPersonByCity(listPerson);
            CheckPhoneNumberPersonPresentOrNot(listPerson);

        }
        private static void AddRecords(List<Person> listPerson)
        {
            listPerson.Add(new Person("6932587473", "Joy", "Gangnapur,nadia","rafiganj","Bihar","824125","Pae@gmail.com"));
            listPerson.Add(new Person("8745548596", "Souvik", "Gangr,nadia", "raniganj", "Bihar", "824122", "Pae@gmail.com"));
            listPerson.Add(new Person("8747845779", "Anu", "Gopinaur,nadia", "aurangabad", "Assam", "824555", "Pae@gmail.com"));
            listPerson.Add(new Person("8745848528", "Avik", "Linpapur,nadia", "arwal", "UP", "888125", "Pae@gmail.com"));
            listPerson.Add(new Person("8746547423", "Antor", "Santinapur,nadia", "siwan", "Mp", "821125", "Pae@gmail.com"));
            listPerson.Add(new Person("8745048357", "jeet", "Mompur,nadia", "rafiganj", "manipur", "824655", "Pae@gmail.com"));
            listPerson.Add(new Person("8745703570", "Moni", "Kannapur,nadia", "sitamarhi", "uttrakhand", "878125", "Pae@gmail.com"));
            listPerson.Add(new Person("6296582055", "Puja", "RajaRHut,nadia", "asansol", "maharastra", "824745", "Pae@gmail.com"));

        }
        //UC-7
        private static void FindThePersonByName(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.Name == "Anu"))
            {
                Console.WriteLine("Phone Number :" + person.PhoneNo + " Name :" + person.Name );
            }
        }

        //UC-8
        private static void FindThePersonByAddress(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.Address == "Gangnapur,nadia"))
            {
                Console.WriteLine("Phone Number :" + person.PhoneNo + " Name :" + person.Name );
            }
        }

       
        //UC-9
        private static void CheckPersonByCity(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.City == "arwal"))
            {
                Console.WriteLine(" Name :" + person.Name);
            }
            
        }


        //UC-10
        private static void CheckPhoneNumberPersonPresentOrNot(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => e.PhoneNo == "6296582055"))
            {
                Console.WriteLine("Name :" + person.Name  + "Address :" + person.Address);
            }
        }
    }
    }

