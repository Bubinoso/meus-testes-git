using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancária contaBancária1 = new ContaBancária();
            contaBancária1.nome = "Ramon Camolez";
            contaBancária1.Depósito(500.35);
            contaBancária1.MostrarDetalhes();

            ContaBancária contaBancária2 = new ContaBancária();
            contaBancária2.nome = "João Vitor";
            contaBancária2.Depósito(180.48);
            contaBancária2.MostrarDetalhes();

            ContaBancária contaBancária3 = new ContaBancária();
            contaBancária3.nome = "Carlos Eduardo";
            contaBancária3.Depósito(381.29);
            contaBancária3.MostrarDetalhes();
            Console.ReadLine();
        }
    }
    public class ContaBancária
    {
        public string nome;
        public double corrente;
        public void Depósito(double quantia)
        {
            corrente += quantia;
        }
        public void MostrarDetalhes()
        {
            Console.WriteLine($"{nome} possui saldo de: {corrente:C2}");
        }
    }

}
