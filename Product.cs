using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract decimal GetPrice();
    public abstract decimal GetTax();
}

// TaxableProduct subclass
public class TaxableProduct : Product
{
    private const decimal TaxRate = 0.08m;

    public TaxableProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetPrice()
    {
        return Price + GetTax();
    }

    public override decimal GetTax()
    {
        return Price * TaxRate;
    }
}

// NonTaxableProduct subclass
public class NonTaxableProduct : Product
{
    public NonTaxableProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetPrice()
    {
        return Price;
    }

    public override decimal GetTax()
    {
        return 0;
    }
}

