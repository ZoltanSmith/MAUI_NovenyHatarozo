using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_NovenyHatarozo.Pages;
using System.Windows.Input;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public class MainVM : ObservableObject
    {
        private Command goToListViewCommand;
        public ICommand GoToListViewCommand => goToListViewCommand ??= new Command(GoToListView);

        private void GoToListView()
        {
            Shell.Current.GoToAsync(nameof(ListPage));
        }

    }
}
