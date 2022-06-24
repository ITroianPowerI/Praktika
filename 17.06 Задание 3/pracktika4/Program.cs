using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Количество часов после которых положена премия,\n Директор компании - 140,\n Главный технический директор - 130,\n Junior Разработчик - 50,\n Middle Разработчик - 70,\n Senior Разработчик - 90,\n Инженеры по обеспечению качества - 110\n");
            Console.Write("\n Введите количество часов: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберете должность");
            Console.WriteLine("1 - Junior Разработчик");
            Console.WriteLine("2 - Middle Разработчик");
            Console.WriteLine("3 - Senior Разработчик");
            Console.WriteLine("4 - Инженеры по обеспечению качества");
            Console.WriteLine("5 - Главный технический директор");
            Console.WriteLine("6 - Директор компании");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {

                case 1:
                    if (Accauntant.AskForBonus(Employees.JuniorDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 2:
                    if (Accauntant.AskForBonus(Employees.MiddleDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 3:
                    if (Accauntant.AskForBonus(Employees.SeniorDeveloper, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 4:
                    if (Accauntant.AskForBonus(Employees.QualityAssuranceEngineers, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 5:
                    if (Accauntant.AskForBonus(Employees.ChiefTechnologyOfficer, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                case 6:
                    if (Accauntant.AskForBonus(Employees.ChiefExecutiveOfficer, h))
                        Console.WriteLine("Премия положена");
                    else
                        Console.WriteLine("Премия не положена");
                    break;
                default:
                    Console.WriteLine("Такого сотрудника нет");
                    break;

            }

            Console.ReadKey();
        }
    }
}
