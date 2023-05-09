namespace Figuras;
public class Circulo
{
    private double _radio;

    public Circulo(double r)
    {
        _radio = r;
        
    }

    public double getArea()
    {
        return Math.PI * Math.Pow(_radio,2);
    }
}
