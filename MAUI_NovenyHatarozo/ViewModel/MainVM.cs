using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_NovenyHatarozo.Pages;
using System.Windows.Input;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public partial class MainVM : ObservableObject
    {
        public MainVM(IPopupService popupService)
        {
            popupService.ShowPopupAsync<PopupVM>(Shell.Current);
        }

        [RelayCommand]
        private void GoToListView()
        {
            Shell.Current.GoToAsync(nameof(ListPage));
        }
    }
}
