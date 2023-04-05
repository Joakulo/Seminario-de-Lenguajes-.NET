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

    public string? getNombre()
    {
        return _nombre;
    }

    public void setNombre(string nombre)
    {
        _nombre = nombre;
    }

    public int getEdad()
    {
        return _edad;
    }

    public void setEdad(int edad)
    {
        _edad = edad;
    }

    public string? getDNI()
    {
        return _DNI;
    }

    public void setDNI(string DNI)
    {
        _DNI = DNI;
    }

    public void Imprimir()
    {
        Console.WriteLine("{0,-25} {1,5} {2,11}" , _nombre, _edad, _DNI);
    }

    public bool EsMayorQue(Persona p)
    {
        return (_edad > p.getEdad());
    }

}