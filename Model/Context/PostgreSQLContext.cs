using Microsoft.EntityFrameworkCore;

namespace WebApiTutorial.Model.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext() { }
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(new Produto 
            {
                Id = 1,
                Nome = "Caneta Bic Azul",
                Preco = new decimal(4.50),
                Descricao = "Caneta Bic Azul 1.0"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 2,
                Nome = "Caderno 10 Mat",
                Preco = new decimal(14.60),
                Descricao = "Caderno 10 Mat Tilibra"
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 3,
                Nome = "Borracha Mercur",
                Preco = new decimal(2.80),
                Descricao = "Borracha Mercur 50"
            });
        }

    }
}