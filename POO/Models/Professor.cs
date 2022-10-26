using System;

namespace POO.Models
{
    public class Professor:Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }
    }
}