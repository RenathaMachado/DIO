using System;
namespace Mentoria_POO.Entities
{
    public class Juiz : Jogador
    {
        
        public Juiz(string nome, int idade, string nacionalidade) : base(nome, idade)
        {
          Nome = nome;
          Idade = idade;
          Nacionalidade = nacionalidade;
        
        }

        public string Nacionalidade{ get; set;}

        public override string ToString(){
            return "Juíz:"  + Nome + "\n"+ "Idade:" + Idade + "\n" + "Nacionalidade:" + Nacionalidade ;
        }
        
    }
}