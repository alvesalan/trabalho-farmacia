using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class SistemaFuncionarios
    {

        string[] Nomes = new string[100];
        string[] Cargo = new string[100];
        string[] Endereço = new string[100];

        double[] Salario = new double[100];

        int[] Cpf = new int[100];
        int[] Carteiradetrabalho = new int[100];
        int[] Telefone = new int[100];
        int Atual = 0;


        public void SistemaFuncionarios2()
        {
            Console.Clear();



            //Cadastrar Funcionario



            Console.Write("Nome: ");
            Nomes[Atual] = Console.ReadLine();

            Console.Write("Cargo: ");
            Cargo[Atual] = Console.ReadLine();

            Console.Write("Salario: ");
            Salario[Atual] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cpf: ");
            Cpf[Atual] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Carteira de trabalho: ");
            Carteiradetrabalho[Atual] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Endereço: ");
            Endereço[Atual] = Console.ReadLine();

            Console.Write("Telefone: ");
            Salario[Atual] = Convert.ToInt32(Console.ReadLine());

           



        }


        public void EditarFuncionario()
        {
            Console.WriteLine("Digite o nome do funcionario a ser editado: ");
            string NomePesquisado = Console.ReadLine().ToLower().Trim();

            int Posiçao = -1;

            for (int i = 0; i < Atual; i++)
            {
                if (NomePesquisado == Nomes[i])
                {
                    Posiçao = i;
                }
            }

            if (Posiçao != -1)
            {
                Console.Write("   Nome: " + Nomes[Atual] + 
                    "\n   Cargo: " + Cargo[Atual] + 
                    "\n   Salario: " + Salario[Atual] + 
                    "\n   Cpf: " + Cpf[Atual] + 
                    "\n   N° Carteira de trabalho: " + Carteiradetrabalho[Atual] + 
                    "\n   Endereço: " + Endereço[Atual] + 
                    "\n   Salario: " +  Salario[Atual]);
                Console.WriteLine("");

                Console.Write("Nome: ");
                Nomes[Atual] = Console.ReadLine();

                Console.Write("Cargo: ");
                Cargo[Atual] = Console.ReadLine();

                Console.Write("Salario: ");
                Salario[Atual] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Cpf: ");
                Cpf[Atual] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Carteira de trabalho: ");
                Carteiradetrabalho[Atual] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Endereço: ");
                Endereço[Atual] = Console.ReadLine();

                Console.Write("Telefone: ");
                Salario[Atual] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dados alterados com sucesso ");
            }
            else
            {
                Console.WriteLine("Regitro não encontrado !!");


            }
            Console.ReadKey();

        }





    }
}

