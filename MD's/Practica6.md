<h1 align="center">Practica 6</h1>

```1)``` Sin borrar ni modificar ninguna línea, completar la definición de las clases B, C y D

```c#
class A
{
    protected int _id;
    public A(int id) => _id = id;
    public virtual void Imprimir() => Console.WriteLine($"A_{_id}");
}
class B : A
{
    . . .
}
class C : B
{
    . . .
}
class D : C
{
    . . .
    public override void Imprimir()
    {
        . . .
        base.Imprimir();
    }
}
```

para que el siguiente código produzca la salida indicada:

```c#
A[] vector = new A[] { new A(3), new B(5), new C(15), new D(41) };
foreach (A a in vector)
{
    a.Imprimir();
}
```

Salida indicada:

```
A_3
B_5 --> A_5
C_15 --> B_15 --> A_15
D_41 --> C_41 --> B_41 --> A_41
```

<details>

<summary> ▶️ </summary>
<br>
  
```c#
class A {
    protected int _id;
    public A(int id) => _id = id;
    public virtual void Imprimir() => Console.WriteLine($"A_{_id}");
}

class B : A {
    public B(int id) : base(id){
        
    }

    public override void Imprimir() {
        Console.Write($"B_{_id} --> ");
        base.Imprimir();
    }
}

class C : B {
    public C(int id) : base(id){

    }

    public override void Imprimir() {
        Console.Write($"C_{_id} --> ");
        base.Imprimir();
    }
}
class D : C {
    public D(int id) : base(id){

    }
    public override void Imprimir() {
        Console.Write($"D_{_id} --> ");
        base.Imprimir();
    }
}
```
  
</details>

<br><hr><br>

```2)``` Aunque consultar en el código por el tipo de un objeto indica habitualmente un diseño ineficiente, por motivos didácticos vamos a utilizarlo. Completar el siguiente código, que utiliza las clases definidas en el ejercicio anterior, para que se produzca la salida indicada:

```c#
A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector)
{
    ...
}
```

Salida indicada:

```
B_3 --> A_3
B_5 --> A_5

```

Es decir, se deben imprimir sólo los objetos cuyo tipo exacto sea ***B***.

- ```a)``` Utilizando el operador ***is***

- ```b)``` Utilizando el método ***GetType()*** y el operador ***typeof()*** (investigar sobre éste último en la documentación en línea de .net)

<details>

<summary> ▶️ </summary>
<br>

<table align="center">
<tr>
<td> is </td> <td> GetType() typeof() </td>
</tr>
<tr>
<td>

```c#
A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector) {
    if ((a is B) && (a is not C) && (a is not D)){
        a.Imprimir();
    }
}
```
</td>
<td>

```c#
A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector) {
    if (a.GetType().Equals(typeof(B))){
        a.Imprimir();
    }
}
```
 
</td>
</tr>
</table>

</details>

<br><hr><br>

```3)``` ¿Por qué no funciona el siguiente código? ¿Cómo se puede solucionar fácilmente?

```c#
class Auto
{
    double velocidad;
    public virtual void Acelerar()
        => Console.WriteLine("Velocidad = {0}", velocidad += 10);
}

class Taxi : Auto
{
    public override void Acelerar()
        => Console.WriteLine("Velocidad = {0}", velocidad += 5);
}
```

<details>

<summary> ▶️ </summary>
<br>
  
Al no especificar el modificador de acceso de la variable "velocidad", el compilador la asigna como privada por default. Haciendo asi que las clases que hereden de Auto no puedan acceder a ella. La solucion es tan sencilla como declarar la variable "velocidad" como protected.
  
</details>

<br><hr><br>

```4)``` Contestar sobre el siguiente programa:

```c#
Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");

class Auto
{
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
    public Auto() { }
}

class Taxi : Auto
{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) => this.Pasajeros = pasajeros;
}
```
¿Por qué no es necesario agregar ***:base*** en el constructor de ***Taxi***? Eliminar el segundo constructor de la clase ***Auto*** y modificar la clase ***Taxi*** para el programa siga funcionando

