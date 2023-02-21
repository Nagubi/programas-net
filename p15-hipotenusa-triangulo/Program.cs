/*calcular la hipotenusa de un triángulo rectángulo dadas las longitudes de sus lados, usando la siguiente
formula:
• hipotenusa = raizcuadrada( longitudLado1 * longitudLado1 + logitudLado2 * longitudLado2 )*/
double hipotenusa,longitudLado1,longitudLado2;
Console.Clear();
Console.WriteLine("Calculando la hipotenusa de un triangulo \n");
Console.Write("Dame la longitud del lado 1 ? "); 
longitudLado1=double.Parse(Console.ReadLine());
Console.Write("Dame la longitud del lado 2 ? "); 
longitudLado2=double.Parse(Console.ReadLine());
hipotenusa = Math.Sqrt((longitudLado1 * longitudLado1) + (longitudLado2 * longitudLado2));
Console.WriteLine($"\nHipotenusa: {hipotenusa}");
