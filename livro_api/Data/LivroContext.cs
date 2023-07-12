using Microsoft.EntityFrameworkCore;

namespace livro_api.Data;

public class LivroContext : DbContext
{
    public LivroContext(DbContextOptions configuracoes) : base(configuracoes)
    {
        
    }
}
