using Microsoft.EntityFrameworkCore;
using twoChartsTask.Models;

namespace twoChartsTask.DataLayer
{
    public class DbContextSales : DbContext
    {
        //definícia konštruktora pre triedu DbContextSales, ktorá zdedí základnu triedu DbContext 
        public DbContextSales(DbContextOptions options) : base(options)
        {
        }


        // Kolekcia objektov / reprezentácia tabuľky cars
        public DbSet<salesEntity> cars { get; set; }
    }
}
