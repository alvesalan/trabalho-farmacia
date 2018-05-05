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

        double[] Cpf = new double[100];
        double[] Carteiradetrabalho = new double[100];
        int[] Telefone = new int[100];
        int Atual = 0;


        public void SistemaFuncionarios2()
        {
            Console.Clear();



            //Cadastrar Funcionario



            Console.Write("Nome: ");
            Nomes[Atual] = Console.ReadLine().ToLower().Trim();

            Console.Write("Cargo: ");
            Cargo[Atual] = Console.ReadLine();

            try
            {
                Console.Write("Salario: ");
                Salario[Atual] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {           
                    Console.WriteLine("Por Favor digite apenas numeros");
                    Console.Write("Salario: ");
                    Salario[Atual] = Convert.ToDouble(Console.ReadLine());
                               
            }

            try
            {
                Console.Write("Cpf   (Apenas numeros): ");
                Cpf[Atual] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por Favor digite apenas numeros");
                Console.Write("Cpf   (Apenas numeros): ");
                Cpf[Atual] = Convert.ToDouble(Console.ReadLine());
            }

            try
            {
                Console.Write("Carteira de trabalho  (Apenas numeros): ");
                Carteiradetrabalho[Atual] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por Favor digite apenas numeros");
                Console.Write("Carteira de trabalho  (Apenas numeros): ");
                Carteiradetrabalho[Atual] = Convert.ToDouble(Console.ReadLine());
            }
            

            Console.Write("Endereço: ");
            Endereço[Atual] = Console.ReadLine();
            try
            {
                Console.Write("Telefone  (Ex: 4798887777)  : ");
                Salario[Atual] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por Favor digite apenas numeros");
                Console.Write("Telefone  (Ex: 4798887777)  : ");
                Salario[Atual] = Convert.ToInt32(Console.ReadLine());
            }
            

            Atual++;
           



        }

        //Editar funcionario
        public void EditarFuncionario()
        {
            Console.Write("Digite o nome do funcionario a ser editado: ");
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
                Console.Write("   Nome: " + Nomes[Posiçao] +
                    "\n   Cargo: " + Cargo[Posiçao] +
                    "\n   Salario: " + Salario[Posiçao] +
                    "\n   Cpf: " + Cpf[Posiçao] +
                    "\n   N° Carteira de trabalho: " + Carteiradetrabalho[Posiçao] +
                    "\n   Endereço: " + Endereço[Posiçao] +
                    "\n   Salario: " + Salario[Posiçao]);
                Console.WriteLine("");

                Console.Write("Nome: ");
                Nomes[Posiçao] = Console.ReadLine().ToLower().Trim(); 

                Console.Write("Cargo: ");
                Cargo[Posiçao] = Console.ReadLine();
                try
                {
                    Console.Write("Salario: ");
                    Salario[Posiçao] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por Favor digite apenas numeros");
                    Console.Write("Salario: ");
                    Salario[Posiçao] = Convert.ToDouble(Console.ReadLine());
                   
                }

                try
                {
                    Console.Write("Cpf: ");
                    Cpf[Posiçao] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por Favor digite apenas numeros");
                    Console.Write("Cpf: ");
                    Cpf[Posiçao] = Convert.ToDouble(Console.ReadLine());
                }

                try
                {
                    Console.Write("Carteira de trabalho  (Apenas numeros): ");
                    Carteiradetrabalho[Posiçao] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por Favor digite apenas numeros");
                    Console.Write("Carteira de trabalho  (Apenas numeros): ");
                    Carteiradetrabalho[Posiçao] = Convert.ToDouble(Console.ReadLine());
                }
                

                Console.Write("Endereço: ");
                Endereço[Posiçao] = Console.ReadLine();

                try
                {
                    Console.Write("Telefone  (Ex: 4798887777)  : ");
                    Salario[Posiçao] = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Por Favor digite apenas numeros");
                    Console.Write("Telefone  (Ex: 4798887777)  : ");
                    Salario[Posiçao] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Dados alterados com sucesso ");
                // Apos editar o programa nao salva o novo cadastro editado
                // depois de editar nao volta ao menu
            }
            else
            {
                Console.WriteLine("Regitro não encontrado !!");


            }
            Console.ReadKey();

        }





    }
}

