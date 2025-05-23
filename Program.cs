// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Input
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many people do you want to add in the addressbook? ");
        string input_num_ppl = Console.ReadLine();
        int num_ppl = Convert.ToInt32(input_num_ppl);
        Dictionary<string, string> addressbook = new Dictionary<string, string>();

        for (int i = 0; i < num_ppl; i++)
        {
            Console.WriteLine("Type name of the person: ");
            string input_name = Console.ReadLine();
            Console.WriteLine("Type telephone number of the person: ");
            string input_phonenumber = Console.ReadLine();

            addressbook.Add(input_name, input_phonenumber);
        }
        Console.WriteLine("Finished adding people to the addressbook.");

        // Show the addressbook
        Console.WriteLine("\nAddressbook:");
        int j = 0;
        foreach (string name in addressbook.Keys)
        {
            Console.WriteLine($"Person{j + 1} {name} : {addressbook[name]}");
            j++;
        }

        AddressFinder finder = new AddressFinder(addressbook);
        while (true)
        {
            Console.WriteLine("\nDo you want to search for a person's phone number? (yes/no)");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "yes")
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter the name of the person: ");
                string searchName = Console.ReadLine();
                string phoneNumber = finder.FindPhonenumber(searchName);
                Console.WriteLine($"Phone number of {searchName} is: {phoneNumber}");
            }
        }
        Console.WriteLine("Exiting the search.");
        }
}