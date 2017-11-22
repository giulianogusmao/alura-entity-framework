using lojasComEntity.DAOs;
using lojasComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojasComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext ctx = new EntidadesContext();

            // --------------------------------------------------------------------------------
            // criando uma venda com 2 produtos para o usuario 1
            /*
            ProdutoDAO produtoDao = new ProdutoDAO(ctx);
            Produto p1 = produtoDao.BuscaPorId(1);
            Produto p2 = produtoDao.BuscaPorId(2);

            UsuarioDAO usuarioDao = new UsuarioDAO(ctx);
            Usuario usuario = usuarioDao.BuscaPorId(1);

            Venda venda = new Venda() {
                Cliente = usuario
            };

            ProdutoVenda pv1 = new ProdutoVenda()
            {
                Venda = venda,
                Produto = p1
            };

            ProdutoVenda pv2 = new ProdutoVenda()
            {
                Venda = venda,
                Produto = p2
            };

            ctx.Vendas.Add(venda);
            ctx.ProdutoVenda.Add(pv1);
            ctx.ProdutoVenda.Add(pv2);
            ctx.SaveChanges();
            ctx.Dispose();
            */

            // consultando venda
            /*
            Venda venda = ctx.Vendas
                .Include(v => v.ProdutoVenda) // incluindo a entidade ProdutoVenda
                .ThenInclude(pv => pv.Produto) // incluindo a entidade Produto apartir da ProdutoVenda
                .FirstOrDefault(v => v.ID == 1);

            foreach(var pv in venda.ProdutoVenda)
            {
                Console.WriteLine(pv.Produto.Nome);
            }
            */
            // fim venda


            // --------------------------------------------------------------------------------
            // Pesquisando produto por categoria
            //ProdutoDAO produtoDao = new ProdutoDAO(ctx);
            //var resultado = produtoDao.BuscaPorNomePrecoNomeCategoria(null, 0, "Informática");

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine(item.Nome);
            //}


            // --------------------------------------------------------------------------------
            // criando uma pessoa Fisica e uma pessoa Juridica
            PessoaFisica pf = new PessoaFisica()
            {
                Nome = "João",
                Senha = "321",
                CPF = "32112365401"
            };
            ctx.PessoasFisica.Add(pf);
            ctx.SaveChanges();

            PessoaJuridica pj = new PessoaJuridica()
            {
                Nome = "Monique",
                Senha = "897",
                CNPJ = "54654789000150"
            };
            ctx.PessoasJuridica.Add(pj);
            ctx.SaveChanges();      


            ctx.Dispose();

            //Console.ReadLine();
        }
    }
}
