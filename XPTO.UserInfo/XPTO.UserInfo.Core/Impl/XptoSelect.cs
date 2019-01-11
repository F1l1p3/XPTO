using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO.UserInfo.Core.Interface;
using XPTO.UserInfo.Core.Model;

namespace XPTO.UserInfo.Core.Impl
{
    public class XptoSelect: IXptoSelect
    {
        XPTOEntities xpto = new XPTOEntities();

        public List<PRODUTO> ConsultaProdutos()
        {
            return xpto.PRODUTO.ToList();
        }

        public List<USUARIO> ConsultaUsuarios()
        {
            using (XPTOEntities context = new XPTOEntities())
            {
                context.Connection.Open();
                return xpto.USUARIO.ToList();
            }
        }

        public UsuarioProduto ConsultaProdutosPorUsuario(string id)
        {
            int id_usuario = int.Parse(id);
            return new UsuarioProduto() { usuario = ConsultaUsuarios().Single(u => u.Id == id_usuario), produtos = ConsultaProdutos().Where(p => p.id_usuario == id_usuario).ToList() };
        }

        public List<UsuarioAtivo> ConsultaUsuariosAtivos()
        {
            List<UsuarioAtivo> usuarios = new List<UsuarioAtivo>();
            foreach (var item in ConsultaUsuarios().Where(u => u.ativo == "true"))
            {
                usuarios.Add(new UsuarioAtivo() { id = item.Id, nome = item.nome });
            }

            return usuarios;
        }

        public UsuariosProdutos UsuariosAtivosComProdutos()
        {
            UsuariosProdutos userprod = new UsuariosProdutos();
            userprod.usuarios = ConsultaUsuarios().Where(u => u.ativo == "true").ToList();
            int[] idUsuariosAtivos = new int[userprod.usuarios.Count]; int count = 0;
            foreach (var item in userprod.usuarios.Select(s => s.Id).ToList())
            {
                idUsuariosAtivos[count] = item;
                count++;
            }
            userprod.produtos = ConsultaProdutos().Where(p => idUsuariosAtivos.Contains(p.id_usuario)).ToList();

            return userprod;
        }
    }
}
