using System;
using System.Drawing;

namespace TrianguloSierpinski
{
    class Program
    {
        static readonly Random random = new Random(Guid.NewGuid().GetHashCode());
        static readonly Point P1 = new Point(Console.WindowWidth / 2, Console.WindowTop);
        static readonly Point P2 = new Point(Console.WindowLeft, Console.WindowHeight);
        static readonly Point P3 = new Point(Console.WindowWidth, Console.WindowHeight);
        const int iterations = 50000;

        static void Main(string[] args)
        {
            DrawSierpinskiTriangle();
            Console.Read();
        }

        static void DrawSierpinskiTriangle()
        {
            Point currentPoint = GetRandomPoint();

            for (int i = 0; i < iterations; i++)
            {
                Point middlePoint = CalculateMiddlePoint(currentPoint, GetRandomPoint());
                DrawPoint(middlePoint);

                currentPoint = middlePoint;
            }
        }

        static void DrawPoint(Point point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write(".");
        }
        static Point CalculateMiddlePoint(Point p1, Point p2)
        {
            return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }
        static Point GetRandomPoint()
        {
            int number = random.Next(1, 4);
            Point temp = new Point();

            switch (number)
            {
                case 1:
                    temp = P1;
                    break;
                case 2:
                    temp = P2;
                    break;
                case 3:
                    temp = P3;
                    break;
                default:
                    break;
            }

            return temp;

        }


    }
}
