using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_35_LINQ_AddressBook
{
    public class LINQ_AddressBook
    {
        static List<AddressBook> addressbook = new List<AddressBook>();

        public void AddNewContacts()
        {
            AddressBook contact = new AddressBook();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter your First name-");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name-");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address-");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your City-");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State-");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode-");
            contact.Zip = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your PhoneNumber-");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Email-");
            contact.Email = Console.ReadLine();

            addressbook.Add(contact);


        }
        public void Display()
        {
            foreach (var data in addressbook)
            {
                Console.WriteLine("The Details that you have added are -");
                Console.WriteLine("First Name: " + data.FirstName);
                Console.WriteLine("Last Name: " + data.LastName);
                Console.WriteLine("Enter Address: " + data.Address);
                Console.WriteLine("City: " + data.City);
                Console.WriteLine("State: " + data.State);
                Console.WriteLine("Zip: " + data.Zip);
                Console.WriteLine("Phone Number: " + data.PhoneNumber);
                Console.WriteLine("Email: " + data.Email);
            }
            Console.WriteLine("Details added successfully");

        }
        public void EditContact()
        {
            Console.WriteLine("__________________________");
            Console.WriteLine("For editing a contact enter first name : ");
            string Name = Console.ReadLine();

            var result = addressbook.FirstOrDefault(x => x.FirstName == Name);
            if (result == null)
            {
                Console.WriteLine("No such contact exists");
                return;
            }
            Console.WriteLine("Edit a contact\n1. Last Name\n2. Address\n3. City\n4. State\n5. ZipCode\n6. Phone Number\n7. Email Address");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter your new Last name");
                    string lastname = Console.ReadLine();
                    result.LastName = lastname;
                    break;
                case 2:
                    Console.WriteLine("Enter your new Address");
                    string address = Console.ReadLine();
                    result.Address = address;
                    break;
                case 3:

                    Console.WriteLine("Enter your new city");
                    string newcity = Console.ReadLine();
                    result.City = newcity;
                    break;
                case 4:
                    Console.WriteLine("Enter your new State");
                    string state = Console.ReadLine();
                    result.State = state;
                    break;
                case 5:
                    Console.WriteLine("Enter your new Zipcode");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    result.Zip = zipcode;
                    break;
                case 6:
                    Console.WriteLine("Enter your new PhoneNumber");
                    string phonenumber = Console.ReadLine();
                    result.PhoneNumber = phonenumber;
                    break;
                case 7:
                    Console.WriteLine("Enter your new Email");
                    string email = Console.ReadLine();
                    result.Email = email;
                    break;


            }

        }

        public void DeleteContact()
        {

            Console.WriteLine("__________________________");
            Console.WriteLine("Enter the First Name that you want to delete : ");
            string FirstName = Console.ReadLine();

            var result = addressbook.FirstOrDefault(x => x.FirstName == FirstName);
            if (result == null)
            {
                Console.WriteLine("No such contact exists");
                return;
            }

            addressbook.Remove(result);
            Console.WriteLine("Contact deleted successfully");
        }
        public void SearchContactByCity()
        {

            Console.WriteLine("__________________________");
            Console.WriteLine("Enter the City : ");
            string city = Console.ReadLine();

            var result = addressbook.FindAll(x => x.City == city);
            if (result.Count == 0)
            {
                Console.WriteLine("No such contact exists");
                return;
            }
            foreach (var List in addressbook)
            {
                Console.WriteLine("Following contacts are available belongs to " + List.City);
                Console.WriteLine("FirstName " + List.FirstName);
                Console.WriteLine("LastName " + List.FirstName);
                Console.WriteLine("Address " + List.Address);
                Console.WriteLine("State " + List.State);
                Console.WriteLine("PhoneNumber " + List.PhoneNumber);
                Console.WriteLine("Email " + List.Email);
            }
        }
        public void SearchContactByState()
        {

            Console.WriteLine("__________________________");
            Console.WriteLine("Enter the State : ");
            string state = Console.ReadLine();

            var result = addressbook.FindAll(x => x.State == state);
            if (result.Count == 0)
            {
                Console.WriteLine("No such contact exists");
                return;
            }
            foreach (var List in addressbook)
            {
                Console.WriteLine("Following contacts are available belongs to " + List.State);
                Console.WriteLine("FirstName " + List.FirstName);
                Console.WriteLine("LastName " + List.LastName);
                Console.WriteLine("Address " + List.Address);
                Console.WriteLine("City " + List.City);
                Console.WriteLine("PhoneNumber " + List.PhoneNumber);
                Console.WriteLine("Email " + List.Email);
            }

        }
        public void SizeOfAddressBook()
        {
            if (addressbook.Count == 0)
            {
                Console.WriteLine("Address Book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Address Book Size is : " + addressbook.Count);
            }


        }
        public void SortPersonsNameByCity()
        {
            Console.WriteLine("Please enter the city name: ");
            string city = Console.ReadLine();
            var result = addressbook.FindAll(x => (x.City == city)).OrderBy(x => x.FirstName);
            Console.WriteLine("All the enteries in AddressBook Sorted Alphabetically :");
            foreach (var list in result)
                Console.WriteLine("\nPerson Name : " + list.FirstName +
                                    "\tCity : " + list.City);

        }
        public void AddMultipleContact(int n)
        {
            while (n > 0)
            {
                AddNewContacts();

                n--;
            }
        }
        //creating method for adding multiple contacts to addressbook by type and name
        public void AddContactbyType(int n)
        {
            while (n > 0)
            {
                AddNewContactByNameAndType();

                n--;
            }
        }
        // /Creating the method for Adding new contact - Add Person to Both Family and Friend
        public void AddNewContactByNameAndType()
        {

            AddressBook contact = new AddressBook();
            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip Code: ");
            contact.Zip = int.Parse(Console.ReadLine());

            Console.Write("Enter Mobile Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter E-Mail: ");
            contact.Email = Console.ReadLine();

            //Console.Write("Enter AddressBook Name: ");
            //contact.AddressBookName = Console.ReadLine();

            //Console.Write("Enter AddressBook Type: ");
            //contact.AddressBookType = Console.ReadLine();



            Console.WriteLine("-------------------");

            addressbook.Add(contact);
        }
        //public void NumberOfContactPersonCountByType()
        //{
        //    Console.WriteLine("Number of Contact persons count by Addresstype: ");
        //    var type = addressbook.GroupBy(x => x.AddressBookType).Select(y => new { AddressBookType = y.Key, count = y.Count() });
        //    foreach (var contact in type)
        //    {
        //        Console.WriteLine("\nAddressBook Type :" + contact.AddressBookType +
        //                            "\n Count : " + contact.count);
        //    }
        //}

    }
}
