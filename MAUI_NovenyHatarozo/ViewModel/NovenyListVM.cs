using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_NovenyHatarozo.Model;
using System.Collections.ObjectModel;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public class NovenyListVM : ObservableObject
    {
        public ObservableCollection<Noveny> Novenyek { get; set; }

        public NovenyListVM()
        {
            Novenyek = new();
            Load();
        }

        private void Load()
        {
            Novenyek.Add(new Noveny() {
                Nev = "Tulipán", Vizigeny = 1.5,
                Kep = "https://t4.ftcdn.net/jpg/00/62/01/43/240_F_62014393_uS0FCMLRmds2nGWkYVVGNE2n3w5VAC6u.jpg",
                Orokzold = false });
            Novenyek.Add(new Noveny() {
                Nev = "Fenyő",
                Vizigeny = 0.5,
                Kep = "https://t4.ftcdn.net/jpg/16/11/65/57/240_F_1611655705_fsoKBQHKXCPFOT2QfblDyG7nqhqrTjux.jpg",
                Orokzold = true });
            Novenyek.Add(new Noveny() {
                Nev = "Paradicsom", 
                Vizigeny = 2.0,
                Kep = "https://t4.ftcdn.net/jpg/01/90/92/07/240_F_190920722_OA6eLB4LWmTxyuayRqa4V2jFGVbXIssX.jpg", 
                Orokzold = false });
        }

    }
}
