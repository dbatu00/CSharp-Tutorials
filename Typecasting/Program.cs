using System;

namespace Typecasting
{
    #region typecasting
    public class Point
    {
        public string Name { get; }
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (Name, X, Y) = ("point", x, y);

        public Point(string name, int x, int y) => (Name, X, Y) = (name, x, y);


    }

    public class Point3D : Point
    {
        public int Z { get; }

        public Point3D(int x, int y, int z) : base("point3D", x, y) => (Z) = (z);

    }

    #endregion


    class Program
    {
        static void Main(string[] args)
        {

            #region typecasting
            //no cast
            Point point = new(-1, -2);
            Point3D point3D = new(1, 2, 3);

            Console.WriteLine("No cast:\n\tprintPoint called with point:");
            printPoint(point);
            Console.WriteLine("\tprintPoint called with point3D:");
            printPoint(point3D);
            Console.WriteLine("\tprintPoint3D cannot be called with point.");
            //printPoint3D(point);
            Console.WriteLine("\tprintPoint3D called with point3D:");
            printPoint3D(point3D);
            Console.WriteLine("\n\n");


            //implicit upcasting point3D to point
            point = new(-1, -2);
            point3D = new(1, 2, 3);
            point = point3D; // point = (Point)point3D;


            Console.WriteLine("implicit upcasting and assigning point3D to point:\n\tprintPoint called with point:");
            printPoint(point);
            Console.WriteLine("\tprintPoint called with point3D:");
            printPoint(point3D);
            Console.WriteLine("\tprintPoint3D cannot be called with point.");
            //printPoint3D(point);
            Console.WriteLine("\tprintPoint3D called with point3D:");
            printPoint3D(point3D);
            Console.WriteLine("\n\n");



            // explicit casting point to point3D
            /*point = new Point(-1, -2);
            point3D = new Point3D(1, 2, 3);
            point3D = (Point3D)point;
            */
            Console.WriteLine("Explicit casting point to point3D does not work:");
            /*
            Console.WriteLine("\tprintPoint called with point:");
            printPoint(point);
            Console.WriteLine("\tprintPoint called with point3D:");
            printPoint(point3D);
            Console.WriteLine("\tprintPoint3D cannot be called with point.");
            //printPoint3D(point);
            Console.WriteLine("\tprintPoint3D called with point3D:");
            printPoint3D(point3D);
            Console.WriteLine(); 
            */

            void printPoint(Point point)
            {
                Console.WriteLine($"\t\t {point.Name}, {point.X}, {point.Y}\n");
            }

            void printPoint3D(Point3D point3D)
            {
                Console.WriteLine($"\t\t {point3D.Name}, {point3D.X}, {point3D.Y}, {point3D.Z}\n");
            }
            #endregion

        }
    }
}
