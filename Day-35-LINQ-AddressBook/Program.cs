
namespace Day_35_LINQ_AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<AddressBook> addressBooks = new List<AddressBook>()
            {
                new AddressBook(){ FirstName = "Mahesh", LastName = "G", Address = "9b Nagar", City = "Mumbai", State = "Maharashtra", Zip = 425009, PhoneNumber = "9812345678", Email = "gaga@gamil.com" },
                new AddressBook(){ FirstName = "Ganesh", LastName = "B", Address = "10b Nagar", City = "Nashik", State = "Maharashtra", Zip = 425005, PhoneNumber = "9855555555", Email = "gaga1@gamil.com" },
                new AddressBook(){ FirstName = "Aksahy", LastName = "T", Address = "99b Nagar", City = "Pune", State = "Maharashtra", Zip = 425003, PhoneNumber = "9888888888", Email = "gaga2@gamil.com" },
                new AddressBook(){ FirstName = "Radha", LastName = "H", Address = "55b Nagar", City = "Indore", State = "M.P", Zip = 425010, PhoneNumber = "9877777777", Email = "gaga23@gamil.com" },
            };
        }
    }
}