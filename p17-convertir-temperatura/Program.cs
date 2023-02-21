// Convertir temperatura de grados celcius a farenheit
float temp, res;
Console.Clear();
Console.WriteLine("\nConvertir de Farenheit a Centigrados\n");
Console.Write("Dame los grados Farenheit ? "); temp=float.Parse(Console.ReadLine());
res = ( temp - 32 ) * 5 / 9;
Console.WriteLine($"{temp} Farenheit, equivale a {res} Centigrados");
