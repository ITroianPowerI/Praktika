using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Укажите цвет: (1 - красный, 2 - синий,  3 - зелёный, 4 - жёлтый)");
            int color = Convert.ToInt32(Console.ReadLine());
            ColorPrint.Print(stroka, color);
            Console.ReadKey();
        }
    }
}
