using System;

namespace srp_invoice;

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
