// Al cifrar un espacio en blanco su valor va ser menor que 'A' al descifrarlo, por lo que se le va a sumar 26.
// ¿Que forma de declarar aux es la optima?

string texto = "Hola Mundo!";
int[] clave = {5, 3, 9, 7};
string textoCifrado = Cifrar(texto.ToUpper(), clave);
string textoDescifrado = Descifrar(textoCifrado, clave);
Console.WriteLine($"Texto original: {texto.ToUpper()}");
Console.WriteLine($"Texto cifrado: {textoCifrado}");
Console.WriteLine($"Texto descifrado: {textoDescifrado}");

string Cifrar(string texto, int[] clave)
{
    Queue<int> cola = new Queue<int>(clave);
    string textoCifrado = "";
    foreach (char c in texto)
    {
        cola.Enqueue(cola.Peek());
        int aux = (int)c + cola.Dequeue();          // aux
        if (aux > 'Z')
        {
            aux -= 26;
        }
        textoCifrado += (char)aux;
    }
    return textoCifrado;
}

string Descifrar(string texto, int[] clave)
{
    Queue<int> cola = new Queue<int>(clave);
    string textoDescifrado = "";
    int aux;                                        // aux
    foreach(char c in texto)
    {
        cola.Enqueue(cola.Peek());
        aux = (int)c - cola.Dequeue();
        if (aux < 'A') 
        {
            aux += 26;
        }
        textoDescifrado += (char)aux;
    }
    return textoDescifrado;
}

Console.ReadKey();