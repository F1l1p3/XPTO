using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.UserInfo.Core.Interface
{
    public interface IXptoUpdate
    {
        void AlterarUsuario(USUARIO u);
        void AlterarProduto(PRODUTO p);
    }
}
