char[] separador = {'+','-','*','/'};
string[] subcadenas = new string[2];
bool ok = true;

while (ok)
{
    try
    {
        string expresion;
        Console.Write("Ingrese una expresion binaria: ");
        expresion = Console.ReadLine();
        subcadenas = expresion.Split(separador);
        chequearNumeros(subcadenas);
        chequearCantStrings(subcadenas);
        chequearCantOperandos(expresion);
        string operando = transformarOperando(expresion);
        double[] nums = transformarNums(subcadenas);
        double result = realizarOperacion(operando, nums);

        Console.WriteLine($"{result:0.00}");
        ok = false;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message + "\n");
    }
}



void chequearNumeros(string[] subcadenas)
{
    for (int i=0; i<subcadenas.Length; i++)
    {
        foreach(char c in subcadenas[i])
        {
            if (((c < 48) | (57 < c)) & (c != 44))
            {
                throw new Exception("La expresion no esta formada por numeros.");
            }
        }
    }
}

void chequearCantStrings(string[] subcadenas)
{
    if (subcadenas.Length != 2)
    {
        throw new Exception("Cantidad de numeros invalida.");
    }
}

void chequearCantOperandos(string expresion)
{
    int aux = 0;
    foreach (char c in expresion)
    {
        if ((c == '+') | (c == '-') | (c == '/') | (c == '*'))
        {
            aux++;
        }
    }
    if (aux == 1) 
    {
        return;
    } else {
        throw new Exception("Cantidad de operadores invalida.");
    }
}

string transformarOperando(string expresion)
{
    string operador = "nada";
    foreach (char c in expresion)
    {
        if (c == '+') {
            operador = "suma";
        } 
        else if (c == '-') {
            operador = "resta";
        } 
        else if (c == '*') {
            operador = "mul";
        } 
        else if (c == '/'){
            operador = "div";
        }
    }
    return operador;
}

double[] transformarNums(string[] subcadenas)
{
    double[] array = new double[2];
    array[0] = double.Parse(subcadenas[0]);
    array[1] = double.Parse(subcadenas[1]);
    return array;
}

double realizarOperacion(string operando, double[] nums)
{
    double result = 0.0;
    if (operando == "suma") {
        result = nums[0] + nums[1];
    } 
    else if (operando == "resta") {
       result = nums[0] - nums[1];
    } 
    else if (operando == "mul") {
       result = nums[0] * nums[1];
    } 
    else if (operando == "div"){
       result = nums[0] / nums[1];
    }
    return result;
}

Console.ReadKey();