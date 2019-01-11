using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO.UserInfo.Core.Interface;

namespace XPTO.UserInfo.Core.Impl
{
    public class XptoDelete : IXptoDelete
    {
        XPTOEntities xpto = new XPTOEntities();
        public void DeleteUsuario(int id)
        {
            List<PRODUTO> ItensUsuario = xpto.PRODUTO.Where(p => p.id_usuario == id).ToList();
            if(ItensUsuario.Count > 0)
            {
                foreach (var itemUser in ItensUsuario)
                {
                    xpto.PRODUTO.DeleteObject(itemUser);
                    xpto.SaveChanges();
                }
            }
            USUARIO uSUARIO = xpto.USUARIO.Single(u => u.Id == id);
            xpto.USUARIO.DeleteObject(uSUARIO);
            xpto.SaveChanges();
        }

        public void DeleteProduto(int id)
        {
            PRODUTO pRODUTO = xpto.PRODUTO.Single(u => u.id == id);
            xpto.PRODUTO.DeleteObject(pRODUTO);
            xpto.SaveChanges();
        }
    }
}
