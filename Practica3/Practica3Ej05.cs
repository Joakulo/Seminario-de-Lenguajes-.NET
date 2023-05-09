double[,] aaa = new double[,]
{ 
    {1.6543,2.4231,3.8765,4.2754},
    {5.2643,6.8675,7.5231,8.0987},
    {9.4623,10.4231,11.8790,12.5236},
    {13.8653,14.2136,15.9642,16.0907}
};

double[][] arrayDeArray = new double[aaa.GetLength(0)][];
for (int i=0; i<aaa.GetLength(0); i++){
    arrayDeArray[i] = new double[aaa.GetLength(1)];
}

arrayDeArray = GetArregloDeArreglo(aaa);

for (int i=0; i<aaa.GetLength(0); i++){
    for (int j=0; j<aaa.GetLength(1); j++){
        Console.Write(arrayDeArray[i][j] + " | ");
    }
    Console.WriteLine("");
}

double[][] GetArregloDeArreglo(double [,] matriz){
    double[][] arrayDeArray = new double[matriz.GetLength(0)][];
    for (int i=0; i<matriz.GetLength(0); i++){
        arrayDeArray[i] = new double[matriz.GetLength(1)];
    }

    for (int i=0; i<matriz.GetLength(0); i++){
        for (int j=0; j<matriz.GetLength(1); j++){
            arrayDeArray[i][j] = matriz[i,j];
        }
    }

    return arrayDeArray;
}


Console.ReadKey();