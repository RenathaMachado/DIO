using System;
using System.Collections.Generic;
using System.Globalization;
using ExemploExplorando.Models;
using Newtonsoft.Json;


    public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
        for (int i =0;i<n ;i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                major = nums[i];
                count++  ;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return major;
    }
}













// Método de extensão / referência classe IntExtensions
// int numero = 15;
// bool par = false;

// par = numero.EhPAr();

// Console.WriteLine("O numéro" +" " + numero + " " + "é" + " " + (par ? "par": "ímpar"));







// Classe genérica
// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElemento("Banana");
// arrayString.AdicionarElemento("Uva");
// arrayString.AdicionarElemento("Abacate");

// Console.WriteLine(arrayString[0]);










// Tipo anônimo em coleção

// string conteudoDoArquivo = File.ReadAllText("Arquivos/Vendas.json");

// List<Venda> listVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoDoArquivo);
// var listaAnonimo  = listVendas.Select(x => new {x.Produto, x.Preco});// tipo anônimo
// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto} \n Preço: {venda.Preco}");
// }









// Tipos anônimos

// var tipoanonimo = new {Nome = "Renata", Sobrenome = "Machado", Altura = 1.56};
// Console.WriteLine("Nome:" + tipoanonimo.Nome);
// Console.WriteLine("Nome:" + tipoanonimo.Sobrenome);
// Console.WriteLine("Nome:" + tipoanonimo.Altura);












// bool? desejaReceberEmail = true;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value){
//     Console.WriteLine("Usuário deseja receber email");
// }else{
//     Console.WriteLine("Usuário não deseja receber email");
// }










//Deserializando

// string conteudoDoArquivo = File.ReadAllText("Arquivos/Vendas.json");

// List<Venda> listVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoDoArquivo);
// foreach (Venda itemVendas in listVendas)
// {
// //     Console.WriteLine(itemVendas);
// Console.WriteLine($"Id: {itemVendas.Id}, Produto:{itemVendas.Produto}," + 
// $"Preço: {itemVendas.Preco}, Data: {itemVendas.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
// $" {(itemVendas.Desconto.HasValue ? $"Desconto de : {itemVendas.Desconto}" : " ")}");
// }










//Serializar

// DateTime dataatual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda (01, "Computador", 3.500M, dataatual ); 
// Venda v2 = new Venda (02, "Cadeira Gamer", 2.700M, dataatual );

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// //string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado );
// Console.WriteLine(serializado);
 









// Pessoa p1 = new Pessoa("Renata", "Machado");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");



// LeituraArquivo leituraArquivo = new LeituraArquivo();

// var (sucesso, linhas, quantidadeLinhas) = leituraArquivo.LerArquivo("Arquivo/arquivoLeitura.txt");

// if(sucesso){
//     foreach (var itens in linhas)
//     {
//         Console.WriteLine($"Itens: {itens}");
//     }
//         Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
// }else{
//         Console.WriteLine($"Não foi possível ler o arquivo");
// }

// (int, string, string) tuplas = (001, "Renata", "Machado");

// Console.WriteLine($"ID: {tuplas.Item1} \n Nome: {tuplas.Item2} \n SOBRENOME: {tuplas.Item3}" );

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (var linha in linhas)
//     {
//         Console.WriteLine(linha); 
//     }
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura de um arquivo. Pasta não encontrada{ex.Message}");
    
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado.{ex.Message}");
    
// }
// finally{
//     Console.WriteLine("Chegou até aqui");
// }








// Pessoa p1 = new Pessoa(nome:"Davi", sobrenome:"Machado");
// Pessoa p2 = new Pessoa(nome:"Renata", sobrenome:"Cruz");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();





//Pessoa p1 = new Pessoa();
//p1.Nome = "Renata";
//p1.Sobrenome = "Machado";
//p1.Idade = 34;
//p1.Apresentar();
