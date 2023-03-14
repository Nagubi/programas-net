// Imprime números pares descendente
int n,c,s,i=0;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime números pares descendente\n");
    Console.WriteLine("Hasta donde ? ");
    n = int.Parse(Console.ReadLine());
    s=0;
    c=100;
    while( c>=n ) {
        Console.Write($"{c} ");
        s = s + c;
        c = c-2;
        i++;
    }
    Console.WriteLine($"La suma es {s}");
    Console.WriteLine($"\nEl promedio es {s/i}");
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp = char.ToUpper( Console.ReadLine()[0] );
} while( resp!='N' );
Console.WriteLine("\nGracias por utilizar este programa !");
