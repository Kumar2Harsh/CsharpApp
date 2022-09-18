using System;
using System.Text;
using Demo.Csharp;
using CSharpdemo.Namespace;
namespace CSharpdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IBike bikex = new XBike1();
            bikex.Break();
            IBike bikey = new YBike1();
            bikey.Break();
            Bike xBike = new XBike();
            xBike.Break();
            xBike.Run();

            Bike yBike = new YBike();
            yBike.Break();

            Animal animal = new Animal();
            animal.Eat();
            Cow cow = new Cow();
            cow.Eat();
            Animal animal1 = new Cow();
            animal1.Eat();
            Csharp csharp1 = new Csharp();
            csharp1.Add(12, 10);
            csharp1.Add(12.5f, 10.40f);

            Class1 class1 = new Class1();
            //var count=class1.count;
            Employee employee = new Employee("Emp001", "Kumar", new Address("Bangalore", "Karnataka"));
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.address.City);
            Console.WriteLine(employee.address.State);
            EncapsulationEx ex = new EncapsulationEx();
            var countEn = ex.Count;
            ex.Count = 40;
            Console.WriteLine(ex.Count);
            A a = new A();
            Rectangle rectangle=new Rectangle(10,50);
            Console.WriteLine("Length " + rectangle.lenght);
            Console.WriteLine("Width " + rectangle.width);
            Console.WriteLine("Area: " + rectangle.Area());
            Console.WriteLine((int)Days.Monday);
            Console.WriteLine((int)Days.Tuesday);
            Console.WriteLine((int)Days.Saturday);
            var names = Enum.GetNames(typeof(Days));
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            var values = Enum.GetValues(typeof(Days));
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            //Csharp csharp = new Csharp(13, 12);
            //csharp.Display();
            StaticDemo st = new StaticDemo();
            Console.WriteLine(StaticDemo.x);
            Console.WriteLine(StaticDemo.x);
            #region Datatype/IO/Color
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

            /* Console.WriteLine("---------------int-------------");
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
             Console.WriteLine("The sum of first and second: " + sum);

             var key = Console.ReadKey();
             Console.WriteLine("Key Pressed: " + key.Key + " Modfier:" + key.Modifiers);*/
            #endregion

            #region Decision-making

            /*  Console.Write("Enter Mark: ");
              int mark = Convert.ToInt32(Console.ReadLine());
              if (mark > 60)
              {
                  Console.WriteLine("A-Grade");

              }
              else if (mark > 50 && mark < 60)
              {
                  Console.WriteLine("B-Grade");
              }
              else if (mark > 40 && mark < 50)
              {
                  Console.WriteLine("C-Grade");
              }
              else
              {
                  Console.WriteLine("Fail");
              }
              string Grade = mark > 60 ? "A-Grade" : mark > 50 && mark < 60 ? "B-Grade" : mark > 40 && mark < 50 ? "C-Grade" : "Fail";
              Console.WriteLine("Grade from ternary operator : " + Grade);
              int first = Convert.ToInt32(Console.ReadLine());
              int second = Convert.ToInt32(Console.ReadLine());
              char ope = Convert.ToChar(Console.ReadLine());
              switch (ope)
              {
                  case '+':
                      Console.WriteLine(first + second);
                      break;
                  case '-':
                      Console.WriteLine(first - second);
                      break;
                  default:
                      Console.WriteLine("Not a valid Operator");
                      break;
              } */

            #endregion

            #region Loop, break, continue and goto

            /*int x;
            FuncWithRefParmeter(out x);
            Console.WriteLine(x);
            StringBuilder n = new StringBuilder("wpf");
            FuncWithParmeter(n);
            Console.WriteLine(n);
            Console.WriteLine("While loop");
            int w = 1;

        come:
            while (w <= 5)
            {
                int nw = 1;
                Console.WriteLine("Table of " + w);
                w++;
                goto come;
                while (nw <= 10)
                {
                    goto come;
                    Console.WriteLine(w * nw);
                    nw++;
                }
                w++;
                Console.WriteLine();
            }

            Console.WriteLine("Do-While loop");
            int d = 1;
            do
            {
                int nd = 1;
                Console.WriteLine("Table of " + d);
                do
                {
                    Console.WriteLine(d * nd);
                    nd++;
                } while (nd <= 10);
                Console.WriteLine();
                d++;
            } while (d <= 5);
            */
            #endregion

            #region Methods
            /* var factorial = Factorial(5);
             Console.WriteLine("5!= " + factorial);
             void ForLoop(int n)
             {

                 for (int i = 1; i <= n; i++)
                 {
                     Console.WriteLine("Table of " + i);
                     for (int j = 1; j <= 10; j++)
                     {
                         if (j == 5)
                             continue;
                         Console.WriteLine(i * j);
                     }
                     Console.WriteLine();
                 }

             }

             void FuncWithParmeter(StringBuilder s)
             {
                 s.Append(" world");
                 Console.WriteLine(s);
             }
             void FuncWithRefParmeter(out int x)
             {
                 x = 10;
                 Console.WriteLine(x);
             }
             int Factorial(int x)
             {
                 int fact = 1;
                 for (int i = 2; i <= x; i++)
                 {
                     fact = fact * i;

                 }
                 return fact;
             } */
            #endregion
        }


    }
    public class Csharp
    {
        //data member
        //member function
        //int len, wid;
        //public Csharp(int len, int wid)
        //{
        //    this.len = len;
        //    this.wid = wid;
        //}
        //public void Display()
        //{
        //    Console.WriteLine("len=" + len);
        //    Console.WriteLine("wid=" + wid);

        //}
        //~Csharp()
        //{
        //    Console.WriteLine("Dis call");
        //}
        public void Add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum a and b are :" + sum);
        }
        public void Add(float fa, float fb)
        {
            float sum = fa + fb;
            Console.WriteLine("The sum fa and fb are :" + sum);
        }
    }

    struct Rectangle
    {
        public int lenght, width;
        public Rectangle(int l,int w)
        {
            lenght = l;
            width = w;
        }
        public int Area()
        {
            return lenght * width;
        }

    }
    enum Days
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday=10,
        Friday,
        Saturday,
        Sunday
    }
}

namespace Demo.Csharp
{
    class A
    {

    }
}
