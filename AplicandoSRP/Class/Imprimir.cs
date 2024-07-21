namespace AplicandoSRP.Class
{
    public class Imprimir
    {
        public void ImprimirDatos(Personas personas)
        {
            Console.WriteLine($"Nombre: {personas.nombre}");
            Console.WriteLine($"Edad: {personas.edad}");
            Console.WriteLine($"Direccion:  {personas.direccion}");
            Console.WriteLine($"Correo electronico: {personas.correoElectronico}");
        }
    }
}