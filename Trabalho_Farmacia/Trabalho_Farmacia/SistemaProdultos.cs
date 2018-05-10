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

        int VagaMaiorNome = 0, VagaMenorNome = int.MaxValue;
        string NomeMaiorNome = "", NomeMenorNome = "";
        string Nomeperiodo = "";
        int SomaC = 0;
        
        
        int Atual = 0;

//___________//_______________//________//_______//________//______________//________________//___________//___________//__________


       internal void CadastrarProdulto()
        {
            Console.Clear();
            Console.Write("Nome do produlto: ");
            Nome[Atual] = Console.ReadLine().ToLower().Trim();

           Console.Write("Fornecedor: ");
           Fornecedor[Atual] = Console.ReadLine().ToLower().Trim();


           bool ValidarP = true;
           while (ValidarP == true)
           {
               try
               {
                   Console.Clear();
                   Console.Write("Quantidade de produlto: ");
                   Quantidade[Atual] = Convert.ToInt32(Console.ReadLine());
                   ValidarP = false;
               }
               catch (Exception)
               {
                   Console.WriteLine("");
               }
           }


           bool Vall = true;
           while (Vall == true)
           {
               try
               {
                   Console.Clear();
                   Console.Write("Preço unitario do prdulto: ");
                   PreçoUnitario[Atual] = Convert.ToDouble(Console.ReadLine());
                   Vall = false;
               }
               catch (Exception)
               {
                   Console.WriteLine("");
               } 
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


               bool ValidarP = true;
               while (ValidarP == true)
               {
                   try
                   {
                       Console.Clear();
                       Console.Write("Quantidade de produlto: ");
                       Quantidade[Posição] = Convert.ToInt32(Console.ReadLine());
                       ValidarP = false;
                   }
                   catch (Exception)
                   {
                       Console.WriteLine("");
                   }
               }


               bool Vall = true;
               while (Vall == true)
               {
                   try
                   {
                       Console.Clear();
                       Console.Write("Preço unitario do prdulto: ");
                       PreçoUnitario[Posição] = Convert.ToDouble(Console.ReadLine());
                       Vall = false;
                   }
                   catch (Exception)
                   {
                       Console.WriteLine("");
                   }
               }

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
                Console.WriteLine("");
                Console.WriteLine("");
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

        public void EstatisticaProdultos()
        {
            Console.WriteLine("");
            Console.Write("Total de produltos cadatrado: " + Atual);

            for (int i = 0; i < Atual; i++)
            {
                if (Nome[i].Length > VagaMaiorNome)
                {
                    VagaMaiorNome = Nome[i].Length;
                    NomeMaiorNome = Nome[i];
                }
            }
            Console.WriteLine("\n");
            Console.Write("Nome do produlto com menor nome: " + NomeMaiorNome);

            for (int i = 0; i < Atual; i++)
            {
                if (Nome[i].Length < VagaMenorNome)
                {
                    VagaMenorNome = Nome[i].Length;
                    NomeMenorNome = Nome[i];
                }
            }
            Console.WriteLine("\n");
            Console.Write("Nome do produlto com menor nome: " + NomeMenorNome);

            for (int i = 0; i < Atual; i++)
            {
                SomaC = SomaC + Quantidade[i];
            }

            double Media = SomaC / Atual;
            Console.WriteLine("\n");
            Console.WriteLine("Media da quantidade Toatal de produltos: " + Media);
            Console.ReadKey();
        }
    }
}
