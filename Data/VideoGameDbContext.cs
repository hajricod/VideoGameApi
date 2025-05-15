using Microsoft.EntityFrameworkCore;

namespace VideoGameApi.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(

                new VideoGame
                {
                    Id = 1,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Platform = "Nintendo Switch",
                    Developer = "Nintendo EPD",
                    Publisher = "Nintendo",
                },
                new VideoGame
                {
                    Id = 2,
                    Title = "The Witcher 3: Wild Hunt",
                    Platform = "PC, PS4, Xbox One, Nintendo Switch",
                    Developer = "CD Projekt Red",
                    Publisher = "CD Projekt",
                },
                new VideoGame
                {
                    Id = 3,
                    Title = "God of War",
                    Platform = "PS4, PC",
                    Developer = "Santa Monica Studio",
                    Publisher = "Sony Interactive Entertainment",
                },
                new VideoGame
                {
                    Id = 4,
                    Title = "Dark Souls III",
                    Platform = "PC, PS4, Xbox One, Nintendo Switch",
                    Developer = "FromSoftware",
                    Publisher = "Bandai Namco Entertainment",
                },
                new VideoGame
                {
                    Id = 5,
                    Title = "Hollow Knight",
                    Platform = "PC, PS4, Xbox One, Nintendo Switch",
                    Developer = "Team Cherry",
                    Publisher = "Team Cherry",
                }
            );
        }
    }

}
