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
        int VagaMaiorNome = 0, VagaMenorNome = int.MaxValue;
        string NomeMaiorNome = "", NomeMenorNome = "";
        string Nomeperiodo = "";
        int SomaC = 0;
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
            Console.Write("Digite uma vaga para ser pesquisado: ");
            string pesquisaV = Console.ReadLine().ToLower().Trim();
            int pocicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (pesquisaV == nomeVaga[i])
                {
                    pocicao = i;
                }
            }
            if (pocicao != -1)
            {
                Console.WriteLine("Quantidade de pessoas para essa vaga: " + curricolo[pocicao] +
                    "\nVaga: " + nomeVaga[pocicao] +
                    "\nPeriodo: " + periodo[pocicao] +
                    "\nCargo: " + cargo[pocicao] +
                    "\nBeneficios: " + benaficio[pocicao]);
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
            string Buscavaga = Console.ReadLine().ToLower().Trim();
            bool encontrou = false;

            for (int i = 0; i < atual; i++)
            {
                if (Buscavaga == nomeVaga[i])
                {
                    Console.WriteLine(string.Format("\nQuantidade de funcionarios para essa vaga: {0}\nNome: {1}\nCargo: {2}\nBeneficios: {3}",
                  curricolo[i], nomeVaga[i], cargo[i], benaficio[i]));
                    encontrou = true;
                    Console.ReadKey();
                    break;
                }
                
                
            }

            if (!encontrou)
            {
                Console.WriteLine("nome nao encontrado!");
                
            }
            Console.ReadKey();
        }
        public void listatVagas()
        {
            Console.Clear();
            Console.Write("Lista de vagas");
            for (int i = 0; i < atual; i++)
            {

                if (periodo[i] == 1)
                {
                    Nomeperiodo = "Matutino";
                }
                else if (periodo[i] == 2)
                {
                    Nomeperiodo = "Vespetino";
                }
                else if (periodo[i] == 3)
                {
                    Nomeperiodo = " Horario Integral (Matutino e Vespetino)";
                }
                else if (periodo[i] == 4)
                {
                    Nomeperiodo = "Noturno";
                }

                Console.WriteLine(string.Format("\nQuantidade de funcionarios para essa vaga: {0}\nNome: {1}\nCargo: {2}\nBeneficios: {3}\nPeriodo: {4}",
                   curricolo[i], nomeVaga[i], cargo[i], benaficio[i], Nomeperiodo));

                
            }
            Console.ReadKey();

        }

        public void EstatisticaVagas()
        {
            Console.WriteLine("");
            Console.Write("Total de vagas cadatrado: " + atual);
            for (int i = 0; i < atual; i++)
            {
                if (nomeVaga[i].Length > VagaMaiorNome)
                {
                    VagaMaiorNome = nomeVaga[i].Length;
                    NomeMaiorNome = nomeVaga[i];
                }
            }
            Console.WriteLine("\n");
            Console.Write("Nome da vaga com maior nome: " + NomeMaiorNome);

            for (int i = 0; i < atual; i++)
            {
                if (nomeVaga[i].Length < VagaMenorNome)
                {
                    VagaMenorNome = nomeVaga[i].Length;
                    NomeMenorNome = nomeVaga[i];
                }
            }
            Console.WriteLine("\n");
            Console.Write("Nome da vaga com menor nome: " + NomeMenorNome);

            for (int i = 0; i < atual; i++)
            {
                 SomaC = SomaC + curricolo[i];
            }

            double Media = SomaC / atual;
            Console.WriteLine("\n");
            Console.WriteLine("Media de quantidade de vagas: " + Media);
            Console.ReadKey();
        }
    }
}
