using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
    public string name;
    public Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool LivesInUSA() => address.IsInUSA();
}
