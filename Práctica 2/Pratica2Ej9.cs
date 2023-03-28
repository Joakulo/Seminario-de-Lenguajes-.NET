﻿/* 
Un string es inmutable, es de solo lectura. Su valor no se puede modificar una vez creado.
Los metodos que parecen modificar un string, en realidad devuelven un nuevo objeto string que contiene la modificación.

Un StringBuilder es mutable, las operaciones realizadas sobre la cadena se guardan en esa misma cadena
Crea un [buffer de cadenas] que ofrece un mejor rendimiento si el programa realiza muchas manipulaciones de cadena.
*/
using System.Text;

string s1 = "Hello ";
string s2 = s1;         // ¿Apunta al mismo string que s1 o a uno distinto creado para s2?
s1 += "World";

Console.WriteLine($"s1 = {s1}");
Console.WriteLine($"s2 = {s2}");
Console.WriteLine();


Random r = new Random();
StringBuilder sr = new StringBuilder("");
for (int i = 0; i<100; i++)
{
    sr.Append((char)r.Next(256));
}

Console.WriteLine(sr);

Console.ReadKey();