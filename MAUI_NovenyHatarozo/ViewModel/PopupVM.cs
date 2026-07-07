using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAUI_NovenyHatarozo.ViewModel
{
    public partial class PopupVM : ObservableObject
    {
        [ObservableProperty]
        public partial string Msg { get; set; } = "Ez egy egyedi figyelemfelkeltő ablak!";

        readonly IPopupService popupService;

        public PopupVM(IPopupService popupService)
        {
            this.popupService = popupService;
        }

        [RelayCommand]
        void Ok()
        {
            popupService.ClosePopupAsync(Shell.Current.CurrentPage);
        }
    }
}
