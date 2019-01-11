using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO.UserInfo.Core.Interface;

namespace XPTO.UserInfo.Core.Impl
{
    public class XptoUpdate : IXptoUpdate
    {
        XPTOEntities xpto = new XPTOEntities();
        public void AlterarProduto(PRODUTO p)
        {
            xpto.ObjectStateManager.ChangeObjectState(p, EntityState.Modified);
            xpto.SaveChanges();
        }

        public void AlterarUsuario(USUARIO u)
        {
            xpto.ObjectStateManager.ChangeObjectState(u, EntityState.Modified);
            xpto.SaveChanges();
        }
    }
}
