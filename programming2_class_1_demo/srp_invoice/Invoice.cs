using System;

namespace srp_invoice;

// This class violates SRP since data modelling, data persistence,
//   priting and tax calculation are all within a single class
public class Invoice
{
    public int InvoiceId { get; set; }
    public double Amount { get; set; }

    public void SaveToDatabase()
    {
        Console.WriteLine("Saving invoice to database...");
    }

    public void Print()
    {
        Console.WriteLine("Printing invoice...");
    }

    public double CalculateTax()
    {
        return Amount * 0.15;
    }
}
