class A
{
    private static int a;               // Variable de clase estatica, solo puede ser inicializada en declaracion o constructor estatico
    private static readonly int b;      // Variable de clase estatica de solo lectura, solo puede ser inicializada en declaracion o constructor estatico
    A() { }                             // Constructor privado sin parametros
    public A(int i) : this() { }        // Constructor publico con un argumento int que referencia al constructor privado
    static A() => b = 2;                // Constructor estatico, inicializa b correctamente, se ejecuta en tiempo de compilacion
    int c;                              // Variable privada
    public static void A1() => a = 1;   // Metodo publico estatico, inicializa a correctamente, se ejecuta en tiempo de compilacion
    public int A1(int a) => A.a + a;    // Metodo publico, devuelve un entero
    public static int A2;               // Variable de clase estatica, solo puede ser inicializada en declaracion o constructor estatico
    static int A3 => 3;                 // Propiedad estatica auto implementada, siempre devuelve 3
    private int A4() => 4;              // Metodo privado, siempre devuelve 4
    public int A5 { get => 5; }         // Propiedad auto implementada de solo lectura, siempre devuelve 5
    int A6 { set => c = value; }        // Propiedad privada de solo escritura, inicializa la variable c
    public int A7 { get; set; }         // Propiedad publica auto implementada de lectura y escritura
    public int A8 { get; } = 8;         // Constante que se inicializa en 8, cuando se llame a la propiedad devuelve 8
    public int this[int i] => i;        // Indizador, devuelve el numero que entra 
}
