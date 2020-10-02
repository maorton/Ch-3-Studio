using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch_3_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";*/
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            Dictionary<char, int> characters = new Dictionary<char, int>();
            
            foreach(char letter in text)
            {
                char lower = char.ToLower(letter);
                int count;

                if (Char.IsLetter(lower))
                {
                    characters.TryGetValue(lower, out count);
                    characters[char.ToLower(lower)] = count + 1;
                }
            }

            foreach(KeyValuePair<char, int> character in characters)
            {
                Console.WriteLine(character.Key + ": " + character.Value);
            }
        }
    }
}
