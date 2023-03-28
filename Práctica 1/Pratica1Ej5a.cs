Console.WriteLine("Ingrese su nombre");
string st = Console.ReadLine();

if (st == "Juan"){
    Console.WriteLine("Hola amigo");
} else if (st == "Maria"){
    Console.WriteLine("Buen día señora");
} else if (st == "Alberto"){
    Console.WriteLine("Hola Alberto");
} else if (st.Length == 0){
    Console.WriteLine("Buen día mundo");
} else {
    Console.WriteLine("Buen dia " + st);
}

Console.ReadKey();