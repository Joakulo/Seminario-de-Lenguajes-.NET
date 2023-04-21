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
```
  
</details>

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

```
</td>
<td>

```c#

```
 
</td>
</tr>
</table>

</details>


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
  
```c#
```
  
</details>
