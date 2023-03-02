/*
Se desea calcular el promedio de 5 calificaciones introducidas por el usuario, luego evaluar el resultado e 
imprimir un mensaje de acuerdo con el promedio obtenido:
• >0 y <= 6 Quedas reprobado
• >6 a <=7 Pasas de panzazo
• >7 y <=8 Muy bien, pues mejorar
• >8 y <=9 Excelente sigue así
• >9 y <=10 Perfecto tu esfuerzo valió la pena
*/
double cal1,cal2,cal3,cal4,cal5;
Console.Write("Calcular el promedio de 5 evaluaciones \n"); 

Console.Write("Calificacion 1:"); cal1 = double.Parse(Console.ReadLine());
Console.Write("Calificacion 2:"); cal2 = double.Parse(Console.ReadLine());
Console.Write("Calificacion 3:"); cal3 = double.Parse(Console.ReadLine());
Console.Write("Calificacion 4:"); cal4 = double.Parse(Console.ReadLine());
Console.Write("Calificacion 5:"); cal5 = double.Parse(Console.ReadLine());
double promedio = (cal1+cal2+cal3+cal4+cal5)/5;
if (promedio>0 && promedio <=6){
    Console.Write("Quedas Reprobado"); 
}else if(promedio>6 && promedio<=7){
    Console.Write("Pasas de panzazo"); 
}else if(promedio>7 && promedio<=8){
    Console.Write("Muy bien, puedes mejorar");
}else if(promedio>8 && promedio<=9){
    Console.Write("Excelente sigue asi");
}else if(promedio>9 && promedio<=10){
    Console.Write("Perfecto tu esfuerzo valió la pena");
}