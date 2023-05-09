namespace Teoria2;

class Ecuacion2
{
    private double a;
    private double b;
    private double c;

    public Ecuacion2(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double getDiscriminante()
    {
        return ((Math.Pow(b,2)) - (4*a*c));
    }

    public int getCantidadRaices()
    {
        if (((Math.Pow(b,2)) - (4*a*c)) < 0)
        {
            return 0;
        } 
        else if (((Math.Pow(b,2)) - (4*a*c)) == 0)
        {
            return 1;
        } 
        else 
        {
            return 2;
        }
    }

    public void ImprimirRaices()
    {
        if (getCantidadRaices() == 0)
        {
            Console.WriteLine("No posee soluciones reales");
        } 
        else if (getCantidadRaices() == 1)
        {
            Console.WriteLine("Raiz: ", (-this.b) / (2 * this.a));
        } 
        else 
        {
            double r1 = (-this.b + Math.Sqrt(getDiscriminante())) / (2 * this.a);
            double r2 = (-this.b - Math.Sqrt(getDiscriminante())) / (2 * this.a);
            Console.WriteLine("Raices: {0} y {1}", r1, r2);
        }
    }

}