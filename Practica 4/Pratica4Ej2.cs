using Teoria2;

try
{
    string linea;
    int i=1;
    StreamReader sr = new System.IO.StreamReader("input123.txt");
    Persona p;
    Console.WriteLine("{0,-2}) {1,-25} {2,5} {3,10}", "N°", "Nombre", "Edad", "DNI");
    while ((linea = sr.ReadLine()) != null)
    {
        string[] terminos = linea.Split(",");
        p = new Persona(terminos[0], int.Parse(terminos[1]), terminos[2]);
        Console.Write("{0,-2})", i);
        p.Imprimir();
        i++;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();

