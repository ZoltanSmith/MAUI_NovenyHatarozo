using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUI_NovenyHatarozo.Components;
using MAUI_NovenyHatarozo.Pages;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public partial class MainVM : ObservableObject
    {
        private readonly IPopupService popupService;

        public MainVM(IPopupService popupService)
        {
            this.popupService = popupService;
            ShowPopup("Hello");
        }

        private void ShowPopup(string message)
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                var popup = new CustomPopup(popupService, message);
                await Shell.Current.ShowPopupAsync(popup);
            });
        }

        [RelayCommand]
        private void GoToListView()
        {
            Shell.Current.GoToAsync(nameof(ListPage));
        }
    }
}
