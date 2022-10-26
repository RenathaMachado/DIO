
using System;


namespace POO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial )
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor){
            if(saldo >= valor){
                saldo-=valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }else{
                Console.WriteLine("Valor de saque é maior do que o saldo disponível");
            }
        }

         public decimal ValorDisponivel(){
            return saldo;
         }
    }
}