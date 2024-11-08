namespace srp_invoice;

class Program
{
    static void Main(string[] args)
    {
        /**
        * By moving each responsibility of our invoice system (invoice,
        *    printer, tax calculation, repository), we are more easily
        *    able to switch out these functionalities without affecting
        *    other areas of our application. This makes our code more
        *    modular, testable and less tightly coupled.
        */

        // create invoice
        InvoiceModel invoice = new InvoiceModel() { InvoiceId = 123, Amount = 5000 };

        // print invoice
        InvoicePrinter printer = new InvoicePrinter();
        printer.Print(invoice);

        // calculate tax
        TaxCalculator calculator = new TaxCalculator();
        double tax = calculator.CalculateTax(invoice);

        // save invoice to database
        InvoiceRepository invoiceRepository = new InvoiceRepository();
        invoiceRepository.SaveToDatabase(invoice);
    }
}
