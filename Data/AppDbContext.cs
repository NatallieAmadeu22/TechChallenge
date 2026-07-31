using Microsoft.EntityFrameworkCore;

namespace TechChallenge;

public class AppDbContext : DbContext  // Herança do Contexto do EF Core
{
    // Herança no Método Construtor
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    /*
        DbSet -> Representação da Tabela no Sistema.
        Para cada model do sistema que for virar uma tabela no Banco de
        de Dados, deverá ser adicionado um DbSet
    */
    public DbSet<Aluno> Alunos {get; set;}  
    public DbSet<Categoria> Categorias {get; set;}  
}
