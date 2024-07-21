namespace AplicandoSRP.Class;

public class Personas
{
    private string Nombre { get; set; }
    private int Edad { get; set; }
    private string Direccion { get; set; }
    private string CorreoElectronico { get; set; }
    
    public Personas(string nombre, int edad, string direccion, string correoElectronico)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Direccion = direccion;
        this.CorreoElectronico = correoElectronico;
    }
    public string nombre => Nombre;
    public int edad => Edad;
    public string direccion => Direccion;
    public string correoElectronico => CorreoElectronico;
}