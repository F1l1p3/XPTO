using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.UserInfo.Core.Interface
{
    public interface IXptoInsert
    {
        string InserirUsuarios(StreamReader sr);
        string InserirProdutos(StreamReader sr);

        void InserirUsuario(USUARIO sr);
        string InserirProduto(int usuario, string nome_produto);
    }
}
