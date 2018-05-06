using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_Farmacia
{
    class Principal2
    {
        SistemaFuncionarios sistemafuncionarios = new SistemaFuncionarios();
        SistemaClientes sistemaclientes = new SistemaClientes();
        SistemaProdultos sistemaprodultos = new SistemaProdultos();
       
        
        

//_____________//______________//___________________//__________________//__________________//____________________        


            public void SistemaClientes()
        {
            
                Console.Clear(); 
               Console.WriteLine(@"1- Cadastrar Cliente  
2- Editar Clientes   
3- Buscar Clientes  
4- Listar Clientes");
                Console.WriteLine("");
                Console.Write("Escolha sua opção: ");
                int MenuSistemaCliente = Convert.ToInt32(Console.ReadLine());

                while (MenuSistemaCliente != 20)
                {
                    switch (MenuSistemaCliente)
                    {
                        case 1:
                            sistemaclientes.CadastroCliente();

                            break;
                        case 2:
                            sistemaclientes.Editarcliente();
                            break;
                        case 3:
                             sistemaclientes.Buscarcliente();
                            break;
                        case 4:
                             sistemaclientes.ListarCliente();
                            break;
                   

                }
                    SistemaClientes();

        }

        }
        
//_____________//_________________//__________________//______________________//______________________//___________________//_________           

            public void SistemaFuncionarios()
            {
                int MenuSistemaFuncionario = 0;
                try
                {	
            Console.Clear();
            Console.WriteLine(@"                     ________________________________
                     | 1- |  Cadastrar Funcionario   |
                     | 2- |  Editar Funcionario      |
                     | 3- |  Buscar Funcionario      |
                     | 4- |  Listar Funcionario      |
                     |____|__________________________|
                     | 20-|  Voltar Menu Anterior    |
                     |____|__________________________|");
            Console.WriteLine("");

                             
	 
                    Console.Write("Escolha sua opção: ");
                    MenuSistemaFuncionario = Convert.ToInt32(Console.ReadLine());	
	                    }
	                catch (Exception)
	                    {
                            Console.Clear();
                            Console.WriteLine(@"                     ________________________________
                     | 1- |  Cadastrar Funcionario   |
                     | 2- |  Editar Funcionario      |
                     | 3- |  Buscar Funcionario      |
                     | 4- |  Listar Funcionario      |
                     |____|__________________________|
                     | 20-|  Voltar Menu Anterior    |
                     |____|__________________________|");
                            Console.WriteLine("");
		                    Console.WriteLine("Por favor digite apenas numeros");
                    Console.Write("Escolha sua opção: ");
                    MenuSistemaFuncionario = Convert.ToInt32(Console.ReadLine());
	                    }
              

                 while (MenuSistemaFuncionario != 20)
                {
                    switch (MenuSistemaFuncionario)
                    {
                        case 1:
                            sistemafuncionarios.CadastroFuncionario();

                            break;
                        case 2:
                            sistemafuncionarios.EditarFuncionario();

                            break;
                        case 3:
                            sistemafuncionarios.BuscarFuncionario();

                            break;
                        case 4:
                            sistemafuncionarios.ListarFuncionario();

                            break;
                   

                }
                    SistemaFuncionarios();
                   }
                
        }


//____________________//_______________//____________________//__________________//_______________________//______________________//________


        public void SistemaProdultos()
        {

            Console.Clear();
            Console.WriteLine(@"                        _____ __________________________
                       | 1-  |  Cadastrar produlto      | 
                       | 2-  |  Editar produlto         |
                       | 3-  |  Buscar produlto         |
                       | 4-  |  Listar produltos        |
                       |_____|__________________________|
                       | 20- |  Voltar ao menu anterior |
                       |_____|__________________________|");
            int MenuSistemaProdultos = 0;
            try
            {

                Console.Write("Escolha sua opção: ");
                MenuSistemaProdultos = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Por favor digite apenas numeros !!");
                Console.Write("Escolha sua opção: ");
                MenuSistemaProdultos = Convert.ToInt32(Console.ReadLine());
                
            }
            while (MenuSistemaProdultos != 20)
            {
                switch (MenuSistemaProdultos)
                {
                    case 1:
                        sistemaprodultos.CadastrarProdulto();
                        break;
                    case 2:
                        sistemaprodultos.EditarProdulto();
                        break;
                    case 3:
                        sistemaprodultos.BuscarProdulto();
                        break;
                    case 4:
                        sistemaprodultos.ListarProdultos();
                        break;
                }
                SistemaProdultos();
            }
           
        }

//______________________//_________________//_________________//______________________//____________________//___________________//________
        public void SistemaVagas()
        {
            throw new NotImplementedException();
        }
}    }     