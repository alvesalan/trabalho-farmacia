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
                    Console.Write("Nome: ");
                    Nomes[i] = Console.ReadLine();

                    Console.Write("Cargo: ");
                    Cargo[i] = Console.ReadLine();

                    Console.Write("Salario: ");
                    Salario[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Cpf: ");
                    Cpf[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Carteira de trabalho: ");
                    Carteiradetrabalho[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Endereço: ");
                    Endereço[i] = Console.ReadLine();

                    Console.Write("Telefone: ");
                    Salario[i] = Convert.ToInt32(Console.ReadLine());
                    
               
                }
        }
    }
}
