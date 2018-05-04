using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class SistemaFuncionarios
    {
        int Tamanho = 10;

        string[] Nomes = new string[1];
        string[] Cargo = new string[1];
        string[] Endereço = new string[1];

        double[] Salario = new double[1];

        int[] Cpf = new int[1];
        int[] Carteiradetrabalho = new int[1];
        int[] Telefone = new int[1];



        internal void SistemaFuncionarios2()
        {
            //Cadastrar Funcionario

            for (int i = 0; i < Tamanho; i++)
            {
            Console.WriteLine("Nome: ");
            Console.WriteLine("Cargo: ");
            Console.WriteLine("Salario: ");
            Console.WriteLine("Cpf: ");
            Console.WriteLine("Carteira de trabalho: ");
            Console.WriteLine("Endereço: ");
            Console.WriteLine("Telefone: ");

            }
        }
    }
}
