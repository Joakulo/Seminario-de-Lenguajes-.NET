namespace Teoria2;

class Hora
{
    private int _hora;
    private int _mins;
    private int _segs;
    private double _segsD;

    public Hora()
    {

    }

    public Hora(int hora, int mins, int segs)
    {
        _hora = hora;
        _mins = mins;
        _segs = segs;
    }

    public Hora(double hora)
    {
        // Al castear obtengo la parte entera del double
        _hora = (int)hora;

        // Si le resto la parte entera al double, tengo los decimales, luego estos multiplicados por 60 me dan los minutos que representan. Otra vez casteando, obtengo la parte entera
        _mins = (int)((hora - _hora) * 60);

        // Mismo procedimiento que con los minutos. Creo una nueva variable tipo double para poder guardar el numero resultante con decimales incluidos-
        _segsD = ((((hora - _hora) * 60) - _mins) * 60);

        // Cuando los segundos deberían llegar a 60, ocurre que el numero es en verdad 59,9999999999999277, entonces aparece como que hay 60 segundos pero no suma un nuevo minuto, entonces este condicional corrige ese pequeño problema que deriva de la precisión de la representación de los valores.
        if (Math.Round(_segsD) == 60)
        {
            _mins++;
            _segsD = 0;
        }
        
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
        if (_segs != 0)
        {
           Console.WriteLine("{0} horas, {1} minutos y {2} segundos.", _hora, _mins, _segs);
        } else {
           Console.WriteLine("{0} horas, {1} minutos y {2:0.000} segundos.", _hora, _mins, _segsD);

        }
    }

}