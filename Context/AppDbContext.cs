using BookShareMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShareMVC.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<LoanModel> Loans { get; set; } = null!;
    }
}
