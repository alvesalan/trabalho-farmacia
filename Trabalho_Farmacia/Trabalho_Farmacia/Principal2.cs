using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class Principal2
    {
        SistemaFuncionarios sistemafuncionarios = new SistemaFuncionarios();

        public void SistemaClientes()
        {
        }
        internal void SistemaFuncionarios()
        {
                Console.Clear(); 
               Console.WriteLine(@"1- Cadastrar Funcionario  
2- Editar Funcionario   
3- Buscar Funcionario   
4- Listar Funcionario");
                Console.WriteLine("");
                Console.Write("Escolha sua opção: ");
                int MenuSistemaFuncionario = Convert.ToInt32(Console.ReadLine());

                while (MenuSistemaFuncionario != 20)
                {
                    switch (MenuSistemaFuncionario)
                    {
                        case 1:
                            sistemafuncionarios.SistemaFuncionarios2();

                            break;
                        case 2:
                            sistemafuncionarios.EditarFuncionario();
                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                   

                }
                    SistemaFuncionarios();


            }

        }





        internal void SistemaProdultos()
        {
            throw new NotImplementedException();
        }


        internal void SistemaVagas()
        {
            throw new NotImplementedException();
        }
}    }     