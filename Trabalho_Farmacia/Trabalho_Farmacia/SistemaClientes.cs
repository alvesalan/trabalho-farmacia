using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class SistemaClientes
    {

        string[] cliente = new string[100];
        double[] cpf = new double[100];
        string[] endereco = new string[100];
        int[] fone = new int[100];
        int[] idade = new int[100];
        double[] peso = new double[100];
        int atual = 0;
        public void CadastroCliente()
        {

            Console.WriteLine("Digite seu nome: ");
            cliente[atual] = Console.ReadLine().ToLower();
            Console.WriteLine("Dijite seu CPF: ");
            cpf[atual] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dijite seu endereso: ");
            endereco[atual] = Console.ReadLine();
            Console.WriteLine("Dijite sue telefone:");
            fone[atual] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite sua idade: ");
            idade[atual] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite seu peso: ");
            peso[atual] = Convert.ToDouble(Console.ReadLine());
            atual++;

        }
        public void Editarcliente()
        {
            Console.Clear();
            Console.WriteLine("digite o nume para pesquisar: ");
            string pesquisa = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (pesquisa == cliente[i])
                {
                    posicao = i;
                }
            }
            if (posicao != -1)
            {
                Console.WriteLine("digite seu nome: ");
                cliente[posicao] = Console.ReadLine();
                Console.WriteLine("Dijite seu CPF: ");
                cpf[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dijite seu endereso: ");
                endereco[posicao] = Console.ReadLine();
                Console.WriteLine("Dijite sue telefone:");
                fone[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite sua idade: ");
                idade[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite seu peso: ");
                peso[posicao] = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("nome nao emcontrado!");

            }
            Console.ReadKey();
        }
        public void Buscarcliente()
        {
            Console.WriteLine("digite um nome para busca: ");
            string Buscanome = Console.ReadLine().ToLower();
            bool emcontrou = true;
            for (int i = 0; i < atual; i++)
            {
                if (Buscanome == cliente[i])
                {

                }
            }

        }

    }

}





