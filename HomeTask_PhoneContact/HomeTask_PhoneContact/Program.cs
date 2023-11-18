


namespace PhoneBookApp
{
    class Program


    {
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        static void Main()
        {
            
            phoneBook.Add("Ali Aslanov", "070-758-59-60");
            phoneBook.Add("Elnur Ismayilov", "111-222-333");
            phoneBook.Add("Leman Memmedova", "555-444-333");
            phoneBook.Add("Bahruz Valiyev", "111-222-3333");
            phoneBook.Add("Yaqub Safarli", "444-555-6666");

            while (true)
            {
                Console.WriteLine("Phone Book Application");
                Console.WriteLine("1. Save Phone Number");
                Console.WriteLine("2. Delete Phone Number");
                Console.WriteLine("3. Update Phone Number");
                Console.WriteLine("4. Contacts Listing (A-Z)");
                Console.WriteLine("5. Contacts Listing (Z-A)");
                Console.WriteLine("6. Search in Contacts");
                Console.WriteLine("0. Exit");

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        SavePhoneNumber();
                        break;

                    case "2":
                        DeletePhoneNumber();
                        break;

                    case "3":
                        UpdatePhoneNumber();
                        break;

                    case "4":
                        ListContacts(true);
                        break;

                    case "5":
                        ListContacts(false);
                        break;

                    case "6":
                        SearchContacts();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void SavePhoneNumber()
        {
            Console.Write("Enter contact name: ");
            string name = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            phoneBook[name] = phoneNumber;

            Console.WriteLine("Contact saved successfully.");
        }

        static void DeletePhoneNumber()
        {
            Console.Write("Enter contact name to delete: ");
            string name = Console.ReadLine();

            if (phoneBook.ContainsKey(name))
            {
                phoneBook.Remove(name);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        static void UpdatePhoneNumber()
        {
            Console.Write("Enter contact name to update: ");
            string name = Console.ReadLine();

            if (phoneBook.ContainsKey(name))
            {
                Console.Write("Enter new phone number: ");
                string newPhoneNumber = Console.ReadLine();

                phoneBook[name] = newPhoneNumber;

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        static void ListContacts(bool ascendingOrder)
        {
            var sortedContacts = ascendingOrder
                ? phoneBook.OrderBy(x => x.Key)
                : phoneBook.OrderByDescending(x => x.Key);

            foreach (var contact in sortedContacts)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
        }

        static void SearchContacts()
        {
            Console.Write("Enter search term: ");
            string searchTerm = Console.ReadLine().ToLower();

            var searchResults = phoneBook
                .Where(x => x.Key.ToLower().Contains(searchTerm) || x.Value.Contains(searchTerm));

            foreach (var result in searchResults)
            {
                Console.WriteLine($"{result.Key}: {result.Value}");
            }
        }
    }

}
