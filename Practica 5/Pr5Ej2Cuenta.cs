namespace Teoria2;

class Cuenta{

    private int _monto;
    private int _ID;
    private static int s_cantIDs = 0;
    private static int s_cantDep = 0;
    private static int s_Depositado = 0;
    private static int s_cantExt = 0;
    private static int s_Extraido = 0;
    private static int s_Denegadas = 0;
    private static List<Cuenta> Lista = new List<Cuenta>();

    public Cuenta(){
        s_cantIDs++;
        _ID = s_cantIDs;
        Lista.Add(this);
        Console.WriteLine($"Se creo la cuenta Id={_ID}");
    }

    public Cuenta Depositar(int monto){
        _monto += monto;
        s_cantDep++;
        s_Depositado += monto;
        Console.WriteLine($"Se deposito {monto} en la cuenta {_ID} (Saldo = {_monto})");
        return this;
    }

    public Cuenta Extraer(int monto){
        if (_monto >= monto){
            _monto -= monto;
            s_cantExt++;
            s_Extraido += monto;
            Console.WriteLine($"Se extrajo {monto} de la cuenta {_ID} (Saldo = {_monto})");
        } else {
            Console.WriteLine("Operacion denegada - Saldo insuficiente");
            s_Denegadas++;
        }
        return this;
    }

    public static void ImprimirDetalle(){
        Console.WriteLine("CUENTAS CREADAS: {0}", s_cantIDs);
        Console.WriteLine("DEPOSITOS: {0,7} {2,2} - Total depositado: {1,5}",s_cantDep, s_Depositado, "");
        Console.WriteLine("EXTRACCIONES: {0,4} {2,2} - Total extraido: {1,7}", s_cantExt, s_Extraido, "");
        Console.WriteLine("{0,21} - Saldo: {1,16}", "", (s_Depositado - s_Extraido));
        Console.WriteLine(" * Se denegaron {0} extracciones por falta de fondos", s_Denegadas);

    }

    public static List<Cuenta> GetCuentas(){
        List<Cuenta> aux = new List<Cuenta>();
        foreach (Cuenta C in Lista){
            aux.Add(C);
        }
        return aux;
    }

}