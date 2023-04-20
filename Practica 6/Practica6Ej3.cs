/*
    Al no especificar el modificador de acceso de la variable "velocidad", el compilador la asigna como privada por default. Haciendo asi que las clases que hereden de Auto no puedan acceder a ella. La solucion es tan sencilla como declarar la variable "velocidad" como protected.
*/

class Auto {
    protected double velocidad;         // antes: double velocidad;
    public virtual void Acelerar()
    => Console.WriteLine("Velocidad = {0}", velocidad += 10);
}

class Taxi : Auto {
    public override void Acelerar()
    => Console.WriteLine("Velocidad = {0}", velocidad += 5);
}