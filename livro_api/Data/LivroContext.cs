using livro_api.Models;
using Microsoft.EntityFrameworkCore;

namespace livro_api.Data;

public class LivroContext : DbContext
{
    // Construtor que define as configurações para a conexão com o banco de dados
    public LivroContext(DbContextOptions<LivroContext> configuracoes) : base(configuracoes)
    {

    }

    // Indica ao Entity a criação da tabela Autor no banco de dados
    public DbSet<Autor> Autor { get; set; }

    // Indica ao Entity a criação da tabela Editora no banco de dados
    public DbSet<Editora> Editora { get; set; }
}