<details>

<summary> ▶️ </summary>
<br>

No hace falta agregar :base en el constructor de taxi porque la unica variable que se necesita inicializar es "Pasajeros". Esto indica que todos los objetos de que se creen de tipo taxi van a tener "Ford" como marca.    
    
```c#
Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");

class Auto {
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
}

class Taxi : Auto {
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) : base("Honda") => this.Pasajeros = pasajeros;
}
```
  
</details>

<br><hr><br>

```5)``` ¿Qué líneas del siguiente código provocan error de compilación y por qué?

```c#
class Persona
{
    public string Nombre { get; set; }
}

public class Auto
{
    private Persona _dueño1, _dueño2;
    public Persona GetPrimerDueño() => _dueño1;
    protected Persona SegundoDueño
    {
        set => _dueño2 = value;
    }
}
```

<details>

<summary> ▶️ </summary>
<br>

Como la clase persona no tiene asignado un modificador de acceso, el compilador la asgina como privada. Esto hace que la clase Auto no pueda acceder a ella. Las lineas que producen error de compilacion son:
    
```c#
public Persona GetPrimerDueño() => _dueño1;
protected Persona SegundoDueño {
    set => _dueño2 = value;
}
```
  
</details>

<br><hr><br>

```6)``` Señalar el error en cada uno de los siguientes casos:

<table align="center">
<tr>
<td> 6.1 </td> <td> 6.2 </td> <td> 6.3 </td>
</tr>
<tr>
<td>

```c#
class A
{
    public string M1()
        => "A.M1";
}

class B : A
{
    public override string M1()
        => "B.M1";
}
```
</td>
<td>

```c#
class A
{
    public abstract string M1();
}

class B : A
{
    public override string M1()
        => "B.M1";
}
```
 
</td>
<td>

```c#
abstract class A
{
    public abstract string M1()
        => "A.M1";
}
    
class B : A
{
    public override string M1()
        => "B.M1";
}
```
</td>
</tr>
</table>
 
<table align="center">
<tr>
<td> 6.4 </td> <td> 6.5 </td> <td> 6.6 </td>
</tr>
<tr>
<td>

```c#
class A
{
    public override string M1()
        => "A.M1";
}
    
class B : A
{
    public override string M1()
        => "B.M1";
}
```
 
</td>
<td>

```c#
class A
{
    public virtual string M1()
        => "A.M1";
}
    
class B : A
{
    protected override string M1()
        => "B.M1";
}
```
</td>
<td>

```c#
class A
{
    public static virtual string M1()
        => "A.M1";
}
    
class B : A
{
    public static override string M1()
        => "B.M1";
}
```

</td>
</tr>
</table>    
    
<table align="center">
<tr>
<td> 6.7 </td> <td> 6.8 </td> <td> 6.9 </td>
</tr>
<tr>
<td>

```c#
class A
{
    virtual string M1() => "A.M1";
}
    
class B : A
{
    override string M1() => "B.M1";
}
```
</td>
<td>

```c#
class A
{
    protected A(int i) { }
}
    
class B : A
{
    B() { }
}
```
 
</td>
<td>

```c#
class A
{
    private int _id;
    protected A(int i) => _id = i;
}
    
class B : A
{
    B(int i):base(5) {
        _id=i;
    }
}
```
</td>
</tr>
</table>    
    
<table align="center">
<tr>
<td> 6.10 </td> <td> 6.11 </td> <td> 6.12 </td>
</tr>
<tr>
<td>

```c#
class A
{
    private int Prop
    {
        set; public get;
    }
}
    
class B : A
{
}
```
 
</td>
<td>

```c#
abstract class A
{
    public abstract int Prop
        {set; get;}
}
    
class B : A
{
    public override int Prop
    {
        get => 5;
    }
}
```
</td>
<td>

