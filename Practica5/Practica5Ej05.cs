class A
{
    char c;
    static string st;
    void metodo1() {
        st = "string";
        c = 'A';
    }
    static void metodo2() {
        new A().c = 'a';
        st = "st2";
        c = 'B';                        // c es variable de instancia, no se puede acceder a ella desde un metodo estatico.
        new A().st = "otro string";     // Se quiere acceder a st como si fuese una variable de instancia.
    }
}