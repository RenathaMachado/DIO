using System;

namespace POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

          public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha nota é {Nota}");
        }
    }
}