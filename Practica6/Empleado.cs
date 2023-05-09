namespace Teoria6;

abstract class Empleado{
    
    public string Nombre {protected set; get;}
    public int DNI {protected set; get;}
    public DateTime FechaDeIngreso {protected set; get;}
    public double SalarioBase {protected set; get;}
    public abstract double Salario {get; }
    public abstract void AumentarSalario();

    public Empleado (string nombre, int _DNI, DateTime fecha, double salario) {
        Nombre = nombre;
        DNI = _DNI;
        FechaDeIngreso = fecha;
        SalarioBase = salario;
    }

    public int Antiguedad {
        get {
            DateTime hoy = DateTime.Parse("09/04/2022");
            int aux = hoy.Year - FechaDeIngreso.Year - 1;
            if (hoy.Month > FechaDeIngreso.Month) {
                aux++;
            } else if (hoy.Month == FechaDeIngreso.Month && hoy.Day >= FechaDeIngreso.Day) {
                aux++;
            }
        return aux;
        }
    }

    public override string ToString()
    {
        return "Nombre " + Nombre + ", DNI: " + DNI + " Antiguedad: " + Antiguedad + "\nSalario Base: " + SalarioBase;
    }
}