using System.Xml.Linq;

namespace FunctionAssigmentV1
{
    internal class Program
    {
        static string KysyNimi()
        {
            while (true)
            {
                Console.Write("KysyNimi: ");
                 string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();
                else
                    Console.WriteLine("Name cannot be empty.");
            }
        }

        static int KysyIka()
        {
            while (true)
            {
                Console.Write("KysyIka: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("Please enter a positive integer.");
            }
        }

        static void tulostaNimijaIka(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        static bool TarkistaTaysiIkainen(int age)
        {
            return age >= 18;
        }

        static void VertaaNimea(string name, string compareName)
        {
            if (name.Equals(compareName,StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
        

        static void Main(string[] args)

        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this
            string name = KysyNimi();
            int age = KysyIka();

            tulostaNimijaIka(name, age);
            bool isFullAge = TarkistaTaysiIkainen(age);

            if (isFullAge)
            {
                Console.WriteLine("You Are an adult");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }   

            VertaaNimea(name, "Matti");






         }
       
        
        
        
           
        
        
        







    }
}