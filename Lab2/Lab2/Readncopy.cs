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
        public static string Readfile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    Console.WriteLine("File not found. Creating new file.");
                    File.WriteAllText(filePath, "Hello and Welcome\r\nIt is the first content \r\nof the text file from first file\r\n");
                    return null;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error reading file: " + ex.Message);
                return null;
            }
        }
        public static void CopyFile( string content, string newDestination)
        {
            try
            {
                if (content != null)
                {
                    File.WriteAllText(newDestination, content);
                    Console.WriteLine("File Copied");
                }
                else
                {
                    Console.WriteLine("Content is null. Cannot copy.");
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("Error copying file:" + e.Message);
            }
        }
    }
}
