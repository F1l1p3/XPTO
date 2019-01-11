using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO.UserInfo.Core.Interface;

namespace XPTO.UserInfo.Core.Impl
{
    public class XptoInsert : IXptoInsert
    {
        XPTOEntities xpto = new XPTOEntities();
        XptoSelect XptoListas = new XptoSelect();

        public string InserirProduto(int usuario, string nome_produto)
        {
            try
            {
                PRODUTO prod = new PRODUTO();
                prod.id = xpto.PRODUTO.Count() + 1;
                prod.id_usuario = usuario;prod.nm_produto = nome_produto;
                xpto.PRODUTO.AddObject(prod);
                xpto.SaveChanges();

                return "Inserido com sucesso!";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public string InserirProdutos(StreamReader sr)
        {
            try
            {
                int contadorDeItensSalvos = 0;
                string[] infoUsuario = sr.ReadToEnd().Split(';');
                foreach (var item in infoUsuario.ToList())
                {
                    int idUser = int.Parse(item.Split(',')[1]);
                    if (xpto.USUARIO.Where(u => u.Id == idUser).Count() > 0)
                    {
                        PRODUTO prod = new PRODUTO();
                        prod.id = int.Parse(item.Split(',')[0]);
                        prod.id_usuario = idUser;
                        prod.nm_produto = item.Split(',')[2];

                        xpto.PRODUTO.AddObject(prod);
                        contadorDeItensSalvos++;
                    }
                }

                xpto.SaveChanges();
                return "Foram inseridos " + contadorDeItensSalvos + " produtos";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public void InserirUsuario(USUARIO sr)
        {
            sr.Id = xpto.USUARIO.Count() + 1;
            xpto.USUARIO.AddObject(sr);
            xpto.SaveChanges();
        }

        public string InserirUsuarios(StreamReader sr)
        {
            try
            {
                string[] infoUsuario = sr.ReadToEnd().Split(';');
                foreach (var item in infoUsuario.ToList())
                {
                    USUARIO user = new USUARIO();
                    user.Id = int.Parse(item.Split(',')[0]);
                    user.nome = item.Split(',')[1];
                    user.sobrenome = item.Split(',')[2];
                    user.dt_nascimento = DateTime.Parse(item.Split(',')[3]);
                    user.sexo = item.Split(',')[4];
                    user.email = item.Split(',')[5];
                    user.ativo = item.Split(',')[6];


                    xpto.USUARIO.AddObject(user);
                }

                xpto.SaveChanges();
                return "Inserido com sucesso!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }
    }
}
