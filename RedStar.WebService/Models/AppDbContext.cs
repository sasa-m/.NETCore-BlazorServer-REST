using Microsoft.EntityFrameworkCore;
using RedStar.Models;

namespace RedStar.WebService.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().HasData(new Player
            {
                Id = 1,
                Number = 7,
                FirstName = "Dejan",
                LastName = "Davidovac",
                Position = "Forward",
                Height = 202,
                Born = 1995,
                PhotoPath = "images/dejan.png"
            });

            modelBuilder.Entity<Player>().HasData(new Player
            {
                Id = 2,
                Number = 9,
                FirstName = "Luka",
                LastName = "Mitrovic",
                Position = "Forward",
                Height = 206,
                Born = 1993,
                PhotoPath = "images/luka.png"
            });

            modelBuilder.Entity<Player>().HasData(new Player
            {
                Id = 3,
                Number = 10,
                FirstName = "Branko",
                LastName = "Lazic",
                Position = "Guard",
                Height = 195,
                Born = 1989,
                PhotoPath = "images/branko.png"
            });

            modelBuilder.Entity<Player>().HasData(new Player
            {
                Id = 4,
                Number = 13,
                FirstName = "Ognjen",
                LastName = "Dobric",
                Position = "Guard",
                Height = 200,
                Born = 1994,
                PhotoPath = "images/ognjen.png"
            });

            modelBuilder.Entity<Player>().HasData(new Player
            {
                Id = 5,
                Number = 19,
                FirstName = "Marko",
                LastName = "Simonovic",
                Position = "Forward",
                Height = 203,
                Born = 1986,
                PhotoPath = "images/marko.png"
            });

            modelBuilder.Entity<Player>().HasData(new Player
            {
                Id = 6,
                Number = 20,
                FirstName = "Nikola",
                LastName = "Ivanovic",
                Position = "Guard",
                Height = 191,
                Born = 1994,
                PhotoPath = "images/nikola.png"
            });

        }
    } 
}
