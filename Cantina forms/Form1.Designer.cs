﻿namespace Cantina_forms
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
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(45, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(196, 214);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(520, 98);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(223, 154);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged_1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(315, 116);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 24);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(315, 211);
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
            btnTotal.Location = new Point(520, 263);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(0, 15);
            btnTotal.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(288, 143);
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
            label4.Location = new Point(288, 237);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 8;
            label4.Text = "Nenhum Produto Selecionado";
            label4.Visible = false;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(97, 261);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(79, 23);
            numQuantidade.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DINHEIRO", "PIX ", "DEBITO", "CREDITO" });
            comboBox1.Location = new Point(656, 271);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(656, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 12;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(520, 323);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 13;
            textBox2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adobe Arabic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 287);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 14;
            label1.Text = "QUANTIDADE";
            label1.Click += label1_Click_3;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(520, 271);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 15;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Adobe Arabic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(656, 255);
            label2.Name = "label2";
            label2.Size = new Size(114, 14);
            label2.TabIndex = 16;
            label2.Text = "FORMA DE PAGAMENTO";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Adobe Arabic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(656, 307);
            label5.Name = "label5";
            label5.Size = new Size(101, 14);
            label5.TabIndex = 17;
            label5.Text = "INFORME A QUANTIA";
            label5.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(315, 391);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 18;
            button1.Text = "FINALIZAR PEDIDO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(74, 343);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 19;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Adobe Arabic", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(73, 326);
            label6.Name = "label6";
            label6.Size = new Size(101, 14);
            label6.TabIndex = 20;
            label6.Text = "ADICIONE SEU NOME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private Label label5;
        private Button button1;
        private TextBox textBox4;
        private Label label6;
    }
}
