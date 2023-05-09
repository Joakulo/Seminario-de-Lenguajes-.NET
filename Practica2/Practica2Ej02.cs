object o1 = "A";
object o2 = o1;
o2 = "Z";           // Genera un nuevo espacio en Memoria Heap
Console.WriteLine(o1 + " " + o2);

Console.ReadKey();