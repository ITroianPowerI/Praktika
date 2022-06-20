using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika1
{
   
    class Rectangle
    {
        double size1;
        double size2;

        Rectangle(double x, double y)
        {
            this.size1 = x;
            this.size2 = y;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }

        double AreaCalculator()
        {
            return size1 * size2;
        }

        double PerimetrCalculator()
        {
            return size1 * 2 + size2 * 2;
        }



        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Введите длины сторон прямоугольника ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            Rectangle iop = new Rectangle(x,y);
            Console.WriteLine("Area is " + iop.Area);
            Console.WriteLine("Perimetr is " + iop.Perimetr);
            Console.ReadKey();
        }
    }
}
