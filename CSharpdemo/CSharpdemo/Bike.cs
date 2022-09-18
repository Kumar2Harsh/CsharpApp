using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpdemo
{
    abstract class Bike
    {
        public Bike()
        {

        }
        public abstract void Break();
        public void Run()
        {
            Console.WriteLine("Bike Run");
        }
    }
    class XBike : Bike
    {
        public override void Break()
        {
            Console.WriteLine("XBike Break");
        }
    }
    class YBike : Bike
    {
        public override void Break()
        {
            Console.WriteLine("YBike Break");
        }
    }
}
