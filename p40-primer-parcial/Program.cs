/*
Se desea llevar el control de la inscripción a un evento académico de la Universidad Patito. Se especifica: Tipo
de usuario, paquete y cantidad.
• Tipo de usuario: [1] Alumno $100, [2] Trabajador $200, [3] Docente $500
• Tipo de paquete: [1] Solo conferencias $600, [2] Con eventos sociales $800, [3] Con kit de acceso $900
Se debe calcular un subtotal de la venta sumando el precio del tipo de usuario más el precio de tipo de paquete, y
multiplicando por la cantidad solicitada.
Se otrgará un descuento siempre y cuando el subtotal sea mayor a 5,000 y de acuerdo a lo siguiente
• Es Alumno 20%
• Es Trabajador y un 10%
• Es Docente y un 5%
Al final mostrar un resumen con los datos calculados
*/
void Menu() {
    Console.Clear();
    Console.WriteLine("Elija la inscripcion a un evento academico:");
    Console.WriteLine("Tipo de usuario: [1] Alumno $100, [2] Trabajador $200, [3] Docente $500");
    Console.WriteLine("Tipo de paquete: [1] Solo conferencias $600, [2] Con eventos sociales $800, [3] Con kit de acceso $900");
    Console.WriteLine("Cantidad:");
}
    
if(args.Length < 3) {
    Menu();
    return 1;
}
char usuario, paq;
string  users = "", paquetetext = "";
float subtot = 0, desc = 0, total = 0, cant = 0,precio=0,paquete=0;

usuario = char.Parse(args[0]);
if(usuario == '1'){users = "Alumno"; subtot+=100;}
else if(usuario == '2'){users = "Trabajador"; subtot+=200;}
else {users = "Docente"; subtot+=500;}

paq = char.Parse(args[1]);
    switch(paq){
        case '1' : paquete += 600;paquetetext="Solo conferencias"; break;
        case '2' : paquete += 800;paquetetext="Con eventos sociales"; break;
        default : paquete += 900;paquetetext="Con kit de acesso"; break;
    }


//Procesar Cantidad
    

cant = float.Parse(args[2]);
subtot = (subtot+paquete) * cant;

//Procesar Descuento
if(subtot > 5000){
    if(users=="Alumno"){
        desc=0.20f;
    }else if(users=="Trabajador"){
        desc=0.10f;
    }else{
        desc=0.05f;
    }
}
else {desc = 0.0f;}

total = subtot - (subtot * desc);
Console.WriteLine($"Usuario:            {users}");
Console.WriteLine($"Paquete:            {paquetetext}");
Console.WriteLine($"Cantidad:           {cant}");
Console.WriteLine($"Precio normal:      ${subtot}");
Console.WriteLine($"Descuento:          ${(subtot * desc)}({desc*100}%)");
Console.WriteLine($"Total con descuento:${total}");

return 0;

