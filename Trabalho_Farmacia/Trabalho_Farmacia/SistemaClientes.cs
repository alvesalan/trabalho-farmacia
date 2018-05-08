using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SistemaClientes
    {
        string[] cliente = new string[100];
        string[] cpf = new string[100];
        string[] endereco = new string[100];
        string[] fone = new string[100];
        int[] idade = new int[100];
        double[] peso = new double[100];
        int atual = 0;
        public void CadastroCliente()
        {
            Console.Clear();
            Console.Write("Digite seu nome: ");
            cliente[atual] = Console.ReadLine().ToLower().Trim();

            try
            {
    
                Console.Write("Digite seu CPF: ");
                cpf[atual] = Console.ReadLine().ToLower();
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite apenas numeros !!");
                Console.WriteLine("Tente novamente !!");
                Console.Write("Digite seu CPF: ");
               cpf[atual] = Console.ReadLine().ToLower();
                
            }

            Console.Write("Digite seu endereço: ");
            endereco[atual] = Console.ReadLine();

            try
            {
                Console.Write("Digite sue telefone: ");
                fone[atual] = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite apenas numeros !!");
                Console.WriteLine("Tente novamente !");
                Console.Write("Digite sue telefone: ");
                fone[atual] = Console.ReadLine();
            }

            try
            {
                Console.Write("digite sua idade: ");
                idade[atual] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite apenas numeros !!");
                Console.WriteLine("Tente novamente");
                Console.Write("digite sua idade: ");
                idade[atual] = Convert.ToInt32(Console.ReadLine());
            }

            atual++;
            

        }
        public void Editarcliente()
        {
            Console.Clear();
            Console.Write("digite o nome para pesquisar: ");
            string pesquisa = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (pesquisa == cliente[i])
                {
                    posicao = i;
                }
                else if (pesquisa.Substring(0, 3) == cliente[i].Substring(0, 3))
                {
                    Console.Clear();
                    Console.WriteLine("Em nosso sistema possue o nome: " + cliente[i]);
                    Console.WriteLine("Caso seja o nome acima volte em (Editar e digite o nome corretamente)");
                }
            }

            if (posicao != -1)
            {
                Console.WriteLine(" Nome: " + cliente[posicao] +
                    "\n CPF: " + cpf[posicao] +
                    "\n endereco:" + endereco[posicao] +
                    "\n telefone: " + fone[posicao] +
                    "\n idade: " + idade[posicao]);
                   
                Console.WriteLine("");
                // Coloque informaçoes

                Console.Write("digite nome: ");
                cliente[posicao] = Console.ReadLine();
                Console.Write("Digite seu CPF: ");
                cpf[posicao] = Console.ReadLine();
                Console.Write("Digite seu endereso: ");
                endereco[posicao] = Console.ReadLine();
                Console.Write("Digite sue telefone:");
                fone[posicao] = Console.ReadLine();
                Console.Write("digite sua idade: ");
                idade[posicao] = Convert.ToInt32(Console.ReadLine());
               
            }
            else
            {
                Console.Write("nome nao encontrado!");

            }
            Console.ReadKey();
        }
        public void Buscarcliente()
        {
            Console.Clear();
            Console.Write("digite um nome para busca: ");
            string Buscanome = Console.ReadLine().ToLower();

            bool encontrou = false;

            for (int i = 0; i < atual; i++)
            {
                if (Buscanome == cliente[i])
                {
                    Console.Write(string.Format("\nNome:{0}\ncpf:{1}\nendereso:{2}\ntelefole:{3}\nIdade:{4}",
                        cliente[i], cpf[i], endereco[i], fone[i], idade[i]));
                    encontrou = true;
                    break;
                }
                else if (Buscanome.Substring(0, 3) == cliente[i].Substring(0, 3))
                {
                    Console.Clear();
                    Console.WriteLine("Em nosso sistema possue o nome: " + cliente[i]);
                    Console.WriteLine("Caso seja o nome acima volte em (Buscar e digite o nome corretamente)");

                }
                
            }

            if (!encontrou)
            {
                Console.WriteLine("Nome nao encontrado!!");

            }
            Console.ReadKey();
            
        }
        public void ListarCliente()
        {
            Console.Clear();
            Console.Write("lista de clientes ");

            for (int j = 0; j < atual; j++)
            {
                Console.WriteLine("");
                Console.Write(string.Format("\nNome: " + cliente[j] +
"\nCpf: " + cpf[j] +
"\nEndereço: " + endereco[j] +
"\nTelefole: " + fone[j] +
"\nIdade: " + idade[j]));
                Console.WriteLine("");
                
            }
            
            Console.ReadKey();
            
        }


    }
}







    