```c#
abstract class A
{
    public int Prop {set; get;}
}
    
class B : A
{
    public override int Prop {
        get => 5;
        set {}
    }
}
```
 
</td>
</tr>
</table>


<details>

<summary> ▶️ </summary>
<br>
  
<table align="center">
<tr>
<td> 6.1 </td> <td> 6.2 </td> <td> 6.3 </td>
</tr>
<tr>
<td>

```c#
class A
{
    public string M1()
        => "A.M1";
}

class B : A
{
    public override string M1()
        => "B.M1";
}
    
/* El metodo de la clase B esta
haciendo override a un metodo que
no es virtual o abstract. */
```
</td>
<td>

```c#
class A
{
    public abstract string M1();
}

class B : A
{
    public override string M1()
        => "B.M1";
}
/* Los metodos abstractos tienen que 
declararse en clases abstractas. Pero 
en este caso class A no lo es. */
```
 
</td>
<td>

```c#
abstract class A
{
    public abstract string M1()
        => "A.M1";
}
    
class B : A
{
    public override string M1()
        => "B.M1";
}
    
/* Los metodos abstractos no pueden
ser desarrollados en la clase abstracta,
solo se declaran para luego ser 
desarrollados en clases herederas. */

```
</td>
</tr>
</table>
 
<table align="center">
<tr>
<td> 6.4 </td> <td> 6.5 </td> <td> 6.6 </td>
</tr>
<tr>
<td>

```c#
class A
{
    public override string M1()
        => "A.M1";
}
    
class B : A
{
    public override string M1()
        => "B.M1";
}
    
/* Para que una clase utilice 
override en un metodo, la clase
debe ser heredera de otra que tenga 
ese metodo como virtual o abstract. */
```
 
</td>
<td>

```c#
class A
{
    public virtual string M1()
        => "A.M1";
}
    
class B : A
{
    protected override string M1()
        => "B.M1";
}
    
/* Un metodo que esta haciendo override 
no puede cambiar el tipo de acceso del 
metodo original. A = public ; B = protected. */
```
</td>
<td>

```c#
class A
{
    public static virtual string M1()
        => "A.M1";
}
    
class B : A
{
    public static override string M1()
        => "B.M1";
}

/* Los metodos estaticos no pueden
hacer override (tampoco pueden ser
virtual o abstract) */

```

</td>
</tr>
</table>    
    
<table align="center">
<tr>
<td> 6.7 </td> <td> 6.8 </td> <td> 6.9 </td>
</tr>
<tr>
<td>

```c#
class A
{
    virtual string M1() => "A.M1";
}
    
class B : A
{
    override string M1() => "B.M1";
}
    
/* Como no se especifica el tipo de 
acceso del metodo de A, se le asigna
private, pero los tipos virtual o 
abstract deben ser public o protected. */
```
</td>
<td>

```c#
class A
{
    protected A(int i) { }
}
    
class B : A
{
    B() { }
}
    
/* B esta queriendo utilizar el contructor
vacio de A. Pero como se declaró otro
constructor distinto al vacío, a este
último hay que declararlo explicitamente
para que pueda ser utilizado. */
```
 
</td>
<td>

```c#
class A
{
    private int _id;
    protected A(int i) => _id = i;
}
    
class B : A
{
    B(int i):base(5) {
        _id=i;
    }
}
    
/* La variable _id fue declarada
como privada en A, por lo tanto B
no tiene acceso a ella. */
```
</td>
</tr>
</table>    
    
<table align="center">
<tr>
<td> 6.10 </td> <td> 6.11 </td> <td> 6.12 </td>
</tr>
<tr>
<td>

```c#
class A
{
    private int Prop
    {
        set; public get;
    }
}
    
class B : A
{
}
    
/* El problema está en que la
propiedad Prop es privada, pero
quiere declarar un getter como 
publico. Esto es una incoherencia 
ya que todo el "bloque" de la 
propiedad va a ser privado. */
```
 
