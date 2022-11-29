//
using System.Collections.Generic;

namespace Day_35_LINQ_AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            LINQ_AddressBook contactdetails = new LINQ_AddressBook();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)Adding Contact \n2)Display contact\n3)Editing Contact\n4)Delete Contact" +
                    "\n5)Search Contact by city\n6)Search Contact by state\n7)count size of AddressBook\n8)Sort person name alphabetically by city" +
                    "\n9) Add multiple contacts\n10) Add contacts by type and name\n11) Get number of contacts by type");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        contactdetails.AddNewContacts();
                        break;
                    case 2:
                        contactdetails.Display();
                        break;
                    case 3:
                        contactdetails.EditContact();
                        break;
                    case 4:
                        contactdetails.DeleteContact();
                        break;
                    case 5:
                        contactdetails.SearchContactByCity();
                        break;
                    case 6:
                        contactdetails.SearchContactByState();
                        break;
                    case 7:
                        contactdetails.SizeOfAddressBook();
                        break;
                    case 8:
                        contactdetails.SortPersonsNameByCity();
                        break;
                    case 9:
                        Console.WriteLine("How many contacts you want to add?");
                        int n = Convert.ToInt32(Console.ReadLine());
                        contactdetails.AddMultipleContact(n);
                        break;
                    case 10:
                        Console.WriteLine("How many contacts you want to add?");
                        int num = Convert.ToInt32(Console.ReadLine());
                        contactdetails.AddContactbyType(num);
                        break;
                    //case 11:
                    //    contactdetails.NumberOfContactPersonCountByType();
                    //    break;

                    default:
                        Console.WriteLine("Please Choose From Above Given Options");
                        break;
                }
            }

        }
    
    }
}

//List<AddressBook> addressBooks = new List<AddressBook>()
//{
//    new AddressBook(){ FirstName = "Mahesh", LastName = "G", Address = "9b Nagar", City = "Mumbai", State = "Maharashtra", Zip = 425009, PhoneNumber = "9812345678", Email = "gaga@gamil.com" },
//    new AddressBook(){ FirstName = "Ganesh", LastName = "B", Address = "10b Nagar", City = "Nashik", State = "Maharashtra", Zip = 425005, PhoneNumber = "9855555555", Email = "gaga1@gamil.com" },
//    new AddressBook(){ FirstName = "Aksahy", LastName = "T", Address = "99b Nagar", City = "Pune", State = "Maharashtra", Zip = 425003, PhoneNumber = "9888888888", Email = "gaga2@gamil.com" },
//    new AddressBook(){ FirstName = "Radha", LastName = "H", Address = "55b Nagar", City = "Indore", State = "M.P", Zip = 425010, PhoneNumber = "9877777777", Email = "gaga23@gamil.com" },
//};

//LINQ_AddressBook lINQ_AddressBook = new LINQ_AddressBook();