using System;

namespace L7homework
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook = new();
            using (StreamReader sr = new("../../.././Phones/Phones.TXT", System.Text.Encoding.Default)) 
            {
                string? phoneNumber;
                while ((phoneNumber = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(phoneNumber);
                    Console.WriteLine("Whose number is it?(No identical names are allowed)");
                    string? name;
                    do
                    {
                        name = Console.ReadLine();
                    }while (name == null || phoneBook.ContainsKey(name));

                    phoneBook.Add(name, phoneNumber);
                    using StreamWriter sw = new("../../.././Phones/New.TXT", true, System.Text.Encoding.Default);
                    sw.WriteLine("+3" + phoneNumber);
                }
            }
            Console.WriteLine("Whose number do you want to find?");
            string? nameToFind;
            do
            {
                nameToFind = Console.ReadLine();
            }while (nameToFind == null);
            if (phoneBook.ContainsKey(nameToFind))
            {
                Console.WriteLine($"{phoneBook[nameToFind]}");
            }
            else { Console.WriteLine($"Seems like there isn't anyone named {nameToFind} in phonebook"); }

        }
    }
}
