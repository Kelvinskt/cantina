using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_forms
{
    public class Produtos
    {
        private int quantidade;

        private string descricao;
 
        private double valor;

        public string StatusCozinha { get; set; } = "Em preparo";

        public string DescricaoComStatus => $"{Descricao} - {StatusCozinha}";

      
        public Produtos()
        {
            descricao = string.Empty;
            valor = 0;
            quantidade = 0;
        }
        public Produtos(string descricao, double valor)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.quantidade = 0;
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public double Valor
        {
            get { return valor; }
            set
            {
                if (value < 0) throw new ArgumentException("Valor não pode ser negativo.");
                valor = value;
            }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set 
            {
                if (value < 0) throw new ArgumentException("Quantidade não pode ser negativa.");
                quantidade = value;
            }
        }
        public override string ToString()
        {
            if (quantidade > 0)
                return $"{Descricao} - R${Valor:F2} x{Quantidade}";


            else
            {
                return $"{descricao} - R${valor:F2}";

            }

        }
    }
}
