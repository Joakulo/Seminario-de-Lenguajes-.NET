class Persona {
    public string Nombre { get; set; }
}
public class Auto {
    private Persona _dueño1, _dueño2;
    public Persona GetPrimerDueño() => _dueño1;
    protected Persona SegundoDueño {
        set => _dueño2 = value;
    }
}

/*
    Como la clase persona no tiene asignado un modificador de acceso, el compilador la asgina como privada. Esto hace que la clase Auto no pueda acceder a ella.
*/