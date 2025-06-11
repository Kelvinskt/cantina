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
    public partial class Form3 : Form
    {
        private List<Produtos> produtosCozinha;


        private void AtualizarListaCozinha()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = produtosCozinha;
            listBox1.SelectedIndex = -1;
        }

        public Form3()
        {
            InitializeComponent();
            produtosCozinha = GerenciadorDados.ProdutosPendentesCozinha;
            AtualizarListaCozinha();
            this.Load += Form3_Load;
        }
        public Form3(List<Produtos> produtosDoCliente)
        {
            InitializeComponent();
            produtosCozinha = produtosDoCliente;
            AtualizarListaCozinha();
            this.Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }

        private void btnConfirmarCozinha_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem is Produtos produto)
            {
                produto.StatusCozinha = "Feito";
                AtualizarListaCozinha();
               

            }



        }
    }
}
            
    

