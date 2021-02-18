using System;

namespace addressBook
{
    class Program
    {
        public static void Main()
        {
            AddressBook AddressBook = new AddressBook(50);

            Console.WriteLine("Address book options:\n" +
                                 "add - to add new entry.\n" +
                                 "search - to search entry.\n" +
                                 "quit - to leave.\n" +
                                 "clear - to clear screen\n" +
                                 "options - display instructions\n");
            while (true)
            {
                Console.Write("Option: ");
                string Instruction = Console.ReadLine();

                if (Instruction.ToLower() == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("GoodBye!");
                    break;
                }
                else if (Instruction.ToLower() == "add")
                {
                    Console.Clear();
                    AddressBook.NewEntry();
                }
                else if (Instruction.ToLower() == "search")
                {
                    Console.Clear();
                    AddressBook.SearchEntry();
                }
                else if (Instruction.ToLower() == "clear")
                {
                    Console.Clear();
                }
                else if (Instruction.ToLower() == "options")
                {
                    Console.Clear();
                    Console.WriteLine("Address book options:\n" +
                                 "add - to add new entry.\n" +
                                 "search - to search entry.\n" +
                                 "quit - to leave.\n" +
                                 "clear - to clear screen\n" +
                                 "options - display instructions\n");
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }
    }
}
Person.cs

using System;

namespace Treehouse
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string EmailAddress { get; set; }

        public string GetInfo()
        {
            string message = "First Name: {0}\nLast Name: {1}\nPhone Number: {2}\nHome Address: {3}\nEmail Address: {4}\n";
            return string.Format(message, FirstName, LastName, PhoneNumber, HomeAddress, EmailAddress);
        }
    }
}
AddressBookEntry.cs

using System;

namespace Treehouse
{
    class AddressBookEntry
    {
        private Person[] _entries;
        private int _totalEntries = 0;

        public int Size { get; private set; }

        public AddressBookEntry(int size)
        {
            _entries = new Person[size];
            Size = size;
        }

        public void NewEntry()
        {
            if (_totalEntries < _entries.Length)
            {
                Console.WriteLine("New Entry:");
                Person person = new Person()
                {
                    FirstName = InputValidator.LetterInput("First Name: ", "Input should only be letters please try again."),
                    LastName = InputValidator.LetterInput("Last Name: ", "Input should only be letters please try again."),
                    PhoneNumber = InputValidator.NumberInput("Phone Number: ", "Input should only be number please try again."),
                    HomeAddress = InputValidator.AnyInput("Home Address: "),
                    EmailAddress = InputValidator.AnyInput("Email Address: ")
                };

                _entries[_totalEntries++] = person;

                Console.WriteLine("Added successfuly!");
            }
            else
            {
                Console.WriteLine("Address Book is already full.");
            }
        }

        public void SearchEntry()
        {
            Console.Write("Type the number of the field you want to search\n" +
                              "[1] First Name \n[2] Last Name \n");
            string result = "No result found!";
            string Option;
            while (true)
            {
                Option = InputValidator.NumberInput("Option: ", "Input should only be number please try again.");
                if (Option == "1" || Option == "2")
                {
                    break;
                }
                Console.WriteLine("Invalid Input.");
            }

            if (_totalEntries == 0)
            {
                result = "Address Book is Empty.";
            }
            else
            {
                for (int i = 0; i < _totalEntries; i++)
                {
                    Person person = _entries[i];

                    if (Option == "1")
                    {
                        string search = InputValidator.LetterInput("First Name: ", "Input should only be letters please try again.");
                        if (person.FirstName.ToLower() == search.ToLower())
                        {
                            result = person.GetInfo();
                            break;
                        }
                    }
                    else if (Option == "2")
                    {
                        string search = InputValidator.LetterInput("Last Name: ", "Input should only be letters please try again.");
                        if (person.LastName.ToLower() == search.ToLower())
                        {
                            result = person.GetInfo();
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
InputValidator.cs

using System;
using System.Text.RegularExpressions;

namespace Treehouse
{
    static class InputValidator
    {
        public static string AnyInput(string label = "Input string: ",
                                  string errorMessage = "Input must only be letters.")
        {
            string input;
            Console.Write(label);
            input = Console.ReadLine();
            return input;
        }

        public static string LetterInput(string label = "Input string: ",
                                  string errorMessage = "Input must only be letters.")
        {
            string input;
            while (true)
            {
                Console.Write(label);
                input = Console.ReadLine();
                if (!(new Regex("[0-9]").IsMatch(input)))
                {
                    break;
                }
                Console.WriteLine(errorMessage);
            }
            return input;
        }

        public static string NumberInput(string label = "Input string: ",
                                  string errorMessage = "Input must only be numbers.")
        {
            string input;
            while (true)
            {
                Console.Write(label);
                input = Console.ReadLine();
                if (!(new Regex("[a-zA-Z]").IsMatch(input)))
                {
                    break;
                }
                Console.WriteLine(errorMessage);
            }
            return input;
        }
    }
}