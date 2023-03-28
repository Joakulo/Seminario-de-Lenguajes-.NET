Console.Write("Ingrese un mes: ");
string Mes = Console.ReadLine();
bool ok = false;
Meses M;

for (Meses mes = Meses.Enero; mes <= Meses.Diciembre; mes++)
        {
            if (Mes == mes.ToString())
            {
                ok = true;
                break;
            }
        }

Console.WriteLine(ok);
Console.ReadKey();

enum Meses
{
    Enero, Febrero, Marzo, 
    Abril, Mayo, Junio, 
    Julio, Agosto, Septiembre, 
    Octubre, Noviembre, Diciembre
}