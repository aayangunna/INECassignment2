// A program that to help prevent multiple registration
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace INECassignment
{
    //Using Main method
    internal class InecDataBase
    {
        static void Main(string[] args)
        {
            string[] RegVoters = { "Messi", "Neymar", "Mbappe", "Ronaldo", "Ronaldo", "Messi", "Messi", "Neymar", "Pedri", "Neymar", "Pedri", "Lewandoski", "Mane", "Sallah", "Mason", "Kante", "Peter" };
            Dictionary<string, int> Database = new Dictionary<string, int>();
            foreach (var item in RegVoters)
            {
                if (Database.ContainsKey(item))
                {
                    Database[item] = Database[item] + 1;
                }
                else
                {
                    Database[item] = 1;
                }
            }
            // Displaying the Names of registered voters with mutiple registration 
            Console.WriteLine("Names and number of times registered");
            foreach (var item in Database)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key + ":" + item.Value);
                }
            }

            // Displaying the Names of all registered voters
            Console.WriteLine("\n\nThe Distinctive List");
            HashSet<string> Distinctive = RegVoters.ToHashSet();
            foreach (var item in Distinctive)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}







