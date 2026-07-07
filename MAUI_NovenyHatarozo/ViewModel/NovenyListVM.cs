using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_NovenyHatarozo.Model;
using MAUI_NovenyHatarozo.Repository;
using MAUI_NovenyHatarozo.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public partial class NovenyListVM : ObservableObject
    {
        SoundService soundService;
        
        [ObservableProperty]
        ObservableCollection<Noveny> novenyek;
        //public ObservableCollection<Noveny> Novenyek { get; set; }

        [RelayCommand]
        void Selected() => soundService.PlaySound();

        public NovenyListVM(INovenyRepository repo, SoundService soundService)
        {
            Novenyek = new ObservableCollection<Noveny>(repo.GetAllNoveny());
            this.soundService = soundService;
            //Novenyek = new();
            //Load();
        }

        //private void Load()
        //{
            
        //}

    }
}
