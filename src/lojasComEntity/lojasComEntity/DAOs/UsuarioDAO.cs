using lojasComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojasComEntity.DAOs
{
    class UsuarioDAO
    {
        private EntidadesContext ctx;

        public UsuarioDAO(EntidadesContext contexto)
        {
            this.ctx = contexto;
        }

        public Usuario BuscaPorId(int id)
        {
            return this.ctx.Usuarios.FirstOrDefault(usuario => usuario.ID == id);
        }

        public void Salva(Usuario usuario)
        {
            this.ctx.Usuarios.Add(usuario);
            this.ctx.SaveChanges();
        }

        public void SaveChanges()
        {
            this.ctx.SaveChanges();
        }

        public void Remove(Usuario usuario)
        {
            this.ctx.Usuarios.Remove(usuario);
            this.ctx.SaveChanges();
        }
    }
}
