namespace Teoria2;

class Persona
{
    private string? _nombre = "NULL";
    private int _edad = -1;
    private string? _DNI = "NULL";

    public Persona()
    {

    }

    public Persona(string nombre, int edad, string DNI)
    {
        _nombre = nombre;
        _edad = edad;
        _DNI = DNI;
    }

    public void Imprimir()
    {
        Console.WriteLine("{0,-25} {1,5} {2,11}" , _nombre, _edad, _DNI);
    }
}