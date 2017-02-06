using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Service
    {
        public IProdutoBLL Produtos { get; set; }

        public Service()
        {
            IProdutoDAL _repo = new ProdutosDAL();

            this.Produtos = new ProdutoBLL(_repo);
        }
    }
}
