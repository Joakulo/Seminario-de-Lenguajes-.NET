<h1 align="center">Practica 1</h1>

<div align = "center"  id="Ejercicio_1"> 
  
<h2> Indice: </h2>

| [1](#Ejercicio_1) | [2](#Ejercicio_2) | [3](#Ejercicio_3) | [4](#Ejercicio_4) | [5](#Ejercicio_5) | [6](#Ejercicio_6) | [7](#Ejercicio_7) | [8](#Ejercicio_8) | [9](#Ejercicio_9) | [10](#Ejercicio_10) | [11](#Ejercicio_11) | [12](#Ejercicio_12) | [13](#Ejercicio_13) | [14](#Ejercicio_14) | [15](#Ejercicio_15) | [16](#Ejercicio_16) | [17](#Ejercicio_17) | [18](#Ejercicio_18) | [19](#Ejercicio_19) | [20](#Ejercicio_20) | [21](#Ejercicio_21) |
===

</div>

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

<hr id="Ejercicio_2"><br  id="Ejercicio_3">

```2.``` Investigar por las secuencias de escape \n, \t , \\" y \\\\. Escribir un programa que las utilice para imprimir distintos mensajes en la consola.

```3.``` El carácter ***@*** delante de un ***string*** desactiva los códigos de escape. Probar el siguiente fragmento de código, eliminar el carácter ***@*** y utilizar las secuencias de escape necesarias para que el programa siga funcionando de igual manera

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

<hr id="Ejercicio_4"><br>

```4.``` Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un saludo personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una línea en blanco. Para ingresar un ***string*** desde el teclado utilizar ***Console.ReadLine()***.

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
  
<hr id="Ejercicio_5"><br>
  
```5.``` Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María” debe imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso, debe imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha ingresado una línea vacía.

- ```a)``` utilizando ***if ... else if***
  
- ```b)``` utilizando ***switch***

<details>

<summary> ▶️ </summary>
<br>

<table align="center">
<tr>
<td> if ... else if </td> <td> switch </td>
</tr>
<tr>
<td>

 ```c#
Console.WriteLine("Ingrese su nombre");
string st = Console.ReadLine();

if (st == "Juan"){
    Console.WriteLine("Hola amigo");
} else if (st == "Maria"){
    Console.WriteLine("Buen día señora");
} else if (st == "Alberto"){
    Console.WriteLine("Hola Alberto");
} else if (st.Length == 0){
    Console.WriteLine("Buen día mundo");
} else {
    Console.WriteLine("Buen dia " + st);
}
```
</td>
<td>

```c#
Console.WriteLine("Ingrese su nombre");
string st = Console.ReadLine();

switch (st)
{
    case "Juan":
        Console.WriteLine("Hola amigo");
        break;
    
    case "Maria":
        Console.WriteLine("Buen día señora");
        break;
    
    case "Alberto":
        Console.WriteLine("Hola Alberto");
        break;

    case "":
        Console.WriteLine("Buen día mundo");
        break;

    default:
        Console.WriteLine("Buen dia " + st);
        break;

}
```
 
</td>
</tr>
</table>

</details>

<hr id="Ejercicio_6"><br>

```6.``` Utilizar ***Console.ReadLine()*** para leer líneas de texto (secuencia de caracteres que finaliza al presionar ***< ENTER >***) por la consola. Por cada línea leída se debe imprimir la cantidad de caracteres de la misma. El programa termina al ingresar la cadena vacía. (si ***st*** es una variable de tipo ***string***, entonces ***st.Length*** devuelve la cantidad de caracteres del ***string***)

<details>

<summary> ▶️ </summary>
<br>
  
```c#
string st = Console.ReadLine();

while (st.Length != 0){
    Console.WriteLine(st.Length);
    st = Console.ReadLine();
}
```
  
</details>

<hr id="Ejercicio_7"><br>

```7.``` Qué hace la instrucción ***Console.WriteLine("100".Length);*** ?
  
  <details>

<summary> ▶️ </summary>
<br>
  
```c#
Console.WriteLine("100".Length);

    // Output: 3
```
  
</details>

<hr id="Ejercicio_8"><br>

```8.``` Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción: Console.WriteLine(st=Console.ReadLine());?
  
<details>

<summary> ▶️ </summary>
<br>

Sí lo es, funciona correctamente.
```c#
string st;
Console.WriteLine(st=Console.ReadLine());

/*
Input: 
  Hola Mundo!

Output:
  Hola Mundo!
  Hola Mundo!
*/
```
  
</details>

<hr id="Ejercicio_9"><br>

```9.``` Escribir un programa que lea dos palabras separadas por un blanco que terminan con ***< ENTER >***, y determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas). ```Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1] devuelve el último carácter de st.```

<details>

<summary> ▶️ </summary>
<br>
  
```c#
string st = Console.ReadLine();
bool j = true;

for (int i = 0; i < (st.Length / 2.0) ; i++) {
    if (st[i] != st[st.Length - (i+1)]) {
        j = false;
    }
}

if (j) {
    Console.WriteLine("Son iguales");
} else {
    Console.WriteLine("Son dinstintas");
}
```
  
