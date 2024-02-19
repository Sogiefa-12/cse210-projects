using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string name;
    public string id;
    public double price;
    public int quantity;

    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost() => price * quantity;
}
