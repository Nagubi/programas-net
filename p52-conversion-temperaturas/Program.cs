/*
Se desea calcular la temperatura convertida de grados centígrados a grados farenheit de un rango de valores
introducidos por el usuario, es decir el usuario introduce la temperatura inicial y la temperatura final en grados
centígrados y el programa realiza la conversión a farenheit incrementando el valor inicial en 1, hasta llegar al
valor final. Se deberá validar el rango, es decir Final no puede ser menor a Inicial. El proceso debe de poder
repetirse hasta que el usuario lo decida.
*/
int tempi,tempf;
float c;
char res;
do {
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de celcius a fahrenheit\n");
    do{
        Console.WriteLine("Temperatura inicial:"); tempi=int.Parse(Console.ReadLine());
        Console.WriteLine("Temperatura final:"); tempf=int.Parse(Console.ReadLine());
    }while(tempf < tempi );
    c= tempi;
    Console.WriteLine(new string('*',25));
    Console.WriteLine("Celcius / Fahrenheit");
    Console.WriteLine(new string('*',25));
    while ( c <= tempf){
        Console.WriteLine($"{c}\t{(c*9/5)+32:f2}");
        c++;
    }
    Console.WriteLine(new string('*',25));
    Console.WriteLine("\nDeseas Continuar (S/N) ?");
    res = char.ToUpper(Console.ReadLine()[0]);
}while( res != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");