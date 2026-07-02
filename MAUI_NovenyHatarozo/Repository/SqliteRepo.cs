using MAUI_NovenyHatarozo.Data;
using MAUI_NovenyHatarozo.Model;

namespace MAUI_NovenyHatarozo.Repository
{
    internal class SqliteRepo : INovenyRepository
    {
        AppDbContext db;

        public SqliteRepo(
            AppDbContext db
            )
        {
            this.db = db;
        }

        public List<Noveny> GetAllNoveny()
        {
            return db.Novenyek.ToList();
        }
    }
}
