using DAL;
using System.Collections.Generic;
using VO;

namespace BLL
{
    public class ProdutoBLL : IProdutoBLL
    {
        IProdutoDAL _produtosRepositorio;

        public ProdutoBLL(IProdutoDAL produtosRepositorio)
        {
            this._produtosRepositorio = produtosRepositorio;
        }

        public List<ProdutoVO> All()
        {
            var l = _produtosRepositorio.All();
            return l;
        }
    }
}
