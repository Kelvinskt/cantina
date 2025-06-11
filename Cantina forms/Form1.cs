namespace Cantina_forms
{
    public partial class Form1 : Form
    {
        double TotalPedido = 0;
        List<PedidoCliente> listaPedidos = new List<PedidoCliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AtualizarTotal()
        {
            textBox3.Text = $"TOTAL: R${TotalPedido:F2}";
            textBox3.Visible = listBox2.Items.Count > 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                label3.Text = "SELECIONE UM PRODUTO";
                label3.Visible = true;
                return;
            }

            var produtoBase = (Produtos)listBox1.SelectedItem;
            var produtoSelecionado = new Produtos(produtoBase.Descricao, produtoBase.Valor)
            {
                Quantidade = (int)numQuantidade.Value
            };

            listBox2.Items.Add(produtoSelecionado);
            label3.Visible = false;

            TotalPedido += produtoSelecionado.Valor * produtoSelecionado.Quantidade;
            AtualizarTotal();

            listBox1.SelectedIndex = -1;
            numQuantidade.Value = 1;

            if (listBox2.Items.Count > 0)
            {
                comboBox1.Visible = true;
                label2.Visible = true;
                label7.Visible = true;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                label4.Text = "SELECIONE UM PRODUTO";
                label4.Visible = true;
                return;
            }

            Produtos produtoSelecionado = (Produtos)listBox2.SelectedItem;
            TotalPedido -= produtoSelecionado.Valor * produtoSelecionado.Quantidade;
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);

            label4.Visible = false;
            AtualizarTotal();

            numQuantidade.Enabled = true;
            numQuantidade.Value = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Produtos("PÃO DE QUEIJO", 3.50));
            listBox1.Items.Add(new Produtos("COXINHA", 5));
            listBox1.Items.Add(new Produtos("PASTEL DE CARNE", 6));
            listBox1.Items.Add(new Produtos("PASTEL DE QUEIJO", 5.50));
            listBox1.Items.Add(new Produtos("SUCO NATURAL (300ml)", 4));
            listBox1.Items.Add(new Produtos("REFRIGERANTE LATA", 4.50));
            listBox1.Items.Add(new Produtos("HAMBÚRGUER SIMPLES", 8));
            listBox1.Items.Add(new Produtos("HAMBÚRGUER COM QUEIJO", 9));
            listBox1.Items.Add(new Produtos("X-TUDO", 12));
            listBox1.Items.Add(new Produtos("ÁGUA MINERAL (500ml)", 2.5));

            if (listBox2.Items.Count == 0)
            {
                comboBox1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                numQuantidade.Value = 1;
            }
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                textBox3.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                label5.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label7.Visible = false;
            }

            if (listBox2.SelectedIndex != -1)
            {
                Produtos produtoSelecionado = (Produtos)listBox2.SelectedItem;
                numQuantidade.Value = produtoSelecionado.Quantidade;
                numQuantidade.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // Dinheiro
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                label5.Visible = true;
                label8.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                label5.Visible = false;
                label8.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && double.TryParse(textBox1.Text, out double valorRecebido))
            {
                if (valorRecebido >= TotalPedido)
                {
                    double troco = valorRecebido - TotalPedido;
                    textBox2.Text = $"R${troco:F2}";
                }
                else
                {
                    textBox2.Text = string.Empty;
                }
            }
            else
            {
                textBox2.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorRecebido = 0;
            double troco = 0;
           
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("FAÇA UM PEDIDO");
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("ESCOLHA O METODO DE PAGAMENTO");
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("INFORME O VALOR RECEBIDO");
                    return;
                }

                if (!double.TryParse(textBox1.Text, out valorRecebido))
                {
                    MessageBox.Show("VALOR INVALIDO PARA TROCO");
                    return;
                }
                if (valorRecebido < TotalPedido)
                {
                    MessageBox.Show("VALOR INSUFICIENTE");
                    return;
                }
                troco = valorRecebido - TotalPedido;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("DIGITE SEU NOME");
                return;
            }

            PedidoCliente novoPedido = new PedidoCliente
            {
                Nome = textBox4.Text,
                Itens = listBox2.Items.Cast<Produtos>().ToList(),
                Total = TotalPedido,
                MetodoPagamento = comboBox1.Text,
                DataPedido = DateTime.Now,
                ValorRecebido = valorRecebido
            };
            GerenciadorDados.PedidosAtivos.Add(novoPedido);
            listaPedidos.Add(novoPedido);

            var produtosParaCozinha = novoPedido.Itens
     .Where(p => GerenciadorDados.ProdutosCozinha.Contains(p.Descricao.ToUpper()))
     .ToList();

            foreach (var prod in produtosParaCozinha)
                prod.StatusCozinha = "Em preparo";

            GerenciadorDados.ProdutosPendentesCozinha.AddRange(produtosParaCozinha);

            MessageBox.Show($@"
        NOME: {textBox4.Text.ToUpper()}
        TOTAL: R${TotalPedido}
        TROCO: R${troco:F2}
        METODO DE PAGAMENTO: {comboBox1.Text}
        {DateTime.Now}");

            Form2 form2 = new Form2();
            form2.ShowDialog();

            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            listBox2.Items.Clear();
            listBox1.SelectedIndex = -1;
            numQuantidade.Value = 1;
            TotalPedido = 0;
            textBox3.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(listaPedidos);
            form2.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}


