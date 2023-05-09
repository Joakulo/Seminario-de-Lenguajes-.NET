object obj = new int[10];
dynamic dyn = 13;
Console.WriteLine(obj.Length);
Console.WriteLine(dyn.Length);  //genera un error en tiempo de ejecución porque la variable "dyn" se ha declarado como "dynamic", lo que significa que su tipo se determina en tiempo de ejecución en lugar de tiempo de compilación.
Console.ReadKey();