using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        {
          
        }
        public DbSet<ProdutoEntidades> Produtos { get; set; }
    

        
    }
}
