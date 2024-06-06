using Microsoft.EntityFrameworkCore;

namespace CQRSProject.DAL
{
    public class Context :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI; initial Catalog=DbCqrs1; integrated security=true");
        }

        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Employee> Employees { get; set; }
    }
}
