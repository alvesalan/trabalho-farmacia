using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class SistemaVagas
    {
        int[] curricolo = new int[100];
        string[] nomeVaga = new string[100];
        int[] periodo = new int[100];
        string[] cargo = new string[100];
        string[] benaficio = new string[100];
        int atual = 0;
        int VagaMaiorNome = int.MaxValue, VagaMenorNome = 0;
        string NomeMaiorNome = "", NomeMenorNome = "";
        public void cadastrarVaga()
        {
            Console.Clear();
            try
            {
                Console.Write("Quantidade de funcionario para essa vaga: ");
                curricolo[atual] = Convert.ToInt32(Console.ReadLine().ToLower());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite apenas numeros: ");
                Console.Write("Quantidade de funcionario para essa vaga: ");
                curricolo[atual] = Convert.ToInt32(Console.ReadLine().ToLower());
            }
            
            Console.Write("Digite nome da vaga: ");
            nomeVaga[atual] = Console.ReadLine().ToLower();


            try
            {
                Console.WriteLine(@"                   _______________________________________________
                  | 1- |  Matutino                                | 
                  | 2- |  Vespetino                               | 
                  | 3- | Horario Integral (Matutino e Vespetino)  |
                  | 4- |  Noturno                                 |
                  |____|__________________________________________|");
                Console.Write("Digite o periodo: ");
                periodo[atual] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Porfavor digite apenas numeros !!");
                Console.WriteLine(@"                   _______________________________________________
                  | 1- |  Matutino                                | 
                  | 2- |  Vespetino                               | 
                  | 3- | Horario Integral (Matutino e Vespetino)  |
                  | 4- |  Noturno                                 |
                  |____|__________________________________________|");
                Console.Write("Digite o periodo: ");
                periodo[atual] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("Digite cargo: ");
            cargo[atual] = Console.ReadLine();
           
           
            Console.Write("Digite os beneficios: ");
            benaficio[atual] = Console.ReadLine();
            atual++;

        }
        public void editarVaga()
        {
            Console.Clear();
            Console.Write("Digite uma vaga para ser pesquisada: ");
            string pesquisaV = Console.ReadLine().ToLower().Trim();
            int pocicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (pesquisaV == nomeVaga[i])
                {
                    pocicao = -1;
                }
            }
            if (pocicao != -1)
            {
                Console.WriteLine("Quantidade de pessoas para essa vaga: " + curricolo[atual] +
                    "\nVaga: " + nomeVaga[atual] +
                    "\nPeriodo: " + periodo[atual] +
                    "\nCargo: " + cargo[atual] +                    
                    "\nBeneficios: " + benaficio[atual]);
                Console.WriteLine("");

                try
                {
                    Console.Write("Quantidade de pessoa para essa vaga: ");
                    curricolo[pocicao] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Por favor digite apenas numeros !!");
                    Console.Write("Quantidade de pessoa para essa vaga: ");
                    curricolo[pocicao] = Convert.ToInt32(Console.ReadLine());
                }
                
                Console.Write("Digite nome da vaga: ");
                nomeVaga[pocicao] = Console.ReadLine();
                try
                {
                    Console.WriteLine(@"                   _______________________________________________
                  | 1- |  Matutino                                | 
                  | 2- |  Vespetino                               | 
                  | 3- | Horario Integral (Matutino e Vespetino)  |
                  | 4- |  Noturno                                 |
                  |____|__________________________________________|");
                    Console.Write("Digite o periodo: ");
                    periodo[pocicao] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Porfavor digite apenas numeros !!");
                    Console.WriteLine(@"                   _______________________________________________
                  | 1- |  Matutino                                | 
                  | 2- |  Vespetino                               | 
                  | 3- | Horario Integral (Matutino e Vespetino)  |
                  | 4- |  Noturno                                 |
                  |____|__________________________________________|");
                    Console.Write("Digite o periodo: ");
                    periodo[pocicao] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Digite o cargo: ");
                cargo[pocicao] = Console.ReadLine();
                
                Console.Write("Digite os benaficios: ");
                benaficio[pocicao] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nome nao encontrado!!");
            }
            Console.ReadKey();

        }
        public void buscarVagas()
        {
            Console.Clear();
            Console.Write("digite um nome para busca de vaga: ");
            string Buscavaga = Console.ReadLine().ToLower();
            bool encontrou = true;
            for (int i = 0; i < atual; i++)
            {
                if (Buscavaga == nomeVaga[atual])
                {
                    Console.WriteLine(string.Format("\nQuantidade de funcionarios para essa vaga:{0}\nNome:{1}\nCargo:{2}\nBeneficios:{3}",
                  curricolo[i], nomeVaga[i], cargo[i], benaficio[i]));
                    encontrou = true;
                    Console.ReadKey();
                    break;
                }
                if (!encontrou)
                {
                    Console.WriteLine("nome nao encontrado!");
                    Console.ReadKey();
                }
                
            }
            Console.ReadKey();
        }
        public void listatVagas()
        {
            Console.Clear();
            Console.Write("Lista de vagas: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(string.Format("\nQuantidade de funcionarios para essa vaga:{0}\nNome:{1}\nCargo:{2}\nBeneficios:{3}",
                   curricolo[i], nomeVaga[i], cargo[i], benaficio[i]));
                
            }
            Console.ReadKey();

        }

        public void EstatisticaVagas()
        {
            Console.Write("Total de vagas cadatrado: " + atual);
            for (int i = 0; i < atual; i++)
            {
                if (VagaMaiorNome > nomeVaga[i].Length)
                {
                    NomeMaiorNome = nomeVaga[i];
                }
            }
            Console.Write("Nome da vaga com maior nome: " + NomeMaiorNome);

            for (int i = 0; i < atual; i++)
            {
                if (VagaMenorNome < nomeVaga[i].Length)
                {
                    NomeMenorNome = nomeVaga[i];
                }
            }
            Console.Write("Nome da vaga com menor nome: " + NomeMenorNome);
            Console.ReadKey();
        }
    }
}
