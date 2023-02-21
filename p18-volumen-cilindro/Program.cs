/* Se desea calcular el volumen de un cilindro dado su radio y altura, usando la siguiente formula:
• volumen = PI * (radio * radio) * altura
*/
double radio,altura,res;
Console.Clear();
Console.WriteLine("\nVolumen de un cilindo\n");
Console.Write("Dame la altura ? "); altura=double.Parse(Console.ReadLine());
Console.Write("Dame el radio ? "); radio=double.Parse(Console.ReadLine());
res = Math.PI * ( radio * radio ) * altura;
Console.WriteLine($"Volumen = {res} m^3");
