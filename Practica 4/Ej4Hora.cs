namespace Teoria2;

class Hora
{
    private int _hora;
    private int _mins;
    private int _segs;

    public Hora()
    {

    }

    public Hora(int hora, int mins, int segs)
    {
        _hora = hora;
        _mins = mins;
        _segs = segs;
    }

    public int getHora()
    {
        return _hora;
    }

    public void setHora(int hora)
    {
        _hora = hora;
    }

    public int getMins()
    {
        return _mins;
    }

    public void setMins(int mins)
    {
        _mins = mins;
    }

    public int getSegs()
    {
        return _segs;
    }

    public void setSegs(int segs)
    {
        _segs = segs;
    }

    public void Imprimir()
    {
        Console.WriteLine($"{_hora} horas, {_mins} minutos y {_segs} segundos.");
    }

}