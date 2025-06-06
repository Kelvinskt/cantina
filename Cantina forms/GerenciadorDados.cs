using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_forms
{
    public static class GerenciadorDados
    {
        public static List<PedidoCliente> PedidosAtivos { get; set; } = new List<PedidoCliente>();

        public static List<PedidoCliente> _historicoGlobal = new List<PedidoCliente>();

        public static List<PedidoCliente> HistoricoGlobal
        {
            get {  return _historicoGlobal; }
        }
        public static void AdicionarHistorico (PedidoCliente pedido)
        {
            _historicoGlobal.Add(pedido);

            if (HistoricoGlobal.Count > 10 )
            {
                _historicoGlobal.RemoveAt(0);
            }
        }
        public static void LimparHistorico()
        {
            _historicoGlobal.Clear();
        }
        public static int TotalPedidoHistorico()
        {
            return _historicoGlobal.Count;
        }
    }
}
