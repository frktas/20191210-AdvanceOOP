using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.DAL.Concrate.EntityFramework
{
    public class OZamanDansDbContext : DbContext
    {
        public OZamanDansDbContext() : base("Server = . ; Database = OZamanDans ; uid = sa ; pwd = 123")
        {
            Database.SetInitializer(new OZamanDansInitializer());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasRequired(a => a.Category)
                .WithMany(a => a.Products)
                .HasForeignKey(a => a.CategoryID);
        }
    }

    class OZamanDansInitializer : CreateDatabaseIfNotExists<OZamanDansDbContext>
    {
        protected override void Seed(OZamanDansDbContext context)
        {
            context.Categories.Add(new Category()
            {
                Name = "İçecekler"
            });

            context.Categories.Add(new Category()
            {
                Name = "Yiyecekler"
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
