using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.Intrinsics.Arm;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        {
          
        }
        public DbSet<ProdutoEntidade> Produtos { get; set; }

        public DbSet<PermissaoEntidade> permissao { get; set; }

        public DbSet<CategoriaEntidade> categoria { get; set; }

        public DbSet<VendasEntidade>Vendas { get; set; }
        public DbSet<ItensVendaEntidade>ItensVenda { get; set; }
    }
}

