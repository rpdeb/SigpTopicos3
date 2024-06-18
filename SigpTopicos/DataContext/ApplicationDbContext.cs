using Microsoft.EntityFrameworkCore;
using SigpTopicos.Models;

namespace SigpTopicos.DataContext
{
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
