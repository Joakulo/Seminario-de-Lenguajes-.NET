string expresion = "y = x(3(x+1) - (x^2)3x)";
Console.WriteLine($"Expresion: {expresion}");
Console.WriteLine(analisis(expresion));

string analisis(string exp)
{
    Stack<char> pila = new Stack<char>(); 
    foreach(char c in exp)
    {
        if (c == '(')
        {
            pila.Push(c);
        }
        else if (c == ')')
        {
            if (pila.Count > 0 )
            {
                pila.Pop();
            } 
            else 
            {
                return "Cadena invalida";
            }
        }
    }
    if (pila.Count == 0)
    {
        return "Cadena valida";
    } else {
        return "Cadena invalida";
    }
}

Console.ReadKey();