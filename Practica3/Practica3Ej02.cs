﻿double[,] aaa = new double[,]
{ 
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12} 
};

ImprimirMatriz(aaa);

void ImprimirMatriz(double[,] matriz){
    for (int i=0; i<matriz.GetLength(0); i++){
        for (int j=0; j<matriz.GetLength(1); j++){
            Console.Write(matriz[i,j] + " | ");
        }
        Console.WriteLine();
    }
}

Console.ReadKey();