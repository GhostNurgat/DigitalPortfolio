using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DigitalPortfolio.Data;

using Models;

public class PortfolioContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public PortfolioContext(DbContextOptions<PortfolioContext> options)
        : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Resume> Resumes { get; set; }
}