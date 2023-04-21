<h1 align="center">Practica 1</h1>

``1.`` Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos ***WriteLine()*** y ***Write()*** de la clase ***System.Console*** ¿Cómo funciona el método ***ReadKey()*** de la misma clase? Escribir un programa que imprima en la consola la frase “Hola Mundo” haciendo una pausa entre palabra y palabra esperando a que el usuario presione una tecla para continuar. ``Tip: usar los métodos ReadKey() y Write() de la clase System.Console.``

<details>

<summary> ▶️ </summary>
<br>
  
```c#
Console.Write("Hola");
Console.ReadKey();
Console.Write(", ");
Console.ReadKey();
Console.Write("Mundo");
Console.ReadKey();
```
  
</details>

```2.``` Investigar por las secuencias de escape \n, \t , \" y \\. Escribir un programa que las utilice
para imprimir distintos mensajes en la consola.

```3.``` El carácter ***@*** delante de un ***string*** desactiva los códigos de escape. Probar el siguiente
fragmento de código, eliminar el carácter ***@*** y utilizar las secuencias de escape necesarias para
que el programa siga funcionando de igual manera

```c#
string st = @"c:\windows\system";
Console.WriteLine(st);
```

<details>

<summary> ▶️ </summary>
<br>
  
```c#
string st = "c:\\windows\\system";
Console.WriteLine(st);
```
  
</details>

```4.``` Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un
saludo personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una
línea en blanco. Para ingresar un ***string*** desde el teclado utilizar ***Console.ReadLine()***.

<details>

<summary> ▶️ </summary>
<br>
  
```c#
string st = Console.ReadLine();
if (st.Length != 0){
    Console.WriteLine("Hola " + st);
} else {
    Console.WriteLine("Hola Mundo");
}
```
  
</details>

```5.``` Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el
nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María”
debe imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso,
debe imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha
ingresado una línea vacía.

- ```a)``` utilizando if ... else if
  
- ```b)``` utilizando switch
















