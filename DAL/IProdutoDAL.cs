using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public interface IProdutoDAL
    {
        List<ProdutoVO> All();
    }
}
