using BANK.SistemaBanco;
using System;
using System.Security.Cryptography;

namespace BANK;

public  class program
{
    public static void Main(string[] args)
    {
        var Conta = new Conta();
        Conta.Nome = "Carlos Alberto";
        Conta.NumeroConta = 0001;
        Conta.Agencia = 001;
        Conta.Saldo = 1300;

        Conta.Titular = new TItular()
        {
            Cpf = "11044512538",
            Rg = "8954566",
            Endereco = "Rua da Palma",
            Nome = "Carlos Alberto"

        };

        Console.WriteLine($"Seu saldo é: {Conta.VerSaldo()}");

        Conta.Depositar(260);

        Console.WriteLine($"Seu saldo é: {Conta.VerSaldo()}");

        Conta.Sacar(280);

        Console.WriteLine($"Seu saldo é: {Conta.VerSaldo()}");

        Conta.Sacar(2000);

        Console.WriteLine($"Seu saldo é: {Conta.VerSaldo()}");

        Console.ReadKey();




    }
}