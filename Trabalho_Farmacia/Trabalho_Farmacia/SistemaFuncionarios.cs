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

        string[] Cpf = new string[100];
        string[] Carteiradetrabalho = new string[100];
        string[] Telefone = new string[100];
        int Atual = 0;
        int Posiçao = -1;

//_____//-------//_______/--------//_________/----------//-------------//________________//---------------/-_______-


        public void CadastroFuncionario()
        {
            Console.Clear();



            //Cadastrar Funcionario



            Console.Write("Nome: ");
            Nomes[Atual] = Console.ReadLine().ToLower().Trim();

            Console.Write("Cargo: ");
            Cargo[Atual] = Console.ReadLine().ToLower().Trim();

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
                Console.Write("Cpf: ");
                Cpf[Atual] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Por Favor digite apenas numeros");
                Console.Write("Cpf: ");
                Cpf[Atual] = Console.ReadLine();
            }

            try
            {
                Console.Write("Carteira de trabalho: ");
                Carteiradetrabalho[Atual] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Por Favor digite apenas numeros");
                Console.Write("Carteira de trabalho: ");
                Carteiradetrabalho[Atual] = Console.ReadLine();
            }
            

            Console.Write("Endereço: ");
            Endereço[Atual] = Console.ReadLine().ToLower().Trim();
            try
            {
                Console.Write("Telefone: ");
                Telefone[Atual] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Por Favor digite apenas numeros");
                Console.Write("Telefone: ");
                Telefone[Atual] = Console.ReadLine();
            }
            

            Atual++;
           



        }

        //Editar funcionario
        public void EditarFuncionario()
        {
            Console.Write("Digite o nome do funcionario a ser editado: ");
            string NomePesquisado = Console.ReadLine().ToLower().Trim();



            for (int i = 0; i < Atual; i++)
            {
                if (NomePesquisado == Nomes[i])
                {
                    Posiçao = i;
                }
                else if (NomePesquisado.Substring(0, 3) == Nomes[i].Substring(0, 3))
                {
                    Console.Clear();
                    Console.WriteLine("Em nosso sistema possue o nome: " + Nomes[i]);
                    Console.WriteLine("Caso seja o nome acima volte em (Editar e digite o nome corretamente)");
                }

            }

            if (Posiçao != -1)
            {
                Console.Clear();
                Console.Write("   Nome: " + Nomes[Posiçao] +
                    "\n   Cargo: " + Cargo[Posiçao] +
                    "\n   Salario: " + Salario[Posiçao] +
                    "\n   Cpf: " + Cpf[Posiçao] +
                    "\n   N° Carteira de trabalho: " + Carteiradetrabalho[Posiçao] +
                    "\n   Endereço: " + Endereço[Posiçao]);
                   
                Console.WriteLine("");

                Console.Write("Nome: ");
                Nomes[Posiçao] = Console.ReadLine().ToLower().Trim(); 

                Console.Write("Cargo: ");
                Cargo[Posiçao] = Console.ReadLine().ToLower().Trim();
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
                    Cpf[Posiçao] = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Por Favor digite apenas numeros");
                    Console.Write("Cpf: ");
                    Cpf[Posiçao] = Console.ReadLine();
                }

                try
                {
                    Console.Write("Carteira de trabalho: ");
                    Carteiradetrabalho[Posiçao] = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Por Favor digite apenas numeros");
                    Console.Write("Carteira de trabalho: ");
                    Carteiradetrabalho[Posiçao] = Console.ReadLine();
                }
                

                Console.Write("Endereço: ");
                Endereço[Posiçao] = Console.ReadLine();

                try
                {
                    Console.Write("Telefone: ");
                    Telefone[Posiçao] = Console.ReadLine();
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Por Favor digite apenas numeros");
                    Console.Write("Telefone: ");
                    Telefone[Posiçao] = Console.ReadLine();
                }

                Console.WriteLine("Dados alterados com sucesso ");
                // Apos editar o programa nao salva o novo cadastro editado
                // depois de editar nao volta ao menu
            }
            else
            {
                
                Console.WriteLine("Regitro não encontrado !!" + 
                    "\n Para continuar aperte uma tecla: ");


            }
            Console.ReadKey();
        }



            public void BuscarFuncionario()
            {
                Console.Write("Digite o nome do funcionario: ");
                string NomeBusca = Console.ReadLine().ToLower().Trim(); 
                bool Achou = false;

                for (int j = 0; j < Atual; j++)
                {
                    if (NomeBusca == Nomes[j])
                    {

                        Console.WriteLine(string.Format(@"Nome: " + Nomes[j] + 
                        "\nCargo: "+ Cargo[j] +
                        "\nSalario: " + Salario[j] +
                        "\nCpf: "+ Cpf[j] +
                        "\nN° Carteira da trabalho: " + Carteiradetrabalho[j] + 
                        "\nEndereço: " + Endereço[j]));
                        Console.WriteLine("");
                        Achou = true;
                    }
                   
                    
                }
                    if(!Achou)
                    {
                        Console.Write("\nNome não encontrado !!" + 
                            "\n" +
                            "Para continua aperte uma tecla: ");

                    }

                    Console.ReadKey();
                
                
            }


            public void ListarFuncionario()
            {
                Console.WriteLine("Lista de funcionarios: ");
                for (int i = 0; i < Atual; i++)
                {
                    Console.WriteLine(string.Format("Nome {0} : " + Nomes[i] + "   Cargo: "+ Cargo[i], i + 1));
                }
                Console.ReadKey();
            }
       




    }
}

