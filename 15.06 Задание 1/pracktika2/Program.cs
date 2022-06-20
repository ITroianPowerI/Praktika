using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracktika2
{
    class Point 
    {
        int a;
        int b;
        string fig;

        
        public int X
        {
            get
            {
                return a;
            }
        }
        public int Y
        {
            get
            {
                return b;
            }
        }
        public string Fig
        {
            get
            {
                return fig;
            }
        }

        public
        Point(int p1, int p2, string pot_te)
        {
            this.a = p1;
            this.b = p2;
            this.fig = pot_te;
        }
    }
    class Figure
    {
        private Point gop1;
        private Point gop2;
        private Point gop3;
        private Point gop4;
        private Point gop5;

        Figure(Point f1, Point f2, Point fop_te)
        {
            gop1 = f1;
            gop2 = f2;
            gop3 = fop_te;

        }

        Figure(Point f1, Point f2, Point fop_te, Point iop)
        {
            gop1 = f1;
            gop2 = f2;
            gop3 = fop_te;
            gop4 = iop;
        }
        Figure(Point f1, Point f2, Point fop_te, Point iop, Point poi)
        {
            gop1 = f1;
            gop2 = f2;
            gop3 = fop_te;
            gop4 = iop;
            gop5 = poi;
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        void PerimeterCalculator()
        {
            if (gop5 == null && gop4 == null)
            {
                Console.WriteLine("Название фигуры: Треугольник");
                Console.WriteLine("Площадь фигуры: {0}", LengthSide(gop1, gop2) + LengthSide(gop2, gop3) + LengthSide(gop3, gop1));
            }
            else if (gop5 == null)
            {
                Console.WriteLine("Название фигуры: Четырехугольник");
                Console.WriteLine("Площадь фигуры: {0}", LengthSide(gop1, gop2) + LengthSide(gop2, gop3) + LengthSide(gop3, gop4) + LengthSide(gop4, gop1));
            }
            else
            {
                Console.WriteLine("Название фигуры: Многоугольник");
                Console.WriteLine("Площадь фигуры: {0}", LengthSide(gop1, gop2) + LengthSide(gop2, gop3) + LengthSide(gop3, gop4) + LengthSide(gop4, gop5) + LengthSide(gop5, gop1));
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Выберите количество точек(от 3 до 5): ");
            int count = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();

            if (count >= 3 && count <= 5)
                for (int i = 0; i < count; i++)
                {
                    Console.Write("\nВведите x точки номер {0}:", i + 1);
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Введите y точки номер {0}:", i + 1);
                    int y = int.Parse(Console.ReadLine());

                    points.Add(new Point(x, y, ""));
                }
            else
            {
                Console.WriteLine("Неверно введено значение");
                Console.ReadKey();
                return;
            }

            if (count == 3)
            {
                Figure fig = new Figure(points[0], points[1], points[2]);
                fig.PerimeterCalculator();
            }
            else if (count == 4)
            {
                Figure fig = new Figure(points[0], points[1], points[2], points[3]);
                fig.PerimeterCalculator();
            }
            else
            {
                Figure fig = new Figure(points[0], points[1], points[2], points[3], points[4]);
                fig.PerimeterCalculator();
            }

            Console.ReadKey();


        }
    }
    
}
