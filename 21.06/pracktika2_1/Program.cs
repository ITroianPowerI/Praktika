using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\file.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
