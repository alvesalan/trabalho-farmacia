using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class SistemaProdultos
    {
        string[] Nome = new string[100];
        string[] Fornecedor = new string[100];
        int[] Quantidade = new int[100];
        double[] PreçoUnitario  = new double[100];
        
        
        int Atual = 0;

//___________//_______________//________//_______//________//______________//________________//___________//___________//__________


       internal void CadastrarProdulto()
        {
            Console.Clear();
            Console.Write("Nome do produlto: ");
            Nome[Atual] = Console.ReadLine().ToLower().Trim();

           Console.Write("Fornecedor: ");
           Fornecedor[Atual] = Console.ReadLine().ToLower().Trim();

           try 
	    {	        
		   Console.Write("Quantidade de produlto: ");
           Quantidade[Atual] = Convert.ToInt32(Console.ReadLine());
	    }
	    catch (Exception)
	    {
        Console.WriteLine("Por favor digite apenas numeros!!");
		Console.Write("Quantidade de produlto: ");
        Quantidade[Atual] = Convert.ToInt32(Console.ReadLine());
	    }

           try
           {
               Console.Write("Preço unitario do prdulto: ");
               PreçoUnitario[Atual] = Convert.ToDouble(Console.ReadLine());
           }
           catch (Exception)
           {
               Console.WriteLine("Por favor digite apenas numeros !!");
               Console.Write("Preço unitario do prdulto: ");
               PreçoUnitario[Atual] = Convert.ToDouble(Console.ReadLine());
           }

           
           Atual++;
            
        }


 //___________//_______________//________//_______//________//______________//________________//___________//___________//__________


        internal void EditarProdulto()
        {
            Console.Clear();
            Console.Write("Digite o nome do produlto a ser editado: ");
            string EditarNomeProdulto = Console.ReadLine().ToLower().Trim(); 
            int Posição = -1;
            for (int i = 0; i < Atual; i++)
            {
                if (EditarNomeProdulto == Nome[i])
                {
                    Posição = i;
                } 
            }
            if (Posição != -1)
            {
                Console.Clear();
                Console.WriteLine("\nNome: " + Nome[Posição] +
                    "\nFornecedor: " + Fornecedor[Posição] +
                    "\nQuantidade: " + Quantidade[Posição] +
                    "\nPreço unitario: " + PreçoUnitario[Posição] + 
                    "\n\n");

                Console.Write("Nome do produlto: ");
                Nome[Posição] = Console.ReadLine().ToLower().Trim(); 

                Console.Write("Fornecedor: ");
                Fornecedor[Posição] = Console.ReadLine().ToLower().Trim(); 

                try
                {
                    Console.Write("Quantidade de produlto: ");
                    Quantidade[Posição] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas numeros!!");
                    Console.Write("Quantidade de produlto: ");
                    Quantidade[Posição] = Convert.ToInt32(Console.ReadLine());
                }

                try
                {
                    Console.Write("Preço unitario do prdulto: ");
                    PreçoUnitario[Posição] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas numeros !!");
                    Console.Write("Preço unitario do prdulto: ");
                    PreçoUnitario[Posição] = Convert.ToDouble(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Reagistro não encontrado !!");
                Console.ReadKey();
            }
            
        }


//___________//_______________//________//_______//________//______________//________________//___________//___________//__________


        internal void BuscarProdulto()
        {
            Console.Clear();
            Console.Write("Digite o nome do prdulto: ");
            string NomeProdulto = Console.ReadLine().ToLower().Trim(); ;
            bool achou = false;
            for (int i = 0; i < Atual; i++)
            {
                if (NomeProdulto == Nome[i])
                {
                    Console.Write("\nNome: " + Nome[i] +
                        "\nFornecedor: " + Fornecedor[i] +
                        "\nQuantidade: " + Quantidade[i] +
                        "\nPreço unitario: " + PreçoUnitario[i] +
                        "\n\n Para voltar aperte uma tecla !!: ");
                    Console.ReadKey();
                    achou = true;
                    break;
                }
              }
            if (achou == false)
            {
                
                Console.WriteLine("Registro não encontrado, tente novamente ou cadastre esse produlto em nosso sistema !!" +
                    " ");
                Console.ReadKey();
            }
            
        }

        
//___________//_______________//________//_______//________//______________//________________//___________//___________//__________

        internal void ListarProdultos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Produltos");
            for (int i = 0; i < Atual; i++)
            {
                Console.Write(string.Format("Nome {0} : " + Nome[i] + 
                    "\n Fornecedor: " + Fornecedor[i] +
                    "\n Quantidade: " + Quantidade[i] +
                    "\n Valor unitario: " + PreçoUnitario[i] + 
                    "\n Valor Total: " + (Quantidade[i] * PreçoUnitario[i]),i + 1));
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
