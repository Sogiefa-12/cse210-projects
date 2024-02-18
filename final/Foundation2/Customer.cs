using System;
using System.Collections.Generic;
using System.Text;
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    
    {
        this.name = name;
        this.address = address;
    }
    public bool IsInUSA()
    {
        return address.IsUsAddress();
    }

    public string Name
    {
        get;
        set;
    }

    public Address Address
    {
        get;
        set;
    }

}