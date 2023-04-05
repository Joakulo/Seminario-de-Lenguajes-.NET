namespace Teoria2;

class Cuenta
{
    private double _monto;
    private int _titularDNI;
    private string? _titularNombre;

    public Cuenta()
    {
        _monto = 0.0;
        _titularDNI = 0;
        _titularNombre = "No especificado";
    }

    public Cuenta(int DNI) :this()
    {
        _titularDNI = DNI;
    }

    public Cuenta(string nombre):this()
    {
        _titularNombre = nombre;
    }

    public Cuenta(string nombre, int DNI):this()
    {
        _titularNombre = nombre;
        _titularDNI = DNI;
    }

    public void Depositar(double x)
    {
        _monto += x;
    }

    public void Extraer(double x)
    {
        if (_monto - x < 0)
        {
            Console.WriteLine("Operacion cancelada, monto insuficiente.");
        }
        else
        {
            _monto -= x;
        }
    }

    public void Imprimir()
    {
        string auxDNI = _titularDNI == 0 ? "No especificado" : _titularDNI.ToString();
        Console.WriteLine("Nombre: {0}, DNI: {1}, Monto: {2}", _titularNombre, auxDNI, _monto);
    }
}