/* using System;
class Calculo
{
    public int fatorial(int n)
    {
        int res = 1;
        if (n == 0 || n == 1)
        {
            return res;
        }
        else if (n > 0)
        {
            return n * fatorial(n - 1);
        }
        else
        {
            return -1;
        }
    }

    static void Main(string[] args)
    {
        int valor = 4;
        int resultado;
        Calculo calc = new Calculo();
        resultado = calc.fatorial(valor);
        Console.WriteLine("{0}! = {1}", valor, resultado);
    }
} */

/* using System;

class MainClass
{

    private static void Tarefa1()
    {
        Console.Clear();
        Console.WriteLine("Executando tarefa 1.");
        Console.ReadLine();
    }

    private static void Tarefa2()
    {
        Console.Clear();
        Console.WriteLine("Executando tarefa 2.");
        Console.ReadLine();
    }

    private static bool MenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1) Executar tarefa 1.");
        Console.WriteLine("2) Executar tarefa 2.");
        Console.WriteLine("3) Sair");
        Console.Write("\r\nOpção: ");

        switch (Console.ReadLine())
        {
            case "1":
                Tarefa1();
                return true;
            case "2":
                Tarefa2();
                return true;
            case "3":
                return false;
            default:
                return true;
        }
    }

    public static void Main(string[] args)
    {
        while (MenuPrincipal()) ;
    }
} */

using System;
using System.Collections.Generic;

public class Conta
{
    private DateTime _criacao;
    private double _saldo = 0;

    public Conta(double saldoInicial, DateTime criacao)
    {
        _saldo = saldoInicial;
        _criacao = criacao;
    }

    public DateTime DataCriacao
    {
        get { return _criacao; }
    }

    public double Sacar(double quantia)
    {
        if (_saldo < quantia)
            throw new ArgumentException("Quantia de saque não permitida.", "quantia");
        _saldo -= quantia;
        return quantia;
    }

    public void Depositar(double quantia)
    {
        if (quantia <= 0)
            throw new ArgumentException("Quantia de depósito não permitida.", "quantia");
        _saldo += quantia;
    }

    public double GetSaldo()
    {
        return _saldo;
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Conta contaDoZe = new Conta(1200, DateTime.Now);

        Console.WriteLine("Saldo da conta do Ze: {0:C2}", contaDoZe.GetSaldo());

        double quantia = 212;
        Console.WriteLine("Sacar {0:C2} da conta do Ze.", quantia);
        contaDoZe.Sacar(quantia);

        Console.WriteLine("Saldo da conta do Ze: {0:C2}", contaDoZe.GetSaldo());

    }
}