using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> users {get; set;}

        public DbSet<MeetingRoom> meetingRooms { get; set; }

        public DbSet<BookMeetingRoom> bookMeetingRooms { get; set; }

        public DbSet<Events> events { get; set; }

        public DbSet<KaniniLocation> kaniniLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<BookMeetingRoom>()
            //    .HasOne(b => b.KaniniLocation)
            //    .WithMany()
            //    .HasForeignKey(b => b.KaniniLocationId);

            var locations = new List<KaniniLocation>()
            {
                new KaniniLocation
                {
                    kaniniLocationId = Guid.Parse("09488999-6c0e-4021-b4ed-10f338175fc4"),
                    Location = "Ratha Tek,Chennai"
                },
                new KaniniLocation
                {
                    kaniniLocationId = Guid.Parse("11c809e3-2965-48b9-9574-263870cdc4b3"),
                    Location = "kanini,Banglore"
                },
                new KaniniLocation
                {
                    kaniniLocationId = Guid.Parse("b510c9de-7f65-445b-a456-bd9e83dd9d7c"),
                    Location = "Futura,Pune"
                },
                new KaniniLocation
                {
                    kaniniLocationId = Guid.Parse("4f067a51-7818-4dca-b3b2-2351ecf8fe62"),
                    Location = "kanini,Coimbatore"
                },
                new KaniniLocation
                {
                    kaniniLocationId = Guid.Parse("a23dddcc-cd19-4c42-8a9c-6a8d8414d3a4"),
                    Location = "kanini,Noida"
                },
                
                
            };
            modelBuilder.Entity<KaniniLocation>().HasData(locations);
        }

    }
}

