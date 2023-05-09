int sum = 0;
int i = 1;
while (i <= 10)     //ERROR: Habia un ;
{
sum += i++;
}

//Va sumando mientras i se incrementa.
//0 = 0 + 1
//1 = 1 + 2
//3 = 3 + 3
//...

Console.ReadKey();