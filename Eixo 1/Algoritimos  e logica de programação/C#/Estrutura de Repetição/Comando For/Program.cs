using System;
class MainClass {
public static void Main (string[] args) {
Double numero, raiz;
// Calcula a raiz quadrada de 10 numeros
for(int cont = 1; cont <= 10; cont++)
{
Console.Write("Digite um numero: ");
numero = Double.Parse(Console.ReadLine());
raiz = Math.Sqrt(numero);
Console.WriteLine($"A raiz quadrada de {numero} = {raiz}");
}
}
}