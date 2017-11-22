using lojasComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojasComEntity.DAOs
{
    class ProdutoDAO
    {
        private EntidadesContext ctx;
        public ProdutoDAO(EntidadesContext ctx)
        {
            this.ctx = ctx;
        }

        public Produto BuscaPorId(int id)
        {
            return this.ctx.Produtos.FirstOrDefault(p => p.ID == id);
        }

        public IList<Produto> BuscaPorNomePrecoNomeCategoria(string nome, double preco, string nomeCategoria)
        {
            var busca = from p in this.ctx.Produtos
                        select p;

            if (!String.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p => p.Nome == nome);
            }

            if (preco > 0.0)
            {
                busca = busca.Where(p => p.Preco == preco);
            }

            if (!String.IsNullOrEmpty(nomeCategoria))
            {
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
            }

            return busca.ToList();
        }

        public void Adiciona(Produto p)
        {
            this.ctx.Produtos.Add(p);
            this.ctx.SaveChanges();
        }

        public void Remove(Produto p)
        {
            this.ctx.Produtos.Remove(p);
            this.ctx.SaveChanges();
        }
    }
}
