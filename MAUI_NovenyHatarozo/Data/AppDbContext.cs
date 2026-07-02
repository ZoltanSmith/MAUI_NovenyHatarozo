using MAUI_NovenyHatarozo.Model;
using Microsoft.EntityFrameworkCore;

namespace MAUI_NovenyHatarozo.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Noveny>? Novenyek { get; set; }

        public AppDbContext()
        {
            this.Database.EnsureCreated(); // létrehozza az adatbázist, ha még nem létezik

            if (!this.Novenyek.Any()) // feltöltés teszt adatokkal, ha üres a tábla
            {
                var novenyek = new List<Model.Noveny>
                {
                    new()
                    {
                        Nev = "Tulipán",
                        Vizigeny = 1.5,
                        Kep = "https://t4.ftcdn.net/jpg/00/62/01/43/240_F_62014393_uS0FCMLRmds2nGWkYVVGNE2n3w5VAC6u.jpg",
                        Orokzold = false
                    },
                    new()
                    {
                        Nev = "Fenyő",
                        Vizigeny = 0.5,
                        Kep = "https://t4.ftcdn.net/jpg/16/11/65/57/240_F_1611655705_fsoKBQHKXCPFOT2QfblDyG7nqhqrTjux.jpg",
                        Orokzold = true
                    },
                    new()
                    {
                        Nev = "Paradicsom",
                        Vizigeny = 2.0,
                        Kep = "https://t4.ftcdn.net/jpg/01/90/92/07/240_F_190920722_OA6eLB4LWmTxyuayRqa4V2jFGVbXIssX.jpg",
                        Orokzold = false
                    }
                };
                this.Novenyek.AddRange(novenyek);
                this.SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var dir = FileSystem.AppDataDirectory;
            var dbPath = Path.Combine(dir, "db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}