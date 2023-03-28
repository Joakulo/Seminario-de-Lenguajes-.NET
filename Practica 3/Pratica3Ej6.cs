double[,] A = new double[,]
{ 
    {91,71,19,21},
    {19,41,51,61},
    {51,61,71,81},
    {51,21,31,41}
    
};

double[,] B = new double[,]
{ 
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12},
    {13,14,15,16}
};

double[,] SSuma = Suma(A,B);
for (int i = 0; i < SSuma.GetLength(0); i++)
{
    for (int j = 0; j < SSuma.GetLength(1); j++)
    {
        Console.Write(SSuma[i, j] + " | ");
    }
    Console.WriteLine();
}

Console.WriteLine();

double[,] RResta = Resta(A,B);
for (int i = 0; i < RResta.GetLength(0); i++)
{
    for (int j = 0; j < RResta.GetLength(1); j++)
    {
        Console.Write(RResta[i, j] + " | ");
    }
    Console.WriteLine();
}

Console.WriteLine();

try
{
    double[,] Mul = Multiplicacion(A,B);
    for (int i = 0; i < Mul.GetLength(0); i++)
    {
        for (int j = 0; j < Mul.GetLength(1); j++)
        {
            Console.Write(Mul[i, j] + " | ");
        }
        Console.WriteLine();
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}



double[,]? Suma(double[,] A, double[,] B){
    if ((A.GetLength(0) == B.GetLength(0)) & (A.GetLength(1) == B.GetLength(1))){
        double[,] C = new double[A.GetLength(0),A.GetLength(1)];
        for (int i=0; i<A.GetLength(0); i++){
            for (int j=0; j<A.GetLength(1); j++){
                C[i,j] = A[i,j] + B[i,j];
            }
        }
        return C;
    } else {
        return null;
    }
}


double[,]? Resta(double[,] A, double[,] B)
{
    if ((A.GetLength(0) == B.GetLength(0)) & (A.GetLength(1) == B.GetLength(1)))
    {
        double[,] C = new double[A.GetLength(0),A.GetLength(1)];
        for (int i=0; i<A.GetLength(0); i++)
        {
            for (int j=0; j<A.GetLength(1); j++)
            {
                C[i,j] = A[i,j] - B[i,j];
            }
        }
        return C;
    } 
    else 
    {
        return null;
    }
}


double[,] Multiplicacion(double[,] A, double[,] B)
{
    if (A.GetLength(1) == B.GetLength(0))
    {
        double[,] C = new double[A.GetLength(0),A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                double sum = 0;
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    sum += A[i, k] * B[k, j];
                }
                C[i, j] = sum;
            }
        }
        return C;
    }
    else
    {
        throw new ArgumentException("La cantidad de columnas de A debe ser igual a la cantidad de filas de B");
    }
}


Console.ReadKey();