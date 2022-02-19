using cdStore.Models;
using Microsoft.EntityFrameworkCore;

namespace cdStore.Data
{
    //This is the class that conects the tables to the database
    public class CdContext : DbContext
    {
        public CdContext(DbContextOptions<CdContext> options) : base(options)
        {

        }
        //creating tables from cdContext
        public DbSet<Cd> Cd{ get; set;}
        public DbSet<Artist> Artist{ get; set;}
        public DbSet<User> User { get; set; }


    }
}