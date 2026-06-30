using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_NovenyHatarozo.Model;
using MAUI_NovenyHatarozo.Pages;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public class NovenyListVM : ObservableObject
    {
        private ObservableCollection<Noveny> novenyek = new();

        public NovenyListVM()
        {
            Load();
        }

        private void Load()
        {
            novenyek.Add(new Noveny() {
                Nev = "Tulipán", Vizigeny = 1.5,
                Kep = "https://hu.wikipedia.org/wiki/F%C3%A1jl:Tulipan_(Ama).JPG",
                Orokzold = false });
            novenyek.Add(new Noveny() {
                Nev = "Fenyő",
                Vizigeny = 0.5,
                Kep = "https://karacsonyfa-vasar.hu/wp-content/uploads/2016/11/dreamstimeextralarge_21507949-2.jpg",
                Orokzold = true });
            novenyek.Add(new Noveny() {
                Nev = "Paradicsom", 
                Vizigeny = 2.0,
                Kep = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Tomato_je.jpg/250px-Tomato_je.jpg", 
                Orokzold = false });
        }

    }
}
