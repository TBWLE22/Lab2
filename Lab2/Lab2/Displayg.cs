using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispg
{
    public class Displayg
    {
        public static void Displaytheg(string filePath) 
        {
            try
            {
                string[] words = File.ReadAllText(filePath).Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("Words ending with 'g':");
                foreach (string word in words)
                {
                    if (word.EndsWith("g", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured: {e.Message}");
            }
        }
    }
}