</td>
<td>

```c#
abstract class A
{
    public abstract int Prop
        {set; get;}
}
    
class B : A
{
    public override int Prop
    {
        get => 5;
    }
}

/* Como la propiedad Prop se declara
como abstracta, B debe implementarla 
de forma completa, o sea, debe 
incluir el setter. */
```
</td>
<td>

```c#
abstract class A
{
    public int Prop {set; get;}
}
    
class B : A
{
    public override int Prop {
        get => 5;
        set {}
    }
}
    
/* La propiedad declarada en A, 
no es ni virtual ni abstracta, 
por lo que no se le puede hacer 
un override desde B. */
```
 
</td>
</tr>
</table>
  
</details>

<br><hr><br>

```7)``` Ofrecer una implementación polimórfica para mejorar el siguiente programa:

```c#
Imprimidor.Imprimir(new A(), new B(), new C(), new D());

class A {
    public void ImprimirA() => Console.WriteLine("Soy una instancia A");
}

class B {
    public void ImprimirB() => Console.WriteLine("Soy una instancia B");
}

class C {
    public void ImprimirC() => Console.WriteLine("Soy una instancia C");
}

class D {
    public void ImprimirD() => Console.WriteLine("Soy una instancia D");
}

static class Imprimidor {
    public static void Imprimir(params object[] vector) {
        foreach (object o in vector) {
            if (o is A) { (o as A)?.ImprimirA(); }
            else if (o is B) { (o as B)?.ImprimirB(); }
            else if (o is C) { (o as C)?.ImprimirC(); }
            else if (o is D) { (o as D)?.ImprimirD(); }
        }   
    }
}
```

<details>

<summary> ▶️ </summary>
<br>
  
```c#
Imprimidor.Imprimir(new A(), new B(), new C(), new D());

abstract class Letra {
    public virtual void Imprimir() => Console.Write("Soy una instancia ");
}
class A : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("A");
    }
}
class B : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("B");
    }
}
class C : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("C");
    }
}
class D : Letra {
    public override void Imprimir() {
        base.Imprimir();
        Console.WriteLine("D");
    }
}

static class Imprimidor {
    public static void Imprimir(params object[] vector) {
        foreach (Letra L in vector) {
            L.Imprimir();
        }
    }
}
```
  
</details>

<br><hr><br>

```8)``` Crear un programa para gestionar empleados en una empresa. Los empleados deben tener las propiedades públicas de sólo lectura ***Nombre***, ***DNI***, ***FechaDeIngreso***, ***SalarioBase*** y ***Salario***. Los valores de estas propiedades (a excepción de ***Salario*** que es una propiedad calculada) deben establecerse por medio de un constructor adecuado.

Existen dos tipos de empleados: ***Administrativo*** y ***Vendedor***. No se podrán crear objetos de la clase padre ***Empleado***, pero sí de sus clases hijas (***Administrativo*** y ***Vendedor***). Aparte de las propiedades de solo lectura mencionadas, el administrativo tiene otra propiedad pública de lectura/escritura llamada ***Premio*** y el vendedor tiene otra propiedad pública de lectura/escritura llamada ***Comision***.

La propiedad de solo lectura ***Salario***, se calcula como el salario base más la comisión o el premio según corresponda.

Las clases tendrán además un método público llamado ***AumentarSalario()*** que tendrá una implementación distinta en cada clase. En el caso del administrativo se incrementará el salario base en un 1% por cada año de antigüedad que posea en la empresa, en el caso del vendedor se incrementará el salario base en un 5% si su antigüedad es inferior a 10 años o en un 10% en caso contrario.

El siguiente código (ejecutado el día 9/4/2022) debería mostrar en la consola el resultado indicado:

