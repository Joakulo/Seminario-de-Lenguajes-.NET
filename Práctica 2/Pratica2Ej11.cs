/*
El método Split de la clase string en C# sirve para dividir una cadena de texto en subcadenas más pequeñas, utilizando un carácter o conjunto de  caracteres como separador.

La sintaxis básica del método Split es la siguiente:
string[] subcadenas = cadena.Split(separador);

Donde "cadena" es la cadena de texto que queremos dividir y "separador" es el carácter o conjunto de caracteres que se utilizará para separar la cadena en subcadenas. El método devuelve un arreglo de cadenas (string[]) que contiene todas las subcadenas resultantes.

Por ejemplo, si tenemos la cadena "Hola,Mundo,desde,C#", podemos usar el método "Split" para dividirla en subcadenas separadas por la coma (,) de la siguiente manera:

string cadena = "Hola,Mundo,desde,C#";
string[] subcadenas = cadena.Split(',');
foreach (string subcadena in subcadenas) {
    Console.WriteLine(subcadena);
}

Output:
Hola
Mundo
desde
C#


*/

Console.Write("Ingrese una frase: ");
string cadena = Console.ReadLine();
string[] subcadenas = cadena.Split(" ");

foreach (string palabra in subcadenas)
{
    Console.WriteLine(palabra);
}

Console.ReadKey();