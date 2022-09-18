using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpdemo.Namespace
{
    class Employee
    {
        public string Id, Name;
        public Address address;
        public Employee(string Id, string Name, Address address)
        {
            this.Id = Id;
            this.Name = Name;
            this.address = address;
        }
    }
    class Address
    {
        public string City, State;
        public Address(string City, string State)
        {
            this.City = City;
            this.State = State;
        }
    }
    public class Class1
    {
        public Class1()
        {
            int c = count;
        }
        protected private int count = 0;
    }
    class class2 : Class1
    {
        public class2()
        {

        }
    }
    class EncapsulationEx
    {
        public EncapsulationEx()
        {
            count = 10;
        }
        public void Setter(int x)
        {
            count = x;
        }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (value > 30)
                    Console.WriteLine("Value should not be more than 30");
            }
        }
    }
}
