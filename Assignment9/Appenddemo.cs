using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment9
{
    internal class Appenddemo
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\\Users\\chand\\OneDrive\\Desktop\\dotnet\\person.txt";
            using (StreamWriter writer = File.AppendText(Filepath))
            {
                string textToAppend = "hi";
                writer.WriteLine(textToAppend);
            }
            Console.ReadLine();
        }
    }
}
