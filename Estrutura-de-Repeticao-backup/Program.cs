using System;

string opcao;
bool menu = true;

while(menu){

    Console.Clear();

    Console.WriteLine("Digite uma das opções abaixo");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao){
        case "1":
            Console.WriteLine("Cadastro de cliente");
        break;
        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        case "3":
            Console.WriteLine("Apagar dados do cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            //Environment.Exit(0);  programa é encerrado sem dar continuidade
            menu = false;  // programa é encerrado dando continuidade caso tenha códigos abaixo a serem executados
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
        Console.WriteLine("continua...");
}



/*
int soma = 0, numero = 0;

do{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());
    
    soma += numero;
    
}while(numero>0);

Console.WriteLine($"A soma dos números é : {soma}");
*/



// int numero = 9;
// int cont = 1;

// while(cont <= 10){
//     int resultado = numero * cont;
//     Console.WriteLine($"{numero} X {cont} = {resultado}");
//     cont++;
// }



// int calc = 9;

// for(int cont = 1; cont<= calc; cont++){
//     int multiplicacao = calc*cont;
//     Console.WriteLine($"{calc} x {cont} = {multiplicacao}");
// }
