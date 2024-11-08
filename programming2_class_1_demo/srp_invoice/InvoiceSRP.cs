namespace srp_invoice;

public class InvoiceModel
{
    public int InvoiceId { get; set; }
    public double Amount { get; set; }
}

public class InvoiceRepository
{
    public void SaveToDatabase(InvoiceModel invoice)
    {
        Console.WriteLine("Saving invoice to database.");
    }
}

public class InvoicePrinter
{
    public void Print(InvoiceModel invoice)
    {
        Console.WriteLine($"Printing invoice: {invoice.InvoiceId}");
    }
}

public class TaxCalculator
{
    public double CalculateTax(InvoiceModel invoice)
    {
        return invoice.Amount * 0.15;
    }
}
