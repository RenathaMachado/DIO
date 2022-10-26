using System;

namespace POO.Models
{
    public class Corrente: Conta
    {
        public override void Creditar(decimal valor){
            saldo += valor;
        } 
    }
}