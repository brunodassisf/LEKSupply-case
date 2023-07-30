
using LEKSupply.Models;
using Microsoft.EntityFrameworkCore;

namespace LEKSupply.Context
{
    public class LEKSupplyDbContext : DbContext
    {
        public LEKSupplyDbContext(DbContextOptions<LEKSupplyDbContext> options) : base(options) { }

        public DbSet<Mercadoria> Mercadoria { get; set; }

        public DbSet<Entrada> Entrada { get; set; }

        public DbSet<Saida> Saida { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mercadoria>().HasData(
                new Mercadoria { Id = 1, Nome = "Mouse", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Dell", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 2, Nome = "Teclado", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Dell", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 3, Nome = "Fone de ouvido", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Dell", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 4, Nome = "Camiseta", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Leader", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Roupas" },
                new Mercadoria { Id = 5, Nome = "Bermuda", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Leader", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Roupas" },
                new Mercadoria { Id = 6, Nome = "Blusa", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Leader", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Roupas" },
                new Mercadoria { Id = 7, Nome = "Carrinho de corrrida", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Hasbro", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Brinquedos" },
                new Mercadoria { Id = 8, Nome = "Boneco de ação", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Hasbro", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Brinquedos" },
                new Mercadoria { Id = 9, Nome = "Casinha de brinquedo", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Hasbro", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Brinquedos" },
                new Mercadoria { Id = 10, Nome = "Batatatinhas", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Lays", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Alimentos" },
                new Mercadoria { Id = 11, Nome = "kit kat", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Nestle", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Alimentos" },
                new Mercadoria { Id = 12, Nome = "Sonho de Valsa", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Lacta", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Alimentos" },
                new Mercadoria { Id = 13, Nome = "Lampada", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Philips", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Materiais de construção" },
                new Mercadoria { Id = 14, Nome = "Tomada", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Pial", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Materiais de construção" },
                new Mercadoria { Id = 15, Nome = "Gabinete desktop", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Dell", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 16, Nome = "Microfone", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Dell", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 17, Nome = "Monitor", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Dell", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 18, Nome = "Processador intel", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Dell", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 19, Nome = "Placa de video", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Dell", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 20, Nome = "Casado", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Leader", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Roupas" },
                new Mercadoria { Id = 21, Nome = "Calça jeans", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Leader", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Roupas" },
                new Mercadoria { Id = 22, Nome = "Camiseta Listrada", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Fashion Clothing", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Roupas" },
                new Mercadoria { Id = 23, Nome = "Smartphone Galaxy", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "TechCom", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 24, Nome = "Carrinho de Controle Remoto", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "BrincaBem", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Brinquedos" },
                new Mercadoria { Id = 25, Nome = "Biscoitos Deliciosos", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Saboroso Foods", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Alimentos" },
                new Mercadoria { Id = 26, Nome = "Tinta para Parede", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "CasaNova Supplies", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Materiais de construção" },
                new Mercadoria { Id = 27, Nome = "Jaqueta de Couro", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "Fashion Deluxe", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Roupas" },
                new Mercadoria { Id = 28, Nome = "Smartwatch Fitness", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "TechGadgets", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Eletrônicos" },
                new Mercadoria { Id = 29, Nome = "Quebra-Cabeça Colorido", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "DivertKids", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Brinquedos" },
                new Mercadoria { Id = 30, Nome = "Chocolate Cremoso", Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", Fabricante = "SweetTreats", Status = "A", Codigo = Guid.NewGuid().ToString(), Tipo = "Alimentos" }
            );

        }

    }
}
