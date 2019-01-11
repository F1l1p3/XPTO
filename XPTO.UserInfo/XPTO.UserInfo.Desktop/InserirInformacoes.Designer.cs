namespace XPTO.UserInfo.Desktop
{
    partial class InserirInformacoes
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
            this.btnInserirProdutos = new System.Windows.Forms.Button();
            this.btnInsereUsuarios = new System.Windows.Forms.Button();
            this.txt_produtos_busca = new System.Windows.Forms.TextBox();
            this.txt_usuario_busca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscarProdutos = new System.Windows.Forms.Button();
            this.btnBuscarUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserirProdutos
            // 
            this.btnInserirProdutos.Location = new System.Drawing.Point(602, 257);
            this.btnInserirProdutos.Name = "btnInserirProdutos";
            this.btnInserirProdutos.Size = new System.Drawing.Size(75, 40);
            this.btnInserirProdutos.TabIndex = 13;
            this.btnInserirProdutos.Text = "Inserir Produtos";
            this.btnInserirProdutos.UseVisualStyleBackColor = true;
            this.btnInserirProdutos.Click += new System.EventHandler(this.btnInserirProdutos_Click);
            // 
            // btnInsereUsuarios
            // 
            this.btnInsereUsuarios.Location = new System.Drawing.Point(602, 173);
            this.btnInsereUsuarios.Name = "btnInsereUsuarios";
            this.btnInsereUsuarios.Size = new System.Drawing.Size(75, 40);
            this.btnInsereUsuarios.TabIndex = 12;
            this.btnInsereUsuarios.Text = "Inserir Usuários";
            this.btnInsereUsuarios.UseVisualStyleBackColor = true;
            this.btnInsereUsuarios.Click += new System.EventHandler(this.btnInsereUsuarios_Click);
            // 
            // txt_produtos_busca
            // 
            this.txt_produtos_busca.Enabled = false;
            this.txt_produtos_busca.Location = new System.Drawing.Point(120, 268);
            this.txt_produtos_busca.Name = "txt_produtos_busca";
            this.txt_produtos_busca.Size = new System.Drawing.Size(380, 20);
            this.txt_produtos_busca.TabIndex = 11;
            // 
            // txt_usuario_busca
            // 
            this.txt_usuario_busca.Enabled = false;
            this.txt_usuario_busca.Location = new System.Drawing.Point(120, 184);
            this.txt_usuario_busca.Name = "txt_usuario_busca";
            this.txt_usuario_busca.Size = new System.Drawing.Size(380, 20);
            this.txt_usuario_busca.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Produtos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuários:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inclusão de dados";
            // 
            // btnBuscarProdutos
            // 
            this.btnBuscarProdutos.Location = new System.Drawing.Point(521, 257);
            this.btnBuscarProdutos.Name = "btnBuscarProdutos";
            this.btnBuscarProdutos.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarProdutos.TabIndex = 15;
            this.btnBuscarProdutos.Text = "Buscar Produtos";
            this.btnBuscarProdutos.UseVisualStyleBackColor = true;
            this.btnBuscarProdutos.Click += new System.EventHandler(this.btnBuscarProdutos_Click);
            // 
            // btnBuscarUsuarios
            // 
            this.btnBuscarUsuarios.Location = new System.Drawing.Point(521, 173);
            this.btnBuscarUsuarios.Name = "btnBuscarUsuarios";
            this.btnBuscarUsuarios.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarUsuarios.TabIndex = 14;
            this.btnBuscarUsuarios.Text = "Buscar Usuários";
            this.btnBuscarUsuarios.UseVisualStyleBackColor = true;
            this.btnBuscarUsuarios.Click += new System.EventHandler(this.btnBuscarUsuarios_Click);
            // 
            // InserirInformacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscarProdutos);
            this.Controls.Add(this.btnBuscarUsuarios);
            this.Controls.Add(this.btnInserirProdutos);
            this.Controls.Add(this.btnInsereUsuarios);
            this.Controls.Add(this.txt_produtos_busca);
            this.Controls.Add(this.txt_usuario_busca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InserirInformacoes";
            this.Size = new System.Drawing.Size(709, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirProdutos;
        private System.Windows.Forms.Button btnInsereUsuarios;
        private System.Windows.Forms.TextBox txt_produtos_busca;
        private System.Windows.Forms.TextBox txt_usuario_busca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.Button btnBuscarProdutos;
        private System.Windows.Forms.Button btnBuscarUsuarios;
    }
}
