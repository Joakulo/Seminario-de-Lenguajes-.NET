string st = Console.ReadLine();
bool j = true;

for (int i = 0; i < (st.Length / 2.0) ; i++)
{
    if (st[i] != st[st.Length - (i+1)])
    {
        j = false;
    }
}

if (j)
{
    Console.WriteLine("Son iguales");
} else {
    Console.WriteLine("Son dinstintas");
}

Console.ReadKey();