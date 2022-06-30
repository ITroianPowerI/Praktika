using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika2_test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool c = true;
                StreamWriter sw = new StreamWriter(@"C:\Users\user\Desktop\file.txt");
                Console.WriteLine("Введите данные для записи в файл:");
                while (c)
                {
                    sw.WriteLine(Console.ReadLine());
                    Console.WriteLine("Продолжить? (y/n)");
                    string s = Console.ReadLine();
                    if (s == "y" || s == "n")
                    {
                        switch (s)
                        {
                            case "y":
                                break;
                            case "n":
                                c = false;
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Ошибка!");
                        Console.WriteLine("Продолжить? (y/n)");
                        s = Console.ReadLine();
                        switch (s)
                        {
                            case "y":
                                break;
                            case "n":
                                c = false;
                                break;
                        }
                    }

                }
                sw.Close();
                Console.Clear();
                StreamReader sr = new StreamReader(@"C: \Users\user\Desktop\file.txt");
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                Console.ReadKey();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
    
}
