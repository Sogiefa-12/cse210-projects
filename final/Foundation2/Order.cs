using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;
    private bool isInUSA;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
        isInUSA = customer.IsInUSA();
    }

    public decimal GetTotalPrice()
    {
        return 0;
    }

    public string GetPackingLabel()
    {
        return "";
    }


}