using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public List<Product> products;
    private Customer customer;

    public Order(Customer customer, List<Product> products)
{
        this.customer = customer;
        this.products = products;
    }

    public double GetTotalPrice()
{
        double totalCost = products.Sum(p => p.GetTotalCost());

        bool isInUSA = customer.LivesInUSA();

        double shippingCost = isInUSA ? 5.0 : 35.0;

        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
{
        return string.Join(Environment.NewLine, products.Select(p => $"{p.name} - {p.id}"));
    }

    public string GetShippingLabel() => $"{customer.name}\n{customer.address.GetFullAddress()}";
}