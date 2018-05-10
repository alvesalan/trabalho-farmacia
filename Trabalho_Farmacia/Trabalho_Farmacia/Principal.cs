﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class Principal
    {
        Principal2 principal2 = new Principal2();
        public Principal()
        {
            GerirMenu();

        }
        // Apresentar menu para o usuario 
        public void Menu()
        {

          
            Console.Clear();
            

            Console.WriteLine(@"                    _____________________________
                    | 1- |Sistema Cliente       |
                    | 2- |Sistema Funcionario   |
                    | 3- |Sistema Produltos     |
                    | 4- |Sistema Vagas         |
                    |____|______________________|
                    |                           |
                    |20- Sair                   |
                    |___________________________|");
                    Console.WriteLine("");
                    Console.Write("Escolha uma opção: ");


           
           
        }


        public void GerirMenu()
        {
            //Chama método para apresentar o menu para o usuário
            int menuEscolha = 0;
            bool ValidarEscolhaMenu = true;  
          
            while (ValidarEscolhaMenu == true)
            {
                try
                {
                    Menu();
                    menuEscolha = Convert.ToInt32(Console.ReadLine());
                    ValidarEscolhaMenu = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("");
                }
              
            }
            
            

            while (menuEscolha != 20)
            {
                switch (menuEscolha)
                {
                    case 1:
                        principal2.SistemaClientes();
                        break;
                    case 2:
                        principal2.SistemaFuncionarios();
                        break;
                    case 3:
                        principal2.SistemaProdultos();
                        break;
                    case 4:
                        principal2.SistemaVagas();
                        break;
                }

                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}