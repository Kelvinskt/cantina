namespace Cantina_forms
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            btnConfirmarCozinha = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(173, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(474, 191);
            listBox1.TabIndex = 0;
            // 
            // btnConfirmarCozinha
            // 
            btnConfirmarCozinha.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            btnConfirmarCozinha.Location = new Point(332, 334);
            btnConfirmarCozinha.Name = "btnConfirmarCozinha";
            btnConfirmarCozinha.Size = new Size(154, 32);
            btnConfirmarCozinha.TabIndex = 1;
            btnConfirmarCozinha.Text = "ENTREGAR";
            btnConfirmarCozinha.UseVisualStyleBackColor = true;
            btnConfirmarCozinha.Click += btnConfirmarCozinha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            label1.Location = new Point(332, 66);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 2;
            label1.Text = "PREPARANDO";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnConfirmarCozinha);
            Controls.Add(listBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnConfirmarCozinha;
        private Label label1;
    }
}