</details>

<hr id="Ejercicio_10"><br>

```10.``` Escribir un programa que imprima en la consola todos los números que sean múltiplos de 17 o de 29 comprendidos entre 1 y 1000

<details>

<summary> ▶️ </summary>
<br>
  
```c#
for (int i = 17; i < 1000; i++) {
    if ((i % 17 == 0) | (i % 29 == 0)) {
        Console.WriteLine(i);
    }
}
```
  
</details>

<hr id="Ejercicio_11"><br>

```11.``` Comprobar el funcionamiento del siguiente fragmento de código, analizar el resultado y contestar las preguntas
  
```c#
Console.WriteLine("10/3 = " + 10 / 3);
Console.WriteLine("10.0/3 = " + 10.0 / 3);
Console.WriteLine("10/3.0 = " + 10 / 3.0);
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);
```

¿Qué se puede concluir respecto del operador de división ***“/”*** ?
  
¿Cómo funciona el operador ***+*** entre un ***string*** y un dato numérico?  
  
<details>

<summary> ▶️ </summary>
<br>
Output:
  
```
  10/3 = 3
  10.0/3 = 3,3333333333333335
  10/3.0 = 3,3333333333333335
  Si a y b son variables enteras, si a=10 y b=3
  entonces a/b = 3
  Si c es una variable double, c=3
  entonces a/c = 3,3333333333333335
```
  
El operador de division ***"/"*** funciona tanto para ***int's*** como para ***double's***. Pero el resultado va a depender de los operandos, si ambos son de tipo ***int***, el resultado será de tipo ***int***. Pero, con que uno solo de esos sea de tipo ***double*** alcanza para que el resultado también sea de tipo ***double***.
 
Entre un ***string*** y un tipo ***numerico***, el operador ***+*** concatena ambos datos para guardarlos en un nuevo ***string***. 

</details>

<hr id="Ejercicio_12"><br>

```12.``` Escribir un programa que imprima todos los divisores de un número entero ingresado desde la consola. Para obtener el entero desde un ***string st*** utilizar ***int.Parse(st)***.
  
<details>

<summary> ▶️ </summary>
<br>
  
```c#
string st = Console.ReadLine();
int j = int.Parse(st);
 
for (int i = 1; i <= j; i++){
    if (j % i == 0){
        Console.WriteLine(i);
    }
}
```
  
</details>

<hr id="Ejercicio_13"><br>

