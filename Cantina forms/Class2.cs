using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_forms
{
    public class PedidoCliente
    {
        public string Nome { get; set; }
        public List<Produtos> Itens { get; set; } = new List<Produtos>();
        public double Total {  get; set; }
        public string MetodoPagamento { get; set; }
        public DateTime DataPedido { get; set; }

        public override string ToString()
        {
            string itensDescricao = string.Join(", ", Itens.Select(i  => i.ToString()));
            return $"Cliente: {Nome} | Total: R${Total:F2} | Itens: {itensDescricao} | Pagamento: {MetodoPagamento} | Data: {DataPedido}";
        }
    }
    }
