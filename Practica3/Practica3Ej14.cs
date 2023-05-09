using System.Text;


int num = 35;
Console.WriteLine(aBinario(num));


string aBinario(int num)
{
    Stack<int> pila = new Stack<int>();
    while (num > 0)
    {
        pila.Push(num % 2);
        num = num / 2;
    }

    string Binario = "";
    int aux;

    while (pila.Count > 0)
    {
        aux = pila.Pop();
        Binario += aux.ToString();
    }

    Console.WriteLine(Binario);
    return Binario;
}

Console.ReadKey();