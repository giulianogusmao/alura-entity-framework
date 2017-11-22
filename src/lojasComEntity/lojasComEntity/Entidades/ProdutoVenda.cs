using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojasComEntity.Entidades
{
    public class ProdutoVenda
    {
        public virtual Venda Venda { get; set; }
        public int VendaID { get; set; }

        public virtual Produto Produto { get; set; }
        public int ProdutoID { get; set; }
    }
}
