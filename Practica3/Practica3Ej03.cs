double[,] aaa = new double[,]
{ 
    {1.6543,2.4231,3.8765,4.2754},
    {5.2643,6.8675,7.5231,8.0987},
    {9.4623,10.4231,11.8790,12.5236} 
};

string bbb = "0.00";
ImprimirMatrizConFormato(aaa, bbb);

void ImprimirMatrizConFormato(double[,] matriz, string formatString){
    for (int i=0; i<matriz.GetLength(0); i++){
        for (int j=0; j<matriz.GetLength(1); j++){
            Console.Write(matriz[i,j].ToString(formatString) + " | ");
        }
        Console.WriteLine();
    }
}

Console.ReadKey();