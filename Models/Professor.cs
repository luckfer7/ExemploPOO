using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor (string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. Sou um professor com salário de R${Salario}!");
        }
    }
}