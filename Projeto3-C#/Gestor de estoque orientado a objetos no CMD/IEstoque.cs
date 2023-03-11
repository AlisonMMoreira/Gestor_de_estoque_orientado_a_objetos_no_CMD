using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque_orientado_a_objetos_no_CMD
{
    interface IEstoque
    {
        void Exibir();
        void AdicionarEntrada();
        void AdicionarSaida();
    }
}
