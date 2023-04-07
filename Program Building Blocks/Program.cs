//https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/program-building-blocks
using System;

namespace ProgramBuildingBlocks
{
  
    public class Color
    {
        //Everything in a class is a member?

        //A field is a variable that is associated with a class or with an instance of a class.

        //Assignment to a read-only field can only occur as part of the field's declaration
        //or in a constructor in the same class.
        public static readonly Color Black = new(0, 0, 0); //static field -only one copy
        public static readonly Color White = new(255, 255, 255);
        public static readonly Color Red = new(255, 0, 0);
        public static readonly Color Green = new(0, 255, 0);
        public static readonly Color Blue = new(0, 0, 255);

        public byte R; //instance field -separate copy for all instances
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }


        //A method is a member that implements a computation or action that can be performed by an
        //object or class. Static methods are accessed through the class. Instance methods are
        //accessed through instances of the class.

    }

    class Program
    {
        static void Main(string[] args)
        {
            Color color = new(5, 5, 5);
            color = Color.Black;

            Console.WriteLine("Hello World!");
        }
    }
}
