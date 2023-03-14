/*
Se desean imprimir los primeros n números de la será de fibbonaci. El proceso debe de poder repetirse hasta que
el usuario lo decida.
Ejemplo:
Ingrese el valor maximo: 50
La sucesion Fibonacci es:
0 1 1 2 3 5 8 13 21 34 166 
*/
int n, i = 0, fi = 0, fibo = 0 , temp = 0;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime los primeros n numero de la serie de fibonacci\n");
    do {
        Console.Write("Dame un numero? ");
        n = int.Parse(Console.ReadLine());
    } while( n <= 0);
    do {
        temp = fibo;
        fibo = fi;
        fi = fibo + temp;
        Console.Write($"{fibo} ");
        if(fi == 0)fi++;
        i++;
    } while(i < n);
    i = fi = fibo = temp = 0;
    Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");