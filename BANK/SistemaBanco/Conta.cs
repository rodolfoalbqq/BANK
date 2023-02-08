using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK.SistemaBanco
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public TItular Titular { get; set; }
        public decimal Saldo { get; set; }

        public decimal VerSaldo()
        {
            return Saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal Valor)
        {
            if(Valor <= Saldo)
            
                Saldo -= Valor;

            else 
                Console.WriteLine("Você não tem saldo suficiente."); 
                    
            

            
        }
    }

    
}
