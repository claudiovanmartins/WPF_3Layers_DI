using System.Collections.Generic;
using System.Data;
using System.Linq;
using VO;

namespace DAL
{
    public class ProdutosDAL : IProdutoDAL
    {
        public List<ProdutoVO> All()
        {
            using (databaseEntities dn = new databaseEntities())
            {
                var l =  dn.Produtos.Select(s => new ProdutoVO
                {
                    Codigo = s.Codigo,
                    Descricao = s.Descricao
                }).ToList();

                return l;
            }
        }
    }
}
