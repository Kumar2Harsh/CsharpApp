using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDemo
{
    class Employee
    {
        string Id, Name;
        Address address;
        public Employee(string Id, string Name, Address address)
        {
            this.Id = Id;
            this.Name = Name;
            this.address = address;
        }
    }
    class Address
    {
        string City, State;
        public Address(string City, string State)
        {
            this.City = City;
            this.State = State;
        }
    }
    class A
    {

    }
    class B:A
    {

    }
    class C:B
    {

    }
    class D : B
    {

    }
}
