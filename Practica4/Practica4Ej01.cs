using Teoria2;

try
{
    string linea;
    int i=1;
    StreamReader sr = new System.IO.StreamReader("input123.txt");
    Persona p = new Persona();
    Console.WriteLine("{0,-2}) {1,-25} {2,5} {3,10}", "N°", "Nombre", "Edad", "DNI");
    while ((linea = sr.ReadLine()) != null)
    {
        string[] terminos = linea.Split(",");
        p.Nombre = terminos[0];
        p.Edad = Int32.Parse(terminos[1]);
        p.DNI = terminos[2];
        Console.WriteLine("{0,-2}) {1,-25} {2,5} {3,10}", i, p.Nombre, p.Edad, p.DNI);
        i++;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();

