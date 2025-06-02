using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_forms
{
    public partial class Form2 : Form
    {
        private List<PedidoCliente> pedidos;
        public Form2(List<PedidoCliente> pedidos)
        {
            InitializeComponent();
            this.pedidos = pedidos;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var pedido in pedidos)
            {
                listBox1.Items.Add(pedido.Nome.ToUpper());
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (listBox1.SelectedIndex != -1)
            {
                PedidoCliente pedidoSelecionado = pedidos[listBox1.SelectedIndex];


                foreach (var item in pedidoSelecionado.Itens)
                {
                    listBox2.Items.Add(item.ToString());
                }
            }
        }
    }
}
