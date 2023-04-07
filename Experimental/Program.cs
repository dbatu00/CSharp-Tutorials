using System;

namespace Experimental
{   

    public class Number
    {
        public int number { get; set; }

        public Number(int _number) => (number) = (_number);


    }
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(5);
            Number number2 = number;
            number2.number = 10;
            
            Console.WriteLine(number.number);

            void numberChanger(Number number)
            {
                number.number = 15;
                Console.WriteLine(number.number);
            }

            numberChanger(number);
            Console.WriteLine(number.number);
        }
    }
}
