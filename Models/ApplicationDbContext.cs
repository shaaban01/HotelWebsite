using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lab_10.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Hotel> Hotels { get; set; } = null!;
}
