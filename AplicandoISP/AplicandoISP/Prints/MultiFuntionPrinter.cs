using Interfaces;

namespace Prints;

public class MultiFuntionPrinter : IPrint, IScan
{
    public void Print(Document.Document document)
    {
        Console.WriteLine("Imprimiendo: " + document.Name);
    }

    public void Scan(Document.Document document)
    {
        Console.WriteLine("Escaneando: " + document.Name);

    }
}