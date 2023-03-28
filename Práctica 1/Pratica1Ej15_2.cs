string st = Console.ReadLine();
int j=int.Parse(st);
 
if (j % 4 == 0){
    if (j % 100 != 0){
        Console.WriteLine("Bisiesto");
    } else if (j % 400 == 0){
        Console.WriteLine("Bisiesto");
    } else{
        Console.WriteLine("No Bisiesto");
    }
} else {
    Console.WriteLine("No Bisiesto");
}