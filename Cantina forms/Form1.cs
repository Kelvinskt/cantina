namespace Cantina_forms
{
    public partial class Form1 : Form
    {
        double TotalPedido = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           

            if (listBox1.SelectedIndex == -1)
            {
                label3.Text = "SELECIONE UM PRODUTO";
                label3.Visible = true;
                return;
            }


            if (listBox1.SelectedIndex != -1)
            {
                int Quant = (int)numQuantidade.Value;

                Produtos ProdutoSelecionado = (Produtos)listBox1.SelectedItem;
                ProdutoSelecionado = new Produtos(ProdutoSelecionado.Descricao, ProdutoSelecionado.Valor)
                {
                    Quantidade = (int)numQuantidade.Value
                };

                listBox2.Items.Add(ProdutoSelecionado);
                label3.Visible = false;

                TotalPedido += ProdutoSelecionado.Valor * ProdutoSelecionado.Quantidade;
                textBox3.Text = $"TOTAL: R${TotalPedido:F2}";
                textBox3.Visible = true;

                listBox1.SelectedIndex = -1;
                numQuantidade.Value = 1;

               
            }

            if (listBox2.Items.Count > 0)
            {
                comboBox1.Visible = true;
                label2.Visible = true;

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
          
                Produtos ProdutoSelecionado = (Produtos)listBox2.SelectedItem;
                TotalPedido -= ProdutoSelecionado.Valor * ProdutoSelecionado.Quantidade;
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);

                label4.Visible = false;

                textBox3.Text = $"TOTAL: R${TotalPedido}";
                textBox3.Visible = listBox2.Items.Count > 0;

                numQuantidade.Enabled = true;
                numQuantidade.Value = 1;

            }

        

        private void btnTotal_Click(object sender, EventArgs e)
        {

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


            }

            if (listBox2.SelectedIndex != -1)
            {
                Produtos ProdutoSelecionado = (Produtos)listBox2.SelectedItem;
                numQuantidade.Value = ProdutoSelecionado.Quantidade;
                numQuantidade.Enabled = false;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                label5.Visible = true;

            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                label5.Visible = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {

            }
            if (listBox1.Items.Count == -1)
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
            if (double.TryParse(textBox1.Text, out double Valor))
            {
                if (Valor >= TotalPedido)
                {
                    double troco = Valor - TotalPedido;
                    textBox2.Text = $" R${troco}";
                }
            }
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
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
                    MessageBox.Show("INFORME O TROCO");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("DIGITE SEU NOME");
                    return;
                }
                if (!double.TryParse(textBox1.Text, out double valorRecebido))
            {
                    MessageBox.Show("VALOR INVALIDO PARA TROCO");
                    return;
                }
            if (valorRecebido < TotalPedido)
                {
                    MessageBox.Show("VALOR INSUFICIENTE");
                    return;
                }
            }
            
            MessageBox.Show($@"TOTAL DO SEU PEDIDO: R${TotalPedido}
NOME: {textBox4.Text.ToUpper()}
METODO DE PAGAMENTO: {comboBox1.Text}
{DateTime.Now}");

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
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}


