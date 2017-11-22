using lojasComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojasComEntity.DAOs
{
    public class CategoriaDAO
    {
        private EntidadesContext ctx;

        public CategoriaDAO()
        {
            this.ctx = new EntidadesContext();
        }

        public Categoria BuscarPorId(int id)
        {
            return this.ctx.Categorias.FirstOrDefault(c => c.ID == id);
        }

        public void Salva(Categoria categoria)
        {
            this.ctx.Categorias.Add(categoria);
            this.ctx.SaveChanges();
        }

        public void SaveChanges()
        {
            this.ctx.SaveChanges();
        }

        public void Remove(Categoria categoria)
        {
            this.ctx.Categorias.Remove(categoria);
            this.ctx.SaveChanges();
        }
    }
}
