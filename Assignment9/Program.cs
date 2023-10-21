﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    
        internal class Program
        {
            static void Main(string[] args)
            {

                CreateAndWriteTXTFile();

                OpenAndReadTXTFile();

                Console.Read();


            }



            private static void OpenAndReadTXTFile()
            {
                //checking file is in the given location or NOT if not it goes to else block
                bool ans = File.Exists(@"C:\Users\chand\OneDrive\Desktop\dotnet\Studentdata.txt");
                if (ans == true)
                {
                    //this try catch block used to if there any exceptions catch block executed otherwise try executed
                    try
                    {
                        //this command used to open the file and read it ... 
                        FileStream fs = new FileStream(@"C:\Users\chand\OneDrive\Desktop\dotnet\Studentdata.txt", FileMode.Open, FileAccess.Read);
                        StreamReader reading = null;
                        //this try catch block used to if there any exceptions catch block executed otherwise try executed
                        try
                        {
                            //Retrieve the data from the file to readme string ..and print it in console..
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
                }
            }

            private static void CreateAndWriteTXTFile()
            {
                //creating a txt file by giving location
                FileStream fs = new FileStream(@"C:\Users\chand\OneDrive\Desktop\dotnet\Studentdata.txt", FileMode.Create, FileAccess.Write);
                //creating a obj for writing
                StreamWriter writing = new StreamWriter(fs);
                //lets assign text to fieds with object
                try
                {
                    writing.WriteLine("Student Details :");
                    writing.WriteLine("Student Id : 101");
                    writing.WriteLine("Student Name : john");
                    writing.WriteLine("Student enrolled courses : C# , JAVA ");
                    writing.WriteLine("Marks On regarded courses : C# - 91/100 , Java - 90/100");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //flush means the buffer data if anything is remaining will be written to the file
                    writing.Flush();
                    //close and save
                    writing.Close();
                    writing.Dispose();
                    fs.Close();
                    fs.Dispose();
                }
            }
        }
    }

    


