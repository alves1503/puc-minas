
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_classe_objetos.models
{
    public class Pessoa
    {

        public string Nome;
        public string Endereco;
        public string Numero;

        public Pessoa(string nome, string endereco, string numero)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Numero = numero;
        }

        public Pessoa()
        {
            this.Nome = "Maria Clara";
            this.Endereco = "Rua 2";
            this.Numero = "(11) 11111-1111";
        }


        public string PrimeiroNome()
        {
            return Nome.Split(' ')[0]; // retorna só o primeiro nome
        }

        public void exibirInformacao()
        {
            Console.WriteLine($"Seja bem vindo: {Nome}");
            Console.WriteLine($"Seu endereço: {Endereco}");
            Console.WriteLine($"Seu telefone: {Numero}");
        }


    }
}