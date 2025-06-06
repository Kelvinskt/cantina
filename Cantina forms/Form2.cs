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
    private List<PedidoCliente> pedidosEntregues;
    private List<PedidoCliente> pedidosAtivos = new List<PedidoCliente>();

        public Form2(List<PedidoCliente> listaPedidos)
        {
            InitializeComponent();
            pedidosEntregues = listaPedidos;
            pedidosAtivos = new List<PedidoCliente>(listaPedidos);
        }
        public Form2()
    {
        InitializeComponent();
    }
        private void AtualizarHistoricoPedidos()
        {
            if (dataGridView1 == null)
                return;

            var listaParaExibir = GerenciadorDados.HistoricoGlobal.AsEnumerable().Reverse().ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaParaExibir;
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

            foreach (var pedido in GerenciadorDados.PedidosAtivos)
            {
                listBox1.Items.Add(pedido.Nome.ToUpper());
            }

            if (listBox1.Items.Count == 0)
            {
                listBox2.Items.Clear();
            }

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

            if (listBox1.SelectedIndex != -1 && listBox1.SelectedIndex < GerenciadorDados.PedidosAtivos.Count)
            {
                PedidoCliente pedidoSelecionado = GerenciadorDados.PedidosAtivos[listBox1.SelectedIndex];
                MostrarDetalhesPedido(pedidoSelecionado);
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
            int index = listBox1.SelectedIndex;

            if (index != -1 && index < GerenciadorDados.PedidosAtivos.Count)
            {
                var pedidoSelecionado = GerenciadorDados.PedidosAtivos[index];

            
                GerenciadorDados.AdicionarHistorico(pedidoSelecionado);

           
                GerenciadorDados.PedidosAtivos.RemoveAt(index);

                AtualizaListaPedidosAtivos();
                AtualizarHistoricoPedidos();

                listBox2.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