```13.``` Escribir un programa que calcule la suma de dos números reales introducidos por teclado y muestre el resultado en la consola (utilizar ***double.Parse(st)*** para obtener el valor ***double*** a partir del ***string st***.

<details>

<summary> ▶️ </summary>
<br>
  
```c#
Console.Write("Ingrese un numero: ");
string st = Console.ReadLine();
double a = double.Parse(st);

Console.Write("Ingrese otro numero: ");
st = Console.ReadLine();
double b = double.Parse(st);

double c = a + b;
Console.WriteLine(c);
```
  
</details>  

<hr id="Ejercicio_14"><br>

```14.``` Escribir un programa que multiplique por 365 el número entero ingresado por el usuario desde la consola. El resultado debe imprimirse en la consola dígito por dígito, separado por un espacio comenzando por el dígito menos significativo al más significativo.  
  
<details>

<summary> ▶️ </summary>
<br>
  
```c#
Console.Write("Ingrese un numero: ");
int a = 365 * int.Parse(Console.ReadLine());
string valor = a.ToString();

for (int i = valor.Length-1; i>=0; i--) {
    Console.Write(valor[i] + " ");
}
```
  
</details>    

<hr id="Ejercicio_15"><br>

```15.``` Escribir un programa que solicite un año por pantalla y diga si es bisiesto. Un año es bisiesto si es divisible por 4 pero no por 100. Si es divisible por 100, para ser bisiesto debe ser divisible por 400  
  
<details>

<summary> ▶️ </summary>
<br>
  
<table align="center">
<tr>
<td> Solucion 1 </td> <td> Solucion 2 </td>
</tr>
<tr>
<td>

```c#
string st = Console.ReadLine();
int j=int.Parse(st);
 
if (j % 4 != 0){
    Console.WriteLine("No bisiesto");
} else if (j % 100 != 0){
    Console.WriteLine("Bisiesto");
} else if (j % 400 == 0){
    Console.WriteLine("Bisiesto");
} else {
    Console.WriteLine("No bisiesto");
}
```
</td>
<td>

```c#
string st = Console.ReadLine();
int j=int.Parse(st);
 
if (j % 4 == 0){
    if (j % 100 != 0){
        Console.WriteLine("Bisiesto");
    } else if (j % 400 == 0){
        Console.WriteLine("Bisiesto");
    } else{
        Console.WriteLine("No Bisiesto");
    }
} else {
    Console.WriteLine("No Bisiesto");
}
```
 
</td>
</tr>
</table>
  
</details>    

<hr id="Ejercicio_16"><br>

```16.``` Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente expresión (tip: observar qué pasa cuando b = 0):
```c#
if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);
```

<details>

<summary> ▶️ </summary>
<br>

El ***if*** tiene dos ***statements*** que estan separados por un ***&*** simple, ¿cual es el problema? Que al momento de llegar al ***if***, se pregunta por ambos parentesis. Por lo tanto, si se ingresa el 0, el primer statement va a dar ***false***, pero cuando llegue al segundo va a preguntar por a/0, y esto tira una excepcion (***DivideByZeroException***). La solucion es tan simple como agregar un segundo ***&*** para que sea un ***and*** estricto, o sea, si el primero da ***false***, no pregunta por el segundo.  

```c#
if ((b != 0) && (a/b > 5)) Console.WriteLine(a/b);
```
  
</details> 

<hr id="Ejercicio_17"><br>

```17.``` Utilizar el operador ternario condicional para establecer el contenido de una variable entera con el menor valor de otras dos variables enteras.

<details>

<summary> ▶️ </summary>
<br>
  
```c#
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
 
int c = (a < b) ? a : b;
Console.WriteLine(c);
```
  
</details> 

<hr id="Ejercicio_18"><br>

```18.``` ¿Cuál es la salida por consola del siguiente código?

```c#
for (int i = 0; i <= 4; i++)
{
  string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
  Console.WriteLine(st);
} 
```
  
<details>

<summary> ▶️ </summary>
<br>

Output:
```
< 1
uno
dos
tres
> 3
```
  
</details>   

<hr id="Ejercicio_19"><br>

  
```19.``` Para cada una de las siguientes líneas de código verificar cuáles son permitidas por el compilador y en tal caso en qué estado quedan las variables involucradas en la declaración al ejecutarse:

```c#
int a, b, c;
int a; int b; int c, d;
int a = 1; int b = 2; int c = 3;
int b; int c; int a = b = c = 1;
int c; int a, b = c = 1;
int c; int a = 2, b = c = 1;
int a = 2, b, c, d = 2 * a;
int a = 2, int b = 3, int c = 4;
int a = 2; b = 3; c = 4;
int a; int c = a;
char c = 'A', string st = "Hola";
char c = 'A'; string st = "Hola";
char c = 'A', st = "Hola";
```

<details>

<summary> ▶️ </summary>
<br>
  
```c#
int a; int b; int c, d;                     // a, b, c, d quedan vacias
int a = 1; int b = 2; int c = 3;            // a = 1, b = 2, c = 3
int b; int c; int a = b = c = 1;            // a = 1, b = 1, c = 1
int c; int a, b = c = 1;                    // a vacia, b = 1, c = 1
int c; int a = 2, b = c = 1;                // a = 2, b = 1, c = 1
int a = 2, b, c, d = 2 * a;                 // a = 2, b = 4, c = 4, d = 4
int a = 2, int b = 3, int c = 4;            // No compila. Se debe reemplazar las "," por ";".
int a = 2; b = 3; c = 4;                    // Individualmente no compila. Antes de asignar valores se debe declarar su tipo.
int a; int c = a;                           // No compila. Se le intenta asignar el valor de "a" a "c", pero "a" no esta inicializada.
char c = 'A', string st = "Hola";           // No compila. Se debe reemplazar la "," por ";".
char c = 'A'; string st = "Hola";           // c = 'A', st = "Hola"
char c = 'A', st = "Hola";                  // No compila. "st" se esta declarando como "char" y se le quiere asignar un "string".
```
  
</details>    

<hr id="Ejercicio_20"><br>

```20.``` ¿Cuál es el problema del código siguiente y cómo se soluciona?

```c#
int i = 0;
for (int i = 1; i <= 10;)
{
  Console.WriteLine(i++);
}
```
                        
<details>

<summary> ▶️ </summary>
<br>

El problema es que la variable ***i***, se esta declarando dos veces. Depende que queramos que haga nuestro programa hay distintas soluciones.  
  
<table align="center">
<tr>
<td> Eliminar la primer declaracion </td> <td> Agregar una segunda variable </td>
</tr>
<tr>
<td>

```c#
for (int i = 1; i <= 10;) {
    Console.WriteLine(i++);
}
                        
/*Output:
1
2
3
4
5
6
7
8
9
10
*/                        
```
</td>
<td>

```c#
int j = 0;
for (int i = 1; i <= 10; i++) {
    Console.WriteLine(j++);
}
                       
/*Output:
0
1
2
3
4
5
6
7
8
9
*/                       
```
 
</td>
</tr>
</table>
  
</details>                        

<hr id="Ejercicio_21"><br>

```21.``` Analizar el siguiente código. ¿Cuál es la salida por consola?  
  
```c# 
int i = 1;
if (--i == 0)
{
  Console.WriteLine("cero");
}
if (i++ == 0)
{
  Console.WriteLine("cero");
}
Console.WriteLine(i)
```
  
<details>

<summary> ▶️ </summary>
<br>
  
```c#
int i = 1;
if (--i == 0)         //Resta, despues compara
{
  Console.WriteLine("cero");
}
if (i++ == 0)         //Compara, despues suma
{
  Console.WriteLine("cero");
}
Console.WriteLine(i)

/*Output:
cero
cero
1
*/
```
  
</details>
  
  
  
  
