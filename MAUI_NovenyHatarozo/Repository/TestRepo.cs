using MAUI_NovenyHatarozo.Model;

namespace MAUI_NovenyHatarozo.Repository
{
    internal class TestRepo : INovenyRepository
    {
        public List<Noveny> GetAllNoveny()
        {
            List<Noveny> novenyek = new();
            novenyek.Add(new Noveny()
            {
                Nev = "Tulipán",
                Vizigeny = 1.5,
                Kep = "https://t4.ftcdn.net/jpg/00/62/01/43/240_F_62014393_uS0FCMLRmds2nGWkYVVGNE2n3w5VAC6u.jpg",
                Orokzold = false,
                MikorUltettuk = new(2025,05,14),
                MikorLocsoljuk = new(15, 30, 0)
            });
            novenyek.Add(new Noveny()
            {
                Nev = "Fenyő",
                Vizigeny = 0.5,
                Kep = "https://t4.ftcdn.net/jpg/16/11/65/57/240_F_1611655705_fsoKBQHKXCPFOT2QfblDyG7nqhqrTjux.jpg",
                Orokzold = true,
                MikorUltettuk = new(2020, 06, 15),
                MikorLocsoljuk = new(17, 45, 0)
            });
            novenyek.Add(new Noveny()
            {
                Nev = "Paradicsom",
                Vizigeny = 2.0,
                Kep = "https://t4.ftcdn.net/jpg/01/90/92/07/240_F_190920722_OA6eLB4LWmTxyuayRqa4V2jFGVbXIssX.jpg",
                Orokzold = false,
                MikorUltettuk = new(2026, 03, 13),
                MikorLocsoljuk = new(18, 00, 0)
            });
            return novenyek;
        }
    }
}
