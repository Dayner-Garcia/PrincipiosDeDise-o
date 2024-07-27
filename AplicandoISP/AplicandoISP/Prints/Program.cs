using AplicandoISP.Prints;
using Interfaces;
using Prints;

namespace AplicandoISP;

public class Program
{
    public static void Main()
    {
        Document.Document dcmt = new Document.Document { Name = "Tarea", Description = "Descripcion" };

        IPrint print = new SimplePrinter();
        print.Print(dcmt);

        MultiFuntionPrinter multiPrint = new MultiFuntionPrinter();
        multiPrint.Print(dcmt);
        multiPrint.Scan(dcmt);
    }
}