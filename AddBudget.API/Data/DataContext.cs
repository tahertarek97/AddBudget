using AddBudget.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AddBudget.API.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}
        public DbSet<Budget> Budgets { get; set; }
        
    }
}