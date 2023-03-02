//Dados tres números enteros, verificar si son consecutivos
int num1,num2,num3;
string salida;
Console.Clear();
Console.WriteLine("Dame tres numeros para verificar si son consecutivos \n");
Console.Write("Dame el primer numero "); num1 = int.Parse(Console.ReadLine());
Console.Write("Dame el segundo numero "); num2 = int.Parse(Console.ReadLine());
Console.Write("Dame el tercer numero "); num3 = int.Parse(Console.ReadLine());
if (num2-num1==1 && num3-num2==1){
     salida = string.Format($"Los numeros ({num1}" + $",{num2}," + $"{num3}) son consecutivos");
}else{
    salida = string.Format($"Los numeros ({num1}" + $",{num2}," + $"{num3}) no son consecutivos");
}
Console.WriteLine(salida);