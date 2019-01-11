using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPTO.UserInfo.Core.Impl;
using XPTO.UserInfo.Core.Model;
using XPTO.UserInfo.Core.Interface;

namespace XPTO.UserInfo.Desktop
{
    public partial class VisualizarInformacoes : UserControl
    {
        IXptoSelect xptolistas = new XptoSelect();
        public VisualizarInformacoes()
        {
            InitializeComponent();
        }

        private void VisualizarInformacoes_Load(object sender, EventArgs e)
        {
            List<UsuarioAtivo> usuarios = xptolistas.ConsultaUsuariosAtivos();
            TreeNode[] array = new TreeNode[usuarios.Count];
            int count = 0;
            foreach (var item in usuarios)
            {
                array[count] = new TreeNode() { Name = item.id.ToString(), Text = item.nome };
                count++;
            }

            TreeNode treeNode = new TreeNode("Usuarios", array);
            treeViewUsuarios.Nodes.Add(treeNode);
        }

        private void treeViewUsuarios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ListViewProdutos.Clear();
            TreeNode node = treeViewUsuarios.SelectedNode;
            if(node.Name != "")
            {
                UsuarioProduto info = xptolistas.ConsultaProdutosPorUsuario(node.Name);

                MostrarDadosConsulta(info);
            }
        }

        private void MostrarDadosConsulta(UsuarioProduto info)
        {
            txt_sobrenome.Text = info.usuario.sobrenome;
            txt_sexo.Text = info.usuario.sexo;
            txt_datanascimento.Text = info.usuario.dt_nascimento.ToString("dd/MM/yyyy");
            txt_email.Text = info.usuario.email;

            foreach (var item in info.produtos)
            {
                ListViewProdutos.Items.Add(item.nm_produto);
            }
        }
    }
}
