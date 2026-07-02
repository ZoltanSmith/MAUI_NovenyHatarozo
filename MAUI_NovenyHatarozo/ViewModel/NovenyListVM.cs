using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_NovenyHatarozo.Model;
using MAUI_NovenyHatarozo.Repository;
using System.Collections.ObjectModel;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public partial class NovenyListVM : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Noveny> novenyek;
        //public ObservableCollection<Noveny> Novenyek { get; set; }

        public NovenyListVM(INovenyRepository repo)
        {
            Novenyek = new ObservableCollection<Noveny>(repo.GetAllNoveny());
            //Novenyek = new();
            //Load();
        }

        //private void Load()
        //{
            
        //}

    }
}
