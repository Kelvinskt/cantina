namespace Cantina_forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnTotal = new Label();
            label3 = new Label();
            label4 = new Label();
            numQuantidade = new NumericUpDown();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(45, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(196, 154);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(520, 84);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(223, 154);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged_1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(85, 273);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 24);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(85, 303);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(112, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnTotal
            // 
            btnTotal.AutoSize = true;
            btnTotal.Location = new Point(520, 252);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(0, 15);
            btnTotal.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(203, 278);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 7;
            label3.Text = "Nenhum Produto Selecionado";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(203, 307);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 8;
            label4.Text = "Nenhum Produto Selecionado";
            label4.Visible = false;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(108, 244);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(72, 23);
            numQuantidade.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DINHEIRO", "PIX ", "DEBITO", "CREDITO" });
            comboBox1.Location = new Point(520, 292);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(662, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(662, 299);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            textBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(numQuantidade);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnTotal);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Label btnTotal;
        private Label label3;
        private Label label4;
        private NumericUpDown numQuantidade;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
