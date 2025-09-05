
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_classe_objetos.models
{
    public class Pessoa
    {

        public string nome;
        public string endereco;
        public string numero;

        public void primeiroNome()
        {
            Console.WriteLine($"Seja bem vindo {nomeCompleto}");
        }
        
    }
}