using System;

namespace POO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);
        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo é de:" + saldo);
        }
    }        
}        