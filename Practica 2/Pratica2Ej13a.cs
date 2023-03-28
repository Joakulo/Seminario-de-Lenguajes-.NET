Meses M;

for (int i = 11 ; i>=0 ; i--)
{
    M = (Meses)i;
    Console.WriteLine(M);
}

Console.ReadKey();


enum Meses
{
    Enero, Febrero, Marzo, 
    Abril, Mayo, Junio, 
    Julio, Agosto, Septiembre, 
    Octubre, Noviembre, Diciembre
}