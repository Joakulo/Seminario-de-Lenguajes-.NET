using Teoria2;

try
{
    string linea;
    int i=1;
    StreamReader sr = new System.IO.StreamReader("input123.txt");
    Persona p;
    string[] terminos;
    Console.WriteLine("{0,-2}) {1,-25} {2,5} {3,10}", "N°", "Nombre", "Edad", "DNI");
    while ((linea = sr.ReadLine()) != null)
    {
        terminos = linea.Split(",");
        p = new Persona(terminos[0], int.Parse(terminos[1]), terminos[2]);
        Console.Write("{0,-2})", i);
        p.Imprimir();
        i++;
    }

    Console.WriteLine();

    sr = new System.IO.StreamReader("input.txt");
    Persona pMin = new Persona("NULL", 1024, "NULL");
    while ((linea = sr.ReadLine()) != null)
    {
        terminos = linea.Split(",");
        p = new Persona(terminos[0], int.Parse(terminos[1]), terminos[2]);
        if (pMin.EsMayorQue(p))
        {
            pMin.setNombre(p.getNombre());
            pMin.setEdad(p.getEdad());
            pMin.setDNI(p.getDNI());
        }   
    }

    Console.Write("   ");
    pMin.Imprimir();

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();

