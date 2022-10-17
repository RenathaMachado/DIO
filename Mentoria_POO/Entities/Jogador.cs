using System;

namespace Mentoria_POO.Entities
{
    public class Jogador
    {
        public Jogador(string nome, int idade, string selecao, string posicao )
        {
          Nome = nome;
          Idade = idade;
          Selecao = selecao;
          Posicao = posicao;
        }

        public Jogador(string nome, int idade, string selecao)
        {
          Nome = nome;
          Idade = idade;
          Selecao = selecao;
          
        }

        public Jogador(string nome, int idade)
        {
          Nome = nome;
          Idade = idade;
          
        }


        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Selecao { get; set; }
        public string? Posicao { get; set; }

        public override string ToString(){
            return "Jogador:"  + Nome + "\n"+ "Idade:" + Idade +
            "\n" + "Seleção:" + Selecao + "\n" + "Posição:" + Posicao;
        }
    }
}