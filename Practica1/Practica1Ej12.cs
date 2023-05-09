string st = Console.ReadLine();
int j = int.Parse(st);
 
for (int i = 1; i <= j; i++){
    if (j % i == 0){
        Console.WriteLine(i);
    }
}