using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_NovenyHatarozo.Pages;
using System.Windows.Input;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public partial class MainVM : ObservableObject
    {
        //private Command goToListViewCommand;
        //public ICommand GoToListViewCommand => goToListViewCommand ??= new Command(GoToListView);

        [RelayCommand]
        private void GoToListView()
        {
            Shell.Current.GoToAsync(nameof(ListPage));
        }

    }
}
