int a; int b; int c, d;                     // a, b, c, d quedan vacias
int a = 1; int b = 2; int c = 3;            // a = 1, b = 2, c = 3
int b; int c; int a = b = c = 1;            // a = 1, b = 1, c = 1
int c; int a, b = c = 1;                    // a vacia, b = 1, c = 1
int c; int a = 2, b = c = 1;                // a = 2, b = 1, c = 1
int a = 2, b, c, d = 2 * a;                 // a = 2, b = 4, c = 4, d = 4
int a = 2, int b = 3, int c = 4;            // No compila. Se debe reemplazar las "," por ";".
int a = 2; b = 3; c = 4;                    // Individualmente no compila. Antes de asignar valores se debe declarar su tipo.
int a; int c = a;                           // No compila. Se le intenta asignar el valor de "a" a "c", pero "a" no esta inicializada.
char c = 'A', string st = "Hola";           // No compila. Se debe reemplazar la "," por ";".
char c = 'A'; string st = "Hola";           // c = 'A', st = "Hola"
char c = 'A', st = "Hola";                  // No compila. "st" se esta declarando como "char" y se le quiere asignar un "string".