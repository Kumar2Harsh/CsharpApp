using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpdemo
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Cow : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cow is Eating...");
        }
    }
}
