namespace Teoria2;

class Matriz
{
    private double[,] _matriz;

    public Matriz(int filas, int columnas)
    {
        _matriz = new double[filas,columnas];
    }

    public Matriz(double[,] matriz)
    {
        _matriz = matriz;
    }

    public void setElemento(int fila, int columna, double elemento)
    {
        _matriz[fila,columna] = elemento;
    }

    public double getElemento(int fila, int columna)
    {
        return _matriz[fila,columna];
    }
    public void Imprimir()
    {
        for (int i=0; i<_matriz.GetLength(0); i++)
        {
            for (int j=0; j<_matriz.GetLength(1); i++)
            {
                Console.Write("{0,-5:0.00} | ", _matriz[i,j]);
            }
            Console.WriteLine();
        }
    }
    public void Imprimir(string formatString)
    {
        for (int i=0; i<_matriz.GetLength(0); i++)
        {
            for (int j=0; j<_matriz.GetLength(1); i++)
            {
                Console.Write("{0,-5} | ", _matriz[i,j].ToString(formatString));
            }
            Console.WriteLine();
        }
    }
    public double[] getFila(int fila)
    {
        double[] aux = new double[_matriz.GetLength(1)];
        for (int i=0; i<_matriz.GetLength(1); i++)
        {
            aux[i] = getElemento(fila,i);
        }
        return aux;
    }
    public double[] getColumna(int columna)
    {
        double[] aux = new double[_matriz.GetLength(0)];
        for (int i=0; i<_matriz.GetLength(0); i++)
        {
            aux[i] = getElemento(i,columna);
        }
        return aux;
    }
    public double[] getDiagonalPrincipal()
    {
        if (_matriz.GetLength(0) == _matriz.GetLength(1))
        {
            double[] aux = new double[_matriz.GetLength(0)];
            for (int i=0; i<_matriz.GetLength(0); i++)
            {
                aux[i] = _matriz[i,i];
            }
            return aux;
        }
        else
        {
            throw new Exception("La matriz no es cuadrada");
        }
    }
    public double[] getDiagonalSecundaria()
    {
        if (_matriz.GetLength(0) == _matriz.GetLength(1))
        {
            double[] aux = new double[_matriz.GetLength(0)];
            for (int i=0; i<_matriz.GetLength(0); i++)
            {
                aux[i] = _matriz[i,_matriz.GetLength(0) - i - 1];
            }
            return aux;
        }
        else
        {
            throw new Exception("La matriz no es cuadrada");
        }
    }
    public double[][] getArregloDeArreglo()
    {
        double[][] aux = new double[_matriz.GetLength(0)][];
        for (int i=0; i<_matriz.GetLength(0); i++)
        {
            aux[i] = new double[_matriz.GetLength(1)];
            for (int j=0; j<_matriz.GetLength(1); j++)
            {
                aux[i][j] = getElemento(i,j);
            }
        }
        return aux;

    }
    public void sumarle(Matriz m)
    {
        double[][] aux = m.getArregloDeArreglo();
        if ((_matriz.GetLength(0) == aux.GetLength(0)) && (_matriz.GetLength(1) == aux[0].GetLength(0)))
        {
            for (int i=0; i<_matriz.GetLength(0); i++)
            {
                for (int j=0; j<_matriz.GetLength(1); i++)
                {
                    setElemento(i,j, getElemento(i,j) + aux[i][j]);
                }
            }
        }
        else
        {
            throw new Exception("El tamaño de las matrices no coincide");
        }
    }
    public void restarle(Matriz m)
    {
        double[][] aux = m.getArregloDeArreglo();
        if ((_matriz.GetLength(0) == aux.GetLength(0)) && (_matriz.GetLength(1) == aux[0].GetLength(0)))
        {
            for (int i=0; i<_matriz.GetLength(0); i++)
            {
                for (int j=0; j<_matriz.GetLength(1); i++)
                {
                    setElemento(i,j, getElemento(i,j) - aux[i][j]);
                }
            }
        }
        else
        {
            throw new Exception("El tamaño de las matrices no coincide");
        }
    }
    public void multiplicarPor(Matriz m)
    {
        if (_matriz.GetLength(1) == m._matriz.GetLength(0))
        {
            double[,] aux = new double[_matriz.GetLength(0), m._matriz.GetLength(1)];
            for (int i=0; i<_matriz.GetLength(0); i++)
            {
                for (int j=0; j<m._matriz.GetLength(1); i++)
                {
                    for (int k=0; k<_matriz.GetLength(1); k++)
                    {
                        aux[i,j] += _matriz[i,k] * m._matriz[k,j];
                    }
                }
            }
            _matriz = aux;
        }
        else
        {
            throw new Exception("El tamaño de las matrices no coincide. La cantidad de columnas de A debe ser igual a la cantidad de columnas de B");
        }
    }

    
}