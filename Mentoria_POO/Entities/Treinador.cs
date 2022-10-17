namespace Mentoria_POO.Entities
{
    public class Treinador : Jogador
    {
        public Treinador(string nome, int idade, string selecao) : base(nome, idade, selecao)
        {
          Nome = nome;
          Idade = idade;
          Selecao = selecao;
        }

     

        public override string ToString(){
            return "Técnico:"  + Nome + "\n"+ "Idade:" + Idade +
            "\n" + "Seleção:" + Selecao ;
        }
    }
}