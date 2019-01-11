namespace XPTO.UserInfo.Desktop
{
    partial class VisualizarInformacoes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewUsuarios = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListViewProdutos = new System.Windows.Forms.ListView();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_datanascimento = new System.Windows.Forms.TextBox();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewUsuarios
            // 
            this.treeViewUsuarios.Location = new System.Drawing.Point(20, 18);
            this.treeViewUsuarios.Name = "treeViewUsuarios";
            this.treeViewUsuarios.Size = new System.Drawing.Size(233, 305);
            this.treeViewUsuarios.TabIndex = 0;
            this.treeViewUsuarios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewUsuarios_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_datanascimento);
            this.groupBox1.Controls.Add(this.txt_sexo);
            this.groupBox1.Controls.Add(this.txt_sobrenome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(270, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewProdutos);
            this.groupBox2.Location = new System.Drawing.Point(24, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // ListViewProdutos
            // 
            this.ListViewProdutos.Location = new System.Drawing.Point(7, 20);
            this.ListViewProdutos.Name = "ListViewProdutos";
            this.ListViewProdutos.Size = new System.Drawing.Size(367, 97);
            this.ListViewProdutos.TabIndex = 0;
            this.ListViewProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(24, 98);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(378, 20);
            this.txt_email.TabIndex = 7;
            // 
            // txt_datanascimento
            // 
            this.txt_datanascimento.Enabled = false;
            this.txt_datanascimento.Location = new System.Drawing.Point(298, 45);
            this.txt_datanascimento.Name = "txt_datanascimento";
            this.txt_datanascimento.Size = new System.Drawing.Size(106, 20);
            this.txt_datanascimento.TabIndex = 6;
            // 
            // txt_sexo
            // 
            this.txt_sexo.Enabled = false;
            this.txt_sexo.Location = new System.Drawing.Point(176, 45);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(109, 20);
            this.txt_sexo.TabIndex = 5;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Enabled = false;
            this.txt_sobrenome.Location = new System.Drawing.Point(24, 45);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(135, 20);
            this.txt_sobrenome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sobre Nome:";
            // 
            // VisualizarInformacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeViewUsuarios);
            this.Name = "VisualizarInformacoes";
            this.Size = new System.Drawing.Size(714, 339);
            this.Load += new System.EventHandler(this.VisualizarInformacoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListViewProdutos;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_datanascimento;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.TextBox txt_sobrenome;
    }
}