```c#
Empleado[] empleados = new Empleado[] {
    new Administrativo("Ana", 20000000, DateTime.Parse("26/4/2018"), 10000) {Premio=1000},
    new Vendedor("Diego", 30000000, DateTime.Parse("2/4/2010"), 10000) {Comision=2000},
    new Vendedor("Luis", 33333333, DateTime.Parse("30/12/2011"), 10000) {Comision=2000}
};
foreach (Empleado e in empleados)
{
    Console.WriteLine(e);
    e.AumentarSalario();
    Console.WriteLine(e);
}
```

Salida por consola:

```
Administrativo Nombre: Ana, DNI: 20000000 Antigüedad: 3
Salario base: 10000, Salario: 11000
-------------
Administrativo Nombre: Ana, DNI: 20000000 Antigüedad: 3
Salario base: 10300, Salario: 11300
-------------
Vendedor Nombre: Diego, DNI: 30000000 Antigüedad: 12
Salario base: 10000, Salario: 12000
-------------
Vendedor Nombre: Diego, DNI: 30000000 Antigüedad: 12
Salario base: 11000, Salario: 13000
-------------
Vendedor Nombre: Luis, DNI: 33333333 Antigüedad: 10
Salario base: 10000, Salario: 12000
-------------
Vendedor Nombre: Luis, DNI: 33333333 Antigüedad: 10
Salario base: 11000, Salario: 13000
-------------

```

***Recomendaciones***: Observar que el método ***AumentarSalario()*** y la propiedad de solo lectura
***Salario*** en la clase ***Empleado*** pueden declararse como abstractos. Intentar no utilizar campos sino
propiedades auto-implementadas todas las veces que sea posible. Además sería deseable que la
propiedad ***SalarioBase*** definida en ***Empleado*** sea pública para la lectura y protegida para la
escritura, para que pueda establecerse desde las subclases ***Administrativo*** y ***Vendedor***

<details>

<summary> ▶️ </summary>
<br>

Program.cs
    
```c#
using Teoria6;

    Empleado[] empleados = new Empleado[] {
        new Administrativo("Ana", 20000000, DateTime.Parse("26/4/2018"), 10000) {Premio=1000},
        new Vendedor("Diego", 30000000, DateTime.Parse("2/4/2010"), 10000) {Comision=2000},
        new Vendedor("Luis", 33333333, DateTime.Parse("30/12/2011"), 10000) {Comision=2000}
    };

    foreach (Empleado e in empleados) {
        Console.WriteLine(e);
        e.AumentarSalario();
        Console.WriteLine(e);
    }
```
    
<hr><br>
    
Empleado.cs

```c#
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
```
  
<hr><br>    
    
Administrativo.cs
    
```c#
namespace Teoria6;

class Administrativo : Empleado {
    public Administrativo(string nombre, int _DNI, DateTime fecha, double salario) : base(nombre, _DNI, fecha, salario) { }

    public double Premio { get; set;}

    public override double Salario {
        get {
            return SalarioBase + Premio;
        }
    }

    public override void AumentarSalario() {
        SalarioBase = SalarioBase + (SalarioBase * Antiguedad * 0.01);
    }

    public override string ToString()
    {
        return "Administrativo " + base.ToString() + ", Salario: " + Salario +
        "\n-------------";
    }
}
```
  
<hr><br>    
    
Vendedor.cs

```c#
namespace Teoria6;

class Administrativo : Empleado {
    public Administrativo(string nombre, int _DNI, DateTime fecha, double salario) : base(nombre, _DNI, fecha, salario) { }

    public double Premio { get; set;}

    public override double Salario {
        get {
            return SalarioBase + Premio;
        }
    }

    public override void AumentarSalario() {
        SalarioBase = SalarioBase + (SalarioBase * Antiguedad * 0.01);
    }

    public override string ToString()
    {
        return "Administrativo " + base.ToString() + ", Salario: " + Salario +
        "\n-------------";
    }
}
```

</details>
