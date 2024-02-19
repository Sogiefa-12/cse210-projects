using System;
using System.Collections.Generic;
using System.Linq;

class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
{
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsInUSA() => country.Equals("USA", StringComparison.OrdinalIgnoreCase);

    public string GetFullAddress() => $"{streetAddress}\n{city}, {stateProvince} {country}";
}
