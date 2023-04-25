//Segundo examen parcial

int op,n=0;
int x=0;
float prom=0;
const int MAX =100;
   int [] calif = new int[MAX];

do{
    op = menu();
    switch(op){
        case 1 :
             Console.WriteLine("Cuantos elementos deseas ?");
             n = int.Parse(Console.ReadLine());
             if(n > MAX){
                Console.WriteLine("no te pases :( )");
             }else{
                AsignaArreglo(calif,n);
             }
             break;
        case 2 : Mostrar(calif,n); 
        break;
        case 3 : 
             prom = Promedio(calif,n);
             Console.WriteLine($"\nEl promedio de las calificaciones es:\n{prom} ");
             Console.WriteLine($"Las calificaciones mayores al promedio son:");
             Mayores(calif,prom,n);
             break;
        case 4 :
             Console.WriteLine($"\nEl complemento a 100 es:");
             ComplementoCien(calif,n);
             break;
        case 5 :
             Console.WriteLine($"Que calificacion?");x= int.Parse(Console.ReadLine());
             Console.WriteLine($"El {x} aparece {Contar(calif,n,x)} veces ");
             break; 
    }
    Console.WriteLine("\nPresione cualquier tecla para continuar..");
    Console.ReadLine();
   }while(op!=6);
int menu(){
    Console.Clear();
    Console.WriteLine("leer elementos en el arreglo..                [1]");
    Console.WriteLine("mostrar elementos en el arreglo..             [2]");
    Console.WriteLine("Promedio y calificaciones mayores a el..      [3]");
    Console.WriteLine("Compelento a 100..                            [4]");
    Console.WriteLine("Contar una calificacion..                     [5]");
    Console.WriteLine("Salir                                         [6]");
    Console.WriteLine("Elige una opcion ?");
    int op = int.Parse(Console.ReadLine());
    return op;
}

void AsignaArreglo(int[] a,int n){
    for(int i=0; i < n; i++ ) {
        Console.Write($"Elemento {i+1}: ");
        a[i] = int.Parse(Console.ReadLine());
        if (a[i]<10 || a[i]>100){
            i--;
            Console.WriteLine("----Calificacion incorrecta ingrese de nuevo----");
        }
    }
}
void Mostrar(int[] a, int n){
    Console.WriteLine("Los elementos del arreglo son:");
    for(int i=0; i<n; i++){
       Console.Write($"{a[i]} ");
    }  
}

float Promedio(int[] a,int n){
    float suma=0;
    float resp;
    for(int i=0; i<n; i++){
       suma= suma+a[i];
    }
    resp = suma/n;
    return resp;  
}
void Mayores(int[] a,float prom,int n){
    
        for(int i=0; i < n; i++ ) {
        if (a[i]>prom){
            Console.Write($"{a[i]} ");
        }
    }
}

void ComplementoCien(int[] a,int n){
    for(int i=0; i < n; i++ ) {
            Console.Write($"{100-a[i]} ");
    }
}

int Contar(int[] a,int n,int nb){
    int pos=0;
    for(int i=0; i<n; i++)
       if(a[i] == nb)
         pos = pos + 1;
    return pos;     
}