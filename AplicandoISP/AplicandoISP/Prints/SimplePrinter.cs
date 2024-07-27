using Interfaces;

namespace AplicandoISP.Prints
{
    public class SimplePrinter : IPrint
    {
        public void Print(Document.Document document)
        {
            Console.WriteLine("Imprimiendo: " + document.Name + " simple.");
            Console.WriteLine("");
        }
    }
}