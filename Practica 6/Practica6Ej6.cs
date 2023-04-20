/*
6.1

class A {
    public string M1()
    => "A.M1";
}
class B : A {
    public override string M1()
    => "B.M1";
}

El metodo de la clase B esta haciendo override a un metodo que no es virtual o abstract.

==================================================

6.2

class A {
    public abstract string M1();
}

class B : A {
    public override string M1() => "B.M1";
}

Los metodos abstractos tienen que declararse en clases abstractas. Pero en este caso class A no lo es.

==================================================

6.3

abstract class A {
    public abstract string M1()
        => "A.M1";
}

class B : A {
    public override string M1()
        => "B.M1";
}

Los metodos abstractos no pueden ser desarrollados en la clase abstracta, solo se declaran para luego ser desarrollados en clases herederas.

==================================================

6.4

class A {
    public override string M1()
        => "A.M1";
}

class B : A {
    public override string M1()
        => "B.M1";
}

Para que una clase utilice override en un metodo, la clase debe ser heredera de otra que tenga ese metodo como virtual o abstract.

==================================================

6.5

class A {
    public virtual string M1()
        => "A.M1";
}

class B : A {
    protected override string M1()
        => "B.M1";
}

Un metodo que esta haciendo override no puede cambiar el tipo de acceso del metodo original. A = public ; B = protected.

==================================================

6.6

class A {
    public static virtual string M1()
        => "A.M1";
}

class B : A {
    public static override string M1()
        => "B.M1";
}

Los metodos estaticos no pueden hacer override (tampoco pueden ser virtual o abstract)

==================================================

6.7

class A {
    virtual string M1() 
        => "A.M1";
}

class B : A {
    override string M1() 
        => "B.M1";
}

Como no se especifica el tipo de acceso del metodo de A, se le asigna private, pero los tipos virtual o abstract deben ser public o protected.

==================================================

6.8

class A {
    protected A(int i) { }
}

class B : A {
    B() { }
}

B esta queriendo utilizar el contructor vacio de A. Pero como se declaró otro constructor distinto al vacío, a este último hay que declararlo explicitamente para que pueda ser utilizado. 

==================================================

6.9

class A {
    private int _id;
    protected A(int i) => _id = i;
}

class B : A {
    B(int i) : base(5) {
        _id=i;
    }
}

La variable _id fue declarada como privada en A, por lo tanto B no tiene acceso a ella.

==================================================

6.10

class A {
    private int Prop {
        set; public get;
    }
}

class B : A {

}

El problema está en que la propiedad Prop es privada, pero quiere declarar un getter como publico. Esto es una incoherencia ya que todo el "bloque" de la propiedad va a ser privado.

==================================================

6.11

abstract class A {
    public abstract int Prop {set; get;}
}

class B : A {
    public override int Prop {
        get => 5;
    }
}

Como la propiedad Prop se declara como abstracta, B debe implementarla de forma completa, o sea, debe incluir el setter.

==================================================

6.12

abstract class A {
    public int Prop {set; get;}
}

class B : A {
    public override int Prop {
        get => 5;
        set {}
    }
}

La propiedad declarada en A, no es ni virtual ni abstracta, por lo que no se le puede hacer un override desde B.

*/