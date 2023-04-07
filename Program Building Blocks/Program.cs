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

        public override string ToString() => "This is a color";
        //Program program = new Program(); ???
        


        //A method is a member that implements a computation or action that can be performed by an
        //object or class. Static methods are accessed through the class. Instance methods are
        //accessed through instances of the class.

    }

    class Entity
    {
        //A method declared without a static modifier is an instance method. An instance method
        //operates on a specific instance and can access both static and instance members. The
        //instance on which an instance method was invoked can be explicitly accessed as this.
        //It's an error to refer to this in a static method.

        static int s_nextSerialNo;
        int _serialNo;

        public Entity()
        {
            _serialNo = s_nextSerialNo++;
        }

        public int GetSerialNo()
        {
            return _serialNo;
        }

        public static int GetNextSerialNo()
        {
            return s_nextSerialNo;
        }

        public static void SetNextSerialNo(int value)
        {
            s_nextSerialNo = value;
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            Color color = new(5, 5, 5);
            color = Color.Black;

            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // "2 1"
        }

        public static void PrintName(string firstName, string lastName = "Doe")
                          => Console.WriteLine($"Name: {firstName} {lastName}");
        //lastName is a default value parameter

        static void Swap(ref int x, ref int y) //reference parameter
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Divide(int x, int y, out int quotient, out int remainder)
        {
            quotient = x / y;
            remainder = x % y;
        }

        public static void OutUsage()
        {
            Divide(10, 3, out int quo, out int rem); //out parameter is like a reference parameter
                                                     //but it doesnt need an inital value
            Console.WriteLine($"{quo} {rem}");  // "3 1"
        }


        //A parameter array permits a variable number of arguments to
        //be passed to a method.A parameter array is declared with the
        //params modifier.Only the last parameter of a method can be a
        //parameter array, and the type of a parameter array must be a
        //single-dimensional array type.

        //parameter can be passed as an array or as the elements of the array
        //Console.WriteLine(s, args);
        //Console.WriteLine("something", x, y, z);

        public static void Write(string fmt, params object[] args) { } //this is actually a System.Console method
    }
}
