using System;
class MainClass {
public static void Main (string[] args) {
Double numero, raiz;
// Calcula a raiz quadrada enquanto
// o numero digitado for maior que 0 (zero)
do
{
Console.Write("Digite um numero: ");
numero = Double.Parse(Console.ReadLine());
if (numero > 0)
{
raiz = Math.Sqrt(numero);
Console.WriteLine($"A raiz quadrada de {numero} = {raiz}");
}
} while (numero > 0);
}
}