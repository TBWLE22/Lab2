using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readncopy
{
    public class Readncopy
    {
        public string ReadFile (string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file '{filePath}': {ex.Message}");
                return null;
            }
        }

        public void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                string content = ReadFile(sourceFilePath);

                if (content != null)
                {
                    File.WriteAllText(destinationFilePath, content);
                    Console.WriteLine($"File '{sourceFilePath}' copied to '{destinationFilePath}' successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}
