char c;
char? c2;
string? st;
c = "";             // "" se usa para declarar strings
c = '';             // No se puede declarar un char vacío 
c = null;           // Char no acepta valores null
c2 = null;
c2 = (65 as char?);
st = "";
st = '';            // '' se usa para declarar chars
st = null;
st = (char)65;      // No se puede convertir explicitamente un char a un string
st = (string)65;    // No se puede convertir explicitamente un int a un string
st = 47.89.ToString();

Console.ReadKey();