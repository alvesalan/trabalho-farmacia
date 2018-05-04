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

            Console.WriteLine(@"1- Cadastrar Funcionario  
2- Editar Funcionario   
3- Buscar Funcionario   
4- Listar Funcionario");

            int MenuSistemaFuncionario = 0;

            while (MenuSistemaFuncionario != 20)
            {
                switch (MenuSistemaFuncionario)
                {
                    case 1:
                        sistemafuncionarios.SistemaFuncionarios2();

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }

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
    }  }     