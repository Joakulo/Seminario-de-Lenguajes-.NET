Imprimir("Hola", "como","world", "!");

void Imprimir(params string[] palabras)
{
    foreach (string p in palabras)
    {
        Console.Write(p + " ");
    }
}

Console.ReadKey();