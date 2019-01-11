using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO.UserInfo.Core.Model;

namespace XPTO.UserInfo.Core.Interface
{
    public interface IXptoSelect
    {
        List<USUARIO> ConsultaUsuarios();
        List<UsuarioAtivo> ConsultaUsuariosAtivos();

        List<PRODUTO> ConsultaProdutos();
        UsuariosProdutos UsuariosAtivosComProdutos();
        UsuarioProduto ConsultaProdutosPorUsuario(string id);
    }
}
