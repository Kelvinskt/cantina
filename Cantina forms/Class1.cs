using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_forms
{
    internal class Produtos
    {
        private int quantidade;

        private string descricao;
 
        private double valor;

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
            set {  valor = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public override string ToString()
        {
            if (quantidade > 0)
            return $"{quantidade} x - {descricao} - R${valor}";
            else
            {
                return $"{descricao} - R${valor}";
            }

        }
    }
}
