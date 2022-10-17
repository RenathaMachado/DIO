using System;
using System.Globalization;

public class Program
{
    public static void Main(String[] args)
    {

      int quantidadeEntradas = 3;
      
      while (quantidadeEntradas > 0) {
      var numeroQuantidade = Int32.Parse(Console.ReadLine()); // numero de tartarugas
        
      if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
        string[] tartarugas = Console.ReadLine().Split(" ");
        var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 1; i < tartarugas.Length; i++) {
          var tartaruga = Int32.Parse(tartarugas[i]);
            
          if (tartaruga > maiorVelocidade ) {
            maiorVelocidade = tartaruga;
          }
        }

        if( maiorVelocidade < 10) {
          Console.WriteLine(1);
        } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
          Console.WriteLine(2);
        } else if (maiorVelocidade >= 20) {
          Console.WriteLine(3);
        }
            quantidadeEntradas--;
      } else {
        Console.WriteLine("Insira um número entre 1 e 500");
      }
    }







//     double salario  = 0.00; 
//     double reajuste = 0.00; 
//     double novoSalario = 0.00; 
//     double percentual = 0.00; 
  
//     salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture); 

// //TODO: Complete os espaços em branco com uma possível solução para o problema:
   
//     if( salario < 0 ) { 
//       return; 

//     } else if (salario <= 400) { 
//       percentual = 15; 
//       reajuste = (salario * 15) / 100 ; 
//       novoSalario = salario + reajuste ; 


//     } else if (salario<= 800) { 
//       percentual = 12  ; 
//       reajuste = (salario * 12) / 100 ;         
//       novoSalario = salario + reajuste ; 

//     } else if (salario <= 1200) { 
//       percentual = 10; 
//       reajuste = (salario * 10) / 100 ;
//       novoSalario = salario + reajuste ;

//     } else if (salario <= 2000) { 
//       percentual = 7 ; 
//       reajuste = (salario * 7) / 100;   
//       novoSalario = salario + reajuste;  

//     } else { 
//       percentual = 4 ; 
//       reajuste = (salario * 4) / 100; 
//       novoSalario = salario + reajuste; 

//     } 

//     Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}"); 
//     Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}"); 
//     Console.WriteLine($"Em percentual: {percentual} %"); 






        // int n = int.Parse(Console.ReadLine());
        
        // int[] num = new int[n];
    
        // for (int i =0;i<n ;i++)
        // {
        //     num[i] = int.Parse(Console.ReadLine());
        // }
        // Console.WriteLine(MajorityElement(num));
        
    }


    // public static int MajorityElement(int[] nums)
    // {
    //     int major = nums[0];
    //     int count = 1;
    //     for (int i = 1; i < nums.Length; i++)
    //     {
    //         if (count == 0)
    //         {
    //             major = nums[i];
    //             count++  ;
    //         }
    //         else
    //         {
    //             if (major == nums[i])
    //             {
    //                 count++;
    //             }
    //             else
    //             {
    //                 count--;
    //             }
    //         }
    //     }
    //     return major;
    //}
}