using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.UserInfo.Core.Model
{
    public class UsuarioProduto
    {
        public USUARIO usuario { get; set; }
        public List<PRODUTO> produtos { get; set; }
    }
}
