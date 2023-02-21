// Dada una cantidad en pesos y la cotización del dólar, se desea obtener el equivalente en dólares.

double dolar,cantidad,res;
Console.Clear();
Console.WriteLine("\nConvertir pesos a dolares\n");
Console.Write("Dame la cantidad de pesos ? "); cantidad=double.Parse(Console.ReadLine());
Console.Write("Dame el valor del dolar ? "); dolar=double.Parse(Console.ReadLine());
res = cantidad/dolar;
Console.WriteLine($"Dolares = ${res}");