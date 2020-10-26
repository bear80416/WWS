using Microsoft.EntityFrameworkCore;
using myspace.Models;
namespace myspace.Data
{
    public class MainContext : DbContext
    {
        public MainContext (
            DbContextOptions<MainContext> options)
            : base(options)
        {
            
        }

        public DbSet<myspace.Models.Blog> Blog { get; set; }
        public DbSet<myspace.Models.Admin> Admin { get; set; }
        public DbSet<myspace.Models.Resgiter> Resgiter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin{
                    ID = 1,Name = "管理員",Mobile = "0912345678",Email = "Admin@com",Department = "管理室",Title = "管理員"
                }
            );
            modelBuilder.Entity<Resgiter>().HasData(
                new Resgiter{
                    ID = 1,Name = "Henry Wu",Nickname = "0912345678",Email = "Admin@com",Password = "q8004166",City = 4,Gender = 1,Commutermode = "1",Comment = "Nothing",Terms = true
                }
            );

        }




    }
}