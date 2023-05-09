namespace Figuras;
public class Rectangulo
{
    private double _base;
    private double _altura;

    public Rectangulo(double Base, double altura)
    {
        _base = Base;
        _altura = altura;
    }

    public double getArea()
    {
        return _base * _altura;
    }
}
