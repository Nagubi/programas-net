using System.Collections.ObjectModel;
// Efectua operaciones matematicas basicas de dos numeros

double suma,resta,mult,div,res,pot;

Console.Clear();
Console.WriteLine("Efectua operaciones matematicas basicas con dos numeros\n");

double x = 10.5 , y = 2.5;

suma = x+y;
resta = x-y;
mult = x * y ;
div = x / y ;
res = x % y ;
pot = Math.Pow(x, y) ;
Console.WriteLine($"Los numeros son: {x}, {y}\n");
Console.WriteLine("El resultado de las operaciones es el siguiente:\n");
Console.WriteLine($"Suma: {suma}\nResta: {resta}");
Console.WriteLine($"Multiplicacion: {mult}\nDivision: {div}");
Console.WriteLine($"Residuo: {res}\nPotencia: {pot}");