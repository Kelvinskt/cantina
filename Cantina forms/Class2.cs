using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_forms
{
    internal class PedidoCliente
    {
        public string Cliente { get; set; }
        public List<Produtos> Produtos { get; set; }

        public PedidoCliente(string cliente, List<Produtos> produtos)
        {
            Cliente = cliente;
            Produtos = produtos;
        }
    }
}
