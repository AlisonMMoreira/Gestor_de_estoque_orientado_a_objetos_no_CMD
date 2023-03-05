using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque_orientado_a_objetos_no_CMD
{
    class Program
    {
        
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }

        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de estoque");
            Console.WriteLine("1-Listar\n2-Atualizar\n3-Remover\n4-Registrar entrada\n5-Saída\n6-Sair");
            string opStr = Console.ReadLine();
            int opInt = int.Parse(opStr);

            bool escolheuSair = false;
            while(escolheuSair = false)
            {
                

                if(opInt > 0 && opInt < 7)
                {
                    Menu escolha = (Menu)opInt;
                    switch (escolha)
                    {
                        case Menu.Listar:
                            break;
                        case Menu.Adicionar:
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.Entrada:
                            break;
                        case Menu.Saida:
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
            }
        }
    }
}
