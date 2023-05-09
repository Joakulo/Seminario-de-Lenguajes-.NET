double[,] aaa = new double[,]
{ 
    {1.6543,2.4231,3.8765,4.2754},
    {5.2643,6.8675,7.5231,8.0987},
    {9.4623,10.4231,11.8790,12.5236},
    {13.8653,14.2136,15.9642,16.0907}
};

double[] array = new double[aaa.GetLength(0)];

try
{
    array = GetDiagonalPrincipal(aaa);

    for (int i=0; i < array.GetLength(0) ; i++)
    {
        Console.Write(array[i] + " | ");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

double[] GetDiagonalPrincipal(double[,] matriz)
{
    if (matriz.GetLength(0) == matriz.GetLength(1))
    {
        double[] array = new double[matriz.GetLength(0)];
        for (int i = 0; i<matriz.GetLength(0); i++)
        {
            array[i]=matriz[i,i];
        }
        return array;
    } 
    else 
    {
        throw new ArgumentException("array");
    }
}

Console.WriteLine();

double[] array2 = new double[aaa.GetLength(0)];

try
{
    array2 = GetDiagonalSecundaria(aaa);

    for (int i=0; i < array2.GetLength(0) ; i++)
    {
        Console.Write(array2[i] + " | ");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
double[] GetDiagonalSecundaria(double[,] matriz)
{
    if (matriz.GetLength(0) == matriz.GetLength(1))
    {
        double[] array = new double[matriz.GetLength(0)];
        int j=matriz.GetLength(0) - 1;

        for (int i=0; i<matriz.GetLength(0); i++)
        {
            array[i]=matriz[i,j];
            j--;
        }

        return array;
    } 
    else 
    {
        throw new ArgumentException("array");
    }
}


Console.ReadKey();