/* Dada una cantidad en horas, calcular su equivalente en días, minutos y segundos, considerando que >
• 1 día tiene 24 horas,
• 1 hora tiene 60 minutos,
• 1 minuto tiene 60 segundos
*/

double dias,horas,minutos,segundos;

Console.WriteLine("Calculando el tiempo:\n");
Console.Write("Dame las horas: "); horas = double.Parse(Console.ReadLine());

dias= horas/24;
minutos= horas * 60;
segundos = horas* 60*60;

Console.WriteLine($"El tiempo es:\n{dias} dias \n{horas} horas\n{minutos} minutos \n{segundos} segundos\n");
