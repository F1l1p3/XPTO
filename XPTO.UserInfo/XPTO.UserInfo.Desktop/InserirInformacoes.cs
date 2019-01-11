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
using XPTO.UserInfo.Core.Interface;
using System.IO;

namespace XPTO.UserInfo.Desktop
{
    public partial class InserirInformacoes : UserControl
    {
        IXptoSelect xptolistas = new XptoSelect();
        IXptoInsert xptoinserir = new XptoInsert();
        public InserirInformacoes()
        {
            InitializeComponent();
            btnInserirProdutos.Enabled = VerificaSeHaUsuariosRegistrados();
        }
        private bool VerificaSeHaUsuariosRegistrados()
        {
            return xptolistas.ConsultaUsuarios().Count > 0;
        }

        private void btnInsereUsuarios_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(txt_usuario_busca.Text);
            MessageBox.Show(xptoinserir.InserirUsuarios(sr));
            sr.Close();

            btnInserirProdutos.Enabled = VerificaSeHaUsuariosRegistrados();
        }

        private void btnBuscarUsuarios_Click(object sender, EventArgs e)
        {
            if (ofdArquivo.ShowDialog() == DialogResult.OK)
            {
                txt_usuario_busca.Text = ofdArquivo.FileName;
            }
        }

        private void btnBuscarProdutos_Click(object sender, EventArgs e)
        {
            if (ofdArquivo.ShowDialog() == DialogResult.OK)
            {
                txt_produtos_busca.Text = ofdArquivo.FileName;
            }
        }

        private void btnInserirProdutos_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(txt_produtos_busca.Text);
            MessageBox.Show(xptoinserir.InserirProdutos(sr));
            sr.Close();
        }
    }
}
