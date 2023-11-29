using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactList
{
    public class Methods : Contact
    {
        public int input;
        public List<Contact> ListOfContacts = new List<Contact>();


        public void InputOption()
        {
            if (!Int32.TryParse(Console.ReadLine(), out input) || input > 4 || input < 0)
            {
                Console.WriteLine("Error, Please input valid option");
                InputOption();
            }
            ChooseOption();
        }

        public void ShowMenu()
        {
            Console.WriteLine("Please Choose an Option:");
            Console.WriteLine("1.Add Contact");
            Console.WriteLine("2.View All Contacts");
            Console.WriteLine("3.Search Conatcts");
            Console.WriteLine("4.Exit\n");
            InputOption();
        }

        public bool EmailIsValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        public Contact AddContact()
        {
            Contact newContact = new Contact();

            Console.Write("Enter Contacts Name: ");
            newContact.Name = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(newContact.Name))
            {
                Console.WriteLine("Name is Empty. Try Again. ");
                Console.Write("Enter Contacts Name: ");
                newContact.Name = Console.ReadLine().Trim();
            }

            Console.Write("Enter Contacts Number: ");
            newContact.PhoneNumber = Console.ReadLine();

            while (string.IsNullOrEmpty(newContact.PhoneNumber) || newContact.PhoneNumber.Length != 9)
            {
                Console.WriteLine("Phone Number is incorrect. Try Again.");
                Console.Write("Enter Contacts Number: ");
                newContact.PhoneNumber = Console.ReadLine();
            }

            Console.Write("Enter Contacts Email: ");
            newContact.Email = Console.ReadLine().Trim();

            while (!EmailIsValid(newContact.Email))
            {
                Console.WriteLine("Email is not valid. Try Again.");
                Console.Write("Enter Contacts Email: ");
                newContact.Email = Console.ReadLine().Trim();
            }

            ListOfContacts.Add(newContact);

            return newContact;
        }
        void AddNameToContact()
        {
            Console.Write("Enter Contacts Name: ");
            Name = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Name is Empty. Try Again. ");
                Console.Write("Enter Contacts Name: ");
                Name = Console.ReadLine().Trim();
            }
        }

        public void ViewAllContacts()
        {
            foreach (Contact contact in ListOfContacts)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}, Email: {contact.Email}");
            }
        }

        public void SearchContact()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error, Try Again:");
                name = Console.ReadLine();
            }

            Console.WriteLine("\n Searching... \n");

            for (int i = 0; i < ListOfContacts.Count; i++)
            {
                if (name == ListOfContacts[i].Name)
                {
                    Console.WriteLine($"Name: {ListOfContacts[i].Name}, Phone Number: {ListOfContacts[i].PhoneNumber}, Email: {ListOfContacts[i].Email} ");
                }
            }
        }

        public void ChooseOption()
        {
            if (input == 1)
            {
                AddContact();
            }
            else if (input == 2)
            {
                ViewAllContacts();
            }
            else if (input == 3)
            {
                SearchContact();
            }
        }
    }
}
