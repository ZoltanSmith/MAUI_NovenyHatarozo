using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public partial class PopupVM : ObservableObject
    {
        [ObservableProperty]
        public partial string Msg { get; set; }

        readonly IPopupService popupService;

        public PopupVM(IPopupService popupService, string msg = "Ez egy egyedi figyelemfelkeltő ablak!")
        {
            this.popupService = popupService;
            this.Msg = msg;
        }

        [RelayCommand]
        void Ok()
        {
            popupService.ClosePopupAsync(Shell.Current.CurrentPage);
        }
    }
}
