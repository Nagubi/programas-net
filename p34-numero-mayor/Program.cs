//Dados tres números enteros, verificar cual es el mayor.
int num1,num2,num3;
string salida;
Console.Clear();
Console.WriteLine("Dame tres numeros para verificar cual es el mayor \n");
Console.Write("Dame el primer numero "); num1 = int.Parse(Console.ReadLine());
Console.Write("Dame el segundo numero "); num2 = int.Parse(Console.ReadLine());
Console.Write("Dame el tercer numero "); num3 = int.Parse(Console.ReadLine());
if (num2>=num1 && num2>=num3){
     Console.WriteLine(string.Format($"El numero mayor es {num2}"));
}
else if (num3>=num1 && num2<=num3){
     Console.WriteLine(string.Format($"El numero mayor es {num3}"));
}
else if (num2<=num1 && num1>=num3){
 Console.WriteLine(string.Format($"El numero mayor es {num1}"));
}

