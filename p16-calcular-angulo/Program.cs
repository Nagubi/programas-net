/*Se desea calcular el 3er ángulo de un triángulo dados los dos primeros ángulos del mismo, usando la siguiente
formula:
• angulo3 = 180 – (angulo1 + angulo2)
*/
double angulo3,angulo1,angulo2;
Console.Clear();
Console.WriteLine("Calculando el tercer angulo \n");
Console.Write("Dame el angulo 1 ? "); 
angulo1=double.Parse(Console.ReadLine());
Console.Write("Dame el angulo 2 ? "); 
angulo2=double.Parse(Console.ReadLine());
angulo3 = 180- (angulo1+angulo2);
Console.WriteLine($"\nAngulo 3: {angulo3}");
