using System;
using System.Text;

namespace CSharpdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //changed from github
            /*Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            byte byteVar = 10;
            Console.Write(byteVar);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine("---------------short-------------");
            short shortVar = 0;
            Console.WriteLine(shortVar);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkGreen;*/

            Console.WriteLine("---------------int-------------");
            int intVar = 100;
            Console.WriteLine(intVar);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine("---------------long-------------");
            long longVar = 100;
            Console.WriteLine(longVar);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine("---------------Float-------------");
            float floatVar = 100e2F;
            Console.WriteLine(floatVar);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine("---------------double-------------");
            double doubleVar = 100e-2d;//100*100
            Console.WriteLine(doubleVar);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine("---------------decimal-------------");
            decimal decimalVar = 100.00m;
            Console.WriteLine(decimalVar);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine("---------------bool-------------");
            bool boolVar = true;
            Console.WriteLine(boolVar);
            Console.WriteLine("---------------char-------------");
            char charVar = '@';
            Console.WriteLine(charVar);
            Console.WriteLine("---------------string-------------");
            string stringVar = "wpfworld";
            Console.WriteLine(stringVar);
            string stringVar1 = stringVar;
            stringVar = stringVar + "C#";
            Console.WriteLine(stringVar1);
            Console.WriteLine(stringVar);

            StringBuilder str = new StringBuilder("wpfworld");
            StringBuilder str1 = str;
            str.Append(".com");
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();//it will take input from user
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("Welcome to Wpf World ");//it will display the value of name
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Enter First value:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            int second = Convert.ToInt32(Console.ReadLine());

            int sum = first + second;
            Console.WriteLine("The sum of first and second: "+sum);

            var key = Console.ReadKey();
            Console.WriteLine("Key Pressed: "+key.Key+" Modfier:"+key.Modifiers);
        }
    }
}
