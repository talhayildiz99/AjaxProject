using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DSQNOEI\\SQLEXPRESS03; initial catalog = DbAjax; integrated security = true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
