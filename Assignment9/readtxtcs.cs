using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class readtxt
    {
        static void Main(string[] args)
        {
           
            bool ans = File.Exists(@"C:\Users\chand\OneDrive\Desktop\dotnet\person.txt");
            if (ans == true)
            {
                try
                {
                    FileStream fs = new FileStream(@"C:\Users\chand\OneDrive\Desktop\dotnet\person.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reading = null;
                    try
                    {
                        reading = new StreamReader(fs);
                        string readme = reading.ReadToEnd();
                        Console.WriteLine(readme);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        fs.Close();
                        fs.Dispose();
                        reading.Close();
                        reading.Dispose();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                Console.WriteLine("File does'nt exist on the given location");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
       
    }
}
