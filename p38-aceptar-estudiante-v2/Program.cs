/*
Dado el nombre del estudiante, sexo (h/m), su edad y tres calificaciones, decidir si el estudiante es aceptado. La
Universidad Kitty Kat SA es solo para mujeres mayores de 21 años con un promedio de entre 8 y 9.5
*/
Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Sexo (h/m): ");
        char sexo = Console.ReadLine()[0];  // Solo se toma el primer carácter
        
        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());
        
        Console.Write("Calificación 1: ");
        double calificacion1 = double.Parse(Console.ReadLine());
        
        Console.Write("Calificación 2: ");
        double calificacion2 = double.Parse(Console.ReadLine());
        
        Console.Write("Calificación 3: ");
        double calificacion3 = double.Parse(Console.ReadLine());
        
        // Verificar si el estudiante cumple con los requisitos
        bool aceptado = sexo == 'm' && edad > 21 && (calificacion1 + calificacion2 + calificacion3) / 3 >= 8 && (calificacion1 + calificacion2 + calificacion3) / 3 <= 9.5; 
        
        // Mostrar resultado
        if (aceptado) {
            Console.WriteLine("El estudiante {0} ha sido aceptado en la Universidad Kitty Kat SA.", nombre);
        } else {
            Console.WriteLine("Lo siento, el estudiante {0} no cumple con los requisitos para ser aceptado en la Universidad Kitty Kat SA.", nombre);
        }