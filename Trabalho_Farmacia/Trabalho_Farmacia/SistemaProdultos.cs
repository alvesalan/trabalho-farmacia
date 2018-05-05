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
        double[] DataValidade = new double[100];
        
        int Atual = 0;

//___________//_______________//________//_______//________//______________//________________//___________//___________//__________


       internal void CadastrarProdulto()
        {
            Console.Clear();
            Console.Write("Nome do produlto: ");
            Nome[Atual] = Console.ReadLine();

           Console.Write("Fornecedor: ");
           Fornecedor[Atual] = Console.ReadLine();

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
            
            Console.WriteLine("aaaaaaaaa");
            Console.ReadKey();
        }


//___________//_______________//________//_______//________//______________//________________//___________//___________//__________


        internal void BuscarProdulto()
        {
           
            Console.WriteLine("aaaaaaaaa");
            Console.ReadKey();
        }

        
//___________//_______________//________//_______//________//______________//________________//___________//___________//__________

        internal void ListarProdultos()
        {
           
            Console.WriteLine("aaaaaaaaa");
            Console.ReadKey();
        }
    }
}
