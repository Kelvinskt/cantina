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
        private List<PedidoCliente> pedidosEntregues = new List<PedidoCliente>();

        public Form2(List<PedidoCliente> pedidos)
        {
            InitializeComponent();
            this.pedidos = pedidos;
        }
        private void ConfigurarDataGridViewHistorico()
        {
            if (dataGridView1 == null)
                return;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridViewHistorico();

            AtualizaListaPedidosAtivos();
            AtualizarHistoricoPedidos();

            if (dataGridView1 != null)
            {
                dataGridView1.Visible = false;
            }
            if (button3 != null)
            {
                button3.Text = "Mostrar Histórico";
            }
        }


        private void AtualizaListaPedidosAtivos()
        {
            listBox1.Items.Clear();

            foreach (var pedido in pedidos)
            {
                listBox1.Items.Add(pedido.Nome.ToUpper());
            }

            if (listBox1.Items.Count == 0)
            {
                listBox2.Items.Clear();
            }

        }
        private void AtualizarHistoricoPedidos()
        {
            if (dataGridView1 == null)
                return;
            var listaParaExibir = pedidosEntregues.AsEnumerable().Reverse().ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaParaExibir;
        }

        private void MostrarDetalhesPedido(PedidoCliente pedido)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add($"Nome: {pedido.Nome}");
            listBox2.Items.Add($"Total: R${pedido.Total:F2}");
            listBox2.Items.Add($"Pagamento: {pedido.MetodoPagamento}");
            listBox2.Items.Add($"Data: {pedido.DataPedido:dd/MM/yyyy HH:mm}");
            listBox2.Items.Add("Itens:");

            foreach (var item in pedido.Itens)
            {
                listBox2.Items.Add($" - {item.ToString()}");
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (listBox1.SelectedIndex != -1 && listBox1.SelectedIndex < pedidos.Count)
            {
                PedidoCliente pedidoSelecionado = pedidos[listBox1.SelectedIndex];
                MostrarDetalhesPedido(pedidoSelecionado); 

                
                var confirmResult = MessageBox.Show("Deseja marcar este pedido como entregue?",
                                                    "Confirmar Entrega",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    pedidosEntregues.Add(pedidoSelecionado);

                    if (pedidosEntregues.Count > 5)
                    {
                        pedidosEntregues.RemoveAt(0);
                    }

                    pedidos.RemoveAt(listBox1.SelectedIndex);

                    AtualizaListaPedidosAtivos();
                    AtualizarHistoricoPedidos();

                    listBox2.Items.Clear(); 
                }
            }
            else
            {
                listBox2.Items.Clear();
            }
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1 == null)
                return;

            bool historicoEstaVisivel = dataGridView1.Visible;

            if (historicoEstaVisivel)
            {
                dataGridView1.Visible = false;
                button3.Text = "Mostrar Histórico";
            }
            else
            {
                AtualizarHistoricoPedidos();
                dataGridView1.Visible = true;
                button3.Text = "Ocultar Histórico";
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (listBox1.SelectedIndex != -1 && listBox1.SelectedIndex < pedidos.Count)
                {
                    PedidoCliente pedidoSelecionado = pedidos[listBox1.SelectedIndex];

                    pedidosEntregues.Add(pedidoSelecionado);

                    if (pedidosEntregues.Count > 5)
                    {
                        pedidosEntregues.RemoveAt(0);
                    }

                    pedidos.RemoveAt(listBox1.SelectedIndex);

                    AtualizaListaPedidosAtivos();
                    AtualizarHistoricoPedidos();

                    listBox2.Items.Clear();
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
