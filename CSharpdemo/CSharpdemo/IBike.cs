using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpdemo
{
    public interface IBike
    {

        public abstract void Break();
        protected void Run()
        {

        }
        static IBike()
        {

        }
    }
    class XBike1 : IBike
    {
        public void Break()
        {
            Console.WriteLine("XBike1 Break");
        }

    }
    class YBike1 : IBike
    {
        public void Break()
        {
            Console.WriteLine("YBike1 Break");
        }
    }
}
