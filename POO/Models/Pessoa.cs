using System;


namespace POO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public virtual void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }
    }
}