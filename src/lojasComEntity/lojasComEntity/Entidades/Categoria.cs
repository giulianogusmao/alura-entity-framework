using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojasComEntity.Entidades
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        // navigation property: para realizar a navegação entre as entidades
        public virtual IList<Produto> Produtos { get; set; } 
    }
}
