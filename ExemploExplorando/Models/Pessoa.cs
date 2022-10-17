using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa(){

        }
        public Pessoa(string nome, String sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome){
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome { 
            get{
                return _nome.ToUpper();
                // get => _nome.ToUpper();  Validação de maneira simplificada nos casos do return em apenas uma linha.
            }
            
            set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        }
        public int Idade { 
            get => _idade;
            set{
                if(value < 0){
                    throw new ArgumentException("A idade não corresponde a um valor válido");
                }
                    _idade = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeSobrenome { 
            get => $"{_nome} {Sobrenome.ToUpper()}";
        }
        public void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome} {Sobrenome} e tenho {Idade} anos");
        }
    }
}